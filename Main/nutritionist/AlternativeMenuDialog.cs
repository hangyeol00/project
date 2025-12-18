using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace nutritionist
{
    public partial class AlternativeMenuDialog : Form
    {
        private readonly Dictionary<int, List<FinalMenuOption>> _candidateMap;
        private readonly List<MenuAssignmentTarget> _targets;

        public AlternativeMenuDialog(string allergyName, IReadOnlyList<MenuAssignmentTarget> targets,
            Dictionary<int, List<FinalMenuOption>> candidateMap)
        {
            InitializeComponent();
            lblAllergyInfo.Text = string.IsNullOrWhiteSpace(allergyName)
                ? "알레르기"
                : $"알레르기: {allergyName}";
            _candidateMap = candidateMap ?? new Dictionary<int, List<FinalMenuOption>>();
            _targets = targets?.ToList() ?? new List<MenuAssignmentTarget>();
            cmbTargetMenu.DisplayMember = nameof(MenuAssignmentTarget.DisplayName);
            cmbTargetMenu.ValueMember = nameof(MenuAssignmentTarget.MenuId);
            cmbTargetMenu.DataSource = _targets;
            cmbTargetMenu.SelectedIndexChanged += (sender, args) => RefreshAlternativeList();
            RefreshAlternativeList();
        }

        public MenuAssignmentTarget SelectedTarget { get; private set; }
        public FinalMenuOption SelectedAlternative { get; private set; }

        private void RefreshAlternativeList()
        {
            SelectedTarget = cmbTargetMenu.SelectedItem as MenuAssignmentTarget;
            lstAlternatives.DataSource = null;
            SelectedAlternative = null;

            if (SelectedTarget == null)
            {
                lstAlternatives.Items.Clear();
                btnOk.Enabled = false;
                return;
            }

            if (!_candidateMap.TryGetValue(SelectedTarget.MenuId, out var candidates))
            {
                candidates = new List<FinalMenuOption>();
            }

            lstAlternatives.DataSource = candidates;
            lstAlternatives.DisplayMember = nameof(FinalMenuOption.DisplayName);
            lstAlternatives.ValueMember = nameof(FinalMenuOption.FinalMenuId);
            btnOk.Enabled = candidates.Count > 0;
            if (candidates.Count > 0)
            {
                lstAlternatives.SelectedIndex = 0;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var target = cmbTargetMenu.SelectedItem as MenuAssignmentTarget;
            var alternative = lstAlternatives.SelectedItem as FinalMenuOption;
            if (target == null)
            {
                MessageBox.Show("대체 대상 메뉴를 선택해 주세요.", "안내");
                return;
            }

            if (alternative == null)
            {
                MessageBox.Show("대체 메뉴를 선택해 주세요.", "안내");
                return;
            }

            SelectedTarget = target;
            SelectedAlternative = alternative;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
