using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Oracle.DataAccess.Client;
using nutritionist.Tabs;
using nutritionist.Tabs.Management;
using nutritionist.Forms;

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
        private readonly Dictionary<int, HashSet<int>> _menuAllergyMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, List<MenuAllergyDetail>> _menuAllergyDetails = new Dictionary<int, List<MenuAllergyDetail>>();
        private readonly Dictionary<int, string> _allergyNameLookup = new Dictionary<int, string>();
        private readonly Dictionary<int, int> _allergyConsumerCounts = new Dictionary<int, int>();
        private readonly Dictionary<string, List<AlternativeAssignment>> _pendingAltAssignments = new Dictionary<string, List<AlternativeAssignment>>();
        private int? _selectedEvaluationMenuId;
        private int? _selectedEvaluationRawId;
        private readonly List<FinalMenuOption> _finalMenuOptions = new List<FinalMenuOption>();
        private readonly BindingList<FinalMenuOption> _filteredMenuOptions = new BindingList<FinalMenuOption>();
        private readonly BindingList<FinalMenuOption> _selectedMealMenus = new BindingList<FinalMenuOption>();
        private readonly Dictionary<string, List<FinalMenuOption>> _mealPlanSelections = new Dictionary<string, List<FinalMenuOption>>();
        private readonly List<MealPlanInfo> _mealPlans = new List<MealPlanInfo>();
        private readonly BindingList<MealPlanInfo> _weekMealPlanOptions = new BindingList<MealPlanInfo>();
        private readonly Dictionary<int, FinalMenuOption> _menuOptionLookup = new Dictionary<int, FinalMenuOption>();
        private readonly BindingList<NutrientSummaryRow> _nutrientSummary = new BindingList<NutrientSummaryRow>();
        private readonly Dictionary<int, HashSet<int>> _menuTagMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, string> _tagNameLookup = new Dictionary<int, string>();
        private readonly List<MenuTagOption> _availableMenuTags = new List<MenuTagOption>();
        private readonly List<MenuSortOption> _menuSortOptions = new List<MenuSortOption>();
        private readonly List<NutrientTarget> _nutrientTargets = new List<NutrientTarget>
        {
            new NutrientTarget("칼로리", "kcal", CalorieNutrientCode, 700m),
            new NutrientTarget("단백질", "g", "PROT", 25m),
            new NutrientTarget("지방", "g", "FAT", 20m),
            new NutrientTarget("탄수화물", "g", "CARB", 90m),
            new NutrientTarget("칼슘", "mg", "CA", 200m)
        };
        private MealPlanInfo _selectedMealPlanInfo;
        private bool _suppressPlanListSelection;
        private DateTime? _pendingWeekDate;
        private bool _suppressMenuFilter;
        private bool _suppressMealBoardUpdate;
        private bool _suppressWeekChange;
        private int? _selectedMealPlanId;
        private readonly List<WeekOption> _mealWeekOptions = new List<WeekOption>();
        private WeekOption _selectedWeekOption;
        private DateTime? _currentPlanStart;
        private DateTime? _currentPlanEnd;
        private ContextMenuStrip _allergyAlertMenu;
        private ToolStripMenuItem _menuAssignAlternative;
        private bool _initialAllergyModalShown;
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
        private int? _selectedPurchaseRequestId;
        private readonly DateTime[] _currentWeekDates = new DateTime[5];
        private int _selectedWeekdayIndex = -1;
        private string _currentMealPlanStatus;
        private bool _isCurrentWeekComplete;
        private bool _isWeekWithinPlanPeriod;
        private RawMaterialsForm _rawMaterialsForm;
        private RecipesForm _recipesForm;
        private MealPlansForm _mealPlansForm;

        private NutritionDashboardControl Dashboard => dashboardTabControl;
        private TableLayoutPanel layoutDashboard => Dashboard?.layoutDashboard;
        private GroupBox grpTodayMeals => Dashboard?.grpTodayMeals;
        private DataGridView dgvTodayMeals => Dashboard?.dgvTodayMeals;
        private GroupBox grpTodayRaw => Dashboard?.grpTodayRaw;
        private DataGridView dgvTodayRawNeeds => Dashboard?.dgvTodayRawNeeds;
        private GroupBox grpShortage => Dashboard?.grpShortage;
        private DataGridView dgvShortageRaw => Dashboard?.dgvShortageRaw;
        private GroupBox grpMealLogs => Dashboard?.grpMealLogs;
        private GroupBox grpAction => Dashboard?.grpAction;
        private Button btnCancelMeal => Dashboard?.btnCancelMeal;
        private Button btnServeMeal => Dashboard?.btnServeMeal;
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
        private Label lblMealPlanStatus => MealPlansTab?.lblMealPlanStatus;
        private ListBox lstWeekMealPlans => MealPlansTab?.lstWeekMealPlans;
        private Button btnDeleteMealPlan => MealPlansTab?.btnDeleteMealPlan;
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
        private ListView lvAllergyAlerts => MealPlansTab?.lvAllergyAlerts;
        private DataGridView dgvMealNutrition => MealPlansTab?.dgvMealNutrition;
        private DataGridViewTextBoxColumn colNutrientStatus => MealPlansTab?.colNutrientStatus;
        private GroupBox grpMealPlanDetail => MealPlansTab?.grpMealPlanDetail;
        private MealEvaluationsTabPage MealEvaluationsTab => mealEvaluationsTabPage;
        private DataGridView dgvEvaluationMenus => MealEvaluationsTab?.dgvEvaluationMenus;
        private DataGridView dgvEvaluationIngredients => MealEvaluationsTab?.dgvEvaluationIngredients;
        private DataGridView dgvEvaluationAllergies => MealEvaluationsTab?.dgvEvaluationAllergies;

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
            ConfigureGrid(dgvMenus);
            ConfigureGrid(dgvIngredients);
            ConfigureGrid(dgvRawNutrients);
            ConfigureGrid(dgvRawComponents);
            ConfigureGrid(dgvEvaluationMenus);
            ConfigureGrid(dgvEvaluationIngredients);
            ConfigureGrid(dgvEvaluationAllergies);
            if (tvRawMaterials != null)
            {
                tvRawMaterials.Visible = false;
            }

            if (splitContainerIngredients != null)
            {
                splitContainerIngredients.Panel2Collapsed = true;
            }

            if (splitContainerNutrients != null)
            {
                splitContainerNutrients.Panel2Collapsed = true;
            }

            if (txtStudentId != null)
            {
                txtStudentId.ReadOnly = true;
            }
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
            if (lvMealBoard != null)
            {
                lvMealBoard.AllowDrop = true;
                lvMealBoard.DragEnter += MealBoard_DragEnter;
                lvMealBoard.DragDrop += MealBoard_DragDrop;
                lvMealBoard.DoubleClick += MealBoard_DoubleClick;
            }

            if (lvAllergyAlerts != null)
            {
                InitializeAllergyAlertMenu();
            }

            if (dgvEvaluationMenus != null)
            {
                dgvEvaluationMenus.SelectionChanged += DgvEvaluationMenus_SelectionChanged;
            }

            if (dgvEvaluationIngredients != null)
            {
                dgvEvaluationIngredients.SelectionChanged += DgvEvaluationIngredients_SelectionChanged;
            }

            if (dgvMealNutrition != null)
            {
                dgvMealNutrition.AutoGenerateColumns = false;
                dgvMealNutrition.DataSource = _nutrientSummary;
                dgvMealNutrition.CellFormatting += DgvMealNutrition_CellFormatting;
            }

            InitializeMealPlannerControls();
            InitializePlanSelectionControls();
            InitializeManagementForms();
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

        private void InitializePlanSelectionControls()
        {
            if (lstWeekMealPlans != null)
            {
                _suppressPlanListSelection = true;
                lstWeekMealPlans.DisplayMember = nameof(MealPlanInfo.DisplayText);
                lstWeekMealPlans.DataSource = _weekMealPlanOptions;
                _suppressPlanListSelection = false;
                lstWeekMealPlans.SelectedIndexChanged += LstWeekMealPlans_SelectedIndexChanged;
            }

            if (btnDeleteMealPlan != null)
            {
                btnDeleteMealPlan.Click += BtnDeleteMealPlan_Click;
            }
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
            RefreshWeekPlanList();
        }

        private void DgvWeeklyMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            SelectWeekday(e.ColumnIndex);
        }

        private void SetMealMonthWithoutEvents(DateTime monthDate, DateTime? preferredDate = null)
        {
            if (dtpMealMonth == null)
            {
                return;
            }

            if (preferredDate.HasValue)
            {
                _pendingWeekDate = preferredDate;
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
            var preferredDate = _pendingWeekDate;
            _pendingWeekDate = null;
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
                WeekOption restored = null;
                if (preferredDate.HasValue)
                {
                    restored = _mealWeekOptions.FirstOrDefault(option =>
                        preferredDate.Value.Date >= option.StartDate && preferredDate.Value.Date <= option.EndDate);
                }

                if (restored == null && previousStart.HasValue)
                {
                    restored = _mealWeekOptions.FirstOrDefault(option => option.StartDate == previousStart.Value);
                }

                _selectedWeekOption = restored ?? _mealWeekOptions.First();
                cmbMealWeek.SelectedItem = _selectedWeekOption;
                _selectedWeekdayIndex = -1;
                _suppressWeekChange = false;
                RefreshWeekPlanList();
                return;
            }

            _selectedWeekOption = null;
            cmbMealWeek.SelectedItem = null;
            _selectedWeekdayIndex = -1;
            _suppressWeekChange = false;
            ClearWeeklyMealsGrid();
            RefreshWeekPlanList(false);
        }

        private static DateTime GetFirstMondayOfMonth(int year, int month)
        {
            var firstDay = new DateTime(year, month, 1);
            var offset = ((int)DayOfWeek.Monday - (int)firstDay.DayOfWeek + 7) % 7;
            return firstDay.AddDays(offset);
        }

        private bool TryGetSelectedWeekRange(out DateTime weekStart, out DateTime weekEnd, out string planNameSuggestion)
        {
            planNameSuggestion = null;
            var weekOption = _selectedWeekOption ?? cmbMealWeek?.SelectedItem as WeekOption;
            if (weekOption == null && cmbMealWeek != null && cmbMealWeek.Items.Count > 0)
            {
                weekOption = cmbMealWeek.Items[0] as WeekOption;
            }

            if (weekOption != null)
            {
                weekStart = weekOption.StartDate;
                weekEnd = weekOption.EndDate;
                planNameSuggestion = $"{weekStart:yyyy년 M월} {weekOption.Index}주차";
                return true;
            }

            var baseDate = dtpMealMonth?.Value ?? DateTime.Today;
            weekStart = GetFirstMondayOfMonth(baseDate.Year, baseDate.Month);
            weekEnd = weekStart.AddDays(4);
            planNameSuggestion = $"{weekStart:yyyy년 M월} 1주차";
            return true;
        }

        private void RefreshWeeklyMealBoard()
        {
            if (dgvWeeklyMeals == null)
            {
                return;
            }

            EnsureWeeklyGridRow();

            if (_selectedWeekOption == null || _selectedMealPlanInfo == null)
            {
                ClearWeeklyMealsGrid();
                return;
            }

            var start = _selectedWeekOption.StartDate;
            var end = start.AddDays(4);
            if (!_selectedMealPlanInfo.Covers(start, end))
            {
                ClearWeeklyMealsGrid();
                return;
            }

            _isWeekWithinPlanPeriod = true;
            UpdateWeeklyMealSelectionAvailability();

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
            _selectedWeekdayIndex = -1;
            _isCurrentWeekComplete = false;
            UpdateApprovalRequestAvailability();
            _isWeekWithinPlanPeriod = false;
            UpdateWeeklyMealSelectionAvailability();
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

        private void RefreshWeekPlanList(bool retainSelection = true)
        {
            if (lstWeekMealPlans == null)
            {
                return;
            }

            var previousPlanId = retainSelection ? _selectedMealPlanId : null;

            _weekMealPlanOptions.RaiseListChangedEvents = false;
            _weekMealPlanOptions.Clear();

            if (_selectedWeekOption != null)
            {
                var weekStart = _selectedWeekOption.StartDate;
                var weekEnd = _selectedWeekOption.EndDate;
                var plans = _mealPlans
                    .Where(plan => plan.Covers(weekStart, weekEnd))
                    .OrderBy(plan => plan.PeriodStart)
                    .ThenBy(plan => plan.PlanName, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                foreach (var plan in plans)
                {
                    _weekMealPlanOptions.Add(plan);
                }
            }

            _weekMealPlanOptions.RaiseListChangedEvents = true;
            _weekMealPlanOptions.ResetBindings();

            if (_weekMealPlanOptions.Count == 0)
            {
                _suppressPlanListSelection = true;
                lstWeekMealPlans.ClearSelected();
                _suppressPlanListSelection = false;
                ApplySelectedMealPlan(null);
                return;
            }

            MealPlanInfo target = null;
            if (previousPlanId.HasValue)
            {
                target = _weekMealPlanOptions.FirstOrDefault(plan => plan.MealPlanId == previousPlanId.Value);
            }

            target ??= _weekMealPlanOptions[0];

            _suppressPlanListSelection = true;
            lstWeekMealPlans.SelectedItem = target;
            _suppressPlanListSelection = false;
            ApplySelectedMealPlan(target);
        }

        private void LstWeekMealPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressPlanListSelection)
            {
                return;
            }

            if (lstWeekMealPlans?.SelectedItem is MealPlanInfo plan)
            {
                ApplySelectedMealPlan(plan);
            }
            else
            {
                ApplySelectedMealPlan(null);
            }
        }

        private void BtnDeleteMealPlan_Click(object sender, EventArgs e)
        {
            if (!EnsureDietitianAccess())
            {
                return;
            }

            if (_selectedMealPlanInfo == null || !_selectedMealPlanId.HasValue)
            {
                MessageBox.Show("삭제할 식단 계획을 선택해 주세요.", "안내");
                return;
            }

            if (!string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("작성 중(DRAFT) 식단만 삭제할 수 있습니다.", "안내");
                return;
            }

            var confirm = MessageBox.Show(
                "선택한 식단 계획과 해당 주차의 식단 등록 내역을 모두 삭제하시겠습니까?",
                "식단 계획 삭제",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            DeleteMealPlan(_selectedMealPlanId.Value);
        }

        private void DeleteMealPlan(int mealPlanId)
        {
            try
            {
                using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM AltReview WHERE AltAssignID IN (SELECT AltAssignID FROM AltAssign WHERE MealID IN (SELECT MealID FROM Meal WHERE MealPlanID = :PLANID))",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM AltAssign WHERE MealID IN (SELECT MealID FROM Meal WHERE MealPlanID = :PLANID)",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM MealReviewItem WHERE MealID IN (SELECT MealID FROM Meal WHERE MealPlanID = :PLANID)",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM MealReview WHERE MealID IN (SELECT MealID FROM Meal WHERE MealPlanID = :PLANID)",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM MealComp WHERE MealID IN (SELECT MealID FROM Meal WHERE MealPlanID = :PLANID)",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM Meal WHERE MealPlanID = :PLANID",
                            mealPlanId);

                        ExecuteNonQuery(conn, transaction,
                            "DELETE FROM MealPlan WHERE MealPlanID = :PLANID",
                            mealPlanId);

                        transaction.Commit();
                    }
                }

                var keysToRemove = _mealPlanSelections.Keys
                    .Where(key => key.StartsWith($"{mealPlanId}_", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                foreach (var key in keysToRemove)
                {
                    _mealPlanSelections.Remove(key);
                }

                _selectedMealPlanInfo = null;
                _selectedMealPlanId = null;
                LoadMealPlans();
                LoadSummary();
                MessageBox.Show("식단 계획이 삭제되었습니다.", "완료");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"식단 계획 삭제 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private static void ExecuteNonQuery(OracleConnection conn, OracleTransaction transaction, string sql, int planId)
        {
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Transaction = transaction;
                cmd.BindByName = true;
                cmd.Parameters.Add(new OracleParameter("PLANID", planId));
                cmd.ExecuteNonQuery();
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

        private void InitializeAllergyAlertMenu()
        {
            if (lvAllergyAlerts == null)
            {
                return;
            }

            _allergyAlertMenu = new ContextMenuStrip();
            _menuAssignAlternative = new ToolStripMenuItem("대체 메뉴 할당");
            _menuAssignAlternative.Click += MenuAssignAlternative_Click;
            _allergyAlertMenu.Items.Add(_menuAssignAlternative);
            lvAllergyAlerts.ContextMenuStrip = _allergyAlertMenu;
            lvAllergyAlerts.MouseDown += LvAllergyAlerts_MouseDown;
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

        private void InitializeManagementForms()
        {
            if (tabRawMaterials != null && rawMaterialsTabPage != null)
            {
                DetachControl(rawMaterialsTabPage);
                _rawMaterialsForm = new RawMaterialsForm(rawMaterialsTabPage);
                HostFormInTab(tabRawMaterials, _rawMaterialsForm);
            }

            if (tabMealPlans != null && mealPlansTabPage != null)
            {
                DetachControl(mealPlansTabPage);
                _mealPlansForm = new MealPlansForm(mealPlansTabPage, _session);
                HostFormInTab(tabMealPlans, _mealPlansForm);
            }

            if (tabRecipes != null && recipesTabPage != null)
            {
                DetachControl(recipesTabPage);
                _recipesForm = new RecipesForm(recipesTabPage);
                _recipesForm.RawMaterialRequested += ShowRawMaterialInManager;
                HostFormInTab(tabRecipes, _recipesForm);
            }

            _mealPlansForm?.SetDependencies(_session, _recipesForm);
        }

        private static void DetachControl(Control control)
        {
            var parent = control?.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(control);
            }
        }

        private static void HostFormInTab(TabPage tab, Form form)
        {
            if (tab == null || form == null)
            {
                return;
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            if (!tab.Controls.Contains(form))
            {
                tab.Controls.Clear();
                tab.Controls.Add(form);
            }

            if (!form.Visible)
            {
                form.Show();
            }
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
            ShowInitialAllergyTraceModal();
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
                _pendingAltAssignments.Clear();
                LoadSummary();
                _rawMaterialsForm?.ReloadRawMaterials();
                LoadRecipesManagement();
                _mealPlansForm?.LoadFinalMenus();
                _mealPlansForm?.LoadMenuTags();
                SyncMenuCachesFromMealPlans();
                LoadMenuAllergySummary();
                LoadAllergyConsumerCounts();
                LoadMealPlans();
                LoadEvaluationExplorer();
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
            _rawMaterialsForm?.ReloadRawMaterials();
            if (_rawMaterialsForm?.RawMaterialTable != null)
            {
                dgvStudents.DataSource = _rawMaterialsForm.RawMaterialTable;
                ApplyRawColumnHeaders(dgvStudents);
            }
        }

        private void LoadRecipesManagement()
        {
            _recipesForm?.ReloadRecipes();
        }

        private void LoadMenuAllergySummary()
        {
            _menuAllergyMap.Clear();
            _menuAllergyDetails.Clear();
            _allergyNameLookup.Clear();

            const string sql =
                "WITH base_component AS ( " +
                "    SELECT FinalMenuID, ComponentType, ComponentRawID, ComponentIngredientID " +
                "    FROM MenuComp " +
                "), raw_component AS ( " +
                "    SELECT FinalMenuID, ComponentRawID AS RawID " +
                "    FROM base_component " +
                "    WHERE ComponentType = 'R' AND ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID " +
                "    FROM base_component bc " +
                "    JOIN IngredientComp ic ON bc.ComponentIngredientID = ic.IngredientID " +
                "    WHERE bc.ComponentType = 'I' AND bc.ComponentIngredientID IS NOT NULL " +
                ") " +
                "SELECT DISTINCT rc.FinalMenuID, rc.RawID, rm.RawName, ra.AllergyID, a.AllergyName " +
                "FROM raw_component rc " +
                "JOIN RawAllergy ra ON rc.RawID = ra.RawID " +
                "LEFT JOIN Allergy a ON a.AllergyID = ra.AllergyID " +
                "LEFT JOIN RawMaterial rm ON rc.RawID = rm.RawID";

            var table = ExecuteDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                var menuId = ToInt(row["FINALMENUID"]);
                var rawId = ToInt(row["RAWID"]);
                var allergyId = ToInt(row["ALLERGYID"]);
                if (menuId <= 0 || rawId <= 0 || allergyId <= 0)
                {
                    continue;
                }

                var set = GetOrCreateMenuAllergySet(menuId);
                set.Add(allergyId);

                if (!_allergyNameLookup.ContainsKey(allergyId))
                {
                    _allergyNameLookup[allergyId] = row["ALLERGYNAME"]?.ToString() ?? string.Empty;
                }

                var details = GetOrCreateMenuAllergyDetails(menuId);
                var rawName = row["RAWNAME"]?.ToString() ?? string.Empty;
                var allergyName = row["ALLERGYNAME"]?.ToString() ?? string.Empty;
                details.Add(new MenuAllergyDetail(rawId, rawName, allergyId, allergyName));
            }
        }

        private void LoadAllergyConsumerCounts()
        {
            _allergyConsumerCounts.Clear();

            const string sql =
                "SELECT ca.AllergyID, a.AllergyName, COUNT(DISTINCT ca.ConsumerID) AS ConsumerCount " +
                "FROM ConsumerAllergy ca " +
                "JOIN Consumer c ON ca.ConsumerID = c.ConsumerID " +
                "JOIN Allergy a ON ca.AllergyID = a.AllergyID " +
                "WHERE NVL(c.Status, 'ACTIVE') = 'ACTIVE' " +
                "GROUP BY ca.AllergyID, a.AllergyName";

            var table = ExecuteDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                var allergyId = ToInt(row["ALLERGYID"]);
                if (allergyId <= 0)
                {
                    continue;
                }

                _allergyConsumerCounts[allergyId] = ToInt(row["CONSUMERCOUNT"]);
                _allergyNameLookup[allergyId] = row["ALLERGYNAME"]?.ToString() ?? string.Empty;
            }
        }

        private void LoadFinalMenus()
        {
            // 메뉴 로드는 MealPlansForm에서 처리
            _mealPlansForm?.LoadFinalMenus();
            _mealPlansForm?.LoadMenuTags();
            SyncMenuCachesFromMealPlans();
        }

        private void LoadEvaluationExplorer()
        {
            var menuGrid = dgvEvaluationMenus;
            if (menuGrid == null)
            {
                return;
            }

            const string sql =
                "SELECT FinalMenuID AS MENU_ID, MenuName AS MENU_NAME, MenuType AS MENU_TYPE " +
                "FROM FinalMenu ORDER BY MenuName";
            menuGrid.DataSource = ExecuteDataTable(sql);

            _selectedEvaluationMenuId = null;
            _selectedEvaluationRawId = null;

            if (dgvEvaluationIngredients != null)
            {
                dgvEvaluationIngredients.DataSource = null;
            }

            if (dgvEvaluationAllergies != null)
            {
                dgvEvaluationAllergies.DataSource = null;
            }
        }

        private void LoadEvaluationIngredientsForMenu(int finalMenuId)
        {
            _selectedEvaluationMenuId = finalMenuId;
            _selectedEvaluationRawId = null;

            var grid = dgvEvaluationIngredients;
            if (grid == null)
            {
                return;
            }

            const string sql =
                "WITH base_component AS ( " +
                "    SELECT FinalMenuID, ComponentType, ComponentRawID, ComponentIngredientID " +
                "    FROM MenuComp " +
                "), raw_component AS ( " +
                "    SELECT FinalMenuID, ComponentRawID AS RawID " +
                "    FROM base_component " +
                "    WHERE ComponentType = 'R' AND ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID " +
                "    FROM base_component bc " +
                "    JOIN IngredientComp ic ON bc.ComponentIngredientID = ic.IngredientID " +
                "    WHERE bc.ComponentType = 'I' AND bc.ComponentIngredientID IS NOT NULL " +
                ") " +
                "SELECT DISTINCT rc.RawID AS RAW_ID, rm.RawName AS RAW_NAME, " +
                "       rm.PurchaseUnit AS PURCHASE_UNIT, rm.BaseUnitQty AS BASE_UNIT_QTY " +
                "FROM raw_component rc " +
                "JOIN RawMaterial rm ON rc.RawID = rm.RawID " +
                "WHERE rc.FinalMenuID = :MENU_ID " +
                "ORDER BY rm.RawName";

            grid.DataSource = ExecuteDataTable(sql, new OracleParameter("MENU_ID", finalMenuId));

            if (dgvEvaluationAllergies != null)
            {
                dgvEvaluationAllergies.DataSource = null;
            }
        }

        private void LoadEvaluationAllergiesForRaw(int rawId)
        {
            _selectedEvaluationRawId = rawId;

            var grid = dgvEvaluationAllergies;
            if (grid == null)
            {
                return;
            }

            const string sql =
                "SELECT ra.AllergyID AS ALLERGY_ID, " +
                "       NVL(a.AllergyName, '알레르기 ' || ra.AllergyID) AS ALLERGY_NAME, " +
                "       ra.EvidenceNote AS EVIDENCE_NOTE " +
                "FROM RawAllergy ra " +
                "LEFT JOIN Allergy a ON ra.AllergyID = a.AllergyID " +
                "WHERE ra.RawID = :RAW_ID " +
                "ORDER BY NVL(a.AllergyName, '알레르기 ' || ra.AllergyID)";

            grid.DataSource = ExecuteDataTable(sql, new OracleParameter("RAW_ID", rawId));
        }

        private void DgvEvaluationMenus_SelectionChanged(object sender, EventArgs e)
        {
            var menuId = GetSelectedGridId(dgvEvaluationMenus, "MENU_ID");
            if (menuId <= 0 || menuId == _selectedEvaluationMenuId)
            {
                return;
            }

            LoadEvaluationIngredientsForMenu(menuId);
        }

        private void DgvEvaluationIngredients_SelectionChanged(object sender, EventArgs e)
        {
            var rawId = GetSelectedGridId(dgvEvaluationIngredients, "RAW_ID");
            if (rawId <= 0 || rawId == _selectedEvaluationRawId)
            {
                return;
            }

            LoadEvaluationAllergiesForRaw(rawId);
        }

        private static int GetSelectedGridId(DataGridView grid, string columnName)
        {
            if (grid?.CurrentRow == null)
            {
                return 0;
            }

            object value = null;
            if (grid.CurrentRow.DataBoundItem is DataRowView view)
            {
                if (view.Row.Table.Columns.Contains(columnName))
                {
                    value = view.Row[columnName];
                }
            }

            if (value == null)
            {
                var column = grid.Columns[columnName];
                if (column != null)
                {
                    value = grid.CurrentRow.Cells[column.Index].Value;
                }
            }

            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return ToInt(value);
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
            // 태그 로드는 MealPlansForm에서 처리
            _mealPlansForm?.LoadMenuTags();
            SyncMenuCachesFromMealPlans();
            RefreshMealBoard();
        }

        private void SyncMenuCachesFromMealPlans()
        {
            var options = _mealPlansForm?.FinalMenuOptions;
            if (options != null)
            {
                _finalMenuOptions.Clear();
                _menuOptionLookup.Clear();
                foreach (var option in options)
                {
                    _finalMenuOptions.Add(option);
                    _menuOptionLookup[option.FinalMenuId] = option;
                }

                PopulateMenuTypeFilter();
                PopulateMenuSortOptions();
                ApplyMenuFilter(true);
            }

            var tagMap = _mealPlansForm?.MenuTagMap;
            if (tagMap != null)
            {
                _menuTagMap.Clear();
                foreach (var kvp in tagMap)
                {
                    _menuTagMap[kvp.Key] = new HashSet<int>(kvp.Value);
                }
            }

            var tagNames = _mealPlansForm?.TagNameLookup;
            if (tagNames != null)
            {
                _tagNameLookup.Clear();
                foreach (var kvp in tagNames)
                {
                    _tagNameLookup[kvp.Key] = kvp.Value;
                }
            }
        }

        private void LoadMealPlans()
        {
            const string sql =
                "SELECT mp.MealPlanID, mp.PlanName, mp.PeriodStart, mp.PeriodEnd, mp.Status, " +
                "       NVL(u.UserName, mp.CreatedBy) AS CreatedByName " +
                "FROM MealPlan mp LEFT JOIN AppUser u ON mp.CreatedBy = u.UserID " +
                "ORDER BY mp.PeriodStart DESC, mp.MealPlanID DESC";

            var previousPlanId = _selectedMealPlanId;
            _mealPlans.Clear();

            var table = ExecuteDataTable(sql);
            foreach (DataRow row in table.Rows)
            {
                var planId = ToInt(row["MEALPLANID"]);
                if (planId <= 0)
                {
                    continue;
                }

                var planName = row["PLANNAME"]?.ToString() ?? string.Empty;
                var periodStart = ToNullableDate(row["PERIODSTART"]);
                var periodEnd = ToNullableDate(row["PERIODEND"]);
                if (!periodStart.HasValue || !periodEnd.HasValue)
                {
                    continue;
                }

                var status = row["STATUS"]?.ToString();
                _mealPlans.Add(new MealPlanInfo(planId, planName, periodStart.Value, periodEnd.Value, status));
            }

            if (!previousPlanId.HasValue && _selectedMealPlanInfo != null)
            {
                previousPlanId = _selectedMealPlanInfo.MealPlanId;
            }

            _selectedMealPlanInfo = null;
            _selectedMealPlanId = previousPlanId;
            RefreshWeekPlanList();
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
            _mealPlansForm?.ApplyMenuFilter(resetSelection);
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
            return _recipesForm?.GetMenuNutrientAmount(menuId, nutrientCode) ?? 0m;
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

            if (dgvMealNutrition.Rows[e.RowIndex].DataBoundItem is not NutrientSummaryRow row)
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

        private void SelectMealPlanById(int mealPlanId)
        {
            var plan = _mealPlans.FirstOrDefault(item => item.MealPlanId == mealPlanId);
            if (plan == null)
            {
                return;
            }

            _selectedMealPlanId = plan.MealPlanId;
            _pendingWeekDate = plan.PeriodStart;
            var monthStart = new DateTime(plan.PeriodStart.Year, plan.PeriodStart.Month, 1);
            SetMealMonthWithoutEvents(monthStart, plan.PeriodStart);
        }

        private void ApplySelectedMealPlan(MealPlanInfo plan)
        {
            var previousPlanId = _selectedMealPlanId;
            if (previousPlanId.HasValue && plan?.MealPlanId != previousPlanId.Value)
            {
                SaveMealRecipesForCurrentPlan();
            }

            _selectedMealPlanInfo = plan;
            _selectedMealPlanId = plan?.MealPlanId;
            _currentPlanStart = plan?.PeriodStart;
            _currentPlanEnd = plan?.PeriodEnd;
            _currentMealPlanStatus = plan?.Status;

            DisplaySelectedMealPlan();

            if (plan == null)
            {
                ClearWeeklyMealsGrid();
                _suppressMealBoardUpdate = true;
                _selectedMealMenus.Clear();
                _suppressMealBoardUpdate = false;
                RefreshMealBoard();
                UpdateNutritionSummary();
                UpdateAllergyAlertSummary();
                UpdateMealPlanInteractionState();
                return;
            }

            RefreshWeeklyMealBoard();
            UpdateAllergyAlertSummary();
            UpdateMealPlanInteractionState();
        }

        private void DisplaySelectedMealPlan()
        {
            UpdateMealPlanStatusLabel();

            if (_selectedWeekdayIndex >= 0 &&
                _selectedWeekdayIndex < _currentWeekDates.Length &&
                _currentWeekDates[_selectedWeekdayIndex] != DateTime.MinValue)
            {
                return;
            }

            if (dgvWeeklyMeals == null || dgvWeeklyMeals.Rows.Count == 0)
            {
                return;
            }

            for (var column = 0; column < _currentWeekDates.Length; column++)
            {
                if (_currentWeekDates[column] == DateTime.MinValue)
                {
                    continue;
                }

                var cellValue = dgvWeeklyMeals.Rows[0].Cells[column].Value;
                if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    continue;
                }

                SelectWeekday(column);
                return;
            }

            _suppressMealBoardUpdate = true;
            _selectedMealMenus.Clear();
            _suppressMealBoardUpdate = false;
            RefreshMealBoard();
            UpdateNutritionSummary();
            UpdateAllergyAlertSummary();
            ShowAllergyAlertModalForSelectedMeals();
        }

        private void UpdateMealPlanInteractionState()
        {
            var hasPlan = _selectedMealPlanId.HasValue;
            UpdateWeeklyMealSelectionAvailability();

            var isDietitian = _session?.IsAdmin != true;
            var canEdit = hasPlan && isDietitian &&
                          string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase);

            if (grpMealPlanDetail != null)
            {
                grpMealPlanDetail.Enabled = canEdit;
            }

            if (btnDeleteMealPlan != null)
            {
                var canDeletePlan = hasPlan &&
                                    string.Equals(_currentMealPlanStatus, MealPlanStatusDraft, StringComparison.OrdinalIgnoreCase);
                btnDeleteMealPlan.Enabled = canDeletePlan;
            }

            UpdateApprovalRequestAvailability();
            UpdateMealPlanStatusLabel();
        }

        private void UpdateMealPlanStatusLabel()
        {
            if (lblMealPlanStatus == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(_currentMealPlanStatus))
            {
                lblMealPlanStatus.Text = "계획 상태: -";
                lblMealPlanStatus.ForeColor = Color.FromArgb(96, 96, 96);
                return;
            }

            var displayText = GetMealPlanStatusDisplayText(_currentMealPlanStatus);
            lblMealPlanStatus.Text = $"계획 상태: {displayText}";
            lblMealPlanStatus.ForeColor = GetMealPlanStatusColor(_currentMealPlanStatus);
        }

        private static string GetMealPlanStatusDisplayText(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                return "-";
            }

            var trimmed = status.Trim();
            if (trimmed.IndexOf("반려", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return "반려";
            }

            switch (trimmed.ToUpperInvariant())
            {
                case MealPlanStatusDraft:
                    return "작성 중";
                case MealPlanStatusPending:
                    return "승인 대기";
                case MealPlanStatusApproved:
                    return "승인 완료";
                case "REJECTED":
                case "REJECT":
                case "RETURNED":
                    return "반려";
                default:
                    return trimmed;
            }
        }

        private static Color GetMealPlanStatusColor(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                return Color.FromArgb(96, 96, 96);
            }

            var trimmed = status.Trim();
            if (trimmed.IndexOf("반려", StringComparison.OrdinalIgnoreCase) >= 0 ||
                trimmed.IndexOf("REJECT", StringComparison.OrdinalIgnoreCase) >= 0 ||
                trimmed.IndexOf("RETURN", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return Color.Firebrick;
            }

            if (string.Equals(trimmed, MealPlanStatusApproved, StringComparison.OrdinalIgnoreCase))
            {
                return Color.SeaGreen;
            }

            if (string.Equals(trimmed, MealPlanStatusPending, StringComparison.OrdinalIgnoreCase))
            {
                return Color.DarkOrange;
            }

            return Color.FromArgb(70, 88, 109);
        }

        private void UpdateWeeklyMealSelectionAvailability()
        {
            if (dgvWeeklyMeals == null)
            {
                return;
            }

            var hasPlan = _selectedMealPlanId.HasValue;
            dgvWeeklyMeals.Enabled = hasPlan && _isWeekWithinPlanPeriod;
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

            if (!TryGetSelectedWeekRange(out var weekStart, out var weekEnd, out var planNameSuggestion))
            {
                MessageBox.Show("주간 범위를 선택할 수 없습니다. 월/주차를 먼저 선택해 주세요.", "안내");
                return;
            }

            using (var dialog = new MealPlanDialog(weekStart, weekEnd, planNameSuggestion))
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
                "VALUES (:ID, :NAME, :PERIODSTART, :PERIODEND, :STATUS, :CREATEDBY)";

            ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("NAME", planName),
                new OracleParameter("PERIODSTART", startDate),
                new OracleParameter("PERIODEND", endDate),
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
                return false;
            }

            return mealDate.Date >= planStart.Value.Date && mealDate.Date <= planEnd.Value.Date;
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
                        SaveAltAssignments(conn, transaction, planId, mealId, mealDate);
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

        private int GetExistingMealId(int planId, DateTime mealDate)
        {
            const string sql =
                "SELECT MealID FROM Meal WHERE MealPlanID = :PLANID AND MealDate = :MEALDATE";
            var result = ExecuteScalar(sql,
                new OracleParameter("PLANID", planId),
                new OracleParameter("MEALDATE", mealDate));
            return ToInt(result);
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

        private void SaveAltAssignments(OracleConnection conn, OracleTransaction transaction, int planId, int mealId, DateTime mealDate)
        {
            DeleteAltAssignments(conn, transaction, mealId);

            var key = BuildMealPlanKey(planId, mealDate);
            if (!_pendingAltAssignments.TryGetValue(key, out var assignments) || assignments.Count == 0)
            {
                return;
            }

            var nextId = GetNextAltAssignId(conn, transaction);
            foreach (var assignment in assignments)
            {
                InsertAltAssignment(conn, transaction, ref nextId, mealId, assignment);
            }
        }

        private static void DeleteAltAssignments(OracleConnection conn, OracleTransaction transaction, int mealId)
        {
            using (var cmd = new OracleCommand(
                       "DELETE FROM AltReview WHERE AltAssignID IN (SELECT AltAssignID FROM AltAssign WHERE MealID = :MEALID)", conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("MEALID", mealId));
                cmd.ExecuteNonQuery();
            }

            using (var cmd = new OracleCommand("DELETE FROM AltAssign WHERE MealID = :MEALID", conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("MEALID", mealId));
                cmd.ExecuteNonQuery();
            }
        }

        private static int GetNextAltAssignId(OracleConnection conn, OracleTransaction transaction)
        {
            using (var cmd = new OracleCommand("SELECT NVL(MAX(AltAssignID), 0) + 1 FROM AltAssign", conn))
            {
                cmd.Transaction = transaction;
                var result = cmd.ExecuteScalar();
                return ToInt(result);
            }
        }

        private void InsertAltAssignment(OracleConnection conn, OracleTransaction transaction, ref int nextId, int mealId, AlternativeAssignment assignment)
        {
            const string sql =
                "INSERT INTO AltAssign (AltAssignID, MealID, TargetFinalMenuID, AllergyID, FinalMenuID, TargetConsumerCount) " +
                "VALUES (:ID, :MEALID, :TARGETMENU, :ALLERGY, :ALTMENU, :COUNT)";

            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Transaction = transaction;
                cmd.Parameters.Add(new OracleParameter("ID", nextId++));
                cmd.Parameters.Add(new OracleParameter("MEALID", mealId));
                cmd.Parameters.Add(new OracleParameter("TARGETMENU", assignment.TargetMenuId));
                cmd.Parameters.Add(new OracleParameter("ALLERGY", assignment.AllergyId));
                cmd.Parameters.Add(new OracleParameter("ALTMENU", assignment.AlternativeMenuId));
                object consumerCount = assignment.RiskConsumerCount > 0
                    ? assignment.RiskConsumerCount
                    : (object)DBNull.Value;
                cmd.Parameters.Add(new OracleParameter("COUNT", consumerCount));
                cmd.ExecuteNonQuery();
            }
        }

        private int GetDefaultPortionCount()
        {
            return DefaultMealPortion;
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

        private void ApplyRawMaterialView()
        {
            _rawMaterialsForm?.ApplyRawMaterialView();
        }

        private void ApplyRecipeFilter()
        {
            _recipesForm?.ApplyRecipeFilter();
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

        private HashSet<int> GetOrCreateMenuAllergySet(int finalMenuId)
        {
            if (!_menuAllergyMap.TryGetValue(finalMenuId, out var set))
            {
                set = new HashSet<int>();
                _menuAllergyMap[finalMenuId] = set;
            }

            return set;
        }

        private List<MenuAllergyDetail> GetOrCreateMenuAllergyDetails(int finalMenuId)
        {
            if (!_menuAllergyDetails.TryGetValue(finalMenuId, out var list))
            {
                list = new List<MenuAllergyDetail>();
                _menuAllergyDetails[finalMenuId] = list;
            }

            return list;
        }

        private sealed class MealPlanInfo
        {
            public MealPlanInfo(int mealPlanId, string planName, DateTime periodStart, DateTime periodEnd, string status)
            {
                MealPlanId = mealPlanId;
                PlanName = planName ?? string.Empty;
                PeriodStart = periodStart.Date;
                PeriodEnd = periodEnd.Date;
                Status = status ?? string.Empty;
            }

            public int MealPlanId { get; }
            public string PlanName { get; }
            public DateTime PeriodStart { get; }
            public DateTime PeriodEnd { get; }
            public string Status { get; private set; }

            public string DisplayText
            {
                get
                {
                    var statusText = NutritionistForm.GetMealPlanStatusDisplayText(Status);
                    return $"{PlanName} ({PeriodStart:MM/dd}~{PeriodEnd:MM/dd}) - {statusText}";
                }
            }

            public bool Covers(DateTime weekStart, DateTime weekEnd)
            {
                return PeriodStart.Date <= weekStart.Date && PeriodEnd.Date >= weekEnd.Date;
            }

            public void UpdateStatus(string status)
            {
                Status = status ?? string.Empty;
            }

            public override string ToString()
            {
                return DisplayText;
            }
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

        private sealed class AlternativeAssignment
        {
            public AlternativeAssignment(int targetMenuId, string targetMenuName, string menuType, int allergyId,
                string allergyName, int alternativeMenuId, string alternativeMenuName, int riskConsumerCount)
            {
                TargetMenuId = targetMenuId;
                TargetMenuName = targetMenuName ?? string.Empty;
                MenuType = menuType ?? string.Empty;
                AllergyId = allergyId;
                AllergyName = allergyName ?? string.Empty;
                AlternativeMenuId = alternativeMenuId;
                AlternativeMenuName = alternativeMenuName ?? string.Empty;
                RiskConsumerCount = Math.Max(0, riskConsumerCount);
            }

            public int TargetMenuId { get; }
            public string TargetMenuName { get; }
            public string MenuType { get; }
            public int AllergyId { get; }
            public string AllergyName { get; }
            public int AlternativeMenuId { get; }
            public string AlternativeMenuName { get; }
            public int RiskConsumerCount { get; }
        }

        private sealed class MenuAllergyDetail
        {
            public MenuAllergyDetail(int rawId, string rawName, int allergyId, string allergyName)
            {
                RawId = rawId;
                RawName = rawName ?? string.Empty;
                AllergyId = allergyId;
                AllergyName = allergyName ?? string.Empty;
            }

            public int RawId { get; }
            public string RawName { get; }
            public int AllergyId { get; }
            public string AllergyName { get; }
        }

        private sealed class AllergyAlertAggregate
        {
            private readonly List<MenuAssignmentTarget> _menus = new List<MenuAssignmentTarget>();

            public AllergyAlertAggregate(int allergyId, string allergyName, int riskConsumerCount)
            {
                AllergyId = allergyId;
                AllergyName = allergyName ?? string.Empty;
                RiskConsumerCount = Math.Max(0, riskConsumerCount);
            }

            public int AllergyId { get; }
            public string AllergyName { get; }
            public int RiskConsumerCount { get; }
            public IEnumerable<string> MenuNames => _menus.Select(menu => menu.DisplayName);
            public IReadOnlyList<MenuAssignmentTarget> TargetMenus => _menus;
            public int RequiredAlternateCount => RiskConsumerCount;

            public void AddMenu(FinalMenuOption menu)
            {
                if (menu == null)
                {
                    return;
                }

                if (_menus.Any(existing => existing.MenuId == menu.FinalMenuId))
                {
                    return;
                }

                _menus.Add(new MenuAssignmentTarget(menu.FinalMenuId, menu.DisplayName, menu.MenuType ?? string.Empty));
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

            var status = _selectedMealPlanInfo?.Status ?? _currentMealPlanStatus;
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

            var rawMaterials = _rawMaterialsForm?.RawMaterials ?? Array.Empty<RawMaterialOption>();
            var selectedRawId = _rawMaterialsForm?.SelectedRawMaterialId;

            if (rawMaterials.Count == 0)
            {
                MessageBox.Show("등록된 원재료가 없습니다. 먼저 원재료를 등록해 주세요.", "안내");
                return;
            }

            using (var dialog = new PurchaseRequestDialog(rawMaterials.ToList(), selectedRawId))
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
            _rawMaterialsForm?.ReloadRawMaterials();
        }

        private void BtnRawSearch_Click(object sender, EventArgs e)
        {
            _rawMaterialsForm?.ApplyRawMaterialView();
        }

        private void BtnRawClear_Click(object sender, EventArgs e)
        {
            if (txtRawSearch != null)
            {
                txtRawSearch.Clear();
            }

            _rawMaterialsForm?.ApplyRawMaterialView();
        }

        private void ChkRawGroup_CheckedChanged(object sender, EventArgs e)
        {
            _rawMaterialsForm?.ApplyRawMaterialView();
        }

        private void TxtRawSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _rawMaterialsForm?.ApplyRawMaterialView();
            }
        }

        private void BtnRecipeSearch_Click(object sender, EventArgs e)
        {
            ApplyRecipeFilter();
        }

        private void BtnRecipeClear_Click(object sender, EventArgs e)
        {
            _recipesForm?.ApplyRecipeFilter();
        }

        private void TxtRecipeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _recipesForm?.ApplyRecipeFilter();
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

            _rawMaterialsForm?.ReloadRawMaterials();

            if (_rawMaterialsForm == null || !_rawMaterialsForm.TrySelectRawMaterial(rawId))
            {
                MessageBox.Show("현재 필터 조건으로 해당 원재료를 찾을 수 없습니다. 검색 조건을 조정한 후 다시 시도해 주세요.", "원재료 찾기");
            }
        }

        private void AddRawMaterial()
        {
            _rawMaterialsForm?.AddRawMaterial();
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
            UpdateAllergyAlertSummary();
        }

        private void LvAllergyAlerts_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvAllergyAlerts == null || e.Button != MouseButtons.Right)
            {
                return;
            }

            var hit = lvAllergyAlerts.HitTest(e.Location);
            if (hit.Item != null)
            {
                lvAllergyAlerts.SelectedItems.Clear();
                hit.Item.Selected = true;
            }
        }

        private void MenuAssignAlternative_Click(object sender, EventArgs e)
        {
            if (lvAllergyAlerts?.SelectedItems == null || lvAllergyAlerts.SelectedItems.Count == 0)
            {
                return;
            }

            if (lvAllergyAlerts.SelectedItems[0].Tag is not AllergyAlertAggregate aggregate)
            {
                MessageBox.Show("알레르기 정보를 찾을 수 없습니다.", "안내");
                return;
            }

            ShowAlternativeAssignmentDialog(aggregate);
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
                var nutrientMaps = _recipesForm?.MenuNutrientAmounts;
                if (nutrientMaps == null || !nutrientMaps.TryGetValue(menu.FinalMenuId, out var nutrientMap))
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

        private List<AllergyAlertAggregate> GetCurrentAllergyAggregates()
        {
            var result = new List<AllergyAlertAggregate>();
            if (_selectedMealMenus.Count == 0)
            {
                return result;
            }

            var aggregates = new Dictionary<int, AllergyAlertAggregate>();
            foreach (var menu in _selectedMealMenus)
            {
                if (!_menuAllergyMap.TryGetValue(menu.FinalMenuId, out var allergyIds) || allergyIds.Count == 0)
                {
                    continue;
                }

                foreach (var allergyId in allergyIds)
                {
                    if (!aggregates.TryGetValue(allergyId, out var aggregate))
                    {
                        var allergyName = _allergyNameLookup.TryGetValue(allergyId, out var name)
                            ? name
                            : $"알레르기 {allergyId}";
                        var riskCount = _allergyConsumerCounts.TryGetValue(allergyId, out var risk)
                            ? risk
                            : 0;
                        aggregate = new AllergyAlertAggregate(allergyId, allergyName, riskCount);
                        aggregates[allergyId] = aggregate;
                    }

                    aggregate.AddMenu(menu);
                }
            }

            if (aggregates.Count == 0)
            {
                return result;
            }

            result.AddRange(aggregates.Values
                .OrderByDescending(a => a.RiskConsumerCount)
                .ThenBy(a => a.AllergyName, StringComparer.OrdinalIgnoreCase));
            return result;
        }

        private void ShowAlternativeAssignmentDialog(AllergyAlertAggregate aggregate)
        {
            if (aggregate == null)
            {
                return;
            }

            if (_selectedMealPlanId == null || dtpMealDate == null)
            {
                MessageBox.Show("식단 계획과 일자를 먼저 선택해 주세요.", "안내");
                return;
            }

            var targets = aggregate.TargetMenus?.ToList() ?? new List<MenuAssignmentTarget>();
            if (targets.Count == 0)
            {
                MessageBox.Show("대체가 필요한 메뉴가 없습니다.", "안내");
                return;
            }

            var candidateMap = new Dictionary<int, List<FinalMenuOption>>();
            foreach (var target in targets)
            {
                candidateMap[target.MenuId] = GetAlternativeMenuCandidates(target, aggregate.AllergyId);
            }

            if (candidateMap.Values.All(list => list == null || list.Count == 0))
            {
                MessageBox.Show("조건에 맞는 대체 메뉴가 없습니다.", "안내");
                return;
            }

            using (var dialog = new AlternativeMenuDialog(aggregate.AllergyName, targets, candidateMap))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                var selectedTarget = dialog.SelectedTarget;
                var selectedAlternative = dialog.SelectedAlternative;
                if (selectedTarget == null || selectedAlternative == null)
                {
                    MessageBox.Show("대체할 메뉴를 선택해 주세요.", "안내");
                    return;
                }

                var key = GetCurrentMealPlanKey();
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("식단 일자를 선택해 주세요.", "안내");
                    return;
                }

                var assignment = new AlternativeAssignment(
                    selectedTarget.MenuId,
                    selectedTarget.DisplayName,
                    selectedTarget.MenuType,
                    aggregate.AllergyId,
                    aggregate.AllergyName,
                    selectedAlternative.FinalMenuId,
                    selectedAlternative.DisplayName,
                    aggregate.RiskConsumerCount);

                AddOrUpdateAltAssignment(key, assignment);
                UpdateAllergyAlertSummary();
                MessageBox.Show($"'{selectedTarget.DisplayName}'의 대체 메뉴가 임시 저장되었습니다.", "대체 메뉴", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<FinalMenuOption> GetAlternativeMenuCandidates(MenuAssignmentTarget target, int allergyId)
        {
            if (target == null)
            {
                return new List<FinalMenuOption>();
            }

            var menuType = target.MenuType ?? string.Empty;
            return _finalMenuOptions
                .Where(menu => menu.FinalMenuId != target.MenuId)
                .Where(menu => string.IsNullOrWhiteSpace(menuType) ||
                               string.Equals(menu.MenuType, menuType, StringComparison.OrdinalIgnoreCase))
                .Where(menu => !MenuContainsAllergy(menu.FinalMenuId, allergyId))
                .OrderBy(menu => menu.DisplayName, StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        private bool MenuContainsAllergy(int finalMenuId, int allergyId)
        {
            return _menuAllergyMap.TryGetValue(finalMenuId, out var allergies) && allergies.Contains(allergyId);
        }

        private IReadOnlyList<AlternativeAssignment> GetAltAssignmentsForCurrentMeal()
        {
            var key = GetCurrentMealPlanKey();
            if (string.IsNullOrEmpty(key))
            {
                return Array.Empty<AlternativeAssignment>();
            }

            return _pendingAltAssignments.TryGetValue(key, out var list)
                ? list
                : Array.Empty<AlternativeAssignment>();
        }

        private void AddOrUpdateAltAssignment(string key, AlternativeAssignment assignment)
        {
            if (string.IsNullOrEmpty(key) || assignment == null)
            {
                return;
            }

            var list = GetOrCreateAltAssignmentList(key);
            var existing = list.FirstOrDefault(item =>
                item.TargetMenuId == assignment.TargetMenuId &&
                item.AllergyId == assignment.AllergyId);
            if (existing != null)
            {
                list.Remove(existing);
            }

            list.Add(assignment);
        }

        private List<AlternativeAssignment> GetOrCreateAltAssignmentList(string key)
        {
            if (!_pendingAltAssignments.TryGetValue(key, out var list))
            {
                list = new List<AlternativeAssignment>();
                _pendingAltAssignments[key] = list;
            }

            return list;
        }

        private void UpdateAllergyAlertSummary()
        {
            var listView = lvAllergyAlerts;
            if (listView == null)
            {
                return;
            }

            listView.BeginUpdate();
            listView.Items.Clear();

            var aggregates = GetCurrentAllergyAggregates();
            var riskAggregates = aggregates
                .Where(aggregate => aggregate.RiskConsumerCount > 0)
                .ToList();

            if (riskAggregates.Count == 0)
            {
                listView.EndUpdate();
                return;
            }

            var currentAssignments = GetAltAssignmentsForCurrentMeal();

            foreach (var aggregate in riskAggregates)
            {
                var assignmentsForAllergy = currentAssignments
                    .Where(a => a.AllergyId == aggregate.AllergyId)
                    .ToList();
                var assignmentText = assignmentsForAllergy.Count > 0
                    ? string.Join(", ", assignmentsForAllergy.Select(a =>
                        string.IsNullOrWhiteSpace(a.AlternativeMenuName)
                            ? a.TargetMenuName
                            : $"{a.TargetMenuName}→{a.AlternativeMenuName}"))
                    : string.Empty;

                var item = new ListViewItem(aggregate.AllergyName)
                {
                    Tag = aggregate
                };
                item.SubItems.Add(string.Join(", ", aggregate.MenuNames));
                item.SubItems.Add(aggregate.RiskConsumerCount > 0
                    ? aggregate.RiskConsumerCount.ToString()
                    : "-");
                item.SubItems.Add(aggregate.RequiredAlternateCount > 0
                    ? aggregate.RequiredAlternateCount.ToString()
                    : "-");
                item.SubItems.Add(string.IsNullOrWhiteSpace(assignmentText) ? "-" : assignmentText);

                if (assignmentsForAllergy.Count > 0)
                {
                    item.BackColor = Color.Honeydew;
                }
                else if (aggregate.RiskConsumerCount > 0)
                {
                    item.BackColor = Color.MistyRose;
                }

                listView.Items.Add(item);
            }

            listView.EndUpdate();
        }

        private void ShowAllergyAlertModalForSelectedMeals()
        {
            const string caption = "알레르기 정보";
            if (_selectedMealMenus.Count == 0)
            {
                MessageBox.Show("선택된 식단에 등록된 메뉴가 없습니다.", caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var aggregates = GetCurrentAllergyAggregates();
            if (aggregates.Count == 0)
            {
                var menus = string.Join(", ", _selectedMealMenus.Select(menu => menu.DisplayName));
                var message = string.IsNullOrWhiteSpace(menus)
                    ? "선택된 식단에 알레르기 정보가 없습니다."
                    : $"선택된 식단에 알레르기 정보가 없습니다.\n메뉴: {menus}";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var builder = new StringBuilder();
            builder.AppendLine("선택된 식단의 알레르기 정보");
            builder.AppendLine();

            foreach (var aggregate in aggregates)
            {
                builder.AppendLine($"- {aggregate.AllergyName} (위험 인원: {aggregate.RiskConsumerCount})");
                builder.AppendLine($"  메뉴: {string.Join(", ", aggregate.MenuNames)}");
                builder.AppendLine();
            }

            MessageBox.Show(builder.ToString().Trim(), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowInitialAllergyTraceModal()
        {
            if (_initialAllergyModalShown)
            {
                return;
            }

            _initialAllergyModalShown = true;

            const string targetMenuName = "새우튀김";
            var targetMenu = _finalMenuOptions.FirstOrDefault(menu =>
                string.Equals(menu.MenuName, targetMenuName, StringComparison.OrdinalIgnoreCase));
            if (targetMenu == null)
            {
                return;
            }

            if (!_menuAllergyDetails.TryGetValue(targetMenu.FinalMenuId, out var details) || details.Count == 0)
            {
                return;
            }

            var builder = new StringBuilder();
            builder.AppendLine("알레르기 연결 정보 예시");
            builder.AppendLine();

            foreach (var detail in details)
            {
                var rawName = string.IsNullOrWhiteSpace(detail.RawName)
                    ? $"원재료 {detail.RawId}"
                    : detail.RawName;
                var allergyName = string.IsNullOrWhiteSpace(detail.AllergyName)
                    ? $"알레르기 {detail.AllergyId}"
                    : detail.AllergyName;
                builder.AppendLine($"새우튀김 -> {rawName} -> {allergyName}");
            }

            MessageBox.Show(builder.ToString().Trim(), "알레르기 연결 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetCurrentMealPlanKey()
        {
            if (_selectedMealPlanId == null || dtpMealDate == null)
            {
                return string.Empty;
            }

            return BuildMealPlanKey(_selectedMealPlanId.Value, dtpMealDate.Value);
        }

        private static string BuildMealPlanKey(int planId, DateTime mealDate)
        {
            return $"{planId}_{mealDate:yyyyMMdd}";
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
                _pendingAltAssignments.Remove(key);
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

            if (dtpMealDate != null)
            {
                LoadAltAssignmentsForMealDate(dtpMealDate.Value.Date);
            }
            _suppressMealBoardUpdate = false;
            RefreshMealBoard();
            UpdateNutritionSummary();
            UpdateAllergyAlertSummary();
            ShowAllergyAlertModalForSelectedMeals();
        }

        private void LoadAltAssignmentsForMealDate(DateTime mealDate)
        {
            if (_selectedMealPlanId == null)
            {
                return;
            }

            var key = BuildMealPlanKey(_selectedMealPlanId.Value, mealDate);
            if (_pendingAltAssignments.ContainsKey(key))
            {
                return;
            }
            var mealId = GetExistingMealId(_selectedMealPlanId.Value, mealDate);
            if (mealId <= 0)
            {
                _pendingAltAssignments.Remove(key);
                return;
            }

            const string sql =
                "SELECT aa.AllergyID, NVL(a.AllergyName, '알레르기 ' || aa.AllergyID) AS AllergyName, " +
                "       aa.TargetFinalMenuID, tm.MenuName AS TargetMenuName, tm.MenuType AS TargetMenuType, " +
                "       aa.FinalMenuID, fm.MenuName AS AltMenuName, NVL(aa.TargetConsumerCount, 0) AS TargetConsumerCount " +
                "FROM AltAssign aa " +
                "JOIN FinalMenu fm ON fm.FinalMenuID = aa.FinalMenuID " +
                "JOIN FinalMenu tm ON tm.FinalMenuID = aa.TargetFinalMenuID " +
                "LEFT JOIN Allergy a ON a.AllergyID = aa.AllergyID " +
                "WHERE aa.MealID = :MEALID";

            var table = ExecuteDataTable(sql, new OracleParameter("MEALID", mealId));
            var list = new List<AlternativeAssignment>();
            foreach (DataRow row in table.Rows)
            {
                var targetMenuId = ToInt(row["TARGETFINALMENUID"]);
                var alternativeMenuId = ToInt(row["FINALMENUID"]);
                if (targetMenuId <= 0 || alternativeMenuId <= 0)
                {
                    continue;
                }

                var assignment = new AlternativeAssignment(
                    targetMenuId,
                    row["TARGETMENUNAME"]?.ToString() ?? string.Empty,
                    row["TARGETMENUTYPE"]?.ToString() ?? string.Empty,
                    ToInt(row["ALLERGYID"]),
                    row["ALLERGYNAME"]?.ToString() ?? string.Empty,
                    alternativeMenuId,
                    row["ALTMENUNAME"]?.ToString() ?? string.Empty,
                    ToInt(row["TARGETCONSUMERCOUNT"]));
                list.Add(assignment);
            }

            if (list.Count > 0)
            {
                _pendingAltAssignments[key] = list;
            }
            else
            {
                _pendingAltAssignments.Remove(key);
            }
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
