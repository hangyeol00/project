using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Oracle.DataAccess.Client;
using nutritionist.Tabs;
using nutritionist.Tabs.Management;

namespace nutritionist
{
    public partial class NutritionistForm : Form
    {
        private const string MealPlanStatusDraft = "DRAFT";
        private const string MealPlanStatusPending = "PENDING";
        private const string MealPlanStatusApproved = "APPROVED";
        private const string PurchaseStatusRequested = "REQUESTED";
        private const string PurchaseStatusApproved = "APPROVED";
        private const string CalorieNutrientCode = "CAL";
        private static readonly Color NavDefaultBackColor = Color.FromArgb(55, 71, 90);
        private static readonly Color NavSelectedBackColor = Color.White;
        private static readonly Color NavDefaultForeColor = Color.White;
        private static readonly Color NavSelectedForeColor = Color.FromArgb(33, 45, 61);
        private static readonly Color NavHoverBackColor = Color.FromArgb(62, 79, 99);
        private static readonly Color NavActiveBackColor = Color.FromArgb(70, 88, 109);

        private readonly UserSession _session;
        private readonly List<RawMaterialOption> _rawMaterials = new List<RawMaterialOption>();
        private readonly List<FinalMenuOption> _finalMenuOptions = new List<FinalMenuOption>();
        private readonly BindingList<FinalMenuOption> _filteredMenuOptions = new BindingList<FinalMenuOption>();
        private readonly BindingList<FinalMenuOption> _selectedMealMenus = new BindingList<FinalMenuOption>();
        private readonly Dictionary<string, List<FinalMenuOption>> _mealPlanSelections = new Dictionary<string, List<FinalMenuOption>>();
        private readonly Dictionary<int, HashSet<string>> _rawNutrientCodes = new Dictionary<int, HashSet<string>>();
        private readonly Dictionary<int, decimal> _rawCalorieMap = new Dictionary<int, decimal>();
        private readonly Dictionary<int, HashSet<string>> _recipeNutrientCodes = new Dictionary<int, HashSet<string>>();
        private readonly Dictionary<int, decimal> _recipeCalorieMap = new Dictionary<int, decimal>();
        private readonly Dictionary<int, FinalMenuOption> _menuOptionLookup = new Dictionary<int, FinalMenuOption>();
        private readonly Dictionary<int, Dictionary<string, decimal>> _menuNutrientAmounts = new Dictionary<int, Dictionary<string, decimal>>();
        private readonly BindingList<NutrientSummaryRow> _nutrientSummary = new BindingList<NutrientSummaryRow>();
        private readonly Dictionary<int, HashSet<int>> _menuTagMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, string> _tagNameLookup = new Dictionary<int, string>();
        private readonly List<MenuTagOption> _availableMenuTags = new List<MenuTagOption>();
        private readonly List<MenuSortOption> _menuSortOptions = new List<MenuSortOption>();
        private ContextMenuStrip _recipeComponentMenu;
        private ToolStripMenuItem _menuRecipeViewRaw;
        private readonly List<NutrientTarget> _nutrientTargets = new List<NutrientTarget>
        {
            new NutrientTarget("칼로리", "kcal", CalorieNutrientCode, 700m),
            new NutrientTarget("단백질", "g", "PROT", 25m),
            new NutrientTarget("지방", "g", "FAT", 20m),
            new NutrientTarget("탄수화물", "g", "CARB", 90m),
            new NutrientTarget("칼슘", "mg", "CA", 200m)
        };
        private DataTable _rawMaterialTable;
        private DataTable _recipeTable;
        private readonly HashSet<string> _collapsedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private int _groupRowSerial = -1;
        private bool _suppressMenuFilter;
        private bool _suppressMealBoardUpdate;
        private bool _suppressWeekChange;
        private static readonly Dictionary<string, string> RawColumnHeaders = new Dictionary<string, string>
        {
            { "ITEMTYPE", "구분" },
            { "RAWNAME", "명칭" },
            { "CATEGORYNAME", "분류" },
            { "PURCHASEUNIT", "단위" },
            { "BASEUNITQTY", "기준량" },
            { "UNITGRAMQTY", "1단위(g)" },
            { "STORAGETYPE", "보관 방식" },
            { "SHELFLIFEDAYS", "유통기한(일)" },
            { "ACTIVEFLAG", "사용 여부" }
        };
        private static readonly Dictionary<string, string> RecipeColumnHeaders = new Dictionary<string, string>
        {
            { "MENUCODE", "메뉴 코드" },
            { "MENUNAME", "요리명" },
            { "MENUTYPE", "분류" },
            { "SERVINGSIZEGRAM", "1인 제공량(g)" },
            { "ACTIVEFLAG", "사용 여부" }
        };
        private const int DefaultMealPortion = 100;
        private static readonly string[] WeekdayNames = { "월", "화", "수", "목", "금" };

        private int? _selectedRawMaterialId;
        private int? _selectedMealPlanId;
        private int? _selectedPurchaseRequestId;
        private int? _selectedRecipeId;
        private readonly DateTime[] _currentWeekDates = new DateTime[5];
        private readonly List<WeekOption> _mealWeekOptions = new List<WeekOption>();
        private WeekOption _selectedWeekOption;
        private int _selectedWeekdayIndex = -1;
        private DateTime? _currentPlanStart;
        private DateTime? _currentPlanEnd;
        private string _currentMealPlanStatus;
        private bool _isCurrentWeekComplete;

        private NutritionDashboardControl Dashboard => dashboardTabControl;
        private TableLayoutPanel layoutDashboard => Dashboard?.layoutDashboard;
        private GroupBox grpTodayMeals => Dashboard?.grpTodayMeals;
        private DataGridView dgvTodayMeals => Dashboard?.dgvTodayMeals;
        private GroupBox grpTodayRaw => Dashboard?.grpTodayRaw;
        private DataGridView dgvTodayRawNeeds => Dashboard?.dgvTodayRawNeeds;
        private GroupBox grpShortage => Dashboard?.grpShortage;
        private DataGridView dgvShortageRaw => Dashboard?.dgvShortageRaw;
        private GroupBox grpMealLogs => Dashboard?.grpMealLogs;
        private DataGridView dgvMealLogs => Dashboard?.dgvMealLogs;
        private GroupBox grpAction => Dashboard?.grpAction;
        private Button btnCancelMeal => Dashboard?.btnCancelMeal;
        private Button btnServeMeal => Dashboard?.btnServeMeal;
        private TextBox txtMenuCode => Dashboard?.txtMenuCode;
        private Label lblMenuCode => Dashboard?.lblMenuCode;
        private TextBox txtStudentId => Dashboard?.txtStudentId;
        private Label lblStudentId => Dashboard?.lblStudentId;
        private GroupBox grpMenus => Dashboard?.grpMenus;
        private DataGridView dgvMenus => Dashboard?.dgvMenus;
        private GroupBox grpStudents => Dashboard?.grpStudents;
        private DataGridView dgvStudents => Dashboard?.dgvStudents;
        private GroupBox grpSummary => Dashboard?.grpSummary;
        private Label lblServeDateTitle => Dashboard?.lblServeDateTitle;
        private Label lblCurrentServeDate => Dashboard?.lblCurrentServeDate;
        private Label lblNotMealValue => Dashboard?.lblNotMealValue;
        private Label lblNotMeal => Dashboard?.lblNotMeal;
        private Label lblTodayMealValue => Dashboard?.lblTodayMealValue;
        private Label lblTodayMeal => Dashboard?.lblTodayMeal;
        private Label lblTotalStudentValue => Dashboard?.lblTotalStudentValue;
        private Label lblTotalStudent => Dashboard?.lblTotalStudent;
        private RawMaterialsTabPage RawMaterialsTab => rawMaterialsTabPage;
        private Panel panelRawToolbar => RawMaterialsTab?.panelRawToolbar;
        private FlowLayoutPanel flowRawCalorieFilter => RawMaterialsTab?.flowRawCalorieFilter;
        private Label lblRawCalorie => RawMaterialsTab?.lblRawCalorie;
        private NumericUpDown nudRawCalorieMin => RawMaterialsTab?.nudRawCalorieMin;
        private Label lblRawCalorieSeparator => RawMaterialsTab?.lblRawCalorieSeparator;
        private NumericUpDown nudRawCalorieMax => RawMaterialsTab?.nudRawCalorieMax;
        private Label lblRawCalorieUnit => RawMaterialsTab?.lblRawCalorieUnit;
        private FlowLayoutPanel flowRawNutrientFilters => RawMaterialsTab?.flowRawNutrientFilters;
        private Label lblRawNutrientFilter => RawMaterialsTab?.lblRawNutrientFilter;
        private CheckBox chkRawNutrientProtein => RawMaterialsTab?.chkRawNutrientProtein;
        private CheckBox chkRawNutrientFat => RawMaterialsTab?.chkRawNutrientFat;
        private CheckBox chkRawNutrientCarb => RawMaterialsTab?.chkRawNutrientCarb;
        private CheckBox chkRawGroup => RawMaterialsTab?.chkRawGroup;
        private Button btnRawClear => RawMaterialsTab?.btnRawClear;
        private Button btnRawSearch => RawMaterialsTab?.btnRawSearch;
        private TextBox txtRawSearch => RawMaterialsTab?.txtRawSearch;
        private Label lblRawSearch => RawMaterialsTab?.lblRawSearch;
        private SplitContainer splitContainerRawMaterials => RawMaterialsTab?.splitContainerRawMaterials;
        private TreeView tvRawMaterials => RawMaterialsTab?.tvRawMaterials;
        private DataGridView dgvRawMaterials => RawMaterialsTab?.dgvRawMaterials;
        private GroupBox grpRawDetail => RawMaterialsTab?.grpRawDetail;
        private TableLayoutPanel tableRawDetail => RawMaterialsTab?.tableRawDetail;
        private Label lblRawDetailName => RawMaterialsTab?.lblRawDetailName;
        private TextBox txtRawDetailName => RawMaterialsTab?.txtRawDetailName;
        private Label lblRawDetailCategory => RawMaterialsTab?.lblRawDetailCategory;
        private TextBox txtRawDetailCategory => RawMaterialsTab?.txtRawDetailCategory;
        private Label lblRawDetailUnit => RawMaterialsTab?.lblRawDetailUnit;
        private TextBox txtRawDetailUnit => RawMaterialsTab?.txtRawDetailUnit;
        private Label lblRawDetailBaseQty => RawMaterialsTab?.lblRawDetailBaseQty;
        private TextBox txtRawDetailBaseQty => RawMaterialsTab?.txtRawDetailBaseQty;
        private Label lblRawDetailUnitGram => RawMaterialsTab?.lblRawDetailUnitGram;
        private TextBox txtRawDetailUnitGram => RawMaterialsTab?.txtRawDetailUnitGram;
        private Label lblRawDetailStorage => RawMaterialsTab?.lblRawDetailStorage;
        private TextBox txtRawDetailStorage => RawMaterialsTab?.txtRawDetailStorage;
        private Label lblRawDetailShelfLife => RawMaterialsTab?.lblRawDetailShelfLife;
        private TextBox txtRawDetailShelfLife => RawMaterialsTab?.txtRawDetailShelfLife;
        private Label lblRawDetailActive => RawMaterialsTab?.lblRawDetailActive;
        private TextBox txtRawDetailActive => RawMaterialsTab?.txtRawDetailActive;
        private Label lblRawNutrients => RawMaterialsTab?.lblRawNutrients;
        private DataGridView dgvRawNutrients => RawMaterialsTab?.dgvRawNutrients;
        private Label lblRawComponents => RawMaterialsTab?.lblRawComponents;
        private DataGridView dgvRawComponents => RawMaterialsTab?.dgvRawComponents;
        private SplitContainer splitContainerRawDetail => RawMaterialsTab?.splitContainerRawDetail;
        private FlowLayoutPanel flowRawButtons => RawMaterialsTab?.flowRawButtons;
        private Button btnRawAdd => RawMaterialsTab?.btnRawAdd;
        private Button btnRawRefresh => RawMaterialsTab?.btnRawRefresh;
        private IngredientsTabPage IngredientsTab => ingredientsTabPage;
        private DataGridView dgvIngredients => IngredientsTab?.dgvIngredients;
        private SplitContainer splitContainerIngredients => IngredientsTab?.splitContainerIngredients;
        private NutrientsTabPage NutrientsTab => nutrientsTabPage;
        private SplitContainer splitContainerNutrients => NutrientsTab?.splitContainerNutrients;
        private RecipesTabPage RecipesTab => recipesTabPage;
        private Panel panelRecipeToolbar => RecipesTab?.panelRecipeToolbar;
        private FlowLayoutPanel flowRecipeCalorieFilter => RecipesTab?.flowRecipeCalorieFilter;
        private NumericUpDown nudRecipeCalorieMin => RecipesTab?.nudRecipeCalorieMin;
        private NumericUpDown nudRecipeCalorieMax => RecipesTab?.nudRecipeCalorieMax;
        private FlowLayoutPanel flowRecipeNutrientFilters => RecipesTab?.flowRecipeNutrientFilters;
        private CheckBox chkRecipeNutrientProtein => RecipesTab?.chkRecipeNutrientProtein;
        private CheckBox chkRecipeNutrientFat => RecipesTab?.chkRecipeNutrientFat;
        private CheckBox chkRecipeNutrientCarb => RecipesTab?.chkRecipeNutrientCarb;
        private Button btnRecipeSearch => RecipesTab?.btnRecipeSearch;
        private Button btnRecipeClear => RecipesTab?.btnRecipeClear;
        private TextBox txtRecipeSearch => RecipesTab?.txtRecipeSearch;
        private Button btnRefreshRecipe => RecipesTab?.btnRefreshRecipe;
        private Button btnRegisterRecipe => RecipesTab?.btnRegisterRecipe;
        private SplitContainer splitContainerRecipes => RecipesTab?.splitContainerRecipes;
        private DataGridView dgvRecipes => RecipesTab?.dgvRecipes;
        private GroupBox grpRecipeDetail => RecipesTab?.grpRecipeDetail;
        private TableLayoutPanel tableRecipeDetail => RecipesTab?.tableRecipeDetail;
        private TextBox txtRecipeName => RecipesTab?.txtRecipeName;
        private TextBox txtRecipeCode => RecipesTab?.txtRecipeCode;
        private TextBox txtRecipeType => RecipesTab?.txtRecipeType;
        private TextBox txtRecipeServing => RecipesTab?.txtRecipeServing;
        private TextBox txtRecipeActive => RecipesTab?.txtRecipeActive;
        private SplitContainer splitContainerRecipeDetail => RecipesTab?.splitContainerRecipeDetail;
        private DataGridView dgvRecipeComponents => RecipesTab?.dgvRecipeComponents;
        private DataGridView dgvRecipeNutrients => RecipesTab?.dgvRecipeNutrients;
        private FlowLayoutPanel flowRecipeButtons => RecipesTab?.flowRecipeButtons;
        private MealPlansTabPage MealPlansTab => mealPlansTabPage;
        private SplitContainer splitContainerMealPlans => MealPlansTab?.splitContainerMealPlans;
        private DateTimePicker dtpMealDate => MealPlansTab?.dtpMealDate;
        private DateTimePicker dtpMealMonth => MealPlansTab?.dtpMealMonth;
        private ComboBox cmbMealWeek => MealPlansTab?.cmbMealWeek;
        private Label lblSelectedMealDay => MealPlansTab?.lblSelectedMealDay;
        private DataGridView dgvWeeklyMeals => MealPlansTab?.dgvWeeklyMeals;
        private TextBox txtMealNotes => MealPlansTab?.txtMealNotes;
        private CheckedListBox clbMenuTags => MealPlansTab?.clbMenuTags;
        private ComboBox cmbMenuTypeFilter => MealPlansTab?.cmbMenuTypeFilter;
        private ComboBox cmbMenuSort => MealPlansTab?.cmbMenuSort;
        private Button btnResetMenuFilter => MealPlansTab?.btnResetMenuFilter;
        private Button btnRegisterMealPlan => MealPlansTab?.btnRegisterMealPlan;
        private Button btnRequestMealApproval => MealPlansTab?.btnRequestMealApproval;
        private Button btnStartMealPlan => MealPlansTab?.btnStartMealPlan;
        private ListBox lstAvailableMenus => MealPlansTab?.lstAvailableMenus;
        private ListView lvMealBoard => MealPlansTab?.lvMealBoard;
        private DataGridView dgvMealNutrition => MealPlansTab?.dgvMealNutrition;
        private DataGridViewTextBoxColumn colNutrientStatus => MealPlansTab?.colNutrientStatus;
        private GroupBox grpMealPlanDetail => MealPlansTab?.grpMealPlanDetail;

        public NutritionistForm() : this(null)
        {
        }

        public NutritionistForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            RestrictNutritionistTabs();

            Load += NutritionistForm_Load;
            menuReload.Click += MenuReload_Click;
            menuAddRaw.Click += MenuAddRaw_Click;
            menuOpenAdmin.Click += MenuOpenAdmin_Click;
            menuExit.Click += MenuExit_Click;
            dgvStudents.CellClick += DgvStudents_CellClick;
            dgvMealLogs.CellClick += DgvMealPlans_CellClick;
            dgvIngredients.CellClick += DgvPurchaseRequests_CellClick;
            btnServeMeal.Click += BtnServeMeal_Click;
            btnCancelMeal.Click += BtnCancelMeal_Click;
            if (btnRegisterMealPlan != null)
            {
                btnRegisterMealPlan.Click += BtnRegisterMealPlan_Click;
            }

            if (btnRequestMealApproval != null)
            {
                btnRequestMealApproval.Click += BtnRequestMealApproval_Click;
            }

            if (btnStartMealPlan != null)
            {
                btnStartMealPlan.Click += BtnStartMealPlan_Click;
            }
            if (dgvRawMaterials != null)
            {
                dgvRawMaterials.CellClick += DgvRawMaterials_CellClick;
                dgvRawMaterials.CellFormatting += DgvRawMaterials_CellFormatting;
            }
            if (btnRawAdd != null)
            {
                btnRawAdd.Click += BtnRawAdd_Click;
            }
            if (btnRawRefresh != null)
            {
                btnRawRefresh.Click += BtnRawRefresh_Click;
            }
            if (btnRawSearch != null)
            {
                btnRawSearch.Click += BtnRawSearch_Click;
            }
            if (btnRawClear != null)
            {
                btnRawClear.Click += BtnRawClear_Click;
            }
            if (chkRawGroup != null)
            {
                chkRawGroup.CheckedChanged += ChkRawGroup_CheckedChanged;
            }
            if (txtRawSearch != null)
            {
                txtRawSearch.KeyDown += TxtRawSearch_KeyDown;
            }

            ConfigureAccessByRole();
            UpdateNavigationSelection();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvStudents);
            ConfigureGrid(dgvTodayMeals);
            ConfigureGrid(dgvTodayRawNeeds);
            ConfigureGrid(dgvShortageRaw);
            ConfigureGrid(dgvRawMaterials);
            ConfigureGrid(dgvRecipes);
            ConfigureGrid(dgvMenus);
            ConfigureGrid(dgvMealLogs);
            ConfigureGrid(dgvIngredients);
            ConfigureGrid(dgvRawNutrients);
            ConfigureGrid(dgvRecipeNutrients);
            ConfigureGrid(dgvRecipeComponents);
            ConfigureGrid(dgvRawComponents);
            InitializeRecipeComponentContextMenu();
            if (tvRawMaterials != null)
            {
                tvRawMaterials.Visible = false;
            }

            if (dgvRecipes != null)
            {
                dgvRecipes.CellClick += DgvRecipes_CellClick;
            }

            if (btnRecipeSearch != null)
            {
                btnRecipeSearch.Click += BtnRecipeSearch_Click;
            }

            if (btnRecipeClear != null)
            {
                btnRecipeClear.Click += BtnRecipeClear_Click;
            }

            if (txtRecipeSearch != null)
            {
                txtRecipeSearch.KeyDown += TxtRecipeSearch_KeyDown;
            }

            if (btnRefreshRecipe != null)
            {
                btnRefreshRecipe.Click += BtnRefreshRecipe_Click;
            }

            if (btnRegisterRecipe != null)
            {
                btnRegisterRecipe.Click += BtnRegisterRecipe_Click;
            }

            if (splitContainerIngredients != null)
            {
                splitContainerIngredients.Panel2Collapsed = true;
            }

            if (splitContainerNutrients != null)
            {
                splitContainerNutrients.Panel2Collapsed = true;
            }

            txtStudentId.ReadOnly = true;
            txtMenuCode.ReadOnly = true;
            if (txtRawDetailName != null)
            {
                txtRawDetailName.ReadOnly = true;
            }
            if (txtRawDetailCategory != null)
            {
                txtRawDetailCategory.ReadOnly = true;
            }
            if (txtRawDetailUnit != null)
            {
                txtRawDetailUnit.ReadOnly = true;
            }
            if (txtRawDetailBaseQty != null)
            {
                txtRawDetailBaseQty.ReadOnly = true;
            }
            if (txtRawDetailStorage != null)
            {
                txtRawDetailStorage.ReadOnly = true;
            }
            if (txtRawDetailShelfLife != null)
            {
                txtRawDetailShelfLife.ReadOnly = true;
            }
            if (txtRawDetailActive != null)
            {
                txtRawDetailActive.ReadOnly = true;
            }
            if (txtRecipeName != null)
            {
                txtRecipeName.ReadOnly = true;
            }
            if (txtRecipeCode != null)
            {
                txtRecipeCode.ReadOnly = true;
            }
            if (txtRecipeType != null)
            {
                txtRecipeType.ReadOnly = true;
            }
            if (txtRecipeServing != null)
            {
                txtRecipeServing.ReadOnly = true;
            }
            if (txtRecipeActive != null)
            {
                txtRecipeActive.ReadOnly = true;
            }

            _selectedMealMenus.ListChanged += SelectedMealMenus_ListChanged;
            if (lstAvailableMenus != null)
            {
                lstAvailableMenus.DisplayMember = nameof(FinalMenuOption.DisplayName);
                lstAvailableMenus.DataSource = _filteredMenuOptions;
                lstAvailableMenus.MouseDown += LstAvailableMenus_MouseDown;
            }

            if (lvMealBoard != null)
            {
                lvMealBoard.AllowDrop = true;
                lvMealBoard.DragEnter += MealBoard_DragEnter;
                lvMealBoard.DragDrop += MealBoard_DragDrop;
                lvMealBoard.DoubleClick += MealBoard_DoubleClick;
            }

            if (cmbMenuTypeFilter != null)
            {
                cmbMenuTypeFilter.SelectedIndexChanged += CmbMenuTypeFilter_SelectedIndexChanged;
            }

            if (cmbMenuSort != null)
            {
                cmbMenuSort.SelectedIndexChanged += CmbMenuSort_SelectedIndexChanged;
            }

            if (btnResetMenuFilter != null)
            {
                btnResetMenuFilter.Click += BtnResetMenuFilter_Click;
            }

            if (clbMenuTags != null)
            {
                clbMenuTags.ItemCheck += ClbMenuTags_ItemCheck;
            }

            if (dgvMealNutrition != null)
            {
                dgvMealNutrition.AutoGenerateColumns = false;
                dgvMealNutrition.DataSource = _nutrientSummary;
                dgvMealNutrition.CellFormatting += DgvMealNutrition_CellFormatting;
            }

            InitializeMealPlannerControls();
            AttachRawFilterEvents();
            AttachRecipeFilterEvents();
        }

        private void InitializeMealPlannerControls()
        {
            if (dtpMealMonth != null)
            {
                dtpMealMonth.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpMealMonth.ValueChanged += DtpMealMonth_ValueChanged;
            }

            if (cmbMealWeek != null)
            {
                cmbMealWeek.SelectedIndexChanged += CmbMealWeek_SelectedIndexChanged;
            }

            if (dgvWeeklyMeals != null)
            {
                dgvWeeklyMeals.Rows.Clear();
                dgvWeeklyMeals.Rows.Add();
                dgvWeeklyMeals.ClearSelection();
                dgvWeeklyMeals.CellClick += DgvWeeklyMeals_CellClick;
            }

            UpdateMealWeekOptions();
            ClearWeeklyMealsGrid();
            UpdateMealPlanInteractionState();
        }

        private void DtpMealMonth_ValueChanged(object sender, EventArgs e)
        {
            if (_suppressWeekChange)
            {
                return;
            }

            UpdateMealWeekOptions();
        }

        private void CmbMealWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressWeekChange)
            {
                return;
            }

            _selectedWeekOption = cmbMealWeek?.SelectedItem as WeekOption;
            _selectedWeekdayIndex = -1;
            RefreshWeeklyMealBoard();
        }

        private void DgvWeeklyMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            SelectWeekday(e.ColumnIndex);
        }

        private void SetMealMonthWithoutEvents(DateTime monthDate)
        {
            if (dtpMealMonth == null)
            {
                return;
            }

            _suppressWeekChange = true;
            dtpMealMonth.Value = monthDate;
            _suppressWeekChange = false;
            UpdateMealWeekOptions();
        }

        private void UpdateMealWeekOptions()
        {
            if (dtpMealMonth == null || cmbMealWeek == null)
            {
                return;
            }

            var targetMonth = dtpMealMonth.Value;
            var previousStart = _selectedWeekOption?.StartDate;
            _suppressWeekChange = true;
            cmbMealWeek.Items.Clear();
            _mealWeekOptions.Clear();

            var current = GetFirstMondayOfMonth(targetMonth.Year, targetMonth.Month);
            var index = 1;
            while (current.Month == targetMonth.Month)
            {
                var option = new WeekOption(index, current);
                _mealWeekOptions.Add(option);
                cmbMealWeek.Items.Add(option);
                index++;
                current = current.AddDays(7);
            }

            if (_mealWeekOptions.Count > 0)
            {
                var restored = _mealWeekOptions.FirstOrDefault(opt => previousStart.HasValue && opt.StartDate == previousStart.Value);
                _selectedWeekOption = restored ?? _mealWeekOptions.First();
                cmbMealWeek.SelectedItem = _selectedWeekOption;
                _selectedWeekdayIndex = -1;
                _suppressWeekChange = false;
                RefreshWeeklyMealBoard();
                return;
            }

            _selectedWeekOption = null;
            cmbMealWeek.SelectedItem = null;
            _selectedWeekdayIndex = -1;
            _suppressWeekChange = false;
            ClearWeeklyMealsGrid();
        }

        private static DateTime GetFirstMondayOfMonth(int year, int month)
        {
            var firstDay = new DateTime(year, month, 1);
            var offset = ((int)DayOfWeek.Monday - (int)firstDay.DayOfWeek + 7) % 7;
            return firstDay.AddDays(offset);
        }

        private void RefreshWeeklyMealBoard()
        {
            if (dgvWeeklyMeals == null)
            {
                return;
            }

            EnsureWeeklyGridRow();

            if (_selectedWeekOption == null || _selectedMealPlanId == null)
            {
                ClearWeeklyMealsGrid();
                return;
            }

            var start = _selectedWeekOption.StartDate;
            var end = start.AddDays(4);
            if (!IsWeekWithinSelectedPlan(start, end))
            {
                ClearWeeklyMealsGrid();
                return;
            }

            var weekMeals = LoadWeekMealsFromDatabase(start, end);
            var weekComplete = true;

            for (var i = 0; i < WeekdayNames.Length; i++)
            {
                var date = start.AddDays(i);
                _currentWeekDates[i] = date;
                dgvWeeklyMeals.Columns[i].HeaderText = $"{WeekdayNames[i]} {date:MM/dd}";
                if (weekMeals.TryGetValue(date.Date, out var menus) && menus.Count > 0)
                {
                    dgvWeeklyMeals.Rows[0].Cells[i].Value = string.Join(Environment.NewLine, menus.Select(m => m.MenuName));
                }
                else
                {
                    dgvWeeklyMeals.Rows[0].Cells[i].Value = string.Empty;
                    weekComplete = false;
                }
            }

            _isCurrentWeekComplete = weekComplete;
            UpdateApprovalRequestAvailability();

            var targetIndex = _selectedWeekdayIndex;
            if (targetIndex < 0 || targetIndex >= WeekdayNames.Length)
            {
                targetIndex = 0;
            }

            SelectWeekday(targetIndex);
        }

        private void EnsureWeeklyGridRow()
        {
            if (dgvWeeklyMeals != null && dgvWeeklyMeals.Rows.Count == 0)
            {
                dgvWeeklyMeals.Rows.Add();
            }
        }

        private void ClearWeeklyMealsGrid()
        {
            if (dgvWeeklyMeals == null)
            {
                return;
            }

            EnsureWeeklyGridRow();
            for (var i = 0; i < WeekdayNames.Length; i++)
            {
                dgvWeeklyMeals.Columns[i].HeaderText = WeekdayNames[i];
                dgvWeeklyMeals.Rows[0].Cells[i].Value = string.Empty;
                _currentWeekDates[i] = DateTime.MinValue;
            }

            dgvWeeklyMeals.ClearSelection();
            UpdateSelectedDayLabel(null, -1);
            _isCurrentWeekComplete = false;
            UpdateApprovalRequestAvailability();
        }

        private void SelectWeekday(int columnIndex, bool suppressReload = false)
        {
            if (columnIndex < 0 || columnIndex >= _currentWeekDates.Length)
            {
                return;
            }

            var date = _currentWeekDates[columnIndex];
            if (date == DateTime.MinValue)
            {
                return;
            }

            _selectedWeekdayIndex = columnIndex;
            if (dgvWeeklyMeals != null && dgvWeeklyMeals.Rows.Count > 0)
            {
                dgvWeeklyMeals.ClearSelection();
                dgvWeeklyMeals[columnIndex, 0].Selected = true;
            }

            if (dtpMealDate != null)
            {
                dtpMealDate.Value = date;
            }

            UpdateSelectedDayLabel(date, columnIndex);

            if (!suppressReload)
            {
                LoadMealRecipesForCurrentPlan();
            }
        }

        private void UpdateSelectedDayLabel(DateTime? date, int columnIndex)
        {
            if (lblSelectedMealDay == null)
            {
                return;
            }

            if (!date.HasValue || columnIndex < 0 || columnIndex >= WeekdayNames.Length)
            {
                lblSelectedMealDay.Text = "-";
                return;
            }

            lblSelectedMealDay.Text = $"{date:yyyy-MM-dd} ({WeekdayNames[columnIndex]})";
        }

        private Dictionary<DateTime, List<FinalMenuOption>> LoadWeekMealsFromDatabase(DateTime start, DateTime end)
        {
            var result = new Dictionary<DateTime, List<FinalMenuOption>>();
            if (_selectedMealPlanId == null)
            {
                return result;
            }

            const string sql =
                "SELECT m.MealDate, mc.FinalMenuID, fm.MenuType " +
                "FROM Meal m " +
                "JOIN MealComp mc ON m.MealID = mc.MealID " +
                "JOIN FinalMenu fm ON mc.FinalMenuID = fm.FinalMenuID " +
                "WHERE m.MealPlanID = :PLANID AND m.MealDate BETWEEN :STARTDATE AND :ENDDATE " +
                "ORDER BY m.MealDate, CASE fm.MenuType " +
                "WHEN 'MAIN' THEN 1 WHEN 'SIDE' THEN 2 WHEN 'SOUP' THEN 3 WHEN 'DRINK' THEN 4 ELSE 5 END, fm.MenuName";

            var table = ExecuteDataTable(sql,
                new OracleParameter("PLANID", _selectedMealPlanId.Value),
                new OracleParameter("STARTDATE", start),
                new OracleParameter("ENDDATE", end));

            foreach (DataRow row in table.Rows)
            {
                var mealDate = ToNullableDate(row["MEALDATE"])?.Date;
                if (!mealDate.HasValue)
                {
                    continue;
                }

                var option = FindMenuOption(ToInt(row["FINALMENUID"]));
                if (option == null)
                {
                    continue;
                }

                if (!result.TryGetValue(mealDate.Value, out var list))
                {
                    list = new List<FinalMenuOption>();
                    result[mealDate.Value] = list;
                }

                list.Add(option);
            }

            return result;
        }

        private List<FinalMenuOption> LoadMealMenusFromDatabase(DateTime mealDate)
        {
            var items = new List<FinalMenuOption>();
            if (_selectedMealPlanId == null)
            {
                return items;
            }

            const string sql =
                "SELECT mc.FinalMenuID, fm.MenuType, fm.MenuName " +
                "FROM Meal m " +
                "JOIN MealComp mc ON m.MealID = mc.MealID " +
                "JOIN FinalMenu fm ON mc.FinalMenuID = fm.FinalMenuID " +
                "WHERE m.MealPlanID = :PLANID AND m.MealDate = :MEALDATE " +
                "ORDER BY CASE fm.MenuType " +
                "WHEN 'MAIN' THEN 1 WHEN 'SIDE' THEN 2 WHEN 'SOUP' THEN 3 WHEN 'DRINK' THEN 4 ELSE 5 END, fm.MenuName";

            var table = ExecuteDataTable(sql,
                new OracleParameter("PLANID", _selectedMealPlanId.Value),
                new OracleParameter("MEALDATE", mealDate));

            foreach (DataRow row in table.Rows)
            {
                var option = FindMenuOption(ToInt(row["FINALMENUID"]));
                if (option != null)
                {
                    items.Add(option);
                }
            }

            return items;
        }

        private FinalMenuOption FindMenuOption(int menuId)
        {
            if (menuId <= 0)
            {
                return null;
            }

            if (_menuOptionLookup.TryGetValue(menuId, out var option))
            {
                return option;
            }

            option = _finalMenuOptions.FirstOrDefault(menu => menu.FinalMenuId == menuId);
            if (option != null)
            {
                _menuOptionLookup[menuId] = option;
            }

            return option;
        }

        private void InitializeRecipeComponentContextMenu()
        {
            if (dgvRecipeComponents == null)
            {
                return;
            }

            _recipeComponentMenu = new ContextMenuStrip();
            _menuRecipeViewRaw = new ToolStripMenuItem("재료관리에서 보기");
            _menuRecipeViewRaw.Click += MenuRecipeViewRaw_Click;
            _recipeComponentMenu.Items.Add(_menuRecipeViewRaw);
            _recipeComponentMenu.Opening += RecipeComponentMenu_Opening;
            dgvRecipeComponents.ContextMenuStrip = _recipeComponentMenu;
            dgvRecipeComponents.CellMouseDown += DgvRecipeComponents_CellMouseDown;
        }

        private static void ConfigureGrid(DataGridView grid)
        {
            if (grid == null)
            {
                return;
            }

            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static DataGridViewColumn GetColumn(DataGridView grid, string columnName)
        {
            if (grid == null || string.IsNullOrWhiteSpace(columnName))
            {
                return null;
            }

            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (string.Equals(column.Name, columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return column;
                }
            }

            return null;
        }

        private void AttachRawFilterEvents()
        {
            EventHandler handler = (sender, args) => ApplyRawMaterialView();
            AttachCheckChangedHandler(chkRawNutrientProtein, handler);
            AttachCheckChangedHandler(chkRawNutrientFat, handler);
            AttachCheckChangedHandler(chkRawNutrientCarb, handler);
            AttachNumericValueChangedHandler(nudRawCalorieMin, handler);
            AttachNumericValueChangedHandler(nudRawCalorieMax, handler);
        }

        private void AttachRecipeFilterEvents()
        {
            EventHandler handler = (sender, args) => ApplyRecipeFilter();
            AttachCheckChangedHandler(chkRecipeNutrientProtein, handler);
            AttachCheckChangedHandler(chkRecipeNutrientFat, handler);
            AttachCheckChangedHandler(chkRecipeNutrientCarb, handler);
            AttachNumericValueChangedHandler(nudRecipeCalorieMin, handler);
            AttachNumericValueChangedHandler(nudRecipeCalorieMax, handler);
        }

        private static void AttachCheckChangedHandler(CheckBox checkBox, EventHandler handler)
        {
            if (checkBox != null && handler != null)
            {
                checkBox.CheckedChanged += handler;
            }
        }

        private static void AttachNumericValueChangedHandler(NumericUpDown control, EventHandler handler)
        {
            if (control != null && handler != null)
            {
                control.ValueChanged += handler;
            }
        }

        private void BtnNavDashboard_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabDashboard;
        }

        private void BtnNavManagement_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabManagement;
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNavigationSelection();
        }

        private void UpdateNavigationSelection()
        {
            ApplyNavStyle(btnNavDashboard, tabMain.SelectedTab == tabDashboard);
            ApplyNavStyle(btnNavManagement, tabMain.SelectedTab == tabManagement);
        }

        private static void ApplyNavStyle(Button button, bool isSelected)
        {
            if (button == null)
            {
                return;
            }

            button.BackColor = isSelected ? NavSelectedBackColor : NavDefaultBackColor;
            button.ForeColor = isSelected ? NavSelectedForeColor : NavDefaultForeColor;
            button.FlatAppearance.MouseOverBackColor = isSelected ? NavSelectedBackColor : NavHoverBackColor;
            button.FlatAppearance.MouseDownBackColor = isSelected ? NavSelectedBackColor : NavActiveBackColor;
        }

        private void ConfigureAccessByRole()
        {
            var isAdmin = _session?.IsAdmin == true;
            var nameSuffix = !string.IsNullOrWhiteSpace(_session?.UserName)
                ? $" - {_session.UserName}"
                : string.Empty;
            Text = $"영양사 도구{nameSuffix}";

            menuOpenAdmin.Visible = isAdmin;
            if (btnServeMeal != null)
            {
                btnServeMeal.Text = isAdmin ? "식단 승인" : "식단 계획 등록";
                btnServeMeal.Visible = isAdmin;
            }

            if (btnCancelMeal != null)
            {
                btnCancelMeal.Text = isAdmin ? "발주 승인" : "발주 요청 등록";
            }

            if (btnStartMealPlan != null)
            {
                btnStartMealPlan.Visible = !isAdmin;
            }

            if (btnRequestMealApproval != null)
            {
                btnRequestMealApproval.Visible = !isAdmin;
            }

            UpdateMealPlanInteractionState();
        }

        private void RestrictNutritionistTabs()
        {
            RemoveManagementTab(tabNutrients);
            RemoveManagementTab(tabUsers);
            RemoveManagementTab(tabAllergies);
            RemoveManagementTab(tabAllergyRelations);
        }

        private void RemoveManagementTab(TabPage tabPage)
        {
            if (tabControlManagement == null || tabPage == null)
            {
                return;
            }

            if (tabControlManagement.TabPages.Contains(tabPage))
            {
                tabControlManagement.TabPages.Remove(tabPage);
                tabPage.Dispose();
            }
        }

        private void NutritionistForm_Load(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void MenuReload_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void MenuAddRaw_Click(object sender, EventArgs e)
        {
            AddRawMaterial();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuOpenAdmin_Click(object sender, EventArgs e)
        {
            if (_session?.IsAdmin != true)
            {
                MessageBox.Show("관리자 전용 메뉴입니다. 관리자 계정으로 로그인해 주세요.", "권한 없음");
                return;
            }

            using (var adminForm = new AdminForm(_session))
            {
                adminForm.StartPosition = FormStartPosition.CenterParent;
                adminForm.ShowDialog(this);
            }
        }

        private void ReloadAll()
        {
            try
            {
                LoadSummary();
                LoadRawMaterials();
                LoadRecipesManagement();
                LoadFinalMenus();
                LoadMealPlans();
                LoadPurchaseRequests();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private DataTable ExecuteDataTable(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            using (var cmd = new OracleCommand(sql, conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }

                var table = new DataTable();
                conn.Open();
                adapter.Fill(table);
                return table;
            }
        }

        private object ExecuteScalar(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            using (var cmd = new OracleCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        private int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            using (var cmd = new OracleCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        private void LoadSummary()
        {
            var totalRaw = ToInt(ExecuteScalar("SELECT COUNT(*) FROM RAWMATERIAL"));
            var totalMealPlan = ToInt(ExecuteScalar("SELECT COUNT(*) FROM MEALPLAN"));
            var pendingPurchase = ToInt(
                ExecuteScalar("SELECT COUNT(*) FROM PURCHASEREQUEST WHERE UPPER(STATUS) <> :STATUS",
                    new OracleParameter("STATUS", PurchaseStatusApproved)));

            lblTotalStudentValue.Text = totalRaw.ToString();
            lblTodayMealValue.Text = totalMealPlan.ToString();
            lblNotMealValue.Text = pendingPurchase.ToString();
            if (lblCurrentServeDate != null)
            {
                lblCurrentServeDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        private void LoadRawMaterials()
        {
            const string sql =
                "SELECT 'RAW' AS ITEMTYPE, r.RawID AS RAWID, r.RawName, c.CategoryName, r.PurchaseUnit, r.BaseUnitQty, r.UnitGramQty, " +
                "       r.StorageType, r.ShelfLifeDays, r.ActiveFlag, NULL AS IngredientType, NULL AS BatchYieldGram, NULL AS DefaultPortionGram " +
                "FROM RawMaterial r LEFT JOIN RawCategory c ON r.RawCategoryID = c.RawCategoryID " +
                "UNION ALL " +
                "SELECT 'ING' AS ITEMTYPE, i.IngredientID AS RAWID, i.IngredientName AS RAWNAME, i.Type AS CategoryName, '조합' AS PurchaseUnit, " +
                "       i.BatchYieldGram AS BaseUnitQty, NULL AS UnitGramQty, NULL AS StorageType, NULL AS ShelfLifeDays, i.ActiveFlag, i.Type AS IngredientType, " +
                "       i.BatchYieldGram, i.DefaultPortionGram " +
                "FROM Ingredient i " +
                "ORDER BY RawName";

            var table = ExecuteDataTable(sql);
            _rawMaterialTable = table;
            dgvStudents.DataSource = table;
            ApplyRawColumnHeaders(dgvStudents);

            _rawMaterials.Clear();
            _rawMaterials.AddRange(
                from DataRow row in table.Rows
                where string.Equals(row["ITEMTYPE"]?.ToString(), "RAW", StringComparison.OrdinalIgnoreCase)
                select new RawMaterialOption(
                    Convert.ToInt32(row["RAWID"]),
                    row["RAWNAME"]?.ToString() ?? string.Empty,
                    row["PURCHASEUNIT"]?.ToString() ?? string.Empty));

            LoadRawNutrientSummary();

            if (dgvStudents.Rows.Count > 0)
            {
                dgvStudents.Rows[0].Selected = true;
                SetSelectedRawMaterialFromRow(dgvStudents.Rows[0]);
            }
            else
            {
                _selectedRawMaterialId = null;
                DisplaySelectedRawMaterial(null);
            }

            ApplyRawMaterialView();
        }

        private void LoadRawNutrientSummary()
        {
            _rawNutrientCodes.Clear();
            _rawCalorieMap.Clear();

            const string sql =
                "SELECT rn.RawID, n.NutrientCode, rn.AmountPerBase AS AMOUNT " +
                "FROM RawNutrient rn " +
                "JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE NVL(n.ActiveFlag, 'Y') = 'Y'";

            var table = ExecuteDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                var rawId = ToInt(row["RAWID"]);
                if (rawId <= 0)
                {
                    continue;
                }

                var code = row["NUTRIENTCODE"]?.ToString();
                if (string.IsNullOrWhiteSpace(code))
                {
                    continue;
                }

                var codeSet = GetOrCreateNutrientSet(_rawNutrientCodes, rawId);
                codeSet.Add(code);

                if (string.Equals(code, CalorieNutrientCode, StringComparison.OrdinalIgnoreCase) &&
                    row["AMOUNT"] != DBNull.Value)
                {
                    _rawCalorieMap[rawId] = Convert.ToDecimal(row["AMOUNT"]);
                }
            }
        }

        private void LoadRecipesManagement()
        {
            const string sql =
                "SELECT FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag " +
                "FROM FinalMenu ORDER BY MenuName";

            _recipeTable = ExecuteDataTable(sql);
            LoadRecipeNutrientSummary();
            ApplyRecipeFilter();
        }

        private void LoadRecipeNutrientSummary()
        {
            _recipeNutrientCodes.Clear();
            _recipeCalorieMap.Clear();
            _menuNutrientAmounts.Clear();

            const string sql =
                "WITH base_component AS ( " +
                "    SELECT mc.FinalMenuID, mc.ComponentType, mc.ComponentRawID, mc.ComponentIngredientID, " +
                "           NVL(mc.QuantityPerServing, 0) AS Qty " +
                "    FROM MenuComp mc " +
                "), raw_component AS ( " +
                "    SELECT bc.FinalMenuID, bc.ComponentRawID AS RawID, CAST(bc.Qty AS NUMBER(18,6)) AS QuantityGram " +
                "    FROM base_component bc " +
                "    WHERE bc.ComponentType = 'R' AND bc.ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID, " +
                "           CAST(bc.Qty * (NVL(ic.QuantityPerBatch, 0) / NULLIF(i.BatchYieldGram, 0)) AS NUMBER(18,6)) AS QuantityGram " +
                "    FROM base_component bc " +
                "    JOIN IngredientComp ic ON bc.ComponentIngredientID = ic.IngredientID " +
                "    JOIN Ingredient i ON ic.IngredientID = i.IngredientID " +
                "    WHERE bc.ComponentType = 'I' AND bc.ComponentIngredientID IS NOT NULL AND i.BatchYieldGram IS NOT NULL AND i.BatchYieldGram > 0 " +
                ") " +
                "SELECT rc.FinalMenuID, n.NutrientCode, " +
                "       CAST(SUM(NVL(rn.AmountPerBase, 0) * NVL(rc.QuantityGram, 0)) AS NUMBER(18,6)) AS NUTRIENTAMOUNT " +
                "FROM raw_component rc " +
                "JOIN RawMaterial r ON rc.RawID = r.RawID " +
                "JOIN RawNutrient rn ON rn.RawID = r.RawID " +
                "JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE NVL(n.ActiveFlag, 'Y') = 'Y' " +
                "GROUP BY rc.FinalMenuID, n.NutrientCode";

            var table = ExecuteDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                var menuId = ToInt(row["FINALMENUID"]);
                if (menuId <= 0)
                {
                    continue;
                }

                var code = row["NUTRIENTCODE"]?.ToString();
                if (string.IsNullOrWhiteSpace(code))
                {
                    continue;
                }

                var codeSet = GetOrCreateNutrientSet(_recipeNutrientCodes, menuId);
                codeSet.Add(code);

                var amountMap = GetOrCreateNutrientAmountMap(menuId);
                amountMap[code] = row["NUTRIENTAMOUNT"] == DBNull.Value
                    ? 0m
                    : Convert.ToDecimal(row["NUTRIENTAMOUNT"]);

                if (string.Equals(code, CalorieNutrientCode, StringComparison.OrdinalIgnoreCase) &&
                    row["NUTRIENTAMOUNT"] != DBNull.Value)
                {
                    _recipeCalorieMap[menuId] = Convert.ToDecimal(row["NUTRIENTAMOUNT"]);
                }
            }
            UpdateNutritionSummary();
        }

        private void LoadFinalMenus()
        {
            const string sql =
                "SELECT FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag " +
                "FROM FinalMenu ORDER BY MenuName";
            var table = ExecuteDataTable(sql);
            dgvMenus.DataSource = table;

            _finalMenuOptions.Clear();
            _menuOptionLookup.Clear();
            foreach (DataRow row in table.Rows)
            {
                var option = new FinalMenuOption(
                    ToInt(row["FINALMENUID"]),
                    row["MENUCODE"]?.ToString(),
                    row["MENUNAME"]?.ToString() ?? string.Empty,
                    row["MENUTYPE"]?.ToString());
                _finalMenuOptions.Add(option);
                _menuOptionLookup[option.FinalMenuId] = option;
            }
            PopulateMenuTypeFilter();
            PopulateMenuSortOptions();
            LoadMenuTags();
            ApplyMenuFilter(true);
        }

        private void PopulateMenuTypeFilter()
        {
            if (cmbMenuTypeFilter == null)
            {
                return;
            }

            var previous = cmbMenuTypeFilter.SelectedItem?.ToString();
            _suppressMenuFilter = true;
            cmbMenuTypeFilter.Items.Clear();
            cmbMenuTypeFilter.Items.Add("전체");
            var types = _finalMenuOptions
                .Select(option => option.MenuType)
                .Where(type => !string.IsNullOrWhiteSpace(type))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(type => type);

            foreach (var type in types)
            {
                cmbMenuTypeFilter.Items.Add(type);
            }

            var targetIndex = 0;
            if (!string.IsNullOrWhiteSpace(previous))
            {
                var found = cmbMenuTypeFilter.Items.IndexOf(previous);
                if (found >= 0)
                {
                    targetIndex = found;
                }
            }

            cmbMenuTypeFilter.SelectedIndex = targetIndex;
            _suppressMenuFilter = false;
        }

        private void PopulateMenuSortOptions()
        {
            if (cmbMenuSort == null)
            {
                return;
            }

            _menuSortOptions.Clear();
            _menuSortOptions.Add(MenuSortOption.CreateDefault("정렬 없음"));
            foreach (var target in _nutrientTargets)
            {
                _menuSortOptions.Add(MenuSortOption.Create($"{target.DisplayName} 높은순", target.Code, true));
                _menuSortOptions.Add(MenuSortOption.Create($"{target.DisplayName} 낮은순", target.Code, false));
            }

            _suppressMenuFilter = true;
            cmbMenuSort.DisplayMember = nameof(MenuSortOption.DisplayName);
            cmbMenuSort.DataSource = null;
            cmbMenuSort.Items.Clear();
            foreach (var option in _menuSortOptions)
            {
                cmbMenuSort.Items.Add(option);
            }

            if (cmbMenuSort.Items.Count > 0)
            {
                cmbMenuSort.SelectedIndex = 0;
            }

            _suppressMenuFilter = false;
        }

        private void LoadMenuTags()
        {
            _availableMenuTags.Clear();
            _menuTagMap.Clear();
            _tagNameLookup.Clear();

            const string tagSql =
                "SELECT mt.MenuTagID AS MENUTAGID, mt.TagName, mt.TagType " +
                "FROM MenuTag mt WHERE NVL(mt.ActiveFlag, 'Y') = 'Y' " +
                "ORDER BY mt.TagType, mt.TagName";
            var tagTable = ExecuteDataTable(tagSql);
            foreach (DataRow row in tagTable.Rows)
            {
                var tagId = ToInt(row["MENUTAGID"]);
                if (tagId <= 0)
                {
                    continue;
                }

                var name = row["TAGNAME"]?.ToString() ?? string.Empty;
                var type = row["TAGTYPE"]?.ToString();
                var option = new MenuTagOption(tagId, name, type);
                _availableMenuTags.Add(option);
                _tagNameLookup[tagId] = name;
            }

            if (clbMenuTags != null)
            {
                _suppressMenuFilter = true;
                clbMenuTags.Items.Clear();
                foreach (var option in _availableMenuTags)
                {
                    clbMenuTags.Items.Add(option, false);
                }
                _suppressMenuFilter = false;
            }

            const string mapSql =
                "SELECT mm.FinalMenuID AS FINALMENUID, mm.MenuTagID AS MENUTAGID FROM MenuTagMap mm";
            var mapTable = ExecuteDataTable(mapSql);
            foreach (DataRow row in mapTable.Rows)
            {
                var menuId = ToInt(row["FINALMENUID"]);
                var tagId = ToInt(row["MENUTAGID"]);
                if (menuId <= 0 || tagId <= 0)
                {
                    continue;
                }

                if (!_menuTagMap.TryGetValue(menuId, out var set))
                {
                    set = new HashSet<int>();
                    _menuTagMap[menuId] = set;
                }

                set.Add(tagId);
            }

            RefreshMealBoard();
        }

        private void LoadMealPlans()
        {
            const string sql =
                "SELECT mp.MealPlanID, mp.PlanName, mp.PeriodStart, mp.PeriodEnd, mp.Status, " +
                "       NVL(u.UserName, mp.CreatedBy) AS CreatedByName " +
                "FROM MealPlan mp LEFT JOIN AppUser u ON mp.CreatedBy = u.UserID " +
                "ORDER BY mp.PeriodStart DESC, mp.MealPlanID DESC";

            dgvMealLogs.DataSource = ExecuteDataTable(sql);
            if (dgvMealLogs.Rows.Count > 0)
            {
                dgvMealLogs.Rows[0].Selected = true;
                SetSelectedMealPlanFromRow(dgvMealLogs.Rows[0]);
            }
            else
            {
                _selectedMealPlanId = null;
                DisplaySelectedMealPlan();
            }
        }

        private void LoadPurchaseRequests()
        {
            const string sql =
                "SELECT pr.PurchaseRequestID, r.RawName, pr.Quantity, pr.UnitPriceEstimate, pr.Status, " +
                "       pr.RequestedDate, pr.ExpectedDeliveryDate, NVL(req.UserName, pr.RequestedBy) AS RequestedByName, " +
                "       NVL(app.UserName, pr.ApprovedBy) AS ApprovedByName, pr.Remark " +
                "FROM PurchaseRequest pr " +
                "LEFT JOIN RawMaterial r ON pr.RawID = r.RawID " +
                "LEFT JOIN AppUser req ON pr.RequestedBy = req.UserID " +
                "LEFT JOIN AppUser app ON pr.ApprovedBy = app.UserID " +
                "ORDER BY pr.PurchaseRequestID DESC";

            dgvIngredients.DataSource = ExecuteDataTable(sql);
            if (dgvIngredients.Rows.Count > 0)
            {
                dgvIngredients.Rows[0].Selected = true;
                SetSelectedPurchaseRequestFromRow(dgvIngredients.Rows[0]);
            }
            else
            {
                _selectedPurchaseRequestId = null;
            }
        }

        private string GetSelectedMenuType()
        {
            var selected = cmbMenuTypeFilter?.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selected) || string.Equals(selected, "전체", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            return selected;
        }

        private List<int> GetSelectedTagIds()
        {
            var selected = new List<int>();
            if (clbMenuTags == null)
            {
                return selected;
            }

            foreach (var item in clbMenuTags.CheckedItems)
            {
                if (item is MenuTagOption option)
                {
                    selected.Add(option.TagId);
                }
            }

            return selected;
        }

        private void ApplyMenuFilter(bool resetSelection = false)
        {
            if (lstAvailableMenus == null)
            {
                return;
            }

            var selectedType = GetSelectedMenuType();
            var selectedTags = GetSelectedTagIds();

            var matched = new List<FinalMenuOption>();
            foreach (var option in _finalMenuOptions)
            {
                if (!string.IsNullOrWhiteSpace(selectedType) &&
                    !string.Equals(option.MenuType, selectedType, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (selectedTags.Count > 0)
                {
                    if (!_menuTagMap.TryGetValue(option.FinalMenuId, out var tagSet) ||
                        !selectedTags.All(tagSet.Contains))
                    {
                        continue;
                    }
                }

                matched.Add(option);
            }

            var ordered = SortMenuOptions(matched);
            _filteredMenuOptions.RaiseListChangedEvents = false;
            _filteredMenuOptions.Clear();
            foreach (var option in ordered)
            {
                _filteredMenuOptions.Add(option);
            }
            _filteredMenuOptions.RaiseListChangedEvents = true;
            _filteredMenuOptions.ResetBindings();

            if (resetSelection && _filteredMenuOptions.Count > 0)
            {
                lstAvailableMenus.SelectedIndex = 0;
            }
        }

        private List<FinalMenuOption> SortMenuOptions(IEnumerable<FinalMenuOption> options)
        {
            var optionList = options?.ToList() ?? new List<FinalMenuOption>();
            if (optionList.Count == 0)
            {
                return optionList;
            }

            var sortOption = GetSelectedMenuSortOption();
            var comparer = StringComparer.CurrentCultureIgnoreCase;

            if (sortOption == null || sortOption.IsDefault)
            {
                return optionList
                    .OrderBy(option => option.MenuName, comparer)
                    .ToList();
            }

            Func<FinalMenuOption, decimal> selector = menu => GetMenuNutrientAmount(menu.FinalMenuId, sortOption.NutrientCode);
            var ordered = sortOption.Descending
                ? optionList.OrderByDescending(selector).ThenBy(menu => menu.MenuName, comparer)
                : optionList.OrderBy(selector).ThenBy(menu => menu.MenuName, comparer);

            return ordered.ToList();
        }

        private MenuSortOption GetSelectedMenuSortOption()
        {
            return cmbMenuSort?.SelectedItem as MenuSortOption;
        }

        private decimal GetMenuNutrientAmount(int menuId, string nutrientCode)
        {
            if (menuId <= 0 || string.IsNullOrWhiteSpace(nutrientCode))
            {
                return 0m;
            }

            if (_menuNutrientAmounts.TryGetValue(menuId, out var nutrientMap) &&
                nutrientMap != null &&
                nutrientMap.TryGetValue(nutrientCode, out var amount))
            {
                return amount;
            }

            return 0m;
        }

        private void CmbMenuTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressMenuFilter)
            {
                return;
            }

            ApplyMenuFilter();
        }

        private void CmbMenuSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressMenuFilter)
            {
                return;
            }

            ApplyMenuFilter();
        }

        private void BtnResetMenuFilter_Click(object sender, EventArgs e)
        {
            if (cmbMenuTypeFilter != null && cmbMenuTypeFilter.Items.Count > 0)
            {
                _suppressMenuFilter = true;
                cmbMenuTypeFilter.SelectedIndex = 0;
                _suppressMenuFilter = false;
            }

            if (clbMenuTags != null)
            {
                _suppressMenuFilter = true;
                for (var i = 0; i < clbMenuTags.Items.Count; i++)
                {
                    clbMenuTags.SetItemChecked(i, false);
                }
                _suppressMenuFilter = false;
            }

            if (cmbMenuSort != null && cmbMenuSort.Items.Count > 0)
            {
                _suppressMenuFilter = true;
                cmbMenuSort.SelectedIndex = 0;
                _suppressMenuFilter = false;
            }

            ApplyMenuFilter();
        }

        private void ClbMenuTags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_suppressMenuFilter)
            {
                return;
            }

            BeginInvoke(new Action(() => ApplyMenuFilter()));
        }

        private void DgvMealNutrition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMealNutrition == null ||
                e.RowIndex < 0 ||
                dgvMealNutrition.Columns[e.ColumnIndex] != colNutrientStatus)
            {
                return;
            }

            var row = dgvMealNutrition.Rows[e.RowIndex].DataBoundItem as NutrientSummaryRow;
            if (row == null)
            {
                return;
            }

            var color = GetCompletionColor(row.CompletionRatio);
            e.CellStyle.ForeColor = color;
            e.CellStyle.SelectionForeColor = color;
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvStudents.CurrentRow == null)
            {
                return;
            }

            SetSelectedRawMaterialFromRow(dgvStudents.CurrentRow);
        }

        private void SetSelectedRawMaterialFromRow(DataGridViewRow row)
        {
            var dataRow = GetDataRowFromGrid(row);
            if (dataRow == null)
            {
                _selectedRawMaterialId = null;
                DisplaySelectedRawMaterial(null);
                return;
            }

            var isRaw = string.Equals(dataRow["ITEMTYPE"]?.ToString(), "RAW", StringComparison.OrdinalIgnoreCase);
            _selectedRawMaterialId = isRaw ? ToInt(dataRow["RAWID"]) : (int?)null;
            DisplaySelectedRawMaterial(dataRow);
        }

        private void DisplaySelectedRawMaterial(DataRow row)
        {
            if (txtStudentId == null)
            {
                return;
            }

            if (row == null)
            {
                txtStudentId.Text = "선택 없음";
                return;
            }

            var name = row["RAWNAME"]?.ToString() ?? string.Empty;
            var idText = row["RAWID"]?.ToString();
            var type = row["ITEMTYPE"]?.ToString();
            var typeText = string.Equals(type, "ING", StringComparison.OrdinalIgnoreCase) ? "재료" : "원재료";

            txtStudentId.Text = string.IsNullOrWhiteSpace(idText)
                ? $"{name} ({typeText})"
                : $"{name} ({typeText} ID: {idText})";
        }

        private void DgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRecipes?.Rows == null || e.RowIndex >= dgvRecipes.Rows.Count)
            {
                return;
            }

            SetSelectedRecipeFromRow(dgvRecipes.Rows[e.RowIndex]);
        }

        private void SetSelectedRecipeFromRow(DataGridViewRow row)
        {
            var dataRow = GetDataRowFromGrid(row);
            if (dataRow == null)
            {
                _selectedRecipeId = null;
                DisplaySelectedRecipe(null);
                return;
            }

            _selectedRecipeId = ToInt(dataRow["FINALMENUID"]);
            DisplaySelectedRecipe(dataRow);
        }

        private void DisplaySelectedRecipe(DataRow row)
        {
            if (row == null)
            {
                if (txtRecipeName != null) txtRecipeName.Text = "선택 없음";
                if (txtRecipeCode != null) txtRecipeCode.Text = string.Empty;
                if (txtRecipeType != null) txtRecipeType.Text = string.Empty;
                if (txtRecipeServing != null) txtRecipeServing.Text = string.Empty;
                if (txtRecipeActive != null) txtRecipeActive.Text = string.Empty;
                ClearRecipeNutrients();
                ClearRecipeComponents();
                return;
            }

            if (txtRecipeName != null) txtRecipeName.Text = row["MENUNAME"]?.ToString() ?? string.Empty;
            if (txtRecipeCode != null) txtRecipeCode.Text = row["MENUCODE"]?.ToString() ?? string.Empty;
            if (txtRecipeType != null) txtRecipeType.Text = row["MENUTYPE"]?.ToString() ?? string.Empty;
            if (txtRecipeServing != null)
            {
                var serving = FormatDecimal(row["SERVINGSIZEGRAM"]);
                txtRecipeServing.Text = string.IsNullOrEmpty(serving) ? string.Empty : $"{serving} g";
            }
            if (txtRecipeActive != null) txtRecipeActive.Text = FormatActiveFlag(row["ACTIVEFLAG"]);

            var menuId = ToInt(row["FINALMENUID"]);
            LoadRecipeNutrients(menuId);
            LoadRecipeComponents(menuId);
        }

        private void DgvMealPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealLogs.CurrentRow == null)
            {
                return;
            }

            SetSelectedMealPlanFromRow(dgvMealLogs.CurrentRow);
        }

        private void SetSelectedMealPlanFromRow(DataGridViewRow row)
        {
            SaveMealRecipesForCurrentPlan();
            if (row?.Cells["MEALPLANID"].Value == null)
            {
                _selectedMealPlanId = null;
                DisplaySelectedMealPlan();
                return;
            }

            _selectedMealPlanId = Convert.ToInt32(row.Cells["MEALPLANID"].Value);
            DisplaySelectedMealPlan();
        }

        private void SelectMealPlanById(int mealPlanId)
        {
            if (dgvMealLogs == null)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvMealLogs.Rows)
            {
                if (row?.Cells["MEALPLANID"]?.Value == null)
                {
                    continue;
                }

                if (ToInt(row.Cells["MEALPLANID"].Value) != mealPlanId)
                {
                    continue;
                }

                row.Selected = true;
                if (row.Cells.Count > 0)
                {
                    dgvMealLogs.CurrentCell = row.Cells[0];
                }

                SetSelectedMealPlanFromRow(row);
                break;
            }
        }

        private void DisplaySelectedMealPlan()
        {
            if (_selectedMealPlanId == null || dgvMealLogs.CurrentRow == null)
            {
                txtMenuCode.Text = "선택 없음";
                _currentPlanStart = null;
                _currentPlanEnd = null;
                _selectedWeekOption = null;
                _selectedWeekdayIndex = -1;
                _currentMealPlanStatus = null;
                ClearWeeklyMealsGrid();
                _suppressMealBoardUpdate = true;
                _selectedMealMenus.Clear();
                _suppressMealBoardUpdate = false;
                RefreshMealBoard();
                UpdateNutritionSummary();
                UpdateSelectedDayLabel(null, -1);
                UpdateMealPlanInteractionState();
                return;
            }

            _currentPlanStart = ToNullableDate(dgvMealLogs.CurrentRow.Cells["PERIODSTART"]?.Value);
            _currentPlanEnd = ToNullableDate(dgvMealLogs.CurrentRow.Cells["PERIODEND"]?.Value);

            var name = dgvMealLogs.CurrentRow.Cells["PLANNAME"].Value?.ToString() ?? string.Empty;
            var status = dgvMealLogs.CurrentRow.Cells["STATUS"].Value?.ToString() ?? string.Empty;
            _currentMealPlanStatus = status;
            txtMenuCode.Text = $"{name} ({status})";

            if (dtpMealMonth != null && _currentPlanStart.HasValue)
            {
                SetMealMonthWithoutEvents(new DateTime(_currentPlanStart.Value.Year, _currentPlanStart.Value.Month, 1));
            }
            else
            {
                UpdateMealWeekOptions();
            }

            UpdateMealPlanInteractionState();
        }

        private void UpdateMealPlanInteractionState()
        {
            var hasPlan = _selectedMealPlanId.HasValue;
            if (dgvWeeklyMeals != null)
            {
                dgvWeeklyMeals.Enabled = hasPlan;
            }

            var isDietitian = _session?.IsAdmin != true;
            var canEdit = hasPlan && isDietitian &&
                          string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase);

            if (grpMealPlanDetail != null)
            {
                grpMealPlanDetail.Enabled = canEdit;
            }

            UpdateApprovalRequestAvailability();
        }

        private void UpdateApprovalRequestAvailability()
        {
            if (btnRequestMealApproval == null)
            {
                return;
            }

            var isDietitian = _session?.IsAdmin != true;
            if (!isDietitian)
            {
                btnRequestMealApproval.Enabled = false;
                return;
            }

            var hasPlan = _selectedMealPlanId.HasValue;
            var canRequestApproval = hasPlan &&
                                     string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase) &&
                                     _isCurrentWeekComplete;
            btnRequestMealApproval.Enabled = canRequestApproval;
        }

        private void DgvPurchaseRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvIngredients.CurrentRow == null)
            {
                return;
            }

            SetSelectedPurchaseRequestFromRow(dgvIngredients.CurrentRow);
        }

        private void SetSelectedPurchaseRequestFromRow(DataGridViewRow row)
        {
            if (row?.Cells["PURCHASEREQUESTID"].Value == null)
            {
                _selectedPurchaseRequestId = null;
                return;
            }

            _selectedPurchaseRequestId = Convert.ToInt32(row.Cells["PURCHASEREQUESTID"].Value);
        }

        private void BtnServeMeal_Click(object sender, EventArgs e)
        {
            if (_session?.IsAdmin == true)
            {
                ApproveSelectedMealPlan();
            }
            else
            {
                OpenMealPlanDialog();
            }
        }

        private void BtnCancelMeal_Click(object sender, EventArgs e)
        {
            if (_session?.IsAdmin == true)
            {
                ApproveSelectedPurchaseRequest();
            }
            else
            {
                OpenPurchaseRequestDialog();
            }
        }

        private void BtnRegisterMealPlan_Click(object sender, EventArgs e)
        {
            if (!EnsureDietitianAccess())
            {
                return;
            }

            try
            {
                RegisterMealForCurrentPlan();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"식단 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void BtnRequestMealApproval_Click(object sender, EventArgs e)
        {
            RequestMealPlanApproval();
        }

        private void BtnStartMealPlan_Click(object sender, EventArgs e)
        {
            OpenMealPlanDialog();
        }

        private void OpenMealPlanDialog()
        {
            if (!EnsureDietitianAccess())
            {
                return;
            }

            using (var dialog = new MealPlanDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    var input = dialog.Result;
                    try
                    {
                        var planId = CreateMealPlan(input.PlanName, input.StartDate, input.EndDate);
                        MessageBox.Show("식단 계획이 등록되었습니다.", "완료");
                        ReloadAll();
                        SelectMealPlanById(planId);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"식단 계획 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
                    }
                }
            }
        }

        private int CreateMealPlan(string planName, DateTime startDate, DateTime endDate)
        {
            var nextId = GetNextId("MEALPLAN", "MEALPLANID");
            const string sql =
                "INSERT INTO MealPlan (MealPlanID, PlanName, PeriodStart, PeriodEnd, Status, CreatedBy) " +
                "VALUES (:ID, :NAME, :START, :END, :STATUS, :CREATEDBY)";

            ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("NAME", planName),
                new OracleParameter("START", startDate),
                new OracleParameter("END", endDate),
                new OracleParameter("STATUS", MealPlanStatusDraft),
                new OracleParameter("CREATEDBY", _session?.UserId ?? "SYSTEM"));

            return nextId;
        }

        private void RequestMealPlanApproval()
        {
            if (!EnsureDietitianAccess())
            {
                return;
            }

            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("식단 계획을 선택해 주세요.", "안내");
                return;
            }

            if (!_isCurrentWeekComplete)
            {
                MessageBox.Show("한 주의 식단을 모두 등록한 후 승인 요청을 할 수 있습니다.", "안내");
                return;
            }

            if (!string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("작성 중인 식단만 승인 요청할 수 있습니다.", "안내");
                return;
            }

            const string sql = "UPDATE MealPlan SET Status = :STATUS WHERE MealPlanID = :ID";
            try
            {
                var planId = _selectedMealPlanId.Value;
                var rows = ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", MealPlanStatusPending),
                    new OracleParameter("ID", planId));

                if (rows > 0)
                {
                    MessageBox.Show("식단 승인 요청이 전송되었습니다.", "완료");
                    ReloadAll();
                    SelectMealPlanById(planId);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"식단 승인 요청 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void RegisterMealForCurrentPlan()
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("식단 계획을 선택해 주세요.", "안내");
                return;
            }

            if (_selectedMealMenus.Count == 0)
            {
                MessageBox.Show("식단 보드에 메뉴를 추가해 주세요.", "안내");
                return;
            }

            if (dtpMealDate == null || _selectedWeekdayIndex < 0)
            {
                MessageBox.Show("요일을 선택해 주세요.", "안내");
                return;
            }

            var mealDate = dtpMealDate.Value.Date;
            if (!IsMealDateWithinSelectedPlan(mealDate, out var planStart, out var planEnd))
            {
                var startText = planStart?.ToString("yyyy-MM-dd") ?? "-";
                var endText = planEnd?.ToString("yyyy-MM-dd") ?? "-";
                MessageBox.Show($"선택한 날짜가 식단 계획 기간({startText} ~ {endText})을 벗어났습니다.", "안내");
                return;
            }

            var notes = txtMealNotes?.Text?.Trim();
            PersistMeal(mealDate, notes);
        }

        private bool IsMealDateWithinSelectedPlan(DateTime mealDate, out DateTime? planStart, out DateTime? planEnd)
        {
            planStart = _currentPlanStart;
            planEnd = _currentPlanEnd;

            if (!planStart.HasValue || !planEnd.HasValue)
            {
                var row = GetCurrentMealPlanRow();
                if (row != null)
                {
                    planStart ??= ToNullableDate(row.Cells["PERIODSTART"]?.Value);
                    planEnd ??= ToNullableDate(row.Cells["PERIODEND"]?.Value);
                }
            }

            if (planStart.HasValue && mealDate.Date < planStart.Value.Date)
            {
                return false;
            }

            if (planEnd.HasValue && mealDate.Date > planEnd.Value.Date)
            {
                return false;
            }

            return true;
        }

        private bool IsWeekWithinSelectedPlan(DateTime weekStart, DateTime weekEnd)
        {
            if (!IsMealDateWithinSelectedPlan(weekStart, out var planStart, out var planEnd))
            {
                return false;
            }

            if (!planStart.HasValue || !planEnd.HasValue)
            {
                return false;
            }

            return weekEnd.Date <= planEnd.Value.Date;
        }

        private DataGridViewRow GetCurrentMealPlanRow()
        {
            if (_selectedMealPlanId == null || dgvMealLogs == null)
            {
                return null;
            }

            foreach (DataGridViewRow row in dgvMealLogs.Rows)
            {
                if (row.Cells["MEALPLANID"]?.Value == null)
                {
                    continue;
                }

                if (ToInt(row.Cells["MEALPLANID"].Value) == _selectedMealPlanId)
                {
                    return row;
                }
            }

            return null;
        }

        private static DateTime? ToNullableDate(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToDateTime(value);
        }

        private void PersistMeal(DateTime mealDate, string notes)
        {
            if (_selectedMealPlanId == null)
            {
                return;
            }

            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        var planId = _selectedMealPlanId.Value;
                        var existingMealId = GetExistingMealId(conn, transaction, planId, mealDate);
                        int mealId;
                        if (existingMealId > 0)
                        {
                            mealId = existingMealId;
                            UpdateMealRow(conn, transaction, mealId, planId, mealDate, notes);
                            DeleteMealComponents(conn, transaction, mealId);
                        }
                        else
                        {
                            mealId = GetNextMealId(conn, transaction);
                            InsertMealRow(conn, transaction, mealId, planId, mealDate, notes);
                        }

                        InsertMealComponents(conn, transaction, mealId);
                        transaction.Commit();
                        MessageBox.Show("식단이 등록되었습니다.", "완료");
                        RefreshWeeklyMealBoard();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private static int GetExistingMealId(OracleConnection conn, OracleTransaction transaction, int planId, DateTime mealDate)
        {
            const string sql =
                "SELECT MealID FROM Meal WHERE MealPlanID = :PLANID AND MealDate = :MEALDATE";
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("PLANID", planId));
                cmd.Parameters.Add(new OracleParameter("MEALDATE", mealDate));
                var result = cmd.ExecuteScalar();
                return ToInt(result);
            }
        }

        private static int GetNextMealId(OracleConnection conn, OracleTransaction transaction)
        {
            using (var cmd = new OracleCommand("SELECT NVL(MAX(MealID), 0) + 1 FROM Meal", conn))
            {
                cmd.Transaction = transaction;
                var result = cmd.ExecuteScalar();
                return ToInt(result);
            }
        }

        private static void InsertMealRow(OracleConnection conn, OracleTransaction transaction, int mealId, int planId, DateTime mealDate, string notes)
        {
            const string sql =
                "INSERT INTO Meal (MealID, MealPlanID, MealDate, TargetGradeFrom, TargetGradeTo, TargetGroup, Notes) " +
                "VALUES (:ID, :PLANID, :MEALDATE, NULL, NULL, NULL, :NOTES)";
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("ID", mealId));
                cmd.Parameters.Add(new OracleParameter("PLANID", planId));
                cmd.Parameters.Add(new OracleParameter("MEALDATE", mealDate));
                cmd.Parameters.Add(new OracleParameter("NOTES",
                    string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes));
                cmd.ExecuteNonQuery();
            }
        }

        private static void UpdateMealRow(OracleConnection conn, OracleTransaction transaction, int mealId, int planId, DateTime mealDate, string notes)
        {
            const string sql =
                "UPDATE Meal SET MealPlanID = :PLANID, MealDate = :MEALDATE, Notes = :NOTES " +
                "WHERE MealID = :ID";
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("PLANID", planId));
                cmd.Parameters.Add(new OracleParameter("MEALDATE", mealDate));
                cmd.Parameters.Add(new OracleParameter("NOTES",
                    string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes));
                cmd.Parameters.Add(new OracleParameter("ID", mealId));
                cmd.ExecuteNonQuery();
            }
        }

        private static void DeleteMealComponents(OracleConnection conn, OracleTransaction transaction, int mealId)
        {
            using (var cmd = new OracleCommand("DELETE FROM MealComp WHERE MealID = :ID", conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("ID", mealId));
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertMealComponents(OracleConnection conn, OracleTransaction transaction, int mealId)
        {
            if (_selectedMealMenus.Count == 0)
            {
                return;
            }

            const string sql =
                "INSERT INTO MealComp (MealID, FinalMenuID, PortionCount, IsMainDish) VALUES (:MEALID, :MENUID, :PORTION, :ISMAIN)";

            var isFirst = true;
            foreach (var menu in _selectedMealMenus)
            {
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.Add(new OracleParameter("MEALID", mealId));
                    cmd.Parameters.Add(new OracleParameter("MENUID", menu.FinalMenuId));
                    cmd.Parameters.Add(new OracleParameter("PORTION", GetDefaultPortionCount()));
                    cmd.Parameters.Add(new OracleParameter("ISMAIN", isFirst ? "Y" : "N"));
                    cmd.ExecuteNonQuery();
                }

                isFirst = false;
            }
        }

        private int GetDefaultPortionCount()
        {
            return DefaultMealPortion;
        }

        private void DisplayManagedRawMaterial(DataRow row)
        {
            if (txtRawDetailName == null)
            {
                return;
            }

            var itemType = row?["ITEMTYPE"]?.ToString();
            var isIngredient = string.Equals(itemType, "ING", StringComparison.OrdinalIgnoreCase);

            if (row == null || IsGroupRow(row))
            {
                txtRawDetailName.Text = "선택 없음";
                txtRawDetailCategory.Text = string.Empty;
                txtRawDetailUnit.Text = string.Empty;
                txtRawDetailBaseQty.Text = string.Empty;
                txtRawDetailUnitGram.Text = string.Empty;
                txtRawDetailStorage.Text = string.Empty;
                txtRawDetailShelfLife.Text = string.Empty;
                txtRawDetailActive.Text = string.Empty;
                ClearRawNutrients();
                ClearIngredientComponents();
                return;
            }

            txtRawDetailName.Text = row["RAWNAME"]?.ToString() ?? string.Empty;
            txtRawDetailCategory.Text = row["CATEGORYNAME"]?.ToString() ?? string.Empty;
            txtRawDetailUnit.Text = row["PURCHASEUNIT"]?.ToString() ?? string.Empty;
            txtRawDetailBaseQty.Text = FormatDecimal(row["BASEUNITQTY"]);
            txtRawDetailUnitGram.Text = FormatDecimal(row["UNITGRAMQTY"]);
            txtRawDetailStorage.Text = row["STORAGETYPE"]?.ToString() ?? string.Empty;
            txtRawDetailShelfLife.Text = FormatShelfLife(row["SHELFLIFEDAYS"]);
            txtRawDetailActive.Text = FormatActiveFlag(row["ACTIVEFLAG"]);
            var rawId = ToInt(row["RAWID"]);
            LoadRawNutrients(rawId);
            if (isIngredient)
            {
                LoadIngredientComponents(rawId);
            }
            else
            {
                ClearIngredientComponents();
            }
        }

        private static bool IsGroupRow(DataRow row)
        {
            if (row == null || !row.Table.Columns.Contains("ISGROUPROW"))
            {
                return false;
            }

            return row["ISGROUPROW"] != DBNull.Value && Convert.ToBoolean(row["ISGROUPROW"]);
        }

        private static string FormatDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return string.Empty;
            }

            return Convert.ToDecimal(value).ToString("#,##0.###");
        }

        private static string FormatShelfLife(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "-";
            }

            return $"{Convert.ToInt32(value)}일";
        }

        private static string FormatActiveFlag(object value)
        {
            var text = value?.ToString();
            if (string.Equals(text, "Y", StringComparison.OrdinalIgnoreCase))
            {
                return "사용";
            }

            if (string.Equals(text, "N", StringComparison.OrdinalIgnoreCase))
            {
                return "중지";
            }

            return text ?? string.Empty;
        }

        private void LoadRawNutrients(int rawId)
        {
            if (dgvRawNutrients == null)
            {
                return;
            }

            const string sql =
                "SELECT n.NutrientName AS 영양소, n.Unit AS 단위, rn.AmountPerBase AS \"1g당 함량\" " +
                "FROM RawNutrient rn INNER JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE rn.RawID = :RAWID ORDER BY n.NutrientName";

            var table = ExecuteDataTable(sql, new OracleParameter("RAWID", rawId));
            dgvRawNutrients.DataSource = table;
        }

        private void LoadIngredientComponents(int ingredientId)
        {
            if (dgvRawComponents == null)
            {
                return;
            }

            const string sql =
                "SELECT r.RawName AS 원재료, ic.QuantityPerBatch AS 배합량, ic.LossRatePct AS 손실률 " +
                "FROM IngredientComp ic INNER JOIN RawMaterial r ON ic.RawID = r.RawID " +
                "WHERE ic.IngredientID = :INGID ORDER BY r.RawName";

            var table = ExecuteDataTable(sql, new OracleParameter("INGID", ingredientId));
            dgvRawComponents.DataSource = table;
        }

        private void ClearRawNutrients()
        {
            if (dgvRawNutrients != null)
            {
                dgvRawNutrients.DataSource = null;
            }
        }

        private void ClearIngredientComponents()
        {
            if (dgvRawComponents != null)
            {
                dgvRawComponents.DataSource = null;
            }
        }

        private void LoadRecipeNutrients(int finalMenuId)
        {
            if (dgvRecipeNutrients == null)
            {
                return;
            }

            const string sql =
                "WITH base_component AS ( " +
                "    SELECT mc.FinalMenuID, mc.ComponentType, mc.ComponentRawID, mc.ComponentIngredientID, " +
                "           NVL(mc.QuantityPerServing, 0) AS Qty " +
                "    FROM MenuComp mc WHERE mc.FinalMenuID = :ID " +
                "), raw_component AS ( " +
                "    SELECT bc.FinalMenuID, bc.ComponentRawID AS RawID, bc.Qty AS QuantityGram " +
                "    FROM base_component bc WHERE bc.ComponentType = 'R' AND bc.ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID, " +
                "           bc.Qty * (NVL(ic.QuantityPerBatch, 0) / NULLIF(i.BatchYieldGram, 0)) AS QuantityGram " +
                "    FROM base_component bc " +
                "    JOIN IngredientComp ic ON bc.ComponentIngredientID = ic.IngredientID " +
                "    JOIN Ingredient i ON ic.IngredientID = i.IngredientID " +
                "    WHERE bc.ComponentType = 'I' AND bc.ComponentIngredientID IS NOT NULL AND i.BatchYieldGram IS NOT NULL AND i.BatchYieldGram > 0 " +
                ") " +
                "SELECT n.NutrientName AS 영양소, n.Unit AS 단위, " +
                "       ROUND(SUM(NVL(rn.AmountPerBase, 0) * NVL(rc.QuantityGram, 0)), 3) AS 함량 " +
                "FROM raw_component rc " +
                "JOIN RawMaterial r ON rc.RawID = r.RawID " +
                "JOIN RawNutrient rn ON rn.RawID = r.RawID " +
                "JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE rc.FinalMenuID = :ID " +
                "GROUP BY n.NutrientName, n.Unit " +
                "ORDER BY n.NutrientName";

            var table = ExecuteDataTable(sql, new OracleParameter("ID", finalMenuId));
            dgvRecipeNutrients.DataSource = table;
        }

        private void LoadRecipeComponents(int finalMenuId)
        {
            if (dgvRecipeComponents == null)
            {
                return;
            }

            var aggregated = LoadAggregatedRecipeComponents(finalMenuId);
            if (aggregated.Rows.Count > 0)
            {
                dgvRecipeComponents.DataSource = aggregated;
                ConfigureAggregatedRecipeGrid();
                return;
            }

            const string sql =
                "SELECT CASE mc.ComponentType WHEN 'R' THEN '원재료' ELSE '재료' END AS TypeLabel, " +
                "       COALESCE(r.RawName, i.IngredientName) AS ComponentName, " +
                "       NVL(mc.QuantityPerServing, 0) AS QuantityPerServing, " +
                "       mc.ComponentRawID AS RawID, " +
                "       CASE mc.ComponentType WHEN 'R' THEN r.PurchaseUnit ELSE '조합' END AS UnitLabel " +
                "FROM MenuComp mc " +
                "LEFT JOIN RawMaterial r ON mc.ComponentRawID = r.RawID " +
                "LEFT JOIN Ingredient i ON mc.ComponentIngredientID = i.IngredientID " +
                "WHERE mc.FinalMenuID = :ID " +
                "ORDER BY TypeLabel, ComponentName";

            var table = ExecuteDataTable(sql, new OracleParameter("ID", finalMenuId));
            dgvRecipeComponents.DataSource = table;
            if (dgvRecipeComponents.Columns.Contains("TypeLabel"))
            {
                dgvRecipeComponents.Columns["TypeLabel"].HeaderText = "구성 구분";
            }

            if (dgvRecipeComponents.Columns.Contains("ComponentName"))
            {
                dgvRecipeComponents.Columns["ComponentName"].HeaderText = "구성명";
            }

            if (dgvRecipeComponents.Columns.Contains("QuantityPerServing"))
            {
                dgvRecipeComponents.Columns["QuantityPerServing"].HeaderText = "1인분 사용량";
            }

            if (dgvRecipeComponents.Columns.Contains("UnitLabel"))
            {
                dgvRecipeComponents.Columns["UnitLabel"].HeaderText = "단위";
            }

            var rawIdColumn = GetColumn(dgvRecipeComponents, "RawID");
            if (rawIdColumn != null)
            {
                rawIdColumn.Visible = false;
            }
        }

        private DataTable LoadAggregatedRecipeComponents(int finalMenuId)
        {
            const string sql =
                "WITH base_component AS ( " +
                "    SELECT mc.FinalMenuID, mc.ComponentType, mc.ComponentRawID, mc.ComponentIngredientID, " +
                "           NVL(mc.QuantityPerServing, 0) AS Qty " +
                "    FROM MenuComp mc WHERE mc.FinalMenuID = :ID " +
                "), raw_component AS ( " +
                "    SELECT bc.FinalMenuID, bc.ComponentRawID AS RawID, bc.Qty AS QuantityGram " +
                "    FROM base_component bc " +
                "    WHERE bc.ComponentType = 'R' AND bc.ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID, " +
                "           bc.Qty * (NVL(ic.QuantityPerBatch, 0) / NULLIF(i.BatchYieldGram, 0)) AS QuantityGram " +
                "    FROM base_component bc " +
                "    JOIN IngredientComp ic ON bc.ComponentIngredientID = ic.IngredientID " +
                "    JOIN Ingredient i ON ic.IngredientID = i.IngredientID " +
                "    WHERE bc.ComponentType = 'I' AND bc.ComponentIngredientID IS NOT NULL " +
                "          AND i.BatchYieldGram IS NOT NULL AND i.BatchYieldGram > 0 " +
                "), aggregated AS ( " +
                "    SELECT rc.FinalMenuID, rc.RawID, SUM(NVL(rc.QuantityGram, 0)) AS QuantityGram " +
                "    FROM raw_component rc " +
                "    GROUP BY rc.FinalMenuID, rc.RawID " +
                ") " +
                "SELECT r.RawID AS RawID, r.RawName AS RawName, ROUND(a.QuantityGram, 3) AS QuantityPerServing, r.PurchaseUnit AS PurchaseUnit " +
                "FROM aggregated a " +
                "JOIN RawMaterial r ON a.RawID = r.RawID " +
                "WHERE a.FinalMenuID = :ID " +
                "ORDER BY r.RawName";

            return ExecuteDataTable(sql, new OracleParameter("ID", finalMenuId));
        }

        private void ConfigureAggregatedRecipeGrid()
        {
            var rawIdColumn = GetColumn(dgvRecipeComponents, "RawID");
            if (rawIdColumn != null)
            {
                rawIdColumn.Visible = false;
            }

            if (dgvRecipeComponents.Columns.Contains("RawName"))
            {
                dgvRecipeComponents.Columns["RawName"].HeaderText = "원재료";
            }

            if (dgvRecipeComponents.Columns.Contains("QuantityPerServing"))
            {
                dgvRecipeComponents.Columns["QuantityPerServing"].HeaderText = "1인분 사용량(g)";
            }

            if (dgvRecipeComponents.Columns.Contains("PurchaseUnit"))
            {
                dgvRecipeComponents.Columns["PurchaseUnit"].HeaderText = "구매 단위";
            }
        }

        private void DgvRecipeComponents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRecipeComponents == null || e.Button != MouseButtons.Right || e.RowIndex < 0)
            {
                return;
            }

            dgvRecipeComponents.ClearSelection();
            var row = dgvRecipeComponents.Rows[e.RowIndex];
            row.Selected = true;
            var columnIndex = e.ColumnIndex >= 0 ? e.ColumnIndex : 0;
            if (columnIndex >= 0 && columnIndex < row.Cells.Count)
            {
                dgvRecipeComponents.CurrentCell = row.Cells[columnIndex];
            }
        }

        private void RecipeComponentMenu_Opening(object sender, CancelEventArgs e)
        {
            if (_menuRecipeViewRaw == null)
            {
                return;
            }

            var rawId = GetSelectedRecipeComponentRawId();
            _menuRecipeViewRaw.Enabled = rawId.HasValue && rawId.Value > 0;
        }

        private void MenuRecipeViewRaw_Click(object sender, EventArgs e)
        {
            var rawId = GetSelectedRecipeComponentRawId();
            if (rawId.HasValue)
            {
                ShowRawMaterialInManager(rawId.Value);
            }
        }

        private int? GetSelectedRecipeComponentRawId()
        {
            if (dgvRecipeComponents?.CurrentRow == null)
            {
                return null;
            }

            var rawId = GetRawIdFromRecipeComponentRow(dgvRecipeComponents.CurrentRow);
            return rawId > 0 ? rawId : (int?)null;
        }

        private void ClearRecipeNutrients()
        {
            if (dgvRecipeNutrients != null)
            {
                dgvRecipeNutrients.DataSource = null;
            }
        }

        private void ClearRecipeComponents()
        {
            if (dgvRecipeComponents != null)
            {
                dgvRecipeComponents.DataSource = null;
            }
        }

        private void ApplyRawMaterialView()
        {
            if (_rawMaterialTable == null || dgvRawMaterials == null)
            {
                return;
            }

            var filteredRows = GetFilteredRawRows().ToList();
            var useGrouping = chkRawGroup?.Checked == true;
            if (!useGrouping)
            {
                _collapsedCategories.Clear();
            }

            var viewTable = CreateRawMaterialViewTable(filteredRows, useGrouping);
            dgvRawMaterials.DataSource = viewTable;
            ConfigureRawGridColumns();

            var firstDataRow = viewTable.AsEnumerable().FirstOrDefault(r => !IsGroupRow(r));
            if (firstDataRow != null)
            {
                var index = viewTable.Rows.IndexOf(firstDataRow);
                if (index >= 0 && index < dgvRawMaterials.Rows.Count)
                {
                    dgvRawMaterials.Rows[index].Selected = true;
                }

                DisplayManagedRawMaterial(firstDataRow);
            }
            else
            {
                DisplayManagedRawMaterial((DataRow)null);
            }
        }

        private IEnumerable<string> GetSelectedRawNutrients()
        {
            return GetSelectedNutrientCodes(chkRawNutrientProtein, chkRawNutrientFat, chkRawNutrientCarb);
        }

        private IEnumerable<string> GetSelectedRecipeNutrients()
        {
            return GetSelectedNutrientCodes(chkRecipeNutrientProtein, chkRecipeNutrientFat, chkRecipeNutrientCarb);
        }

        private static IEnumerable<string> GetSelectedNutrientCodes(params CheckBox[] checkBoxes)
        {
            if (checkBoxes == null)
            {
                yield break;
            }

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox?.Checked == true &&
                    checkBox.Tag is string code &&
                    !string.IsNullOrWhiteSpace(code))
                {
                    yield return code;
                }
            }
        }

        private static decimal? GetNumericFilterValue(NumericUpDown control)
        {
            if (control == null)
            {
                return null;
            }

            var value = control.Value;
            return value > 0 ? value : (decimal?)null;
        }

        private static void NormalizeRange(ref decimal? min, ref decimal? max)
        {
            if (min.HasValue && max.HasValue && min.Value > max.Value)
            {
                var temp = min;
                min = max;
                max = temp;
            }
        }

        private IEnumerable<DataRow> GetFilteredRawRows()
        {
            if (_rawMaterialTable == null)
            {
                return Enumerable.Empty<DataRow>();
            }

            var search = txtRawSearch?.Text?.Trim();
            var rows = _rawMaterialTable.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                rows = rows.Where(r =>
                    (r["RAWNAME"]?.ToString() ?? string.Empty)
                        .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var requiredNutrients = GetSelectedRawNutrients().ToList();
            var minCalorie = GetNumericFilterValue(nudRawCalorieMin);
            var maxCalorie = GetNumericFilterValue(nudRawCalorieMax);
            NormalizeRange(ref minCalorie, ref maxCalorie);

            if (requiredNutrients.Count > 0)
            {
                rows = rows.Where(r =>
                {
                    var rawId = ToInt(r["RAWID"]);
                    return _rawNutrientCodes.TryGetValue(rawId, out var codes) &&
                           requiredNutrients.All(code => codes.Contains(code));
                });
            }

            if (minCalorie.HasValue || maxCalorie.HasValue)
            {
                rows = rows.Where(r =>
                {
                    var rawId = ToInt(r["RAWID"]);
                    if (!_rawCalorieMap.TryGetValue(rawId, out var calories))
                    {
                        return false;
                    }

                    if (minCalorie.HasValue && calories < minCalorie.Value)
                    {
                        return false;
                    }

                    if (maxCalorie.HasValue && calories > maxCalorie.Value)
                    {
                        return false;
                    }

                    return true;
                });
            }

            return rows.OrderBy(r => r["RAWNAME"]?.ToString());
        }

        private void ApplyRecipeFilter()
        {
            if (_recipeTable == null || dgvRecipes == null)
            {
                return;
            }

            var viewTable = _recipeTable.Clone();
            var keyword = txtRecipeSearch?.Text?.Trim();
            IEnumerable<DataRow> rows = _recipeTable.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                rows = rows.Where(r =>
                    (r["MENUNAME"]?.ToString() ?? string.Empty).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (r["MENUCODE"]?.ToString() ?? string.Empty).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var requiredNutrients = GetSelectedRecipeNutrients().ToList();
            var minCalorie = GetNumericFilterValue(nudRecipeCalorieMin);
            var maxCalorie = GetNumericFilterValue(nudRecipeCalorieMax);
            NormalizeRange(ref minCalorie, ref maxCalorie);

            if (requiredNutrients.Count > 0)
            {
                rows = rows.Where(r =>
                {
                    var menuId = ToInt(r["FINALMENUID"]);
                    return _recipeNutrientCodes.TryGetValue(menuId, out var codes) &&
                           requiredNutrients.All(code => codes.Contains(code));
                });
            }

            if (minCalorie.HasValue || maxCalorie.HasValue)
            {
                rows = rows.Where(r =>
                {
                    var menuId = ToInt(r["FINALMENUID"]);
                    if (!_recipeCalorieMap.TryGetValue(menuId, out var calories))
                    {
                        return false;
                    }

                    if (minCalorie.HasValue && calories < minCalorie.Value)
                    {
                        return false;
                    }

                    if (maxCalorie.HasValue && calories > maxCalorie.Value)
                    {
                        return false;
                    }

                    return true;
                });
            }

            foreach (var row in rows)
            {
                viewTable.ImportRow(row);
            }

            dgvRecipes.DataSource = viewTable;
            ConfigureRecipeGridColumns();
            if (dgvRecipes.Rows.Count > 0)
            {
                dgvRecipes.Rows[0].Selected = true;
                SetSelectedRecipeFromRow(dgvRecipes.Rows[0]);
            }
            else
            {
                _selectedRecipeId = null;
                DisplaySelectedRecipe(null);
            }
        }

        private DataTable CreateRawMaterialViewTable(IReadOnlyCollection<DataRow> rows, bool useGrouping)
        {
            var table = _rawMaterialTable.Clone();
            if (!table.Columns.Contains("ISGROUPROW"))
            {
                table.Columns.Add("ISGROUPROW", typeof(bool));
            }

            if (!table.Columns.Contains("GROUPNAME"))
            {
                table.Columns.Add("GROUPNAME", typeof(string));
            }

            if (!useGrouping)
            {
                _groupRowSerial = -1;
                foreach (var row in rows)
                {
                    var newRow = table.NewRow();
                    CopyRawRow(row, newRow);
                    newRow["ISGROUPROW"] = false;
                    newRow["GROUPNAME"] = row["CATEGORYNAME"]?.ToString() ?? "미분류";
                    table.Rows.Add(newRow);
                }

                return table;
            }

            var grouped = rows.GroupBy(r => r["CATEGORYNAME"]?.ToString() ?? "미분류")
                .OrderBy(g => g.Key);
            _groupRowSerial = -1;

            foreach (var group in grouped)
            {
                var isCollapsed = _collapsedCategories.Contains(group.Key);
                var headerRow = table.NewRow();
                headerRow["ISGROUPROW"] = true;
                headerRow["GROUPNAME"] = group.Key;
                headerRow["RAWNAME"] = $"{(isCollapsed ? "[+]" : "[-]")} {group.Key} ({group.Count()}개)";
                headerRow["ITEMTYPE"] = "GROUP";
                AssignGroupRowId(headerRow);
                FillRequiredDefaults(headerRow);
                table.Rows.Add(headerRow);

                if (isCollapsed)
                {
                    continue;
                }

                foreach (var row in group.OrderBy(r => r["RAWNAME"]?.ToString()))
                {
                    var newRow = table.NewRow();
                    CopyRawRow(row, newRow);
                    newRow["ISGROUPROW"] = false;
                    newRow["GROUPNAME"] = group.Key;
                    table.Rows.Add(newRow);
                }
            }

            return table;
        }

        private static void CopyRawRow(DataRow source, DataRow destination)
        {
            foreach (DataColumn column in source.Table.Columns)
            {
                destination[column.ColumnName] = source[column];
            }
        }

        private static HashSet<string> GetOrCreateNutrientSet(Dictionary<int, HashSet<string>> map, int key)
        {
            if (!map.TryGetValue(key, out var set))
            {
                set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                map[key] = set;
            }

            return set;
        }

        private Dictionary<string, decimal> GetOrCreateNutrientAmountMap(int key)
        {
            if (!_menuNutrientAmounts.TryGetValue(key, out var map))
            {
                map = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
                _menuNutrientAmounts[key] = map;
            }

            return map;
        }

        private sealed class MenuTagOption
        {
            public MenuTagOption(int tagId, string name, string type)
            {
                TagId = tagId;
                Name = name ?? string.Empty;
                Type = type;
            }

            public int TagId { get; }
            public string Name { get; }
            public string Type { get; }

            public override string ToString()
            {
                if (string.IsNullOrWhiteSpace(Type))
                {
                    return Name;
                }

                return $"{Name} ({Type})";
            }
        }

        private sealed class MenuSortOption
        {
            private MenuSortOption(string displayName, string nutrientCode, bool descending, bool isDefault)
            {
                DisplayName = displayName;
                NutrientCode = nutrientCode;
                Descending = descending;
                IsDefault = isDefault || string.IsNullOrWhiteSpace(nutrientCode);
            }

            public string DisplayName { get; }
            public string NutrientCode { get; }
            public bool Descending { get; }
            public bool IsDefault { get; }

            public override string ToString() => DisplayName;

            public static MenuSortOption CreateDefault(string displayName)
            {
                return new MenuSortOption(displayName, null, false, true);
            }

            public static MenuSortOption Create(string displayName, string nutrientCode, bool descending)
            {
                return new MenuSortOption(displayName, nutrientCode, descending, false);
            }
        }

        private sealed class NutrientTarget
        {
            public NutrientTarget(string displayName, string unit, string code, decimal targetAmount)
            {
                DisplayName = displayName;
                Unit = unit;
                Code = code;
                TargetAmount = targetAmount;
            }

            public string DisplayName { get; }
            public string Unit { get; }
            public string Code { get; }
            public decimal TargetAmount { get; }
        }

        private sealed class NutrientSummaryRow
        {
            public NutrientSummaryRow(string nutrient, string unit, decimal targetAmount, decimal currentAmount)
            {
                Nutrient = nutrient;
                Unit = unit;
                TargetAmount = Math.Round(targetAmount, 2);
                CurrentAmount = Math.Round(currentAmount, 2);
            }

            public string Nutrient { get; }
            public string Unit { get; }
            public decimal TargetAmount { get; }
            public decimal CurrentAmount { get; }
            public decimal CompletionRatio
            {
                get
                {
                    if (TargetAmount <= 0)
                    {
                        return 0m;
                    }

                    return Math.Round(CurrentAmount / TargetAmount * 100m, 1);
                }
            }

            public string CompletionText => $"{CompletionRatio:0.#}%";
        }

        private static Color GetCompletionColor(decimal ratio)
        {
            if (ratio < 50m)
            {
                return Color.Firebrick;
            }

            if (ratio < 70m)
            {
                return Color.DarkOrange;
            }

            if (ratio < 90m)
            {
                return Color.SeaGreen;
            }

            return Color.RoyalBlue;
        }

        private static void FillRequiredDefaults(DataRow row)
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.ColumnName == "ISGROUPROW" || column.ColumnName == "GROUPNAME")
                {
                    continue;
                }

                if (!column.AllowDBNull && (row[column] == DBNull.Value || row[column] == null))
                {
                    if (column.DataType == typeof(string))
                    {
                        row[column] = string.Empty;
                    }
                    else if (column.DataType == typeof(DateTime))
                    {
                        row[column] = DateTime.MinValue;
                    }
                    else if (column.DataType.IsValueType)
                    {
                        row[column] = Activator.CreateInstance(column.DataType);
                    }
                    else
                    {
                        row[column] = DBNull.Value;
                    }
                }
            }
        }

        private void AssignGroupRowId(DataRow row)
        {
            var table = row.Table;
            if (!table.Columns.Contains("RAWID"))
            {
                return;
            }

            var next = _groupRowSerial--;
            var column = table.Columns["RAWID"];
            if (column.DataType == typeof(int))
            {
                row["RAWID"] = next;
            }
            else if (column.DataType == typeof(long))
            {
                row["RAWID"] = (long)next;
            }
            else if (column.DataType == typeof(decimal))
            {
                row["RAWID"] = Convert.ToDecimal(next);
            }
            else if (column.DataType == typeof(double))
            {
                row["RAWID"] = Convert.ToDouble(next);
            }
            else
            {
                row["RAWID"] = next.ToString();
            }
        }

        private void ConfigureRawGridColumns()
        {
            if (dgvRawMaterials == null)
            {
                return;
            }

            if (dgvRawMaterials.Columns.Contains("ISGROUPROW"))
            {
                dgvRawMaterials.Columns["ISGROUPROW"].Visible = false;
            }

            if (dgvRawMaterials.Columns.Contains("GROUPNAME"))
            {
                dgvRawMaterials.Columns["GROUPNAME"].Visible = false;
            }

            if (dgvRawMaterials.Columns.Contains("RAWID"))
            {
                dgvRawMaterials.Columns["RAWID"].Visible = false;
            }

            if (dgvRawMaterials.Columns.Contains("ITEMTYPE"))
            {
                dgvRawMaterials.Columns["ITEMTYPE"].HeaderText = "구분";
            }

            if (dgvRawMaterials.Columns.Contains("INGREDIENTTYPE"))
            {
                dgvRawMaterials.Columns["INGREDIENTTYPE"].Visible = false;
            }

            if (dgvRawMaterials.Columns.Contains("BATCHYIELDGRAM"))
            {
                dgvRawMaterials.Columns["BATCHYIELDGRAM"].Visible = false;
            }

            if (dgvRawMaterials.Columns.Contains("DEFAULTPORTIONGRAM"))
            {
                dgvRawMaterials.Columns["DEFAULTPORTIONGRAM"].Visible = false;
            }

            ApplyRawColumnHeaders(dgvRawMaterials);
        }

        private static void ApplyRawColumnHeaders(DataGridView grid)
        {
            if (grid == null || grid.Columns.Count == 0)
            {
                return;
            }

            foreach (var kvp in RawColumnHeaders)
            {
                if (grid.Columns.Contains(kvp.Key))
                {
                    grid.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }
        }

        private void ConfigureRecipeGridColumns()
        {
            if (dgvRecipes == null)
            {
                return;
            }

            if (dgvRecipes.Columns.Contains("FINALMENUID"))
            {
                dgvRecipes.Columns["FINALMENUID"].Visible = false;
            }

            foreach (var kvp in RecipeColumnHeaders)
            {
                if (dgvRecipes.Columns.Contains(kvp.Key))
                {
                    dgvRecipes.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }
        }

        private List<RawCategoryOption> GetRawCategories()
        {
            const string sql =
                "SELECT RawCategoryID, CategoryName FROM RawCategory " +
                "WHERE NVL(ActiveFlag, 'Y') = 'Y' ORDER BY CategoryName";

            var table = ExecuteDataTable(sql);
            var result = new List<RawCategoryOption>();
            foreach (DataRow row in table.Rows)
            {
                result.Add(new RawCategoryOption(
                    Convert.ToInt32(row["RAWCATEGORYID"]),
                    row["CATEGORYNAME"]?.ToString() ?? string.Empty));
            }

            return result;
        }

        private void CreateRawMaterial(RawMaterialInput input)
        {
            var nextId = GetNextId("RAWMATERIAL", "RAWID");
            const string sql =
                "INSERT INTO RawMaterial (RawID, RawName, RawCategoryID, PurchaseUnit, BaseUnitQty, UnitGramQty, StorageType, ShelfLifeDays, ActiveFlag) " +
                "VALUES (:ID, :NAME, :CATEGORY, :UNIT, :BASEQTY, :UNITGRAM, :STORAGE, :SHELFLIFE, :ACTIVE)";

            ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("NAME", input.RawName),
                new OracleParameter("CATEGORY", input.RawCategoryId),
                new OracleParameter("UNIT", input.PurchaseUnit),
                new OracleParameter("BASEQTY", input.BaseUnitQty),
                new OracleParameter("UNITGRAM", input.UnitGramQty.HasValue
                    ? (object)input.UnitGramQty.Value
                    : DBNull.Value),
                new OracleParameter("STORAGE", string.IsNullOrWhiteSpace(input.StorageType)
                    ? (object)DBNull.Value
                    : input.StorageType),
                new OracleParameter("SHELFLIFE", input.ShelfLifeDays.HasValue
                    ? (object)input.ShelfLifeDays.Value
                    : DBNull.Value),
                new OracleParameter("ACTIVE", input.ActiveFlag ? "Y" : "N"));
        }

        private void ApproveSelectedMealPlan()
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("승인할 식단을 선택해 주세요.", "안내");
                return;
            }

            var row = GetCurrentMealPlanRow();
            var status = row?.Cells["STATUS"]?.Value?.ToString() ?? _currentMealPlanStatus;
            if (!string.Equals(status, MealPlanStatusPending, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("승인 요청된 식단만 승인할 수 있습니다.", "안내");
                return;
            }

            var sql = "UPDATE MealPlan SET Status = :STATUS WHERE MealPlanID = :ID";
            try
            {
                var planId = _selectedMealPlanId.Value;
                var rows = ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", MealPlanStatusApproved),
                    new OracleParameter("ID", planId));

                if (rows > 0)
                {
                    MessageBox.Show("식단이 승인되었습니다.", "완료");
                    ReloadAll();
                    SelectMealPlanById(planId);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"식단 승인 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void OpenPurchaseRequestDialog()
        {
            if (!EnsureDietitianAccess())
            {
                return;
            }

            if (_rawMaterials.Count == 0)
            {
                MessageBox.Show("등록된 원재료가 없습니다. 먼저 원재료를 등록해 주세요.", "안내");
                return;
            }

            using (var dialog = new PurchaseRequestDialog(_rawMaterials, _selectedRawMaterialId))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    var request = dialog.Result;
                    try
                    {
                        CreatePurchaseRequest(request);
                        MessageBox.Show("발주 요청이 등록되었습니다.", "완료");
                        ReloadAll();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"발주 요청 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
                    }
                }
            }
        }

        private void CreatePurchaseRequest(PurchaseRequestInput request)
        {
            var nextId = GetNextId("PURCHASEREQUEST", "PURCHASEREQUESTID");
            const string sql =
                "INSERT INTO PurchaseRequest (PurchaseRequestID, RawID, RawContractID, RequestedBy, RequestedDate, Quantity, " +
                "UnitPriceEstimate, ExpectedDeliveryDate, Status, Remark) " +
                "VALUES (:ID, :RAWID, :CONTRACTID, :REQUESTEDBY, :REQUESTEDDATE, :QTY, :PRICE, :EXPECTED, :STATUS, :REMARK)";

            ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("RAWID", request.RawId),
                new OracleParameter("CONTRACTID", request.ContractId.HasValue
                    ? (object)request.ContractId.Value
                    : DBNull.Value),
                new OracleParameter("REQUESTEDBY", _session?.UserId ?? "SYSTEM"),
                new OracleParameter("REQUESTEDDATE", request.RequestedDate),
                new OracleParameter("QTY", request.Quantity),
                new OracleParameter("PRICE", request.UnitPriceEstimate.HasValue
                    ? (object)request.UnitPriceEstimate.Value
                    : DBNull.Value),
                new OracleParameter("EXPECTED", request.ExpectedDate.HasValue
                    ? (object)request.ExpectedDate.Value
                    : DBNull.Value),
                new OracleParameter("STATUS", PurchaseStatusRequested),
                new OracleParameter("REMARK", string.IsNullOrEmpty(request.Remark)
                    ? (object)DBNull.Value
                    : request.Remark));
        }

        private void ApproveSelectedPurchaseRequest()
        {
            if (_selectedPurchaseRequestId == null)
            {
                MessageBox.Show("승인할 발주 요청을 선택해 주세요.", "안내");
                return;
            }

            const string sql =
                "UPDATE PurchaseRequest SET Status = :STATUS, ApprovedBy = :APPROVEDBY, ApprovedDate = SYSDATE " +
                "WHERE PurchaseRequestID = :ID";

            try
            {
                var rows = ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", PurchaseStatusApproved),
                    new OracleParameter("APPROVEDBY", _session?.UserId ?? "ADMIN"),
                    new OracleParameter("ID", _selectedPurchaseRequestId));

                if (rows > 0)
                {
                    MessageBox.Show("발주 요청 상태가 승인으로 변경되었습니다.", "완료");
                    ReloadAll();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"발주 승인 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private int GetNextId(string tableName, string columnName)
        {
            var sql = $"SELECT NVL(MAX({columnName}), 0) + 1 FROM {tableName}";
            return ToInt(ExecuteScalar(sql));
        }

        private static int ToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(value);
        }

        private bool EnsureDietitianAccess()
        {
            if (_session?.IsAdmin == true)
            {
                MessageBox.Show("관리자 계정에서는 해당 작업을 수행할 수 없습니다.", "권한 없음");
                return false;
            }

            return true;
        }

        private void BtnRawAdd_Click(object sender, EventArgs e)
        {
            AddRawMaterial();
        }

        private void BtnRawRefresh_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void BtnRawSearch_Click(object sender, EventArgs e)
        {
            ApplyRawMaterialView();
        }

        private void BtnRawClear_Click(object sender, EventArgs e)
        {
            if (txtRawSearch != null)
            {
                txtRawSearch.Clear();
            }

            ApplyRawMaterialView();
        }

        private void ChkRawGroup_CheckedChanged(object sender, EventArgs e)
        {
            ApplyRawMaterialView();
        }

        private void TxtRawSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ApplyRawMaterialView();
            }
        }

        private void BtnRecipeSearch_Click(object sender, EventArgs e)
        {
            ApplyRecipeFilter();
        }

        private void BtnRecipeClear_Click(object sender, EventArgs e)
        {
            if (txtRecipeSearch != null)
            {
                txtRecipeSearch.Clear();
            }

            ApplyRecipeFilter();
        }

        private void TxtRecipeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ApplyRecipeFilter();
            }
        }

        private void BtnRefreshRecipe_Click(object sender, EventArgs e)
        {
            LoadRecipesManagement();
        }

        private void BtnRegisterRecipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("요리 등록 기능은 추후 제공될 예정입니다.", "안내");
        }

        private void DgvRawMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRawMaterials?.Rows == null || e.RowIndex >= dgvRawMaterials.Rows.Count)
            {
                return;
            }

            var row = GetDataRowFromGrid(dgvRawMaterials.Rows[e.RowIndex]);
            if (row == null)
            {
                return;
            }

            if (IsGroupRow(row))
            {
                ToggleCategoryCollapse(row["GROUPNAME"]?.ToString());
                return;
            }

            DisplayManagedRawMaterial(row);
        }

        private static DataRow GetDataRowFromGrid(DataGridViewRow gridRow)
        {
            return (gridRow?.DataBoundItem as DataRowView)?.Row;
        }

        private int GetRawIdFromRecipeComponentRow(DataGridViewRow row)
        {
            if (row == null)
            {
                return 0;
            }

            var dataRow = GetDataRowFromGrid(row);
            if (dataRow != null)
            {
                if (dataRow.Table.Columns.Contains("RAWID"))
                {
                    return ToInt(dataRow["RAWID"]);
                }

                if (dataRow.Table.Columns.Contains("RawID"))
                {
                    return ToInt(dataRow["RawID"]);
                }
            }

            var column = GetColumn(row.DataGridView, "RawID");
            if (column != null)
            {
                return ToInt(row.Cells[column.Index].Value);
            }

            return 0;
        }

        private void ShowRawMaterialInManager(int rawId)
        {
            if (rawId <= 0)
            {
                return;
            }

            if (tabMain != null && tabManagement != null)
            {
                tabMain.SelectedTab = tabManagement;
            }

            if (tabControlManagement != null && tabRawMaterials != null)
            {
                tabControlManagement.SelectedTab = tabRawMaterials;
            }

            if (_rawMaterialTable == null || _rawMaterialTable.Rows.Count == 0)
            {
                LoadRawMaterials();
            }
            else
            {
                ApplyRawMaterialView();
            }

            if (!TrySelectRawMaterialInGrid(rawId))
            {
                MessageBox.Show("현재 필터 조건으로 해당 원재료를 찾을 수 없습니다. 검색 조건을 조정한 후 다시 시도해 주세요.", "원재료 찾기");
            }
        }

        private bool TrySelectRawMaterialInGrid(int rawId)
        {
            if (dgvRawMaterials == null || rawId <= 0)
            {
                return false;
            }

            foreach (DataGridViewRow gridRow in dgvRawMaterials.Rows)
            {
                var dataRow = GetDataRowFromGrid(gridRow);
                if (dataRow == null || IsGroupRow(dataRow))
                {
                    continue;
                }

                if (ToInt(dataRow["RAWID"]) != rawId)
                {
                    continue;
                }

                dgvRawMaterials.ClearSelection();
                gridRow.Selected = true;

                var currentCell = gridRow.Cells.Cast<DataGridViewCell>()
                    .FirstOrDefault(c => c.Visible) ?? gridRow.Cells.Cast<DataGridViewCell>().FirstOrDefault();
                if (currentCell != null)
                {
                    dgvRawMaterials.CurrentCell = currentCell;
                }

                try
                {
                    dgvRawMaterials.FirstDisplayedScrollingRowIndex = gridRow.Index;
                }
                catch (ArgumentOutOfRangeException)
                {
                    // ignore if can't scroll to row
                }

                DisplayManagedRawMaterial(dataRow);
                return true;
            }

            return false;
        }

        private void DgvRawMaterials_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRawMaterials?.Rows == null || e.RowIndex >= dgvRawMaterials.Rows.Count)
            {
                return;
            }

            var row = GetDataRowFromGrid(dgvRawMaterials.Rows[e.RowIndex]);
            if (!IsGroupRow(row))
            {
                return;
            }

            e.CellStyle.BackColor = Color.Gainsboro;
            e.CellStyle.ForeColor = Color.Black;
            e.CellStyle.SelectionBackColor = Color.DarkGray;
            e.CellStyle.SelectionForeColor = Color.Black;
        }

        private void AddRawMaterial()
        {
            try
            {
                var categories = GetRawCategories();
                if (categories.Count == 0)
                {
                    MessageBox.Show("등록된 원재료 분류가 없습니다. 분류를 먼저 등록해 주세요.", "안내");
                    return;
                }

                using (var dialog = new RawMaterialDialog(categories))
                {
                    if (dialog.ShowDialog(this) != DialogResult.OK || dialog.Result == null)
                    {
                        return;
                    }

                    CreateRawMaterial(dialog.Result);
                    MessageBox.Show("원재료가 등록되었습니다.", "완료");
                    ReloadAll();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"원재료 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void ToggleCategoryCollapse(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return;
            }

            if (!_collapsedCategories.Add(category))
            {
                _collapsedCategories.Remove(category);
            }

            ApplyRawMaterialView();
        }

        private void LstAvailableMenus_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || lstAvailableMenus == null)
            {
                return;
            }

            var index = lstAvailableMenus.IndexFromPoint(e.Location);
            if (index < 0 || index >= lstAvailableMenus.Items.Count)
            {
                return;
            }

            lstAvailableMenus.SelectedIndex = index;
            if (lstAvailableMenus.Items[index] is FinalMenuOption option)
            {
                lstAvailableMenus.DoDragDrop(option, DragDropEffects.Copy);
            }
        }

        private void MealBoard_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(FinalMenuOption)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MealBoard_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data?.GetData(typeof(FinalMenuOption)) is FinalMenuOption option))
            {
                return;
            }

            if (_selectedMealMenus.Any(item => item.FinalMenuId == option.FinalMenuId))
            {
                return;
            }

            _selectedMealMenus.Add(option);
            SaveMealRecipesForCurrentPlan();
        }

        private void MealBoard_DoubleClick(object sender, EventArgs e)
        {
            if (lvMealBoard?.SelectedItems == null || lvMealBoard.SelectedItems.Count == 0)
            {
                return;
            }

            if (lvMealBoard.SelectedItems[0].Tag is not FinalMenuOption option)
            {
                return;
            }

            _selectedMealMenus.Remove(option);
            SaveMealRecipesForCurrentPlan();
        }

        private void SelectedMealMenus_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (_suppressMealBoardUpdate)
            {
                return;
            }

            RefreshMealBoard();
            UpdateNutritionSummary();
        }

        private void RefreshMealBoard()
        {
            if (lvMealBoard == null)
            {
                return;
            }

            lvMealBoard.BeginUpdate();
            lvMealBoard.Items.Clear();
            lvMealBoard.Groups.Clear();

            var groups = new Dictionary<string, ListViewGroup>(StringComparer.OrdinalIgnoreCase);
            foreach (var menu in _selectedMealMenus)
            {
                var type = string.IsNullOrWhiteSpace(menu.MenuType) ? "기타" : menu.MenuType;
                if (!groups.TryGetValue(type, out var group))
                {
                    group = new ListViewGroup(type, type);
                    lvMealBoard.Groups.Add(group);
                    groups[type] = group;
                }

                var tagText = string.Join(", ", GetMenuTagNames(menu.FinalMenuId));
                var item = new ListViewItem(menu.DisplayName, group)
                {
                    Tag = menu
                };
                item.SubItems.Add(menu.MenuType ?? "-");
                item.SubItems.Add(tagText);
                lvMealBoard.Items.Add(item);
            }

            lvMealBoard.EndUpdate();
        }

        private IEnumerable<string> GetMenuTagNames(int finalMenuId)
        {
            if (_menuTagMap.TryGetValue(finalMenuId, out var tagIds))
            {
                foreach (var tagId in tagIds)
                {
                    if (_tagNameLookup.TryGetValue(tagId, out var name))
                    {
                        yield return name;
                    }
                }
            }
        }

        private void UpdateNutritionSummary()
        {
            _nutrientSummary.RaiseListChangedEvents = false;
            _nutrientSummary.Clear();

            var totals = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
            foreach (var menu in _selectedMealMenus)
            {
                if (!_menuNutrientAmounts.TryGetValue(menu.FinalMenuId, out var nutrientMap))
                {
                    continue;
                }

                foreach (var target in _nutrientTargets)
                {
                    if (nutrientMap.TryGetValue(target.Code, out var amount))
                    {
                        totals[target.Code] = totals.TryGetValue(target.Code, out var current)
                            ? current + amount
                            : amount;
                    }
                }
            }

            foreach (var target in _nutrientTargets)
            {
                var current = totals.TryGetValue(target.Code, out var sum) ? sum : 0m;
                _nutrientSummary.Add(new NutrientSummaryRow(target.DisplayName, target.Unit, target.TargetAmount, current));
            }

            _nutrientSummary.RaiseListChangedEvents = true;
            _nutrientSummary.ResetBindings();
        }

        private string GetCurrentMealPlanKey()
        {
            if (_selectedMealPlanId == null || dtpMealDate == null)
            {
                return string.Empty;
            }

            return $"{_selectedMealPlanId.Value}_{dtpMealDate.Value:yyyyMMdd}";
        }

        private void SaveMealRecipesForCurrentPlan()
        {
            var key = GetCurrentMealPlanKey();
            if (string.IsNullOrEmpty(key))
            {
                return;
            }

            if (_selectedMealMenus.Count == 0)
            {
                _mealPlanSelections.Remove(key);
                return;
            }

            _mealPlanSelections[key] = _selectedMealMenus.ToList();
        }

        private void LoadMealRecipesForCurrentPlan()
        {
            var key = GetCurrentMealPlanKey();
            _suppressMealBoardUpdate = true;
            _selectedMealMenus.Clear();
            List<FinalMenuOption> menus = null;
            if (!string.IsNullOrEmpty(key))
            {
                _mealPlanSelections.TryGetValue(key, out menus);
            }

            if ((menus == null || menus.Count == 0) && dtpMealDate != null)
            {
                menus = LoadMealMenusFromDatabase(dtpMealDate.Value.Date);
            }

            if (menus != null)
            {
                foreach (var menu in menus)
                {
                    _selectedMealMenus.Add(menu);
                }
            }
            _suppressMealBoardUpdate = false;
            RefreshMealBoard();
            UpdateNutritionSummary();
        }

        private sealed class WeekOption
        {
            public WeekOption(int index, DateTime startDate)
            {
                Index = index;
                StartDate = startDate.Date;
            }

            public int Index { get; }
            public DateTime StartDate { get; }
            public DateTime EndDate => StartDate.AddDays(4);

            public override string ToString()
            {
                return $"{Index}주차 ({StartDate:MM/dd}~{EndDate:MM/dd})";
            }
        }
    }
}
