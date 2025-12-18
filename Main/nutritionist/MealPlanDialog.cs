using System;
using System.Drawing;
using System.Windows.Forms;

namespace nutritionist
{
    public class MealPlanDialog : Form
    {
        private readonly TextBox _txtPlanName;
        private readonly Label _lblRangeValue;
        private readonly Button _btnOk;
        private readonly Button _btnCancel;
        private readonly DateTime _rangeStart;
        private readonly DateTime _rangeEnd;

        public MealPlanDialog(DateTime rangeStart, DateTime rangeEnd, string suggestedName)
        {
            _rangeStart = rangeStart.Date;
            _rangeEnd = rangeEnd.Date;

            Text = "식단 계획 등록";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(380, 170);

            var lblName = new Label
            {
                AutoSize = true,
                Location = new Point(20, 20),
                Text = "계획명"
            };

            _txtPlanName = new TextBox
            {
                Location = new Point(100, 16),
                Width = 240,
                Text = string.IsNullOrWhiteSpace(suggestedName) ? string.Empty : suggestedName
            };

            var lblNameHint = new Label
            {
                AutoSize = true,
                Location = new Point(100, 42),
                ForeColor = SystemColors.GrayText,
                Text = string.IsNullOrWhiteSpace(suggestedName)
                    ? "(예: 2023년 12월 2주차)"
                    : $"(예: {suggestedName})"
            };

            var lblRange = new Label
            {
                AutoSize = true,
                Location = new Point(20, 60),
                Text = "계획 기간"
            };

            _lblRangeValue = new Label
            {
                AutoSize = true,
                Location = new Point(100, 60),
                Text = GetRangeText()
            };

            var lblHint = new Label
            {
                AutoSize = true,
                Location = new Point(100, 85),
                ForeColor = SystemColors.GrayText,
                Text = "(주간 단위로 자동 설정됩니다)"
            };

            _btnOk = new Button
            {
                Text = "확인",
                DialogResult = DialogResult.None,
                Location = new Point(110, 120),
                Width = 90
            };
            _btnOk.Click += BtnOk_Click;

            _btnCancel = new Button
            {
                Text = "취소",
                DialogResult = DialogResult.Cancel,
                Location = new Point(210, 120),
                Width = 90
            };

            Controls.AddRange(new Control[]
            {
                lblName,
                _txtPlanName,
                lblNameHint,
                lblRange,
                _lblRangeValue,
                lblHint,
                _btnOk,
                _btnCancel
            });

            AcceptButton = _btnOk;
            CancelButton = _btnCancel;
            if (!string.IsNullOrEmpty(_txtPlanName.Text))
            {
                _txtPlanName.SelectionStart = 0;
                _txtPlanName.SelectionLength = _txtPlanName.Text.Length;
            }
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

            Result = new MealPlanInput
            {
                PlanName = planName,
                StartDate = _rangeStart,
                EndDate = _rangeEnd
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private string GetRangeText()
        {
            return $"{_rangeStart:yyyy-MM-dd} ~ {_rangeEnd:yyyy-MM-dd}";
        }
    }

    public class MealPlanInput
    {
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
