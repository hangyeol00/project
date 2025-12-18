using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class DashboardForm : Form
    {
        private const string MealPlanStatusDraft = "DRAFT";
        private const string MealPlanStatusApproved = "APPROVED";
        private const string PurchaseStatusRequested = "REQUESTED";
        private const string PurchaseStatusApproved = "APPROVED";

        private readonly UserSession _session;
        private DateTime _currentServeDate = DateTime.Today;
        private bool _serveDateInitialized;
        private int? _selectedMealPlanId;
        private int? _selectedPurchaseRequestId;

        public DashboardForm(UserSession session)
        {
            try
            {
                _session = session;
                InitializeComponent();
                InitializeLayout();
                AttachEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DashboardForm 생성 중 오류: {ex.Message}\n\n{ex.StackTrace}", 
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void InitializeLayout()
        {
            try
            {
                ConfigureGrid(dgvTodayMeals);
                ConfigureGrid(dgvTodayRawNeeds);
                ConfigureGrid(dgvShortageRaw);
                ConfigureGrid(dgvMealLogs);

                if (txtStudentId != null) txtStudentId.ReadOnly = true;
                if (txtMenuCode != null) txtMenuCode.ReadOnly = true;

                ConfigureAccessByRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DashboardForm 레이아웃 초기화 중 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AttachEventHandlers()
        {
            Load += DashboardForm_Load;
            if (btnServeMeal != null) btnServeMeal.Click += BtnServeMeal_Click;
            if (btnCancelMeal != null) btnCancelMeal.Click += BtnCancelMeal_Click;
            if (btnMarkServed != null) btnMarkServed.Click += BtnMarkServed_Click;
            if (dgvMealLogs != null)
            {
                dgvMealLogs.CellClick += DgvMealLogs_CellClick;
            }
            if (dgvShortageRaw != null)
            {
                dgvShortageRaw.CellClick += DgvShortageRaw_CellClick;
            }
        }

        private void ConfigureAccessByRole()
        {
            var isAdmin = _session?.IsAdmin == true;
            if (btnServeMeal != null)
            {
                btnServeMeal.Text = isAdmin ? "식단 승인" : "식단 계획 등록";
            }
            if (btnCancelMeal != null)
            {
                btnCancelMeal.Text = isAdmin ? "발주 승인" : "발주 요청 등록";
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadAll()
        {
            try
            {
                EnsureServeDateInitialized();
                LoadSummary();
                LoadTodayMeals();
                LoadTodayRawNeeds();
                LoadShortageList();
                LoadMealPlans();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnsureServeDateInitialized()
        {
            if (_serveDateInitialized)
            {
                return;
            }

            _serveDateInitialized = true;
            var today = DateTime.Today;
            var sql = "SELECT NVL(MIN(MealDate), :P_TODAY) FROM Meal WHERE MealDate >= :P_TODAY";
            var nextMealDate = DatabaseHelper.ExecuteScalar(sql, new OracleParameter("P_TODAY", OracleDbType.Date) { Value = today });
            var resolved = nextMealDate == DBNull.Value ? today : Convert.ToDateTime(nextMealDate);
            SetServeDate(resolved);
        }

        private void SetServeDate(DateTime targetDate)
        {
            _currentServeDate = targetDate.Date;
            if (lblCurrentServeDate != null)
            {
                lblCurrentServeDate.Text = _currentServeDate.ToString("yyyy-MM-dd");
            }
            if (txtStudentId != null)
            {
                txtStudentId.Text = _currentServeDate.ToString("yyyy-MM-dd");
            }

            var today = DateTime.Today;
            var rawLabel = _currentServeDate == today
                ? "오늘 필요한 원재료"
                : $"{_currentServeDate:yyyy-MM-dd} 필요 원재료";
            var mealLabel = _currentServeDate == today
                ? "오늘의 식단"
                : $"{_currentServeDate:yyyy-MM-dd} 식단";

            if (grpTodayRaw != null)
            {
                grpTodayRaw.Text = rawLabel;
            }

            if (grpTodayMeals != null)
            {
                grpTodayMeals.Text = mealLabel;
            }
        }

        private DateTime GetNextMealDate(DateTime currentDate)
        {
            var sql = "SELECT MIN(MealDate) FROM Meal WHERE MealDate > :P_DATE";
            var next = DatabaseHelper.ExecuteScalar(sql, new OracleParameter("P_DATE", OracleDbType.Date) { Value = currentDate.Date });
            return next == DBNull.Value ? currentDate.Date : Convert.ToDateTime(next);
        }

        private void LoadSummary()
        {
            var todayMeals = DatabaseHelper.ToInt(
                DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM MEAL WHERE MealDate = :P_DATE",
                    new OracleParameter("P_DATE", OracleDbType.Date) { Value = _currentServeDate }));
            var pendingMealPlan = DatabaseHelper.ToInt(
                DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM MEALPLAN WHERE UPPER(STATUS) = :STATUS",
                    new OracleParameter("STATUS", MealPlanStatusDraft)));
            var pendingPurchase = DatabaseHelper.ToInt(
                DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM PURCHASEREQUEST WHERE UPPER(STATUS) <> :STATUS",
                    new OracleParameter("STATUS", PurchaseStatusApproved)));

            if (lblTotalStudentValue != null)
            {
                lblTotalStudentValue.Text = todayMeals.ToString();
            }
            if (lblTodayMealValue != null)
            {
                lblTodayMealValue.Text = pendingMealPlan.ToString();
            }
            if (lblNotMealValue != null)
            {
                lblNotMealValue.Text = pendingPurchase.ToString();
            }
            SetServeDate(_currentServeDate);
        }

        private void LoadTodayMeals()
        {
            if (dgvTodayMeals == null)
            {
                return;
            }

            const string sql =
                "SELECT m.MealID, m.MealDate, m.MealType, mp.PlanName, " +
                "       LISTAGG(f.MenuName, ', ') WITHIN GROUP (ORDER BY f.MenuName) AS Menus, " +
                "       m.Notes " +
                "FROM Meal m " +
                "JOIN MealPlan mp ON m.MealPlanID = mp.MealPlanID " +
                "LEFT JOIN MealComp mc ON m.MealID = mc.MealID " +
                "LEFT JOIN FinalMenu f ON mc.FinalMenuID = f.FinalMenuID " +
                "WHERE m.MealDate = :TARGETDATE " +
                "GROUP BY m.MealID, m.MealDate, m.MealType, mp.PlanName, m.Notes " +
                "ORDER BY m.MealDate, m.MealType";

            dgvTodayMeals.DataSource = DatabaseHelper.ExecuteDataTable(sql,
                new OracleParameter("TARGETDATE", OracleDbType.Date) { Value = _currentServeDate });
        }

        private void LoadTodayRawNeeds()
        {
            if (dgvTodayRawNeeds == null)
            {
                return;
            }

            const string sql =
                "WITH meal_base AS ( " +
                "    SELECT mc.MealID, mc.FinalMenuID, mc.PortionCount " +
                "    FROM Meal m JOIN MealComp mc ON m.MealID = mc.MealID " +
                "    WHERE m.MealDate = :TARGETDATE " +
                "), menu_raw AS ( " +
                "    SELECT mb.MealID, " +
                "           CASE WHEN mc.ComponentType = 'R' THEN mc.ComponentRawID ELSE ic.RawID END AS RawID, " +
                "           CASE WHEN mc.ComponentType = 'R' THEN mc.QuantityPerServing * mb.PortionCount " +
                "                ELSE (mc.QuantityPerServing / NULLIF(i.DefaultPortionGram, 0)) * ic.QuantityPerBatch * mb.PortionCount * (1 + NVL(ic.LossRatePct, 0) / 100) END AS NeedQty " +
                "    FROM meal_base mb " +
                "    JOIN MenuComp mc ON mb.FinalMenuID = mc.FinalMenuID " +
                "    LEFT JOIN Ingredient i ON mc.ComponentIngredientID = i.IngredientID " +
                "    LEFT JOIN IngredientComp ic ON mc.ComponentIngredientID = ic.IngredientID " +
                "    WHERE (mc.ComponentType = 'R' AND mc.ComponentRawID IS NOT NULL) " +
                "       OR (mc.ComponentType = 'I' AND mc.ComponentIngredientID IS NOT NULL) " +
                ") " +
                "SELECT r.RawName, NVL(MIN(c.CategoryName), '미분류') AS Category, r.PurchaseUnit, " +
                "       ROUND(SUM(NVL(mr.NeedQty, 0)), 2) AS NeededQty " +
                "FROM menu_raw mr " +
                "JOIN RawMaterial r ON mr.RawID = r.RawID " +
                "LEFT JOIN RawCategory c ON r.RawCategoryID = c.RawCategoryID " +
                "GROUP BY r.RawID, r.RawName, r.PurchaseUnit " +
                "ORDER BY NeededQty DESC, r.RawName";

            dgvTodayRawNeeds.DataSource = DatabaseHelper.ExecuteDataTable(sql,
                new OracleParameter("TARGETDATE", OracleDbType.Date) { Value = _currentServeDate });
        }

        private void LoadShortageList()
        {
            if (dgvShortageRaw == null)
            {
                return;
            }

            const string sql =
                "SELECT r.RawName, COUNT(*) AS PendingRequests, " +
                "       MIN(pr.ExpectedDeliveryDate) AS EarliestEta, " +
                "       MIN(pr.RequestedDate) AS FirstRequested " +
                "FROM PurchaseRequest pr " +
                "JOIN RawMaterial r ON pr.RawID = r.RawID " +
                "WHERE UPPER(pr.Status) = :STATUS " +
                "GROUP BY r.RawID, r.RawName " +
                "ORDER BY EarliestEta NULLS LAST, PendingRequests DESC, r.RawName";

            dgvShortageRaw.DataSource = DatabaseHelper.ExecuteDataTable(sql,
                new OracleParameter("STATUS", PurchaseStatusRequested));
        }

        private void LoadMealPlans()
        {
            if (dgvMealLogs == null)
            {
                return;
            }

            const string sql =
                "SELECT mp.MealPlanID, mp.PlanName, mp.PeriodStart, mp.PeriodEnd, mp.Status, " +
                "       NVL(u.UserName, mp.CreatedBy) AS CreatedByName " +
                "FROM MealPlan mp LEFT JOIN AppUser u ON mp.CreatedBy = u.UserID " +
                "ORDER BY mp.PeriodStart DESC, mp.MealPlanID DESC";

            dgvMealLogs.DataSource = DatabaseHelper.ExecuteDataTable(sql);
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

        private void DgvMealLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealLogs?.CurrentRow == null)
            {
                return;
            }

            SetSelectedMealPlanFromRow(dgvMealLogs.CurrentRow);
        }

        private void DgvShortageRaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dgvShortageRaw는 부족 원재료 목록을 표시하므로 특별한 선택 동작은 없음
            // 필요시 여기에 추가 로직 구현 가능
        }

        private void SetSelectedPurchaseRequestFromRow(DataGridViewRow row)
        {
            // dgvShortageRaw에는 PurchaseRequestID가 없으므로 이 메서드는 사용하지 않음
            // 필요시 PurchaseRequest를 별도로 로드해야 함
        }

        private void SetSelectedMealPlanFromRow(DataGridViewRow row)
        {
            if (row?.Cells["MEALPLANID"].Value == null)
            {
                _selectedMealPlanId = null;
                DisplaySelectedMealPlan();
                return;
            }

            _selectedMealPlanId = Convert.ToInt32(row.Cells["MEALPLANID"].Value);
            DisplaySelectedMealPlan();
        }

        private void DisplaySelectedMealPlan()
        {
            if (_selectedMealPlanId == null || dgvMealLogs?.CurrentRow == null)
            {
                if (txtMenuCode != null)
                {
                    txtMenuCode.Text = "선택 없음";
                }
                return;
            }

            var name = dgvMealLogs.CurrentRow.Cells["PLANNAME"].Value?.ToString() ?? string.Empty;
            var status = dgvMealLogs.CurrentRow.Cells["STATUS"].Value?.ToString() ?? string.Empty;
            if (txtMenuCode != null)
            {
                txtMenuCode.Text = $"{name} ({status})";
            }
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

        private void BtnMarkServed_Click(object sender, EventArgs e)
        {
            var nextDate = GetNextMealDate(_currentServeDate);
            if (nextDate.Date == _currentServeDate.Date)
            {
                MessageBox.Show("다음 식단 일정이 없습니다.", "안내");
                return;
            }

            SetServeDate(nextDate);
            LoadSummary();
            LoadTodayMeals();
            LoadTodayRawNeeds();
            LoadShortageList();
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
                        CreateMealPlan(input.PlanName, input.StartDate, input.EndDate);
                        MessageBox.Show("식단 계획이 등록되었습니다.", "완료");
                        ReloadAll();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"식단 계획 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
                    }
                }
            }
        }

        private void CreateMealPlan(string planName, DateTime startDate, DateTime endDate)
        {
            var nextId = GetNextId("MEALPLAN", "MEALPLANID");
            const string sql =
                "INSERT INTO MealPlan (MealPlanID, PlanName, PeriodStart, PeriodEnd, Status, CreatedBy) " +
                "VALUES (:ID, :NAME, :START, :END, :STATUS, :CREATEDBY)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("NAME", planName),
                new OracleParameter("START", startDate),
                new OracleParameter("END", endDate),
                new OracleParameter("STATUS", MealPlanStatusDraft),
                new OracleParameter("CREATEDBY", _session?.UserId ?? "SYSTEM"));
        }

        private void ApproveSelectedMealPlan()
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("승인할 식단을 선택해 주세요.", "안내");
                return;
            }

            var sql = "UPDATE MealPlan SET Status = :STATUS WHERE MealPlanID = :ID";
            try
            {
                var rows = DatabaseHelper.ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", MealPlanStatusApproved),
                    new OracleParameter("ID", _selectedMealPlanId));

                if (rows > 0)
                {
                    MessageBox.Show("식단이 승인되었습니다.", "완료");
                    ReloadAll();
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

            var rawMaterials = LoadRawMaterials();
            if (rawMaterials.Count == 0)
            {
                MessageBox.Show("등록된 원재료가 없습니다. 먼저 원재료를 등록해 주세요.", "안내");
                return;
            }

            using (var dialog = new PurchaseRequestDialog(rawMaterials, null))
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

        private List<RawMaterialOption> LoadRawMaterials()
        {
            const string sql =
                "SELECT r.RawID, r.RawName, r.PurchaseUnit " +
                "FROM RawMaterial r " +
                "WHERE r.ActiveFlag = 'Y' " +
                "ORDER BY r.RawName";

            var table = DatabaseHelper.ExecuteDataTable(sql);
            return (from DataRow row in table.Rows
                    select new RawMaterialOption(
                        Convert.ToInt32(row["RAWID"]),
                        row["RAWNAME"]?.ToString() ?? string.Empty,
                        row["PURCHASEUNIT"]?.ToString() ?? string.Empty)).ToList();
        }

        private void CreatePurchaseRequest(PurchaseRequestInput request)
        {
            var nextId = GetNextId("PURCHASEREQUEST", "PURCHASEREQUESTID");
            const string sql =
                "INSERT INTO PurchaseRequest (PurchaseRequestID, RawID, RawContractID, RequestedBy, RequestedDate, Quantity, " +
                "UnitPriceEstimate, ExpectedDeliveryDate, Status, Remark) " +
                "VALUES (:ID, :RAWID, :CONTRACTID, :REQUESTEDBY, :REQUESTEDDATE, :QTY, :PRICE, :EXPECTED, :STATUS, :REMARK)";

            DatabaseHelper.ExecuteNonQuery(sql,
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
                var rows = DatabaseHelper.ExecuteNonQuery(sql,
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
            return DatabaseHelper.ToInt(DatabaseHelper.ExecuteScalar(sql));
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
    }
}

