using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class RecipesForm : Form
    {
        private readonly UserSession _session;
        private DataTable _recipeTable;
        private int? _selectedRecipeId;

        public RecipesForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvRecipes);
            ConfigureGrid(dgvRecipeNutrients);
            ConfigureGrid(dgvRecipeComponents);
            if (txtRecipeName != null) txtRecipeName.ReadOnly = true;
            if (txtRecipeCode != null) txtRecipeCode.ReadOnly = true;
            if (txtRecipeType != null) txtRecipeType.ReadOnly = true;
            if (txtRecipeServing != null) txtRecipeServing.ReadOnly = true;
            if (txtRecipeActive != null) txtRecipeActive.ReadOnly = true;
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
            Load += RecipesForm_Load;
            if (dgvRecipes != null)
            {
                dgvRecipes.CellClick += DgvRecipes_CellClick;
            }
            if (btnRefreshRecipe != null)
            {
                btnRefreshRecipe.Click += BtnRefreshRecipe_Click;
            }
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            const string sql =
                "SELECT FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag " +
                "FROM FinalMenu ORDER BY MenuName";

            _recipeTable = DatabaseHelper.ExecuteDataTable(sql);
            if (dgvRecipes != null)
            {
                dgvRecipes.DataSource = _recipeTable;
            }
        }

        private void DgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRecipes?.CurrentRow == null) return;
            DisplayRecipe(dgvRecipes.CurrentRow);
        }

        private void DisplayRecipe(DataGridViewRow row)
        {
            if (row?.Cells["FINALMENUID"]?.Value == null)
            {
                _selectedRecipeId = null;
                return;
            }

            _selectedRecipeId = Convert.ToInt32(row.Cells["FINALMENUID"].Value);
            if (txtRecipeName != null)
            {
                txtRecipeName.Text = row.Cells["MENUNAME"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtRecipeCode != null)
            {
                txtRecipeCode.Text = row.Cells["MENUCODE"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtRecipeType != null)
            {
                txtRecipeType.Text = row.Cells["MENUTYPE"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtRecipeServing != null)
            {
                txtRecipeServing.Text = row.Cells["SERVINGSIZEGRAM"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtRecipeActive != null)
            {
                var active = row.Cells["ACTIVEFLAG"]?.Value?.ToString();
                txtRecipeActive.Text = string.Equals(active, "Y", StringComparison.OrdinalIgnoreCase) ? "사용" : "중지";
            }

            if (_selectedRecipeId.HasValue)
            {
                LoadRecipeNutrients(_selectedRecipeId.Value);
                LoadRecipeComponents(_selectedRecipeId.Value);
            }
        }

        private void LoadRecipeNutrients(int finalMenuId)
        {
            if (dgvRecipeNutrients == null) return;

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
                "       ROUND(SUM(NVL(rn.AmountPerBase / NULLIF(r.BaseUnitQty, 0), 0) * NVL(rc.QuantityGram, 0)), 3) AS 함량 " +
                "FROM raw_component rc " +
                "JOIN RawMaterial r ON rc.RawID = r.RawID " +
                "JOIN RawNutrient rn ON rn.RawID = r.RawID " +
                "JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE rc.FinalMenuID = :ID " +
                "GROUP BY n.NutrientName, n.Unit " +
                "ORDER BY n.NutrientName";

            dgvRecipeNutrients.DataSource = DatabaseHelper.ExecuteDataTable(sql, new OracleParameter("ID", finalMenuId));
        }

        private void LoadRecipeComponents(int finalMenuId)
        {
            if (dgvRecipeComponents == null) return;

            const string sql =
                "WITH base_component AS ( " +
                "    SELECT mc.FinalMenuID, mc.ComponentType, mc.ComponentRawID, mc.ComponentIngredientID, " +
                "           NVL(mc.QuantityPerServing, 0) AS Qty " +
                "    FROM MenuComp mc WHERE mc.FinalMenuID = :ID " +
                "), raw_component AS ( " +
                "    SELECT bc.FinalMenuID, bc.ComponentRawID AS RawID, CAST(bc.Qty AS NUMBER(18,6)) AS QuantityGram " +
                "    FROM base_component bc WHERE bc.ComponentType = 'R' AND bc.ComponentRawID IS NOT NULL " +
                "    UNION ALL " +
                "    SELECT bc.FinalMenuID, ic.RawID, " +
                "           CAST(bc.Qty * (NVL(ic.QuantityPerBatch, 0) / NULLIF(i.BatchYieldGram, 0)) AS NUMBER(18,6)) AS QuantityGram " +
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
                "SELECT r.RawName AS RawName, ROUND(a.QuantityGram, 3) AS QuantityPerServing, r.PurchaseUnit AS PurchaseUnit " +
                "FROM aggregated a " +
                "JOIN RawMaterial r ON a.RawID = r.RawID " +
                "WHERE a.FinalMenuID = :ID " +
                "ORDER BY r.RawName";

            dgvRecipeComponents.DataSource = DatabaseHelper.ExecuteDataTable(sql, new OracleParameter("ID", finalMenuId));
        }

        private void BtnRefreshRecipe_Click(object sender, EventArgs e)
        {
            LoadRecipes();
        }
    }
}

