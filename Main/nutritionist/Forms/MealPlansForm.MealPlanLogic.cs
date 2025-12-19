using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist.Forms
{
    public partial class MealPlansForm
    {
        private const string MealPlanStatusDraft = "DRAFT";
        private const string MealPlanStatusPending = "PENDING";
        private const string MealPlanStatusApproved = "APPROVED";
        private const int DefaultMealPortion = 100;
        private static readonly string[] WeekdayNames = { "월", "화", "수", "목", "금" };

        private readonly BindingList<FinalMenuOption> _selectedMealMenus = new BindingList<FinalMenuOption>();
        private readonly Dictionary<string, List<FinalMenuOption>> _mealPlanSelections = new Dictionary<string, List<FinalMenuOption>>();
        private readonly List<MealPlanInfo> _mealPlans = new List<MealPlanInfo>();
        private readonly BindingList<MealPlanInfo> _weekMealPlanOptions = new BindingList<MealPlanInfo>();
        private readonly List<WeekOption> _mealWeekOptions = new List<WeekOption>();
        private readonly Dictionary<int, HashSet<int>> _menuAllergyMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, List<MenuAllergyDetail>> _menuAllergyDetails = new Dictionary<int, List<MenuAllergyDetail>>();
        private readonly Dictionary<int, string> _allergyNameLookup = new Dictionary<int, string>();
        private readonly Dictionary<int, int> _allergyConsumerCounts = new Dictionary<int, int>();
        private readonly Dictionary<string, List<AlternativeAssignment>> _pendingAltAssignments = new Dictionary<string, List<AlternativeAssignment>>();
        private readonly BindingList<NutrientSummaryRow> _nutrientSummary = new BindingList<NutrientSummaryRow>();

        private MealPlanInfo _selectedMealPlanInfo;
        private int? _selectedMealPlanId;
        private WeekOption _selectedWeekOption;
        private DateTime? _currentPlanStart;
        private DateTime? _currentPlanEnd;
        private readonly DateTime[] _currentWeekDates = new DateTime[5];
        private int _selectedWeekdayIndex = -1;
        private string _currentMealPlanStatus;
        private bool _isCurrentWeekComplete;
        private bool _isWeekWithinPlanPeriod;
        private bool _suppressMealBoardUpdate;
        private bool _suppressWeekChange;
        private bool _suppressPlanListSelection;
        private DateTime? _pendingWeekDate;
        private ContextMenuStrip _allergyAlertMenu;
        private ToolStripMenuItem _menuAssignAlternative;

        public event Action MealPlansChanged;

        private void InitializeMealPlanControls()
        {
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

            if (dgvMealNutrition != null)
            {
                dgvMealNutrition.AutoGenerateColumns = false;
                dgvMealNutrition.DataSource = _nutrientSummary;
                dgvMealNutrition.CellFormatting += DgvMealNutrition_CellFormatting;
            }

            InitializeMealPlannerControls();
            InitializePlanSelectionControls();
            ConfigureAccessByRole();
            LoadMenuAllergySummary();
            LoadAllergyConsumerCounts();
            LoadMealPlans();
        }

        public void ConfigureAccessByRole()
        {
            var isAdmin = _session?.IsAdmin == true;

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

        public void ReloadData()
        {
            _pendingAltAssignments.Clear();
            LoadFinalMenus();
            LoadMenuTags();
            LoadMenuAllergySummary();
            LoadAllergyConsumerCounts();
            LoadMealPlans();
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
                OnMealPlansChanged();
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

            return _finalMenuOptions.FirstOrDefault(menu => menu.FinalMenuId == menuId);
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

        public void OpenMealPlanDialogFromHost()
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
                        ReloadData();
                        SelectMealPlanById(planId);
                        OnMealPlansChanged();
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
                    ReloadData();
                    SelectMealPlanById(planId);
                    OnMealPlansChanged();
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
                        OnMealPlansChanged();
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

        public void ApproveSelectedMealPlan()
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("승인할 식단 계획을 선택해 주세요.", "안내");
                return;
            }

            var status = _selectedMealPlanInfo?.Status ?? _currentMealPlanStatus;
            if (!string.Equals(status, MealPlanStatusPending, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("승인 대기 상태인 식단만 승인할 수 있습니다.", "안내");
                return;
            }

            var confirm = MessageBox.Show("선택한 식단 계획을 승인하시겠습니까?", "식단 승인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            const string sql = "UPDATE MealPlan SET Status = :STATUS WHERE MealPlanID = :ID";
            try
            {
                var planId = _selectedMealPlanId.Value;
                var rows = ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", MealPlanStatusApproved),
                    new OracleParameter("ID", planId));

                if (rows > 0)
                {
                    MessageBox.Show("식단 계획이 승인되었습니다.", "완료");
                    ReloadData();
                    SelectMealPlanById(planId);
                    OnMealPlansChanged();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"식단 승인 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
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
            // 디버그용 알림 모달 제거: 리스트에서만 표시
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

        private bool EnsureDietitianAccess()
        {
            if (_session?.IsAdmin == true)
            {
                MessageBox.Show("관리자 계정에서는 해당 작업을 수행할 수 없습니다.", "권한 없음");
                return false;
            }

            return true;
        }

        private static DataRow GetDataRowFromGrid(DataGridViewRow gridRow)
        {
            return (gridRow?.DataBoundItem as DataRowView)?.Row;
        }

        private int GetNextId(string tableName, string columnName)
        {
            var sql = $"SELECT NVL(MAX({columnName}), 0) + 1 FROM {tableName}";
            return ToInt(ExecuteScalar(sql));
        }

        private static DateTime? ToNullableDate(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToDateTime(value);
        }

        private void OnMealPlansChanged()
        {
            MealPlansChanged?.Invoke();
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
                    var statusText = MealPlansForm.GetMealPlanStatusDisplayText(Status);
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
