using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist.Forms
{
    public partial class RawMaterialsForm
    {
        private readonly List<RawMaterialOption> _rawMaterials = new List<RawMaterialOption>();
        private readonly Dictionary<int, HashSet<string>> _rawNutrientCodes = new Dictionary<int, HashSet<string>>();
        private readonly Dictionary<int, decimal> _rawCalorieMap = new Dictionary<int, decimal>();
        private readonly HashSet<string> _collapsedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
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

        private DataTable _rawMaterialTable;
        private int? _selectedRawMaterialId;

        public IReadOnlyList<RawMaterialOption> RawMaterials => _rawMaterials;
        public DataTable RawMaterialTable => _rawMaterialTable;
        public int? SelectedRawMaterialId => _selectedRawMaterialId;

        private Panel PanelRawToolbar => panelRawToolbar;
        private FlowLayoutPanel FlowRawCalorieFilter => flowRawCalorieFilter;
        private Label LblRawCalorie => lblRawCalorie;
        private NumericUpDown NudRawCalorieMin => nudRawCalorieMin;
        private Label LblRawCalorieSeparator => lblRawCalorieSeparator;
        private NumericUpDown NudRawCalorieMax => nudRawCalorieMax;
        private Label LblRawCalorieUnit => lblRawCalorieUnit;
        private FlowLayoutPanel FlowRawNutrientFilters => flowRawNutrientFilters;
        private Label LblRawNutrientFilter => lblRawNutrientFilter;
        private CheckBox ChkRawNutrientProtein => chkRawNutrientProtein;
        private CheckBox ChkRawNutrientFat => chkRawNutrientFat;
        private CheckBox ChkRawNutrientCarb => chkRawNutrientCarb;
        private CheckBox ChkRawGroup => chkRawGroup;
        private Button BtnRawClear => btnRawClear;
        private Button BtnRawSearch => btnRawSearch;
        private TextBox TxtRawSearch => txtRawSearch;
        private Label LblRawSearch => lblRawSearch;
        private TreeView TvRawMaterials => tvRawMaterials;
        private DataGridView DgvRawMaterials => dgvRawMaterials;
        private GroupBox GrpRawDetail => grpRawDetail;
        private TextBox TxtRawDetailName => txtRawDetailName;
        private TextBox TxtRawDetailCategory => txtRawDetailCategory;
        private TextBox TxtRawDetailUnit => txtRawDetailUnit;
        private TextBox TxtRawDetailBaseQty => txtRawDetailBaseQty;
        private TextBox TxtRawDetailUnitGram => txtRawDetailUnitGram;
        private TextBox TxtRawDetailStorage => txtRawDetailStorage;
        private TextBox TxtRawDetailShelfLife => txtRawDetailShelfLife;
        private TextBox TxtRawDetailActive => txtRawDetailActive;
        private DataGridView DgvRawNutrients => dgvRawNutrients;
        private DataGridView DgvRawComponents => dgvRawComponents;
        private Button BtnRawAdd => btnRawAdd;
        private Button BtnRawRefresh => btnRawRefresh;

        private void InitializeLogic()
        {
            ConfigureGrid(DgvRawMaterials);
            ConfigureGrid(DgvRawNutrients);
            ConfigureGrid(DgvRawComponents);

            if (TvRawMaterials != null)
            {
                TvRawMaterials.Visible = false;
            }

            if (TxtRawDetailName != null) TxtRawDetailName.ReadOnly = true;
            if (TxtRawDetailCategory != null) TxtRawDetailCategory.ReadOnly = true;
            if (TxtRawDetailUnit != null) TxtRawDetailUnit.ReadOnly = true;
            if (TxtRawDetailBaseQty != null) TxtRawDetailBaseQty.ReadOnly = true;
            if (TxtRawDetailUnitGram != null) TxtRawDetailUnitGram.ReadOnly = true;
            if (TxtRawDetailStorage != null) TxtRawDetailStorage.ReadOnly = true;
            if (TxtRawDetailShelfLife != null) TxtRawDetailShelfLife.ReadOnly = true;
            if (TxtRawDetailActive != null) TxtRawDetailActive.ReadOnly = true;

            if (DgvRawMaterials != null)
            {
                DgvRawMaterials.CellClick += DgvRawMaterials_CellClick;
                DgvRawMaterials.CellFormatting += DgvRawMaterials_CellFormatting;
            }

            if (BtnRawAdd != null)
            {
                BtnRawAdd.Click += BtnRawAdd_Click;
            }

            if (BtnRawRefresh != null)
            {
                BtnRawRefresh.Click += BtnRawRefresh_Click;
            }

            if (BtnRawSearch != null)
            {
                BtnRawSearch.Click += BtnRawSearch_Click;
            }

            if (BtnRawClear != null)
            {
                BtnRawClear.Click += BtnRawClear_Click;
            }

            if (ChkRawGroup != null)
            {
                ChkRawGroup.CheckedChanged += ChkRawGroup_CheckedChanged;
            }

            if (TxtRawSearch != null)
            {
                TxtRawSearch.KeyDown += TxtRawSearch_KeyDown;
            }

            AttachRawFilterEvents();
        }

        public void ReloadRawMaterials()
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

            _rawMaterials.Clear();
            _rawMaterials.AddRange(
                from DataRow row in table.Rows
                where string.Equals(row["ITEMTYPE"]?.ToString(), "RAW", StringComparison.OrdinalIgnoreCase)
                select new RawMaterialOption(
                    Convert.ToInt32(row["RAWID"]),
                    row["RAWNAME"]?.ToString() ?? string.Empty,
                    row["PURCHASEUNIT"]?.ToString() ?? string.Empty));

            LoadRawNutrientSummary();

            if (table.Rows.Count > 0)
            {
                _selectedRawMaterialId = null;
            }
            else
            {
                _selectedRawMaterialId = null;
                DisplayManagedRawMaterial(null);
            }

            ApplyRawMaterialView();
        }

        public void ApplyRawMaterialView()
        {
            if (_rawMaterialTable == null || DgvRawMaterials == null)
            {
                return;
            }

            var filteredRows = GetFilteredRawRows().ToList();
            var useGrouping = ChkRawGroup?.Checked == true;

            var viewTable = CreateRawMaterialViewTable(filteredRows, useGrouping);
            DgvRawMaterials.DataSource = viewTable;
            ConfigureRawGridColumns();

            DataRow firstDataRow = null;
            foreach (DataRow row in viewTable.Rows)
            {
                if (IsGroupRow(row))
                {
                    continue;
                }

                firstDataRow = row;
                break;
            }

            if (firstDataRow != null && DgvRawMaterials.Rows.Count > 0)
            {
                var index = viewTable.Rows.IndexOf(firstDataRow);
                if (index >= 0 && index < DgvRawMaterials.Rows.Count)
                {
                    DgvRawMaterials.ClearSelection();
                    DgvRawMaterials.Rows[index].Selected = true;
                }

                DisplayManagedRawMaterial(firstDataRow);
            }
            else
            {
                DisplayManagedRawMaterial((DataRow)null);
            }
        }

        public bool TrySelectRawMaterial(int rawId)
        {
            if (DgvRawMaterials == null || rawId <= 0)
            {
                return false;
            }

            foreach (DataGridViewRow gridRow in DgvRawMaterials.Rows)
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

                DgvRawMaterials.ClearSelection();
                gridRow.Selected = true;

                var currentCell = gridRow.Cells.Cast<DataGridViewCell>()
                    .FirstOrDefault(c => c.Visible) ?? gridRow.Cells.Cast<DataGridViewCell>().FirstOrDefault();
                if (currentCell != null)
                {
                    DgvRawMaterials.CurrentCell = currentCell;
                }

                try
                {
                    DgvRawMaterials.FirstDisplayedScrollingRowIndex = gridRow.Index;
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

        public void AddRawMaterial()
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
                    ReloadRawMaterials();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"원재료 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
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

                if (string.Equals(code, "CAL", StringComparison.OrdinalIgnoreCase) &&
                    row["AMOUNT"] != DBNull.Value)
                {
                    _rawCalorieMap[rawId] = Convert.ToDecimal(row["AMOUNT"]);
                }
            }
        }

        private IEnumerable<DataRow> GetFilteredRawRows()
        {
            if (_rawMaterialTable == null)
            {
                return Enumerable.Empty<DataRow>();
            }

            var search = TxtRawSearch?.Text?.Trim();
            var rows = _rawMaterialTable.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                rows = rows.Where(r =>
                    (r["RAWNAME"]?.ToString() ?? string.Empty)
                        .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var requiredNutrients = GetSelectedRawNutrients().ToList();
            var minCalorie = GetNumericFilterValue(NudRawCalorieMin);
            var maxCalorie = GetNumericFilterValue(NudRawCalorieMax);
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
                    if (!_rawCalorieMap.TryGetValue(rawId, out var calorie))
                    {
                        return false;
                    }

                    if (minCalorie.HasValue && calorie < minCalorie.Value)
                    {
                        return false;
                    }

                    if (maxCalorie.HasValue && calorie > maxCalorie.Value)
                    {
                        return false;
                    }

                    return true;
                });
            }

            return rows;
        }

        private DataTable CreateRawMaterialViewTable(IReadOnlyCollection<DataRow> rows, bool useGrouping)
        {
            var table = _rawMaterialTable.Clone();
            table.Columns.Add("ISGROUPROW", typeof(bool));
            table.Columns.Add("GROUPNAME", typeof(string));
            table.Columns["GROUPNAME"].Caption = "분류";

            if (!useGrouping)
            {
                foreach (var row in rows)
                {
                    CopyRawRow(row, table.NewRow());
                }

                return table;
            }

            var byCategory = rows.GroupBy(r => r["CATEGORYNAME"]?.ToString() ?? string.Empty)
                .OrderBy(g => g.Key);

            foreach (var group in byCategory)
            {
                var groupRow = table.NewRow();
                groupRow["ISGROUPROW"] = true;
                groupRow["GROUPNAME"] = group.Key;
                groupRow["RAWNAME"] = group.Key;
                table.Rows.Add(groupRow);

                var collapsed = _collapsedCategories.Contains(group.Key);
                if (collapsed)
                {
                    continue;
                }

                foreach (var row in group)
                {
                    CopyRawRow(row, table.NewRow());
                }
            }

            return table;
        }

        private void DgvRawMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || DgvRawMaterials?.Rows == null || e.RowIndex >= DgvRawMaterials.Rows.Count)
            {
                return;
            }

            var row = GetDataRowFromGrid(DgvRawMaterials.Rows[e.RowIndex]);
            if (IsGroupRow(row))
            {
                ToggleCategoryCollapse(row["GROUPNAME"]?.ToString());
                return;
            }

            DisplayManagedRawMaterial(row);
        }

        private void DgvRawMaterials_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || DgvRawMaterials?.Rows == null || e.RowIndex >= DgvRawMaterials.Rows.Count)
            {
                return;
            }

            var row = GetDataRowFromGrid(DgvRawMaterials.Rows[e.RowIndex]);
            if (!IsGroupRow(row))
            {
                return;
            }

            e.CellStyle.BackColor = Color.Gainsboro;
            e.CellStyle.ForeColor = Color.Black;
            e.CellStyle.SelectionBackColor = Color.DarkGray;
            e.CellStyle.SelectionForeColor = Color.Black;
        }

        private void BtnRawAdd_Click(object sender, EventArgs e)
        {
            AddRawMaterial();
        }

        private void BtnRawRefresh_Click(object sender, EventArgs e)
        {
            ReloadRawMaterials();
        }

        private void BtnRawSearch_Click(object sender, EventArgs e)
        {
            ApplyRawMaterialView();
        }

        private void BtnRawClear_Click(object sender, EventArgs e)
        {
            if (TxtRawSearch != null)
            {
                TxtRawSearch.Clear();
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
                ApplyRawMaterialView();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AttachRawFilterEvents()
        {
            EventHandler handler = (sender, args) => ApplyRawMaterialView();
            AttachCheckChangedHandler(ChkRawNutrientProtein, handler);
            AttachCheckChangedHandler(ChkRawNutrientFat, handler);
            AttachCheckChangedHandler(ChkRawNutrientCarb, handler);
            AttachNumericValueChangedHandler(NudRawCalorieMin, handler);
            AttachNumericValueChangedHandler(NudRawCalorieMax, handler);
        }

        private void DisplayManagedRawMaterial(DataRow row)
        {
            if (TxtRawDetailName == null)
            {
                return;
            }

            if (row == null)
            {
                TxtRawDetailName.Text = "선택 없음";
                TxtRawDetailCategory.Text = string.Empty;
                TxtRawDetailUnit.Text = string.Empty;
                TxtRawDetailBaseQty.Text = string.Empty;
                TxtRawDetailUnitGram.Text = string.Empty;
                TxtRawDetailStorage.Text = string.Empty;
                TxtRawDetailShelfLife.Text = string.Empty;
                TxtRawDetailActive.Text = string.Empty;
                ClearRawNutrients();
                ClearIngredientComponents();
                return;
            }

            _selectedRawMaterialId = ToInt(row["RAWID"]);

            TxtRawDetailName.Text = row["RAWNAME"]?.ToString() ?? string.Empty;
            TxtRawDetailCategory.Text = row["CATEGORYNAME"]?.ToString() ?? string.Empty;
            TxtRawDetailUnit.Text = row["PURCHASEUNIT"]?.ToString() ?? string.Empty;
            TxtRawDetailBaseQty.Text = FormatDecimal(row["BASEUNITQTY"]);
            TxtRawDetailUnitGram.Text = FormatDecimal(row["UNITGRAMQTY"]);
            TxtRawDetailStorage.Text = row["STORAGETYPE"]?.ToString() ?? string.Empty;
            TxtRawDetailShelfLife.Text = FormatShelfLife(row["SHELFLIFEDAYS"]);
            TxtRawDetailActive.Text = FormatActiveFlag(row["ACTIVEFLAG"]);

            var isRaw = string.Equals(row["ITEMTYPE"]?.ToString(), "RAW", StringComparison.OrdinalIgnoreCase);
            if (isRaw)
            {
                LoadRawNutrients(_selectedRawMaterialId ?? 0);
                ClearIngredientComponents();
            }
            else
            {
                ClearRawNutrients();
                LoadIngredientComponents(_selectedRawMaterialId ?? 0);
            }
        }

        private void LoadRawNutrients(int rawId)
        {
            if (DgvRawNutrients == null)
            {
                return;
            }

            const string sql =
                "SELECT n.NutrientName AS 영양소, n.Unit AS 단위, rn.AmountPerBase AS \"1g당 함량\" " +
                "FROM RawNutrient rn INNER JOIN Nutrient n ON rn.NutrientID = n.NutrientID " +
                "WHERE rn.RawID = :RAWID ORDER BY n.NutrientName";

            var table = ExecuteDataTable(sql, new OracleParameter("RAWID", rawId));
            DgvRawNutrients.DataSource = table;
        }

        private void LoadIngredientComponents(int ingredientId)
        {
            if (DgvRawComponents == null)
            {
                return;
            }

            const string sql =
                "SELECT r.RawName AS 원재료, ic.QuantityPerBatch AS 배합량, ic.LossRatePct AS 손실률 " +
                "FROM IngredientComp ic INNER JOIN RawMaterial r ON ic.RawID = r.RawID " +
                "WHERE ic.IngredientID = :INGID ORDER BY r.RawName";

            var table = ExecuteDataTable(sql, new OracleParameter("INGID", ingredientId));
            DgvRawComponents.DataSource = table;
        }

        private void ClearRawNutrients()
        {
            if (DgvRawNutrients != null)
            {
                DgvRawNutrients.DataSource = null;
            }
        }

        private void ClearIngredientComponents()
        {
            if (DgvRawComponents != null)
            {
                DgvRawComponents.DataSource = null;
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

        private void ConfigureRawGridColumns()
        {
            if (DgvRawMaterials == null)
            {
                return;
            }

            if (DgvRawMaterials.Columns.Contains("ISGROUPROW"))
            {
                DgvRawMaterials.Columns["ISGROUPROW"].Visible = false;
            }

            if (DgvRawMaterials.Columns.Contains("GROUPNAME"))
            {
                DgvRawMaterials.Columns["GROUPNAME"].Visible = false;
            }

            if (DgvRawMaterials.Columns.Contains("RAWID"))
            {
                DgvRawMaterials.Columns["RAWID"].Visible = false;
            }

            if (DgvRawMaterials.Columns.Contains("ITEMTYPE"))
            {
                DgvRawMaterials.Columns["ITEMTYPE"].HeaderText = "구분";
            }

            if (DgvRawMaterials.Columns.Contains("INGREDIENTTYPE"))
            {
                DgvRawMaterials.Columns["INGREDIENTTYPE"].Visible = false;
            }

            if (DgvRawMaterials.Columns.Contains("BATCHYIELDGRAM"))
            {
                DgvRawMaterials.Columns["BATCHYIELDGRAM"].Visible = false;
            }

            if (DgvRawMaterials.Columns.Contains("DEFAULTPORTIONGRAM"))
            {
                DgvRawMaterials.Columns["DEFAULTPORTIONGRAM"].Visible = false;
            }

            ApplyRawColumnHeaders(DgvRawMaterials);
        }

        private static void ApplyRawColumnHeaders(DataGridView grid)
        {
            if (grid == null)
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
                    Convert.ToInt32(row["RawCategoryID"]),
                    row["CategoryName"]?.ToString() ?? string.Empty));
            }

            return result;
        }

        private void CreateRawMaterial(RawMaterialInput input)
        {
            if (input == null)
            {
                return;
            }

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

        private static void CopyRawRow(DataRow source, DataRow destination)
        {
            if (source == null || destination == null)
            {
                return;
            }

            destination["ISGROUPROW"] = false;
            destination["GROUPNAME"] = DBNull.Value;

            foreach (DataColumn column in source.Table.Columns)
            {
                destination[column.ColumnName] = source[column];
            }

            destination.Table.Rows.Add(destination);
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

        private static DataRow GetDataRowFromGrid(DataGridViewRow gridRow)
        {
            return (gridRow?.DataBoundItem as DataRowView)?.Row;
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

        private IEnumerable<string> GetSelectedRawNutrients()
        {
            return GetSelectedNutrientCodes(ChkRawNutrientProtein, ChkRawNutrientFat, ChkRawNutrientCarb);
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

        private static void ConfigureGrid(DataGridView grid)
        {
            if (grid == null)
            {
                return;
            }

            grid.AutoGenerateColumns = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static int ToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(value);
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

        private int GetNextId(string tableName, string columnName)
        {
            var sql = $"SELECT NVL(MAX({columnName}), 0) + 1 FROM {tableName}";
            return ToInt(ExecuteScalar(sql));
        }
    }
}
