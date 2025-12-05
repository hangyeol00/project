using System;
using System.Drawing;
using System.Windows.Forms;

namespace nutritionist
{
    public class MealPlanDialog : Form
    {
        private readonly TextBox _txtPlanName;
        private readonly DateTimePicker _dtpStart;
        private readonly DateTimePicker _dtpEnd;
        private readonly Button _btnOk;
        private readonly Button _btnCancel;

        public MealPlanDialog()
        {
            Text = "식단 계획 등록";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(360, 180);

            var lblName = new Label
            {
                AutoSize = true,
                Location = new Point(20, 20),
                Text = "계획명"
            };

            _txtPlanName = new TextBox
            {
                Location = new Point(100, 16),
                Width = 220
            };

            var lblStart = new Label
            {
                AutoSize = true,
                Location = new Point(20, 60),
                Text = "시작일"
            };

            _dtpStart = new DateTimePicker
            {
                Location = new Point(100, 56),
                Format = DateTimePickerFormat.Short,
                Width = 120
            };

            var lblEnd = new Label
            {
                AutoSize = true,
                Location = new Point(20, 100),
                Text = "종료일"
            };

            _dtpEnd = new DateTimePicker
            {
                Location = new Point(100, 96),
                Format = DateTimePickerFormat.Short,
                Width = 120
            };

            _btnOk = new Button
            {
                Text = "확인",
                DialogResult = DialogResult.None,
                Location = new Point(100, 135),
                Width = 90
            };
            _btnOk.Click += BtnOk_Click;

            _btnCancel = new Button
            {
                Text = "취소",
                DialogResult = DialogResult.Cancel,
                Location = new Point(200, 135),
                Width = 90
            };

            Controls.AddRange(new Control[]
            {
                lblName,
                _txtPlanName,
                lblStart,
                _dtpStart,
                lblEnd,
                _dtpEnd,
                _btnOk,
                _btnCancel
            });

            AcceptButton = _btnOk;
            CancelButton = _btnCancel;
        }

        public MealPlanInput Result { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var planName = _txtPlanName.Text.Trim();
            if (string.IsNullOrWhiteSpace(planName))
            {
                MessageBox.Show("계획명을 입력해 주세요.", "안내");
                _txtPlanName.Focus();
                return;
            }

            if (_dtpStart.Value.Date > _dtpEnd.Value.Date)
            {
                MessageBox.Show("종료일은 시작일 이후여야 합니다.", "안내");
                return;
            }

            Result = new MealPlanInput
            {
                PlanName = planName,
                StartDate = _dtpStart.Value.Date,
                EndDate = _dtpEnd.Value.Date
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }

    public class MealPlanInput
    {
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
