using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class RawMaterialsForm : Form
    {
        private readonly UserSession _session;
        private DataTable _rawMaterialTable;
        private int? _selectedRawMaterialId;
        private readonly HashSet<string> _collapsedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public RawMaterialsForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            try
            {
                ConfigureGrid(dgvRawMaterials);
                ConfigureGrid(dgvRawNutrients);
                ConfigureGrid(dgvRawComponents);
                
                if (txtRawDetailName != null) txtRawDetailName.ReadOnly = true;
                if (txtRawDetailCategory != null) txtRawDetailCategory.ReadOnly = true;
                if (txtRawDetailUnit != null) txtRawDetailUnit.ReadOnly = true;
                if (txtRawDetailBaseQty != null) txtRawDetailBaseQty.ReadOnly = true;
                if (txtRawDetailStorage != null) txtRawDetailStorage.ReadOnly = true;
                if (txtRawDetailShelfLife != null) txtRawDetailShelfLife.ReadOnly = true;
                if (txtRawDetailActive != null) txtRawDetailActive.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"RawMaterialsForm 초기화 중 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Load += RawMaterialsForm_Load;
            if (dgvRawMaterials != null)
            {
                dgvRawMaterials.CellClick += DgvRawMaterials_CellClick;
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
        }

        private void RawMaterialsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRawMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadRawMaterials();
        }

        private void LoadRawMaterials()
        {
            const string sql =
                "SELECT 'RAW' AS ITEMTYPE, r.RawID AS RAWID, r.RawName, c.CategoryName, r.PurchaseUnit, r.BaseUnitQty, " +
                "       r.StorageType, r.ShelfLifeDays, r.ActiveFlag, NULL AS IngredientType, NULL AS BatchYieldGram, NULL AS DefaultPortionGram " +
                "FROM RawMaterial r LEFT JOIN RawCategory c ON r.RawCategoryID = c.RawCategoryID " +
                "UNION ALL " +
                "SELECT 'ING' AS ITEMTYPE, i.IngredientID AS RAWID, i.IngredientName AS RAWNAME, i.Type AS CategoryName, '조합' AS PurchaseUnit, " +
                "       i.BatchYieldGram AS BaseUnitQty, NULL AS StorageType, NULL AS ShelfLifeDays, i.ActiveFlag, i.Type AS IngredientType, " +
                "       i.BatchYieldGram, i.DefaultPortionGram " +
                "FROM Ingredient i " +
                "ORDER BY RawName";

            _rawMaterialTable = DatabaseHelper.ExecuteDataTable(sql);
            if (dgvRawMaterials != null)
            {
                dgvRawMaterials.DataSource = _rawMaterialTable;
            }
        }

        private void DgvRawMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRawMaterials?.Rows == null || e.RowIndex >= dgvRawMaterials.Rows.Count)
            {
                return;
            }

            var row = dgvRawMaterials.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row?.Row == null)
            {
                return;
            }

            DisplayRawMaterial(row.Row);
        }

        private void DisplayRawMaterial(DataRow row)
        {
            if (row == null)
            {
                if (txtRawDetailName != null) txtRawDetailName.Text = "선택 없음";
                return;
            }

            var rawId = DatabaseHelper.ToInt(row["RAWID"]);
            _selectedRawMaterialId = rawId;

            if (txtRawDetailName != null)
            {
                txtRawDetailName.Text = row["RAWNAME"]?.ToString() ?? string.Empty;
            }
            if (txtRawDetailCategory != null)
            {
                txtRawDetailCategory.Text = row["CATEGORYNAME"]?.ToString() ?? string.Empty;
            }
            if (txtRawDetailUnit != null)
            {
                txtRawDetailUnit.Text = row["PURCHASEUNIT"]?.ToString() ?? string.Empty;
            }
            if (txtRawDetailBaseQty != null)
            {
                txtRawDetailBaseQty.Text = FormatDecimal(row["BASEUNITQTY"]);
            }
            if (txtRawDetailStorage != null)
            {
                txtRawDetailStorage.Text = row["STORAGETYPE"]?.ToString() ?? string.Empty;
            }
            if (txtRawDetailShelfLife != null)
            {
                txtRawDetailShelfLife.Text = FormatShelfLife(row["SHELFLIFEDAYS"]);
            }
            if (txtRawDetailActive != null)
            {
                txtRawDetailActive.Text = FormatActiveFlag(row["ACTIVEFLAG"]);
            }

            LoadRawNutrients(rawId);
            LoadRawComponents(rawId);
        }

        private void LoadRawNutrients(int rawId)
        {
            if (dgvRawNutrients == null) return;

            const string sql =
                "SELECT n.NutrientName AS 영양소, n.Unit AS 단위, rn.AmountPerBase AS 함량 " +
                "FROM RawNutrient rn INNER JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE rn.RawID = :RAWID ORDER BY n.NutrientName";

            dgvRawNutrients.DataSource = DatabaseHelper.ExecuteDataTable(sql, new OracleParameter("RAWID", rawId));
        }

        private void LoadRawComponents(int rawId)
        {
            if (dgvRawComponents == null) return;

            // Ingredient인 경우에만 원재료 목록 표시
            const string sql =
                "SELECT r.RawName AS 원재료명, ic.QuantityPerBatch AS 배치당수량, r.PurchaseUnit AS 구매단위 " +
                "FROM IngredientComp ic " +
                "JOIN RawMaterial r ON ic.RawID = r.RawID " +
                "WHERE ic.IngredientID = :INGREDIENTID " +
                "ORDER BY r.RawName";

            var table = DatabaseHelper.ExecuteDataTable(sql, new OracleParameter("INGREDIENTID", rawId));
            if (table.Rows.Count == 0)
            {
                dgvRawComponents.DataSource = null;
            }
            else
            {
                dgvRawComponents.DataSource = table;
            }
        }

        private static string FormatDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return string.Empty;
            return Convert.ToDecimal(value).ToString("#,##0.###");
        }

        private static string FormatShelfLife(object value)
        {
            if (value == null || value == DBNull.Value) return "-";
            return $"{Convert.ToInt32(value)}일";
        }

        private static string FormatActiveFlag(object value)
        {
            var text = value?.ToString();
            if (string.Equals(text, "Y", StringComparison.OrdinalIgnoreCase)) return "사용";
            if (string.Equals(text, "N", StringComparison.OrdinalIgnoreCase)) return "중지";
            return text ?? string.Empty;
        }

        private void BtnRawAdd_Click(object sender, EventArgs e)
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
                    if (dialog.ShowDialog(this) == DialogResult.OK && dialog.Result != null)
                    {
                        CreateRawMaterial(dialog.Result);
                        MessageBox.Show("원재료가 등록되었습니다.", "완료");
                        LoadRawMaterials();
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"원재료 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void BtnRawRefresh_Click(object sender, EventArgs e)
        {
            LoadRawMaterials();
        }

        private void BtnRawSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRawClear_Click(object sender, EventArgs e)
        {
            if (txtRawSearch != null) txtRawSearch.Clear();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_rawMaterialTable == null || dgvRawMaterials == null) return;

            var search = txtRawSearch?.Text?.Trim();
            if (string.IsNullOrWhiteSpace(search))
            {
                dgvRawMaterials.DataSource = _rawMaterialTable;
                return;
            }

            var filtered = _rawMaterialTable.Clone();
            foreach (DataRow row in _rawMaterialTable.Rows)
            {
                var name = row["RAWNAME"]?.ToString() ?? string.Empty;
                if (name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filtered.ImportRow(row);
                }
            }
            dgvRawMaterials.DataSource = filtered;
        }

        private List<RawCategoryOption> GetRawCategories()
        {
            const string sql =
                "SELECT RawCategoryID, CategoryName FROM RawCategory " +
                "WHERE NVL(ActiveFlag, 'Y') = 'Y' ORDER BY CategoryName";

            var table = DatabaseHelper.ExecuteDataTable(sql);
            return (from DataRow row in table.Rows
                    select new RawCategoryOption(
                        Convert.ToInt32(row["RAWCATEGORYID"]),
                        row["CATEGORYNAME"]?.ToString() ?? string.Empty)).ToList();
        }

        private void CreateRawMaterial(RawMaterialInput input)
        {
            var nextId = GetNextId("RAWMATERIAL", "RAWID");
            const string sql =
                "INSERT INTO RawMaterial (RawID, RawName, RawCategoryID, PurchaseUnit, BaseUnitQty, StorageType, ShelfLifeDays, ActiveFlag) " +
                "VALUES (:ID, :NAME, :CATEGORY, :UNIT, :BASEQTY, :STORAGE, :SHELFLIFE, :ACTIVE)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new OracleParameter("ID", nextId),
                new OracleParameter("NAME", input.RawName),
                new OracleParameter("CATEGORY", input.RawCategoryId),
                new OracleParameter("UNIT", input.PurchaseUnit),
                new OracleParameter("BASEQTY", input.BaseUnitQty),
                new OracleParameter("STORAGE", string.IsNullOrWhiteSpace(input.StorageType)
                    ? (object)DBNull.Value
                    : input.StorageType),
                new OracleParameter("SHELFLIFE", input.ShelfLifeDays.HasValue
                    ? (object)input.ShelfLifeDays.Value
                    : DBNull.Value),
                new OracleParameter("ACTIVE", input.ActiveFlag ? "Y" : "N"));
        }

        private int GetNextId(string tableName, string columnName)
        {
            var sql = $"SELECT NVL(MAX({columnName}), 0) + 1 FROM {tableName}";
            return DatabaseHelper.ToInt(DatabaseHelper.ExecuteScalar(sql));
        }
    }
}

