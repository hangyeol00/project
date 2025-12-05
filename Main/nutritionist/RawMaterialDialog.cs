using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace nutritionist
{
    public class RawMaterialDialog : Form
    {
        private readonly TextBox _txtName;
        private readonly ComboBox _cmbCategory;
        private readonly TextBox _txtUnit;
        private readonly NumericUpDown _nudBaseQty;
        private readonly ComboBox _cmbStorage;
        private readonly NumericUpDown _nudShelfLife;
        private readonly CheckBox _chkActive;
        private readonly Button _btnOk;
        private readonly Button _btnCancel;

        private readonly List<RawCategoryOption> _categories;

        public RawMaterialDialog(IEnumerable<RawCategoryOption> categories)
        {
            _categories = categories?.ToList() ?? new List<RawCategoryOption>();
            Text = "원재료 등록";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 320);

            var lblName = new Label
            {
                AutoSize = true,
                Location = new Point(20, 20),
                Text = "원재료명"
            };
            _txtName = new TextBox
            {
                Location = new Point(120, 16),
                Width = 260
            };

            var lblCategory = new Label
            {
                AutoSize = true,
                Location = new Point(20, 60),
                Text = "분류"
            };
            _cmbCategory = new ComboBox
            {
                Location = new Point(120, 56),
                Width = 260,
                DropDownStyle = ComboBoxStyle.DropDownList,
                DataSource = _categories
            };
            _cmbCategory.DisplayMember = nameof(RawCategoryOption.CategoryName);
            _cmbCategory.ValueMember = nameof(RawCategoryOption.CategoryId);
            if (_categories.Count > 0)
            {
                _cmbCategory.SelectedIndex = 0;
            }

            var lblUnit = new Label
            {
                AutoSize = true,
                Location = new Point(20, 100),
                Text = "구매 단위"
            };
            _txtUnit = new TextBox
            {
                Location = new Point(120, 96),
                Width = 120
            };

            var lblBaseQty = new Label
            {
                AutoSize = true,
                Location = new Point(20, 140),
                Text = "1단위(g)"
            };
            _nudBaseQty = new NumericUpDown
            {
                Location = new Point(120, 136),
                Width = 120,
                DecimalPlaces = 3,
                Increment = 0.5M,
                Maximum = 1000000,
                Minimum = 0.001M
            };
            _nudBaseQty.Value = 1000M;

            var lblStorage = new Label
            {
                AutoSize = true,
                Location = new Point(20, 180),
                Text = "보관 방식"
            };
            _cmbStorage = new ComboBox
            {
                Location = new Point(120, 176),
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDown
            };
            _cmbStorage.Items.AddRange(new object[] { "상온", "실온", "냉장", "냉동" });
            _cmbStorage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cmbStorage.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (_cmbStorage.Items.Count > 0)
            {
                _cmbStorage.SelectedIndex = 0;
            }

            var lblShelfLife = new Label
            {
                AutoSize = true,
                Location = new Point(20, 220),
                Text = "유통기한(일)"
            };
            _nudShelfLife = new NumericUpDown
            {
                Location = new Point(120, 216),
                Width = 120,
                Maximum = 3650,
                Minimum = 0
            };

            _chkActive = new CheckBox
            {
                Text = "사용 중",
                Location = new Point(260, 216),
                Checked = true,
                AutoSize = true
            };

            _btnOk = new Button
            {
                Text = "등록",
                Location = new Point(200, 260),
                Width = 80
            };
            _btnOk.Click += BtnOk_Click;

            _btnCancel = new Button
            {
                Text = "취소",
                Location = new Point(300, 260),
                Width = 80,
                DialogResult = DialogResult.Cancel
            };

            Controls.AddRange(new Control[]
            {
                lblName, _txtName,
                lblCategory, _cmbCategory,
                lblUnit, _txtUnit,
                lblBaseQty, _nudBaseQty,
                lblStorage, _cmbStorage,
                lblShelfLife, _nudShelfLife,
                _chkActive,
                _btnOk, _btnCancel
            });

            AcceptButton = _btnOk;
            CancelButton = _btnCancel;
        }

        public RawMaterialInput Result { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var name = _txtName.Text.Trim();
            var unit = _txtUnit.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("원재료명을 입력해 주세요.", "안내");
                _txtName.Focus();
                return;
            }

            if (_cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("분류를 선택해 주세요.", "안내");
                _cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("구매 단위를 입력해 주세요.", "안내");
                _txtUnit.Focus();
                return;
            }

            Result = new RawMaterialInput
            {
                RawName = name,
                RawCategoryId = ((RawCategoryOption)_cmbCategory.SelectedItem).CategoryId,
                PurchaseUnit = unit.ToUpperInvariant(),
                BaseUnitQty = _nudBaseQty.Value,
                StorageType = string.IsNullOrWhiteSpace(_cmbStorage.Text) ? null : _cmbStorage.Text.Trim(),
                ShelfLifeDays = _nudShelfLife.Value > 0 ? (int?)_nudShelfLife.Value : null,
                ActiveFlag = _chkActive.Checked
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }

    public class RawMaterialInput
    {
        public string RawName { get; set; }
        public int RawCategoryId { get; set; }
        public string PurchaseUnit { get; set; }
        public decimal BaseUnitQty { get; set; }
        public string StorageType { get; set; }
        public int? ShelfLifeDays { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
