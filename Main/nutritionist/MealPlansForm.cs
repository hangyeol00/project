using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class MealPlansForm : Form
    {
        private readonly UserSession _session;
        private int? _selectedMealPlanId;

        public MealPlansForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvMealPlans);
            ConfigureGrid(dgvMealRecipes);
            ConfigureGrid(dgvMealComponents);
            if (cmbMealType != null)
            {
                cmbMealType.Items.AddRange(new[] { "조식", "중식", "석식" });
                if (cmbMealType.Items.Count > 0) cmbMealType.SelectedIndex = 0;
            }
            if (dtpMealDate != null)
            {
                dtpMealDate.Value = DateTime.Today;
            }
        }

        private static void ConfigureGrid(DataGridView grid)
        {
            if (grid == null) return;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AttachEventHandlers()
        {
            Load += MealPlansForm_Load;
            if (dgvMealPlans != null)
            {
                dgvMealPlans.CellClick += DgvMealPlans_CellClick;
            }
            if (dtpMealDate != null)
            {
                dtpMealDate.ValueChanged += InputMeal_Changed;
            }
            if (cmbMealType != null)
            {
                cmbMealType.SelectedIndexChanged += InputMeal_Changed;
            }
            if (dgvMealRecipes != null)
            {
                dgvMealRecipes.CellClick += DgvMealRecipes_CellClick;
            }
        }

        private void MealPlansForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMealPlans();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadMealPlans();
        }

        private void LoadMealPlans()
        {
            const string sql =
                "SELECT mp.MealPlanID, mp.PeriodStart, mp.PeriodEnd, mp.Status, " +
                "       NVL(u.UserName, mp.CreatedBy) AS CreatedByName " +
                "FROM MealPlan mp LEFT JOIN AppUser u ON mp.CreatedBy = u.UserID " +
                "ORDER BY mp.PeriodStart DESC, mp.MealPlanID DESC";

            if (dgvMealPlans != null)
            {
                dgvMealPlans.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvMealPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealPlans?.CurrentRow == null) return;
            var row = dgvMealPlans.CurrentRow;
            if (row.Cells["MEALPLANID"]?.Value != null)
            {
                _selectedMealPlanId = Convert.ToInt32(row.Cells["MEALPLANID"].Value);
                LoadMealRecipes();
            }
        }

        private void DgvMealRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealRecipes?.Rows[e.RowIndex] == null) return;
            var row = dgvMealRecipes.Rows[e.RowIndex];
            if (row.Cells["FINALMENUID"]?.Value != null)
            {
                var menuId = Convert.ToInt32(row.Cells["FINALMENUID"].Value);
                LoadMealComponents(menuId);
            }
        }

        private void LoadMealRecipes()
        {
            if (dgvMealRecipes == null || !_selectedMealPlanId.HasValue) return;
            if (dtpMealDate == null || cmbMealType == null) return;

            var date = dtpMealDate.Value.Date;
            var type = cmbMealType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(type)) return;

            var dbType = type == "조식" ? "BREAKFAST" : type == "중식" ? "LUNCH" : "DINNER";

            const string sql =
                "SELECT r.FinalMenuID, r.MenuCode, r.MenuName, r.MenuType, r.ServingSizeGram " +
                "FROM Meal m " +
                "JOIN MealComp mc ON m.MealID = mc.MealID " +
                "JOIN FinalMenu r ON mc.FinalMenuID = r.FinalMenuID " +
                "WHERE m.MealPlanID = :planId AND m.MealDate = :mDate AND m.MealType = :mType " +
                "ORDER BY r.MenuName";

            dgvMealRecipes.DataSource = DatabaseHelper.ExecuteDataTable(sql,
                new OracleParameter("planId", _selectedMealPlanId),
                new OracleParameter("mDate", date),
                new OracleParameter("mType", dbType));
        }

        private void LoadMealComponents(int finalMenuId)
        {
            if (dgvMealComponents == null) return;

            const string sql =
                "SELECT i.IngredientName AS ItemName, '재료' AS ItemType, mc.QuantityPerServing, i.DefaultPortionGram AS StdQty " +
                "FROM MenuComp mc " +
                "JOIN Ingredient i ON mc.ComponentIngredientID = i.IngredientID " +
                "WHERE mc.FinalMenuID = :id AND mc.ComponentType = 'I' " +
                "UNION ALL " +
                "SELECT r.RawName AS ItemName, '원재료' AS ItemType, mc.QuantityPerServing, r.BaseUnitQty AS StdQty " +
                "FROM MenuComp mc " +
                "JOIN RawMaterial r ON mc.ComponentRawID = r.RawID " +
                "WHERE mc.FinalMenuID = :id AND mc.ComponentType = 'R'";

            dgvMealComponents.DataSource = DatabaseHelper.ExecuteDataTable(sql, new OracleParameter("id", finalMenuId));
        }

        private void InputMeal_Changed(object sender, EventArgs e)
        {
            LoadMealRecipes();
            if (dgvMealComponents != null) dgvMealComponents.DataSource = null;
        }
    }
}

