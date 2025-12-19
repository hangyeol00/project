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
        private readonly BindingList<FinalMenuOption> _selectedMealMenus = new BindingList<FinalMenuOption>();
        private readonly Dictionary<string, List<FinalMenuOption>> _mealPlanSelections = new Dictionary<string, List<FinalMenuOption>>();
        private readonly List<MealPlanInfo> _mealPlans = new List<MealPlanInfo>();
        private readonly BindingList<MealPlanInfo> _weekMealPlanOptions = new BindingList<MealPlanInfo>();
        private readonly Dictionary<int, FinalMenuOption> _menuOptionLookup = new Dictionary<int, FinalMenuOption>();
        private readonly BindingList<NutrientSummaryRow> _nutrientSummary = new BindingList<NutrientSummaryRow>();
        private readonly Dictionary<int, HashSet<int>> _menuTagMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, string> _tagNameLookup = new Dictionary<int, string>();
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
        private bool _suppressMealBoardUpdate;
        private bool _suppressWeekChange;
        private int? _selectedMealPlanId;
        private readonly List<WeekOption> _mealWeekOptions = new List<WeekOption>();
        private WeekOption _selectedWeekOption;
        private DateTime? _currentPlanStart;
        private DateTime? _currentPlanEnd;
        private ContextMenuStrip _allergyAlertMenu;
        private ToolStripMenuItem _menuAssignAlternative;
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
        private DataGridView dgvTodayMealBoard => Dashboard?.dgvTodayMealBoard;
        private GroupBox grpTodayRaw => Dashboard?.grpTodayRaw;
        private ListView lvTodayRawNeeds => Dashboard?.lvTodayRawNeeds;
        private GroupBox grpShortage => Dashboard?.grpShortage;
        private ListView lvShortageRaw => Dashboard?.lvShortageRaw;
        private GroupBox grpMealLogs => Dashboard?.grpMealLogs;
        private ListView lvMealLogs => Dashboard?.lvMealLogs;
        private GroupBox grpAction => Dashboard?.grpAction;
        private Button btnCancelMeal => Dashboard?.btnCancelMeal;
        private Button btnServeMeal => Dashboard?.btnServeMeal;
        private TextBox txtStudentId => Dashboard?.txtStudentId;
        private Label lblStudentId => Dashboard?.lblStudentId;
        private GroupBox grpMenus => Dashboard?.grpMenus;
        private ListView lvMenus => Dashboard?.lvMenus;
        private GroupBox grpStudents => Dashboard?.grpStudents;
        private ListView lvRawMaterials => Dashboard?.lvRawMaterials;
        private GroupBox grpSummary => Dashboard?.grpSummary;
        private Label lblServeDateTitle => Dashboard?.lblServeDateTitle;
        private Label lblCurrentServeDate => Dashboard?.lblCurrentServeDate;
        private Label lblNotMealValue => Dashboard?.lblNotMealValue;
        private Label lblNotMeal => Dashboard?.lblNotMeal;
        private Label lblTodayMealValue => Dashboard?.lblTodayMealValue;
        private Label lblTodayMeal => Dashboard?.lblTodayMeal;
        private Label lblTotalStudentValue => Dashboard?.lblTotalStudentValue;
        private Label lblTotalStudent => Dashboard?.lblTotalStudent;
        private IngredientsTabPage IngredientsTab => ingredientsTabPage;
        private DataGridView dgvIngredients => IngredientsTab?.dgvIngredients;
        private SplitContainer splitContainerIngredients => IngredientsTab?.splitContainerIngredients;
        private NutrientsTabPage NutrientsTab => nutrientsTabPage;
        private SplitContainer splitContainerNutrients => NutrientsTab?.splitContainerNutrients;
        private SplitContainer splitContainerMealPlans => _mealPlansForm?.SplitContainerMealPlans;
        private DateTimePicker dtpMealDate => _mealPlansForm?.DtpMealDate;
        private DateTimePicker dtpMealMonth => _mealPlansForm?.DtpMealMonth;
        private ComboBox cmbMealWeek => _mealPlansForm?.CmbMealWeek;
        private Label lblSelectedMealDay => _mealPlansForm?.LblSelectedMealDay;
        private Label lblMealPlanStatus => _mealPlansForm?.LblMealPlanStatus;
        private ListBox lstWeekMealPlans => _mealPlansForm?.LstWeekMealPlans;
        private Button btnDeleteMealPlan => _mealPlansForm?.BtnDeleteMealPlan;
        private DataGridView dgvWeeklyMeals => _mealPlansForm?.DgvWeeklyMeals;
        private TextBox txtMealNotes => _mealPlansForm?.TxtMealNotes;
        private CheckedListBox clbMenuTags => _mealPlansForm?.ClbMenuTags;
        private ComboBox cmbMenuTypeFilter => _mealPlansForm?.CmbMenuTypeFilter;
        private ComboBox cmbMenuSort => _mealPlansForm?.CmbMenuSort;
        private Button btnResetMenuFilter => _mealPlansForm?.BtnResetMenuFilter;
        private Button btnRegisterMealPlan => _mealPlansForm?.BtnRegisterMealPlan;
        private Button btnRequestMealApproval => _mealPlansForm?.BtnRequestMealApproval;
        private Button btnStartMealPlan => _mealPlansForm?.BtnStartMealPlan;
        private ListBox lstAvailableMenus => _mealPlansForm?.LstAvailableMenus;
        private ListView lvMealBoard => _mealPlansForm?.LvMealBoard;
        private ListView lvAllergyAlerts => _mealPlansForm?.LvAllergyAlerts;
        private DataGridView dgvMealNutrition => _mealPlansForm?.DgvMealNutrition;
        private DataGridViewTextBoxColumn colNutrientStatus => _mealPlansForm?.ColNutrientStatus;
        private GroupBox grpMealPlanDetail => _mealPlansForm?.GrpMealPlanDetail;
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
            if (lvRawMaterials != null)
            {
                lvRawMaterials.SelectedIndexChanged += LvRawMaterials_SelectedIndexChanged;
            }
            dgvIngredients.CellClick += DgvPurchaseRequests_CellClick;
            btnServeMeal.Click += BtnServeMeal_Click;
            btnCancelMeal.Click += BtnCancelMeal_Click;
            ConfigureAccessByRole();
            UpdateNavigationSelection();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvIngredients);
            ConfigureGrid(dgvEvaluationMenus);
            ConfigureGrid(dgvEvaluationIngredients);
            ConfigureGrid(dgvEvaluationAllergies);
            ConfigureDashboardViews();

            if (dgvEvaluationMenus != null)
            {
                dgvEvaluationMenus.SelectionChanged += DgvEvaluationMenus_SelectionChanged;
            }

            if (dgvEvaluationIngredients != null)
            {
                dgvEvaluationIngredients.SelectionChanged += DgvEvaluationIngredients_SelectionChanged;
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

            InitializeManagementForms();
        }

        private void InitializeManagementForms()
        {
            if (tabRawMaterials != null)
            {
                _rawMaterialsForm = new RawMaterialsForm();
                HostFormInTab(tabRawMaterials, _rawMaterialsForm);
            }

            if (tabMealPlans != null)
            {
                _mealPlansForm = new MealPlansForm(_session);
                HostFormInTab(tabMealPlans, _mealPlansForm);
                _mealPlansForm.SetDependencies(_session, _recipesForm);
                _mealPlansForm.MealPlansChanged += LoadDashboardData;
            }

            if (tabControlManagement != null)
            {
                tabControlManagement.SelectedIndexChanged += TabControlManagement_SelectedIndexChanged;
                if (tabControlManagement.SelectedTab == tabRecipes)
                {
                    EnsureRecipesFormInitialized();
                }
            }
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

        private void TabControlManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlManagement?.SelectedTab == tabRecipes)
            {
                EnsureRecipesFormInitialized();
            }
        }

        private void EnsureRecipesFormInitialized()
        {
            if (_recipesForm != null || tabRecipes == null)
            {
                return;
            }

            _recipesForm = new RecipesForm();
            _recipesForm.RawMaterialRequested += ShowRawMaterialInManager;
            HostFormInTab(tabRecipes, _recipesForm);
            _recipesForm.ReloadRecipes();
            _mealPlansForm?.SetDependencies(_session, _recipesForm);
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

            _mealPlansForm?.ConfigureAccessByRole();
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
                LoadDashboardData();
                LoadRecipesManagement();
                _mealPlansForm?.ReloadData();
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

        private void LoadDashboardData()
        {
            LoadSummary();
            LoadTodayMealBoard();
            LoadTodayRawNeeds();
            LoadPendingPurchaseRequestsSummary();
            LoadRecentMealLogs();
            LoadRawMaterials();
            LoadFinalMenusSummary();
        }

        private void LoadSummary()
        {
            EnsureSummaryLabels();

            var totalStudents = ToInt(ExecuteScalar(
                "SELECT COUNT(*) FROM Consumer WHERE ConsumerType = 'S' AND NVL(Status, 'ACTIVE') = 'ACTIVE'"));
            var todayMenuCount = ToInt(ExecuteScalar(
                "SELECT COUNT(*) FROM MealComp mc JOIN Meal m ON m.MealID = mc.MealID WHERE TRUNC(m.MealDate) = TRUNC(:TODAY)",
                new OracleParameter("TODAY", DateTime.Today)));
            var pendingPurchase = ToInt(ExecuteScalar(
                "SELECT COUNT(*) FROM PurchaseRequest WHERE UPPER(NVL(Status, :STATUS)) <> :STATUS",
                new OracleParameter("STATUS", PurchaseStatusApproved)));

            lblTotalStudentValue.Text = totalStudents.ToString();
            lblTodayMealValue.Text = todayMenuCount.ToString();
            lblNotMealValue.Text = pendingPurchase.ToString();
            if (lblCurrentServeDate != null)
            {
                lblCurrentServeDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        private void EnsureSummaryLabels()
        {
            if (lblServeDateTitle != null)
            {
                lblServeDateTitle.Text = "기준 일자:";
            }

            if (lblTotalStudent != null)
            {
                lblTotalStudent.Text = "재학생 수:";
            }

            if (lblTodayMeal != null)
            {
                lblTodayMeal.Text = "오늘 메뉴 수:";
            }

            if (lblNotMeal != null)
            {
                lblNotMeal.Text = "미승인 발주:";
            }
        }

        private void LoadRawMaterials()
        {
            _rawMaterialsForm?.ReloadRawMaterials();
            var list = lvRawMaterials;
            var table = _rawMaterialsForm?.RawMaterialTable;
            if (list == null || table == null)
            {
                return;
            }

            DataRow firstRow = null;
            list.BeginUpdate();
            list.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["RAWNAME"]?.ToString() ?? "-");
                item.SubItems.Add(row["CATEGORYNAME"]?.ToString() ?? "-");
                item.SubItems.Add(row["PURCHASEUNIT"]?.ToString() ?? "-");
                item.SubItems.Add(row["ACTIVEFLAG"]?.ToString() ?? "-");
                item.Tag = row;
                list.Items.Add(item);

                if (firstRow == null)
                {
                    firstRow = row;
                }
            }

            list.EndUpdate();

            if (list.Items.Count > 0 && firstRow != null)
            {
                list.Items[0].Selected = true;
                SetSelectedRawMaterial(firstRow);
            }
            else
            {
                SetSelectedRawMaterial(null);
            }
        }

        private void LoadTodayMealBoard()
        {
            var grid = dgvTodayMealBoard;
            if (grid == null)
            {
                return;
            }

            const string sql =
                "WITH today_meal AS ( " +
                "    SELECT MealID FROM Meal WHERE TRUNC(MealDate) = TRUNC(:MEALDATE) " +
                "), menu_tags AS ( " +
                "    SELECT mtm.FinalMenuID, LISTAGG(mt.TagName, ', ') WITHIN GROUP(ORDER BY mt.TagName) AS Tags " +
                "    FROM MenuTagMap mtm " +
                "    JOIN MenuTag mt ON mtm.MenuTagID = mt.MenuTagID " +
                "    GROUP BY mtm.FinalMenuID " +
                ") " +
                "SELECT DISTINCT fm.FinalMenuID, fm.MenuName AS MENU_NAME, fm.MenuType AS MENU_TYPE, NVL(mt.Tags, '-') AS TAGS " +
                "FROM MealComp mc " +
                "JOIN today_meal tm ON mc.MealID = tm.MealID " +
                "JOIN FinalMenu fm ON mc.FinalMenuID = fm.FinalMenuID " +
                "LEFT JOIN menu_tags mt ON fm.FinalMenuID = mt.FinalMenuID " +
                "ORDER BY CASE UPPER(fm.MenuType) WHEN 'MAIN' THEN 1 WHEN 'SIDE' THEN 2 WHEN 'SOUP' THEN 3 WHEN 'DRINK' THEN 4 ELSE 5 END, fm.MenuName";

            var table = ExecuteDataTable(sql, new OracleParameter("MEALDATE", DateTime.Today));

            if (grid.Columns.Count > 0)
            {
                grid.Columns[0].HeaderText = $"{DateTime.Today:MM/dd} (오늘)";
            }

            if (grid.Rows.Count == 0)
            {
                grid.Rows.Add();
            }

            var lines = table.Rows.Count == 0
                ? new[] { "등록된 식단 없음" }
                : table.Rows.Cast<DataRow>().Select(FormatTodayMealLine).ToArray();

            grid.Rows[0].Cells[0].Value = string.Join(Environment.NewLine, lines);
            grid.ClearSelection();
            if (lblTodayMealValue != null)
            {
                lblTodayMealValue.Text = table.Rows.Count.ToString();
            }
        }

        private void LoadTodayRawNeeds()
        {
            var list = lvTodayRawNeeds;
            if (list == null)
            {
                return;
            }

            const string sql =
                "WITH today_meal AS ( " +
                "    SELECT MealID FROM Meal WHERE TRUNC(MealDate) = TRUNC(:MEALDATE) " +
                "), raw_need AS ( " +
                "    SELECT mc.MealID, mc.PortionCount, comp.ComponentRawID AS RawID, comp.QuantityPerServing " +
                "    FROM MealComp mc " +
                "    JOIN today_meal tm ON mc.MealID = tm.MealID " +
                "    JOIN MenuComp comp ON mc.FinalMenuID = comp.FinalMenuID " +
                "    WHERE comp.ComponentType = 'R' " +
                ") " +
                "SELECT rm.RawName AS RAW_NAME, " +
                "       ROUND(NVL(SUM(NVL(raw_need.QuantityPerServing, 0) * NVL(raw_need.PortionCount, 1)), 0), 2) AS REQUIRED_QTY, " +
                "       rm.PurchaseUnit AS UNIT " +
                "FROM raw_need " +
                "JOIN RawMaterial rm ON raw_need.RawID = rm.RawID " +
                "GROUP BY rm.RawName, rm.PurchaseUnit " +
                "ORDER BY rm.RawName";

            var table = ExecuteDataTable(sql, new OracleParameter("MEALDATE", DateTime.Today));

            list.BeginUpdate();
            list.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["RAW_NAME"]?.ToString() ?? "-");
                item.SubItems.Add(FormatDecimalDisplay(row["REQUIRED_QTY"]));
                item.SubItems.Add(row["UNIT"]?.ToString() ?? "-");
                list.Items.Add(item);
            }

            list.EndUpdate();
        }

        private void LoadPendingPurchaseRequestsSummary()
        {
            var list = lvShortageRaw;
            if (list == null)
            {
                return;
            }

            const string sql =
                "SELECT pr.PurchaseRequestID, " +
                "       NVL(r.RawName, '원재료 ' || pr.RawID) AS RAW_NAME, " +
                "       pr.Quantity, pr.UnitPriceEstimate, NVL(pr.Status, 'REQUESTED') AS STATUS, " +
                "       pr.RequestedDate, pr.ExpectedDeliveryDate " +
                "FROM PurchaseRequest pr " +
                "LEFT JOIN RawMaterial r ON pr.RawID = r.RawID " +
                "WHERE UPPER(NVL(pr.Status, 'REQUESTED')) <> :STATUS " +
                "ORDER BY pr.RequestedDate DESC";

            var table = ExecuteDataTable(sql, new OracleParameter("STATUS", PurchaseStatusApproved));

            list.BeginUpdate();
            list.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["PURCHASEREQUESTID"]?.ToString() ?? "-");
                item.SubItems.Add(row["RAW_NAME"]?.ToString() ?? "-");
                item.SubItems.Add(FormatDecimalDisplay(row["QUANTITY"]));
                item.SubItems.Add(FormatDecimalDisplay(row["UNITPRICEESTIMATE"]));
                item.SubItems.Add(row["STATUS"]?.ToString() ?? "-");
                item.SubItems.Add(FormatDateDisplay(row["REQUESTEDDATE"]));
                item.SubItems.Add(FormatDateDisplay(row["EXPECTEDDELIVERYDATE"]));
                list.Items.Add(item);
            }

            list.EndUpdate();
        }

        private void LoadRecentMealLogs()
        {
            var list = lvMealLogs;
            if (list == null)
            {
                return;
            }

            const string sql =
                "SELECT m.MealID, NVL(mp.PlanName, '계획 ' || m.MealPlanID) AS PLAN_NAME, " +
                "       m.MealDate, NVL(m.TargetGroup, '-') AS TARGET_GROUP, NVL(m.Notes, '-') AS NOTES " +
                "FROM Meal m " +
                "LEFT JOIN MealPlan mp ON m.MealPlanID = mp.MealPlanID " +
                "ORDER BY m.MealDate DESC " +
                "FETCH FIRST 20 ROWS ONLY";

            var table = ExecuteDataTable(sql);
            list.BeginUpdate();
            list.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row["MEALID"]?.ToString() ?? "-");
                item.SubItems.Add(row["PLAN_NAME"]?.ToString() ?? "-");
                item.SubItems.Add(FormatDateDisplay(row["MEALDATE"]));
                item.SubItems.Add(row["TARGET_GROUP"]?.ToString() ?? "-");
                item.SubItems.Add(row["NOTES"]?.ToString() ?? "-");
                list.Items.Add(item);
            }

            list.EndUpdate();
        }

        private void LoadFinalMenusSummary()
        {
            var list = lvMenus;
            if (list == null)
            {
                return;
            }

            const string sql =
                "SELECT fm.FinalMenuID, fm.MenuName AS MENU_NAME, fm.MenuType AS MENU_TYPE, " +
                "       CASE UPPER(fm.MenuType) " +
                "            WHEN 'MAIN' THEN '주식' " +
                "            WHEN 'SIDE' THEN '반찬' " +
                "            WHEN 'SOUP' THEN '국/탕' " +
                "            WHEN 'DRINK' THEN '음료' " +
                "            ELSE '기타' END AS MENU_TYPE_NAME, " +
                "       NVL(fm.ActiveFlag, 'Y') AS ACTIVE_FLAG " +
                "FROM FinalMenu fm " +
                "ORDER BY fm.MenuName";

            var table = ExecuteDataTable(sql);
            list.BeginUpdate();
            list.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var menuName = row["MENU_NAME"]?.ToString() ?? "-";
                var typeName = row["MENU_TYPE_NAME"]?.ToString() ?? "-";
                var activeFlag = row["ACTIVE_FLAG"]?.ToString();
                var activeText = string.Equals(activeFlag, "Y", StringComparison.OrdinalIgnoreCase) ? "사용" : "중지";
                var item = new ListViewItem(menuName);
                item.SubItems.Add(typeName);
                item.SubItems.Add(activeText);
                item.SubItems.Add(row["FINALMENUID"]?.ToString() ?? "-");
                list.Items.Add(item);
            }

            list.EndUpdate();
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

        private void ApplyMenuFilter(bool resetSelection = false)
        {
            _mealPlansForm?.ApplyMenuFilter(resetSelection);
        }

        private decimal GetMenuNutrientAmount(int menuId, string nutrientCode)
        {
            return _recipesForm?.GetMenuNutrientAmount(menuId, nutrientCode) ?? 0m;
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

        private void LvRawMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = lvRawMaterials;
            if (list?.SelectedItems == null || list.SelectedItems.Count == 0)
            {
                SetSelectedRawMaterial(null);
                return;
            }

            var selected = list.SelectedItems[0];
            if (selected.Tag is DataRow row)
            {
                SetSelectedRawMaterial(row);
            }
            else
            {
                SetSelectedRawMaterial(null);
            }
        }

        private void SetSelectedRawMaterial(DataRow row)
        {
            if (row == null)
            {
                _selectedRawMaterialId = null;
                DisplaySelectedRawMaterial(null);
                return;
            }

            var isRaw = string.Equals(row["ITEMTYPE"]?.ToString(), "RAW", StringComparison.OrdinalIgnoreCase);
            _selectedRawMaterialId = isRaw ? ToInt(row["RAWID"]) : (int?)null;
            DisplaySelectedRawMaterial(row);
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

        private static string GetMenuTypeDisplay(string menuType)
        {
            var code = menuType?.Trim().ToUpperInvariant();
            switch (code)
            {
                case "MAIN":
                    return "주식";
                case "SIDE":
                    return "반찬";
                case "SOUP":
                    return "국/탕";
                case "DRINK":
                    return "음료";
                default:
                    return "기타";
            }
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
                _mealPlansForm?.ApproveSelectedMealPlan();
            }
            else
            {
                _mealPlansForm?.OpenMealPlanDialogFromHost();
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

        private int GetExistingMealId(int planId, DateTime mealDate)
        {
            const string sql =
                "SELECT MealID FROM Meal WHERE MealPlanID = :PLANID AND MealDate = :MEALDATE";
            var result = ExecuteScalar(sql,
                new OracleParameter("PLANID", planId),
                new OracleParameter("MEALDATE", mealDate));
            return ToInt(result);
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

        private static void ConfigureListView(ListView list, params (string Header, int Width, HorizontalAlignment Align)[] columns)
        {
            if (list == null)
            {
                return;
            }

            if (columns?.Length > 0 && list.Columns.Count == 0)
            {
                foreach (var column in columns)
                {
                    list.Columns.Add(column.Header, column.Width, column.Align);
                }
            }

            list.View = View.Details;
            list.FullRowSelect = true;
            list.MultiSelect = false;
            list.HideSelection = false;
            list.GridLines = true;
        }

        private void ConfigureDashboardViews()
        {
            ConfigureTodayMealBoardGrid();
            ConfigureListView(lvTodayRawNeeds,
                ("원재료", 200, HorizontalAlignment.Left),
                ("필요 수량", 100, HorizontalAlignment.Right),
                ("단위", 80, HorizontalAlignment.Left));
            ConfigureListView(lvShortageRaw,
                ("요청 ID", 70, HorizontalAlignment.Left),
                ("원재료", 130, HorizontalAlignment.Left),
                ("수량", 80, HorizontalAlignment.Right),
                ("예상 단가", 90, HorizontalAlignment.Right),
                ("상태", 80, HorizontalAlignment.Center),
                ("요청일", 90, HorizontalAlignment.Left),
                ("입고 예정", 90, HorizontalAlignment.Left));
            ConfigureListView(lvMealLogs,
                ("식단 ID", 80, HorizontalAlignment.Left),
                ("식단 계획", 160, HorizontalAlignment.Left),
                ("일자", 100, HorizontalAlignment.Left),
                ("대상", 90, HorizontalAlignment.Left),
                ("비고", 150, HorizontalAlignment.Left));
            ConfigureListView(lvRawMaterials,
                ("명칭", 160, HorizontalAlignment.Left),
                ("분류", 130, HorizontalAlignment.Left),
                ("단위", 80, HorizontalAlignment.Left),
                ("사용 여부", 80, HorizontalAlignment.Center));
            ConfigureListView(lvMenus,
                ("메뉴명", 170, HorizontalAlignment.Left),
                ("분류", 90, HorizontalAlignment.Left),
                ("사용 여부", 80, HorizontalAlignment.Center),
                ("메뉴 ID", 80, HorizontalAlignment.Left));
        }

        private void ConfigureTodayMealBoardGrid()
        {
            var grid = dgvTodayMealBoard;
            if (grid == null)
            {
                return;
            }

            if (grid.Columns.Count == 0)
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colTodayMealBoard",
                    HeaderText = "오늘의 식단",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            if (grid.Rows.Count == 0)
            {
                grid.Rows.Add();
            }

            grid.ClearSelection();
        }

        private static string FormatDecimalDisplay(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "-";
            }

            if (decimal.TryParse(value.ToString(), out var number))
            {
                return number.ToString("0.##");
            }

            return value.ToString();
        }

        private static string FormatDateDisplay(object value)
        {
            var date = ToNullableDate(value);
            return date?.ToString("yyyy-MM-dd") ?? "-";
        }

        private static string FormatTodayMealLine(DataRow row)
        {
            var menuName = row["MENU_NAME"]?.ToString() ?? "-";
            var typeDisplay = GetMenuTypeDisplay(row["MENU_TYPE"]?.ToString());
            var tags = row["TAGS"]?.ToString();
            var tagText = string.IsNullOrWhiteSpace(tags) ? string.Empty : $" ({tags})";
            return string.IsNullOrWhiteSpace(typeDisplay)
                ? $"{menuName}{tagText}"
                : $"{menuName} [{typeDisplay}]{tagText}";
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

        private static DateTime? ToNullableDate(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToDateTime(value);
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
