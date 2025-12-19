using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using nutritionist;
using nutritionist.Tabs.Management;

namespace nutritionist.Forms
{
    public partial class RecipesForm
    {
        private DataTable _recipeTable;
        private readonly Dictionary<int, HashSet<string>> _recipeNutrientCodes = new Dictionary<int, HashSet<string>>();
        private readonly Dictionary<int, decimal> _recipeCalorieMap = new Dictionary<int, decimal>();
        private readonly Dictionary<int, Dictionary<string, decimal>> _menuNutrientAmounts = new Dictionary<int, Dictionary<string, decimal>>();
        private int? _selectedRecipeId;
        private ContextMenuStrip _recipeComponentMenu;
        private ToolStripMenuItem _menuRecipeViewRaw;
        private static readonly string[] DefaultMenuTypes = { "MAIN", "SIDE", "SOUP", "DRINK", "SNACK" };
        private static readonly Dictionary<string, string> RecipeColumnHeaders = new Dictionary<string, string>
        {
            { "MENUCODE", "메뉴 코드" },
            { "MENUNAME", "요리명" },
            { "MENUTYPE", "분류" },
            { "SERVINGSIZEGRAM", "1인 제공량(g)" },
            { "ACTIVEFLAG", "사용 여부" }
        };

        private class RecipeComponentInput
        {
            public int RawId { get; set; }
            public string RawName { get; set; }
            public string Unit { get; set; }
            public decimal QuantityGram { get; set; }
        }

        private class RecipeRegisterResult
        {
            public string MenuName { get; set; }
            public string MenuCode { get; set; }
            public string MenuType { get; set; }
            public decimal ServingSize { get; set; }
            public bool IsActive { get; set; }
            public List<RecipeComponentInput> Components { get; set; }
        }

        public event Action<int> RawMaterialRequested;

        public DataTable RecipeTable => _recipeTable;
        public IReadOnlyDictionary<int, Dictionary<string, decimal>> MenuNutrientAmounts => _menuNutrientAmounts;
        public int? SelectedRecipeId => _selectedRecipeId;

        private FlowLayoutPanel FlowRecipeCalorieFilter => flowRecipeCalorieFilter;
        private NumericUpDown NudRecipeCalorieMin => nudRecipeCalorieMin;
        private NumericUpDown NudRecipeCalorieMax => nudRecipeCalorieMax;
        private FlowLayoutPanel FlowRecipeNutrientFilters => flowRecipeNutrientFilters;
        private CheckBox ChkRecipeNutrientProtein => chkRecipeNutrientProtein;
        private CheckBox ChkRecipeNutrientFat => chkRecipeNutrientFat;
        private CheckBox ChkRecipeNutrientCarb => chkRecipeNutrientCarb;
        private Button BtnRecipeSearch => btnRecipeSearch;
        private Button BtnRecipeClear => btnRecipeClear;
        private TextBox TxtRecipeSearch => txtRecipeSearch;
        private Button BtnRefreshRecipe => btnRefreshRecipe;
        private Button BtnRegisterRecipe => btnRegisterRecipe;
        private DataGridView DgvRecipes => dgvRecipes;
        private TextBox TxtRecipeName => txtRecipeName;
        private TextBox TxtRecipeCode => txtRecipeCode;
        private TextBox TxtRecipeType => txtRecipeType;
        private TextBox TxtRecipeServing => txtRecipeServing;
        private TextBox TxtRecipeActive => txtRecipeActive;
        private DataGridView DgvRecipeComponents => dgvRecipeComponents;
        private DataGridView DgvRecipeNutrients => dgvRecipeNutrients;

        private void InitializeLogic()
        {
            ConfigureGrid(DgvRecipes);
            ConfigureGrid(DgvRecipeComponents);
            ConfigureGrid(DgvRecipeNutrients);

            if (TxtRecipeName != null) TxtRecipeName.ReadOnly = true;
            if (TxtRecipeCode != null) TxtRecipeCode.ReadOnly = true;
            if (TxtRecipeType != null) TxtRecipeType.ReadOnly = true;
            if (TxtRecipeServing != null) TxtRecipeServing.ReadOnly = true;
            if (TxtRecipeActive != null) TxtRecipeActive.ReadOnly = true;

            if (DgvRecipes != null)
            {
                DgvRecipes.CellClick += DgvRecipes_CellClick;
            }

            if (BtnRecipeSearch != null)
            {
                BtnRecipeSearch.Click += BtnRecipeSearch_Click;
            }

            if (BtnRecipeClear != null)
            {
                BtnRecipeClear.Click += BtnRecipeClear_Click;
            }

            if (TxtRecipeSearch != null)
            {
                TxtRecipeSearch.KeyDown += TxtRecipeSearch_KeyDown;
            }

            if (BtnRefreshRecipe != null)
            {
                BtnRefreshRecipe.Click += BtnRefreshRecipe_Click;
            }

            if (BtnRegisterRecipe != null)
            {
                BtnRegisterRecipe.Click += BtnRegisterRecipe_Click;
            }

            InitializeRecipeComponentContextMenu();
            AttachRecipeFilterEvents();
        }

        public void ReloadRecipes()
        {
            const string sql =
                "SELECT FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag " +
                "FROM FinalMenu ORDER BY MenuName";

            _recipeTable = ExecuteDataTable(sql);
            LoadRecipeNutrientSummary();
            ApplyRecipeFilter();
        }

        public void ApplyRecipeFilter()
        {
            if (_recipeTable == null || DgvRecipes == null)
            {
                return;
            }

            var viewTable = _recipeTable.Clone();
            var keyword = TxtRecipeSearch?.Text?.Trim();
            IEnumerable<DataRow> rows = _recipeTable.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                rows = rows.Where(r =>
                    (r["MENUNAME"]?.ToString() ?? string.Empty).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (r["MENUCODE"]?.ToString() ?? string.Empty).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var requiredNutrients = GetSelectedRecipeNutrients().ToList();
            var minCalorie = GetNumericFilterValue(NudRecipeCalorieMin);
            var maxCalorie = GetNumericFilterValue(NudRecipeCalorieMax);
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

            DgvRecipes.DataSource = viewTable;
            ConfigureRecipeGridColumns();
            if (DgvRecipes.Rows.Count > 0)
            {
                DgvRecipes.Rows[0].Selected = true;
                SetSelectedRecipeFromRow(DgvRecipes.Rows[0]);
            }
            else
            {
                _selectedRecipeId = null;
                DisplaySelectedRecipe(null);
            }
        }

        public decimal GetMenuNutrientAmount(int menuId, string nutrientCode)
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

        private void ConfigureRecipeGridColumns()
        {
            if (DgvRecipes == null)
            {
                return;
            }

            if (DgvRecipes.Columns.Contains("FINALMENUID"))
            {
                DgvRecipes.Columns["FINALMENUID"].Visible = false;
            }

            foreach (var kvp in RecipeColumnHeaders)
            {
                if (DgvRecipes.Columns.Contains(kvp.Key))
                {
                    DgvRecipes.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }
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

                if (string.Equals(code, "CAL", StringComparison.OrdinalIgnoreCase) &&
                    row["NUTRIENTAMOUNT"] != DBNull.Value)
                {
                    _recipeCalorieMap[menuId] = Convert.ToDecimal(row["NUTRIENTAMOUNT"]);
                }
            }
        }

        private void DgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || DgvRecipes?.Rows == null || e.RowIndex >= DgvRecipes.Rows.Count)
            {
                return;
            }

            SetSelectedRecipeFromRow(DgvRecipes.Rows[e.RowIndex]);
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
                if (TxtRecipeName != null) TxtRecipeName.Text = "선택 없음";
                if (TxtRecipeCode != null) TxtRecipeCode.Text = string.Empty;
                if (TxtRecipeType != null) TxtRecipeType.Text = string.Empty;
                if (TxtRecipeServing != null) TxtRecipeServing.Text = string.Empty;
                if (TxtRecipeActive != null) TxtRecipeActive.Text = string.Empty;
                ClearRecipeNutrients();
                ClearRecipeComponents();
                return;
            }

            if (TxtRecipeName != null) TxtRecipeName.Text = row["MENUNAME"]?.ToString() ?? string.Empty;
            if (TxtRecipeCode != null) TxtRecipeCode.Text = row["MENUCODE"]?.ToString() ?? string.Empty;
            if (TxtRecipeType != null) TxtRecipeType.Text = row["MENUTYPE"]?.ToString() ?? string.Empty;
            if (TxtRecipeServing != null)
            {
                var serving = FormatDecimal(row["SERVINGSIZEGRAM"]);
                TxtRecipeServing.Text = string.IsNullOrEmpty(serving) ? string.Empty : $"{serving} g";
            }
            if (TxtRecipeActive != null) TxtRecipeActive.Text = FormatActiveFlag(row["ACTIVEFLAG"]);

            var menuId = ToInt(row["FINALMENUID"]);
            LoadRecipeNutrients(menuId);
            LoadRecipeComponents(menuId);
        }

        private void LoadRecipeNutrients(int finalMenuId)
        {
            if (DgvRecipeNutrients == null)
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
                "    FROM base_component bc " +
                "    WHERE bc.ComponentType = 'R' AND bc.ComponentRawID IS NOT NULL " +
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
            DgvRecipeNutrients.DataSource = table;
        }

        private void LoadRecipeComponents(int finalMenuId)
        {
            if (DgvRecipeComponents == null)
            {
                return;
            }

            var aggregated = LoadAggregatedRecipeComponents(finalMenuId);
            if (aggregated.Rows.Count > 0)
            {
                DgvRecipeComponents.DataSource = aggregated;
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
            DgvRecipeComponents.DataSource = table;
            if (DgvRecipeComponents.Columns.Contains("TypeLabel"))
            {
                DgvRecipeComponents.Columns["TypeLabel"].HeaderText = "구성 구분";
            }

            if (DgvRecipeComponents.Columns.Contains("ComponentName"))
            {
                DgvRecipeComponents.Columns["ComponentName"].HeaderText = "구성명";
            }

            if (DgvRecipeComponents.Columns.Contains("QuantityPerServing"))
            {
                DgvRecipeComponents.Columns["QuantityPerServing"].HeaderText = "1인분 사용량";
            }

            if (DgvRecipeComponents.Columns.Contains("UnitLabel"))
            {
                DgvRecipeComponents.Columns["UnitLabel"].HeaderText = "단위";
            }

            var rawIdColumn = GetColumn(DgvRecipeComponents, "RawID");
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
            var rawIdColumn = GetColumn(DgvRecipeComponents, "RawID");
            if (rawIdColumn != null)
            {
                rawIdColumn.Visible = false;
            }

            if (DgvRecipeComponents.Columns.Contains("RawName"))
            {
                DgvRecipeComponents.Columns["RawName"].HeaderText = "원재료";
            }

            if (DgvRecipeComponents.Columns.Contains("QuantityPerServing"))
            {
                DgvRecipeComponents.Columns["QuantityPerServing"].HeaderText = "1인분 사용량(g)";
            }

            if (DgvRecipeComponents.Columns.Contains("PurchaseUnit"))
            {
                DgvRecipeComponents.Columns["PurchaseUnit"].HeaderText = "구매 단위";
            }
        }

        private void DgvRecipeComponents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvRecipeComponents == null || e.Button != MouseButtons.Right || e.RowIndex < 0)
            {
                return;
            }

            DgvRecipeComponents.ClearSelection();
            var row = DgvRecipeComponents.Rows[e.RowIndex];
            row.Selected = true;
            var columnIndex = e.ColumnIndex >= 0 ? e.ColumnIndex : 0;
            if (columnIndex >= 0 && columnIndex < row.Cells.Count)
            {
                DgvRecipeComponents.CurrentCell = row.Cells[columnIndex];
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
            if (rawId.HasValue && rawId.Value > 0)
            {
                RawMaterialRequested?.Invoke(rawId.Value);
            }
        }

        private int? GetSelectedRecipeComponentRawId()
        {
            if (DgvRecipeComponents?.CurrentRow == null)
            {
                return null;
            }

            var rawId = GetRawIdFromRecipeComponentRow(DgvRecipeComponents.CurrentRow);
            return rawId > 0 ? rawId : (int?)null;
        }

        private void ClearRecipeNutrients()
        {
            if (DgvRecipeNutrients != null)
            {
                DgvRecipeNutrients.DataSource = null;
            }
        }

        private void ClearRecipeComponents()
        {
            if (DgvRecipeComponents != null)
            {
                DgvRecipeComponents.DataSource = null;
            }
        }

        private void AttachRecipeFilterEvents()
        {
            EventHandler handler = (sender, args) => ApplyRecipeFilter();
            AttachCheckChangedHandler(ChkRecipeNutrientProtein, handler);
            AttachCheckChangedHandler(ChkRecipeNutrientFat, handler);
            AttachCheckChangedHandler(ChkRecipeNutrientCarb, handler);
            AttachNumericValueChangedHandler(NudRecipeCalorieMin, handler);
            AttachNumericValueChangedHandler(NudRecipeCalorieMax, handler);
        }

        private IEnumerable<string> GetSelectedRecipeNutrients()
        {
            return GetSelectedNutrientCodes(ChkRecipeNutrientProtein, ChkRecipeNutrientFat, ChkRecipeNutrientCarb);
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

        private void BtnRecipeSearch_Click(object sender, EventArgs e)
        {
            ApplyRecipeFilter();
        }

        private void BtnRecipeClear_Click(object sender, EventArgs e)
        {
            if (TxtRecipeSearch != null)
            {
                TxtRecipeSearch.Clear();
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
            ReloadRecipes();
        }

        private void BtnRegisterRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ShowRegisterRecipeDialog();
                if (result == null)
                {
                    return;
                }

                SaveNewRecipe(result);
                MessageBox.Show("메뉴가 등록되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadRecipes();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"메뉴 등록 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"메뉴 등록 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RecipeRegisterResult ShowRegisterRecipeDialog()
        {
            var rawOptions = LoadRawMaterialOptions();
            if (rawOptions.Count == 0)
            {
                MessageBox.Show("등록 가능한 원재료가 없습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var typeOptions = GetMenuTypeOptions();
            RecipeRegisterResult result = null;

            using (var dialog = new Form())
            {
                dialog.Text = "메뉴 등록";
                dialog.Size = new Size(900, 620);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;

                var mainLayout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 3,
                    ColumnCount = 1,
                    Padding = new Padding(10),
                    RowStyles =
                    {
                        new RowStyle(SizeType.AutoSize),
                        new RowStyle(SizeType.Percent, 100),
                        new RowStyle(SizeType.AutoSize)
                    }
                };

                var metaTable = new TableLayoutPanel
                {
                    ColumnCount = 4,
                    RowCount = 3,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

                metaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
                metaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                metaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
                metaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                metaTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                metaTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                metaTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                var lblName = new Label { Text = "메뉴명", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(0, 3, 0, 0) };
                var txtName = new TextBox { Dock = DockStyle.Fill };
                var lblCode = new Label { Text = "메뉴 코드", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(0, 3, 0, 0) };
                var txtCode = new TextBox { Dock = DockStyle.Fill };
                var lblType = new Label { Text = "분류", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(0, 3, 0, 0) };
                var cmbType = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
                cmbType.Items.AddRange(typeOptions.Cast<object>().ToArray());
                var lblServing = new Label { Text = "1인 제공량(g)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(0, 3, 0, 0) };
                var nudServing = new NumericUpDown { Dock = DockStyle.Fill, DecimalPlaces = 1, Minimum = 1, Maximum = 100000, Increment = 1, Value = 100 };
                var chkActive = new CheckBox { Text = "사용", Dock = DockStyle.Fill, Checked = true, AutoSize = true };

                metaTable.Controls.Add(lblName, 0, 0);
                metaTable.Controls.Add(txtName, 1, 0);
                metaTable.Controls.Add(lblCode, 2, 0);
                metaTable.Controls.Add(txtCode, 3, 0);
                metaTable.Controls.Add(lblType, 0, 1);
                metaTable.Controls.Add(cmbType, 1, 1);
                metaTable.Controls.Add(lblServing, 2, 1);
                metaTable.Controls.Add(nudServing, 3, 1);

                var listsLayout = new TableLayoutPanel
                {
                    ColumnCount = 3,
                    RowCount = 1,
                    Dock = DockStyle.Fill
                };
                listsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
                listsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140));
                listsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));

                var lvRaw = new ListView
                {
                    View = View.Details,
                    FullRowSelect = true,
                    MultiSelect = false,
                    HideSelection = false,
                    Dock = DockStyle.Fill,
                    GridLines = true
                };
                lvRaw.Columns.Add("원재료", 200);
                lvRaw.Columns.Add("단위", 80);

                foreach (var raw in rawOptions)
                {
                    var item = new ListViewItem(raw.RawName);
                    item.SubItems.Add(string.IsNullOrWhiteSpace(raw.PurchaseUnit) ? "-" : raw.PurchaseUnit);
                    item.Tag = raw;
                    lvRaw.Items.Add(item);
                }

                var lvSelected = new ListView
                {
                    View = View.Details,
                    FullRowSelect = true,
                    MultiSelect = false,
                    HideSelection = false,
                    Dock = DockStyle.Fill,
                    GridLines = true
                };
                lvSelected.Columns.Add("구성 원재료", 220);
                lvSelected.Columns.Add("사용량(g)", 100, HorizontalAlignment.Right);

                var actionLayout = new TableLayoutPanel
                {
                    ColumnCount = 1,
                    RowCount = 5,
                    Dock = DockStyle.Fill,
                    RowStyles =
                    {
                        new RowStyle(SizeType.Percent, 100),
                        new RowStyle(SizeType.AutoSize),
                        new RowStyle(SizeType.AutoSize),
                        new RowStyle(SizeType.AutoSize),
                        new RowStyle(SizeType.Percent, 0)
                    }
                };

                var lblQty = new Label { Text = "사용량(g)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Padding = new Padding(0, 6, 0, 6) };
                var nudQty = new NumericUpDown { DecimalPlaces = 2, Minimum = 0, Maximum = 100000, Increment = 1, Dock = DockStyle.Top, Width = 120 };
                var btnAdd = new Button { Text = "추가 →", Dock = DockStyle.Top, Height = 32 };
                var btnRemove = new Button { Text = "← 빼기", Dock = DockStyle.Top, Height = 32 };

                void AddSelectedRaw()
                {
                    if (lvRaw.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("추가할 원재료를 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var raw = lvRaw.SelectedItems[0].Tag as RawMaterialOption;
                    if (raw == null)
                    {
                        return;
                    }

                    var qty = nudQty.Value;
                    if (qty <= 0)
                    {
                        MessageBox.Show("사용량을 입력해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var existing = lvSelected.Items.Cast<ListViewItem>()
                        .FirstOrDefault(i => (i.Tag as RecipeComponentInput)?.RawId == raw.RawId);
                    if (existing != null)
                    {
                        var comp = existing.Tag as RecipeComponentInput;
                        if (comp != null)
                        {
                            comp.QuantityGram = qty;
                            existing.SubItems[1].Text = FormatQuantity(qty);
                        }
                    }
                    else
                    {
                        var comp = new RecipeComponentInput
                        {
                            RawId = raw.RawId,
                            RawName = raw.RawName,
                            Unit = raw.PurchaseUnit,
                            QuantityGram = qty
                        };
                        var item = new ListViewItem(comp.RawName) { Tag = comp };
                        item.SubItems.Add(FormatQuantity(comp.QuantityGram));
                        lvSelected.Items.Add(item);
                    }
                }

                void RemoveSelectedRaw()
                {
                    if (lvSelected.SelectedItems.Count == 0)
                    {
                        return;
                    }

                    lvSelected.Items.Remove(lvSelected.SelectedItems[0]);
                }

                btnAdd.Click += (s, e) => AddSelectedRaw();
                btnRemove.Click += (s, e) => RemoveSelectedRaw();
                lvRaw.DoubleClick += (s, e) => AddSelectedRaw();
                lvSelected.DoubleClick += (s, e) => RemoveSelectedRaw();

                actionLayout.Controls.Add(new Panel(), 0, 0);
                actionLayout.Controls.Add(lblQty, 0, 1);
                actionLayout.Controls.Add(nudQty, 0, 2);
                actionLayout.Controls.Add(btnAdd, 0, 3);
                actionLayout.Controls.Add(btnRemove, 0, 4);

                listsLayout.Controls.Add(lvRaw, 0, 0);
                listsLayout.Controls.Add(actionLayout, 1, 0);
                listsLayout.Controls.Add(lvSelected, 2, 0);

                var buttonPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.RightToLeft,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, 8, 0, 0),
                    AutoSize = true
                };

                var btnOk = new Button { Text = "등록", Width = 100, DialogResult = DialogResult.OK };
                var btnCancel = new Button { Text = "취소", Width = 100, DialogResult = DialogResult.Cancel };
                buttonPanel.Controls.Add(btnOk);
                buttonPanel.Controls.Add(btnCancel);

                dialog.AcceptButton = btnOk;
                dialog.CancelButton = btnCancel;

                btnOk.Click += (s, e) =>
                {
                    var name = txtName.Text?.Trim();
                    var code = txtCode.Text?.Trim();
                    var type = cmbType.Text?.Trim();
                    var serving = nudServing.Value;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("메뉴명을 입력해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialog.DialogResult = DialogResult.None;
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(code))
                    {
                        MessageBox.Show("메뉴 코드를 입력해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialog.DialogResult = DialogResult.None;
                        return;
                    }

                    if (lvSelected.Items.Count == 0)
                    {
                        MessageBox.Show("사용할 원재료를 추가해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialog.DialogResult = DialogResult.None;
                        return;
                    }

                    result = new RecipeRegisterResult
                    {
                        MenuName = name,
                        MenuCode = code,
                        MenuType = string.IsNullOrWhiteSpace(type) ? "OTHER" : type,
                        ServingSize = serving,
                        IsActive = chkActive.Checked,
                        Components = lvSelected.Items.Cast<ListViewItem>()
                            .Select(item => item.Tag as RecipeComponentInput)
                            .Where(comp => comp != null)
                            .Select(comp => new RecipeComponentInput
                            {
                                RawId = comp.RawId,
                                RawName = comp.RawName,
                                Unit = comp.Unit,
                                QuantityGram = comp.QuantityGram
                            })
                            .ToList()
                    };

                    if (result.Components.Count == 0)
                    {
                        MessageBox.Show("사용할 원재료를 추가해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialog.DialogResult = DialogResult.None;
                    }
                };

                mainLayout.Controls.Add(metaTable, 0, 0);
                mainLayout.Controls.Add(listsLayout, 0, 1);
                mainLayout.Controls.Add(buttonPanel, 0, 2);
                dialog.Controls.Add(mainLayout);
                chkActive.Anchor = AnchorStyles.Left;
                metaTable.Controls.Add(chkActive, 0, 2);
                metaTable.SetColumnSpan(chkActive, 4);
                chkActive.Margin = new Padding(0, 6, 0, 0);

                dialog.ShowDialog(this);
            }

            return result;
        }

        private void SaveNewRecipe(RecipeRegisterResult result)
        {
            if (result == null || result.Components == null || result.Components.Count == 0)
            {
                return;
            }

            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        var finalMenuId = GetNextId(conn, tx, "FinalMenu", "FinalMenuID");
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = tx;
                            cmd.BindByName = true;
                            cmd.CommandText =
                                "INSERT INTO FinalMenu (FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag) " +
                                "VALUES (:ID, :CODE, :NAME, :TYPE, :SERVING, :ACTIVE)";
                            cmd.Parameters.Add(new OracleParameter("ID", finalMenuId));
                            cmd.Parameters.Add(new OracleParameter("CODE", result.MenuCode));
                            cmd.Parameters.Add(new OracleParameter("NAME", result.MenuName));
                            cmd.Parameters.Add(new OracleParameter("TYPE", result.MenuType));
                            cmd.Parameters.Add(new OracleParameter("SERVING", result.ServingSize));
                            cmd.Parameters.Add(new OracleParameter("ACTIVE", result.IsActive ? "Y" : "N"));
                            cmd.ExecuteNonQuery();
                        }

                        var nextMenuCompId = GetNextId(conn, tx, "MenuComp", "MenuCompID");
                        foreach (var comp in result.Components)
                        {
                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.Transaction = tx;
                                cmd.BindByName = true;
                                cmd.CommandText =
                                    "INSERT INTO MenuComp (MenuCompID, FinalMenuID, ComponentType, ComponentRawID, ComponentIngredientID, QuantityPerServing) " +
                                    "VALUES (:ID, :FINALID, 'R', :RAWID, NULL, :QTY)";
                                cmd.Parameters.Add(new OracleParameter("ID", nextMenuCompId++));
                                cmd.Parameters.Add(new OracleParameter("FINALID", finalMenuId));
                                cmd.Parameters.Add(new OracleParameter("RAWID", comp.RawId));
                                cmd.Parameters.Add(new OracleParameter("QTY", comp.QuantityGram));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        private List<RawMaterialOption> LoadRawMaterialOptions()
        {
            const string sql =
                "SELECT RawID, RawName, PurchaseUnit " +
                "FROM RawMaterial WHERE NVL(ActiveFlag, 'Y') = 'Y' ORDER BY RawName";
            var table = ExecuteDataTable(sql);
            var list = new List<RawMaterialOption>();
            foreach (DataRow row in table.Rows)
            {
                var rawId = ToInt(row["RAWID"]);
                if (rawId <= 0)
                {
                    continue;
                }

                list.Add(new RawMaterialOption(
                    rawId,
                    row["RAWNAME"]?.ToString() ?? string.Empty,
                    row["PURCHASEUNIT"]?.ToString() ?? string.Empty));
            }

            return list;
        }

        private List<string> GetMenuTypeOptions()
        {
            var options = new List<string>();
            if (_recipeTable != null)
            {
                options.AddRange(_recipeTable.AsEnumerable()
                    .Select(r => r["MENUTYPE"]?.ToString())
                    .Where(type => !string.IsNullOrWhiteSpace(type)));
            }

            options.AddRange(DefaultMenuTypes);
            return options
                .Where(type => !string.IsNullOrWhiteSpace(type))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(type => type)
                .ToList();
        }

        private static string FormatQuantity(decimal value)
        {
            return value.ToString("0.###");
        }

        private static int GetNextId(OracleConnection conn, OracleTransaction tx, string tableName, string columnName)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.Transaction = tx;
                cmd.CommandText = $"SELECT NVL(MAX({columnName}), 0) + 1 FROM {tableName}";
                var result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? 1 : Convert.ToInt32(result);
            }
        }

        private void InitializeRecipeComponentContextMenu()
        {
            if (DgvRecipeComponents == null)
            {
                return;
            }

            _recipeComponentMenu = new ContextMenuStrip();
            _menuRecipeViewRaw = new ToolStripMenuItem("재료관리에서 보기");
            _menuRecipeViewRaw.Click += MenuRecipeViewRaw_Click;
            _recipeComponentMenu.Items.Add(_menuRecipeViewRaw);
            _recipeComponentMenu.Opening += RecipeComponentMenu_Opening;
            DgvRecipeComponents.ContextMenuStrip = _recipeComponentMenu;
            DgvRecipeComponents.CellMouseDown += DgvRecipeComponents_CellMouseDown;
        }

        private static DataRow GetDataRowFromGrid(DataGridViewRow gridRow)
        {
            return (gridRow?.DataBoundItem as DataRowView)?.Row;
        }

        private static int GetRawIdFromRecipeComponentRow(DataGridViewRow row)
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

        private static string FormatDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return string.Empty;
            }

            return Convert.ToDecimal(value).ToString("#,##0.###");
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
    }
}
