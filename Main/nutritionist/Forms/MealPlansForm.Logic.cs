using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using nutritionist;

namespace nutritionist.Forms
{
    public partial class MealPlansForm
    {
        private readonly List<FinalMenuOption> _finalMenuOptions = new List<FinalMenuOption>();
        private readonly BindingList<FinalMenuOption> _filteredMenuOptions = new BindingList<FinalMenuOption>();
        private readonly List<MenuTagOption> _availableMenuTags = new List<MenuTagOption>();
        private readonly List<MenuSortOption> _menuSortOptions = new List<MenuSortOption>();
        private readonly Dictionary<int, HashSet<int>> _menuTagMap = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, string> _tagNameLookup = new Dictionary<int, string>();
        private readonly List<NutrientTarget> _nutrientTargets = new List<NutrientTarget>
        {
            new NutrientTarget("칼로리", "kcal", "CAL", 700m),
            new NutrientTarget("단백질", "g", "PROT", 25m),
            new NutrientTarget("지방", "g", "FAT", 20m),
            new NutrientTarget("탄수화물", "g", "CARB", 90m),
            new NutrientTarget("칼슘", "mg", "CA", 200m)
        };
        private bool _suppressMenuFilter;

        private void InitializeLogic()
        {
            InitializeMenuControls();
            InitializeMealPlanControls();
            LoadFinalMenus();
            LoadMenuTags();
        }

        public IReadOnlyList<FinalMenuOption> FinalMenuOptions => _finalMenuOptions;
        public IReadOnlyDictionary<int, HashSet<int>> MenuTagMap => _menuTagMap;
        public IReadOnlyDictionary<int, string> TagNameLookup => _tagNameLookup;

        #region 초기화 및 이벤트 연결
        private void InitializeMenuControls()
        {
            if (lstAvailableMenus != null)
            {
                lstAvailableMenus.DisplayMember = nameof(FinalMenuOption.DisplayName);
                lstAvailableMenus.DataSource = _filteredMenuOptions;
                lstAvailableMenus.MouseDown += LstAvailableMenus_MouseDown;
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
        }
        #endregion

        #region 메뉴 로드/필터
        public void LoadFinalMenus()
        {
            const string sql =
                "SELECT FinalMenuID, MenuCode, MenuName, MenuType, ServingSizeGram, ActiveFlag " +
                "FROM FinalMenu ORDER BY MenuName";
            var table = ExecuteDataTable(sql);
            _finalMenuOptions.Clear();

            foreach (DataRow row in table.Rows)
            {
                var option = new FinalMenuOption(
                    ToInt(row["FINALMENUID"]),
                    row["MENUCODE"]?.ToString(),
                    row["MENUNAME"]?.ToString() ?? string.Empty,
                    row["MENUTYPE"]?.ToString());
                _finalMenuOptions.Add(option);
            }

            PopulateMenuTypeFilter();
            PopulateMenuSortOptions();
            ApplyMenuFilter(true);
        }

        public void LoadMenuTags()
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

        public void ApplyMenuFilter(bool resetSelection = false)
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

        private MenuSortOption GetSelectedMenuSortOption()
        {
            return cmbMenuSort?.SelectedItem as MenuSortOption;
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
        #endregion

        #region 드래그 소스 설정
        private void LstAvailableMenus_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstAvailableMenus == null)
            {
                return;
            }

            var item = lstAvailableMenus.SelectedItem as FinalMenuOption;
            if (item == null)
            {
                return;
            }

            lstAvailableMenus.DoDragDrop(item, DragDropEffects.Copy);
        }

        #endregion

        #region 하위 모델/유틸
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
        #endregion

        #region DB/헬퍼
        private static int ToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(value);
        }

        private decimal GetMenuNutrientAmount(int menuId, string nutrientCode)
        {
            return _recipesForm?.GetMenuNutrientAmount(menuId, nutrientCode) ?? 0m;
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
        #endregion
    }
}
