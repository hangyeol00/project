using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace nutritionist
{
    public class PurchaseRequestDialog : Form
    {
        private readonly ComboBox _cmbRaw;
        private readonly TextBox _txtContractId;
        private readonly NumericUpDown _nudQuantity;
        private readonly NumericUpDown _nudUnitPrice;
        private readonly DateTimePicker _dtpExpected;
        private readonly TextBox _txtRemark;
        private readonly Button _btnOk;
        private readonly Button _btnCancel;

        public PurchaseRequestDialog(IEnumerable<RawMaterialOption> rawMaterials, int? defaultRawId)
        {
            Text = "발주 요청 등록";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 280);

            var lblRaw = new Label { AutoSize = true, Location = new Point(20, 20), Text = "원재료" };
            _cmbRaw = new ComboBox
            {
                Location = new Point(120, 16),
                Width = 260,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            var rawList = rawMaterials?.ToList() ?? new List<RawMaterialOption>();
            _cmbRaw.DataSource = rawList;
            _cmbRaw.DisplayMember = nameof(RawMaterialOption.RawName);
            _cmbRaw.ValueMember = nameof(RawMaterialOption.RawId);
            if (defaultRawId.HasValue)
            {
                _cmbRaw.SelectedValue = defaultRawId.Value;
            }

            var lblContract = new Label { AutoSize = true, Location = new Point(20, 60), Text = "계약 ID" };
            _txtContractId = new TextBox { Location = new Point(120, 56), Width = 120 };

            var lblQuantity = new Label { AutoSize = true, Location = new Point(20, 100), Text = "수량" };
            _nudQuantity = new NumericUpDown
            {
                Location = new Point(120, 96),
                Width = 120,
                DecimalPlaces = 2,
                Maximum = 1000000,
                Minimum = 0,
                Increment = 0.5M
            };

            var lblUnitPrice = new Label { AutoSize = true, Location = new Point(20, 140), Text = "예상 단가" };
            _nudUnitPrice = new NumericUpDown
            {
                Location = new Point(120, 136),
                Width = 120,
                DecimalPlaces = 2,
                Maximum = 100000000,
                Minimum = 0
            };

            var lblExpected = new Label { AutoSize = true, Location = new Point(20, 180), Text = "희망 납기" };
            _dtpExpected = new DateTimePicker
            {
                Location = new Point(120, 176),
                Format = DateTimePickerFormat.Short,
                Width = 120,
                ShowCheckBox = true
            };

            var lblRemark = new Label { AutoSize = true, Location = new Point(20, 212), Text = "비고" };
            _txtRemark = new TextBox { Location = new Point(120, 208), Width = 260 };

            _btnOk = new Button { Text = "확인", Location = new Point(200, 240), Width = 80 };
            _btnOk.Click += BtnOk_Click;

            _btnCancel = new Button { Text = "취소", Location = new Point(300, 240), Width = 80, DialogResult = DialogResult.Cancel };

            Controls.AddRange(new Control[]
            {
                lblRaw, _cmbRaw,
                lblContract, _txtContractId,
                lblQuantity, _nudQuantity,
                lblUnitPrice, _nudUnitPrice,
                lblExpected, _dtpExpected,
                lblRemark, _txtRemark,
                _btnOk, _btnCancel
            });

            AcceptButton = _btnOk;
            CancelButton = _btnCancel;
        }

        public PurchaseRequestInput Result { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (_cmbRaw.SelectedItem == null)
            {
                MessageBox.Show("원재료를 선택해 주세요.", "안내");
                return;
            }

            if (_nudQuantity.Value <= 0)
            {
                MessageBox.Show("수량을 입력해 주세요.", "안내");
                return;
            }

            var expectedDate = _dtpExpected.ShowCheckBox && !_dtpExpected.Checked
                ? (DateTime?)null
                : _dtpExpected.Value.Date;

            Result = new PurchaseRequestInput
            {
                RawId = Convert.ToInt32(_cmbRaw.SelectedValue),
                ContractId = ParseNullableInt(_txtContractId.Text),
                Quantity = _nudQuantity.Value,
                UnitPriceEstimate = _nudUnitPrice.Value > 0 ? _nudUnitPrice.Value : (decimal?)null,
                ExpectedDate = expectedDate,
                Remark = string.IsNullOrWhiteSpace(_txtRemark.Text) ? null : _txtRemark.Text.Trim(),
                RequestedDate = DateTime.Today
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private static int? ParseNullableInt(string value)
        {
            if (int.TryParse(value, out var result))
            {
                return result;
            }

            return null;
        }
    }

    public class PurchaseRequestInput
    {
        public int RawId { get; set; }
        public int? ContractId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPriceEstimate { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string Remark { get; set; }
    }
}
