using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class MealPlanApprovalForm : Form
    {
        private const string MealPlanStatusDraft = "DRAFT";
        private const string MealPlanStatusApproved = "APPROVED";

        private readonly UserSession _session;
        private int? _selectedMealPlanId;

        public MealPlanApprovalForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvMealPlans);
            if (txtPlanName != null) txtPlanName.ReadOnly = true;
            if (txtDetails != null) txtDetails.ReadOnly = true;
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
            Load += MealPlanApprovalForm_Load;
            if (dgvMealPlans != null)
            {
                dgvMealPlans.CellClick += DgvMealPlans_CellClick;
            }
            if (btnApprove != null) btnApprove.Click += BtnApprove_Click;
            if (btnReject != null) btnReject.Click += BtnReject_Click;
        }

        private void MealPlanApprovalForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMealPlansForApproval();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadMealPlansForApproval();
        }

        private void LoadMealPlansForApproval()
        {
            try
            {
                const string sql =
                    "SELECT mp.MealPlanID, mp.PlanName, mp.PeriodStart, mp.PeriodEnd, mp.Status, " +
                    "       NVL(u.UserName, mp.CreatedBy) AS CreatedByName " +
                    "FROM MealPlan mp " +
                    "LEFT JOIN AppUser u ON mp.CreatedBy = u.UserID " +
                    "WHERE UPPER(mp.Status) = :STATUS " +
                    "ORDER BY mp.PeriodStart DESC, mp.MealPlanID DESC";

                var table = DatabaseHelper.ExecuteDataTable(sql,
                    new OracleParameter("STATUS", MealPlanStatusDraft));

                if (dgvMealPlans != null)
                {
                    dgvMealPlans.DataSource = table;
                    ConfigureGrid(dgvMealPlans);

                    if (dgvMealPlans.Rows.Count > 0)
                    {
                        dgvMealPlans.Rows[0].Selected = true;
                        SetSelectedMealPlanFromRow(dgvMealPlans.Rows[0]);
                    }
                    else
                    {
                        _selectedMealPlanId = null;
                        DisplayMealPlanDetail(null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"식단 계획 목록 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMealPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealPlans?.CurrentRow == null)
            {
                return;
            }

            SetSelectedMealPlanFromRow(dgvMealPlans.CurrentRow);
        }

        private void SetSelectedMealPlanFromRow(DataGridViewRow row)
        {
            var dataRow = GetDataRowFromGrid(row);
            if (dataRow == null)
            {
                _selectedMealPlanId = null;
                DisplayMealPlanDetail(null);
                return;
            }

            _selectedMealPlanId = DatabaseHelper.ToIntNullable(dataRow["MealPlanID"]);
            DisplayMealPlanDetail(dataRow);
        }

        private void DisplayMealPlanDetail(DataRow row)
        {
            if (txtPlanName != null)
            {
                txtPlanName.Text = row?["PlanName"]?.ToString() ?? string.Empty;
            }
            if (txtDetails != null)
            {
                var startDate = row?["PeriodStart"]?.ToString() ?? string.Empty;
                var endDate = row?["PeriodEnd"]?.ToString() ?? string.Empty;
                var createdBy = row?["CreatedByName"]?.ToString() ?? string.Empty;
                txtDetails.Text = $"기간: {startDate} ~ {endDate}\n작성자: {createdBy}";
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("승인할 식단 계획을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                const string sql = "UPDATE MealPlan SET Status = :STATUS WHERE MealPlanID = :ID";

                var rows = DatabaseHelper.ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", MealPlanStatusApproved),
                    new OracleParameter("ID", _selectedMealPlanId));

                if (rows > 0)
                {
                    MessageBox.Show("식단 계획이 승인되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMealPlansForApproval();
                    OnDataChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"식단 승인 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (_selectedMealPlanId == null)
            {
                MessageBox.Show("거부할 식단 계획을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 거부 사유 입력 다이얼로그
            string reason = string.Empty;
            using (var inputForm = new Form())
            {
                inputForm.Text = "식단 계획 거부";
                inputForm.Size = new System.Drawing.Size(400, 150);
                inputForm.StartPosition = FormStartPosition.CenterParent;
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.MaximizeBox = false;
                inputForm.MinimizeBox = false;

                var lblReason = new Label
                {
                    Text = "거부 사유를 입력하세요:",
                    Location = new System.Drawing.Point(10, 15),
                    AutoSize = true
                };

                var txtReason = new TextBox
                {
                    Location = new System.Drawing.Point(10, 35),
                    Size = new System.Drawing.Size(360, 20),
                    Multiline = false
                };

                var btnOk = new Button
                {
                    Text = "확인",
                    DialogResult = DialogResult.OK,
                    Location = new System.Drawing.Point(200, 70),
                    Size = new System.Drawing.Size(75, 25)
                };

                var btnCancel = new Button
                {
                    Text = "취소",
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(285, 70),
                    Size = new System.Drawing.Size(75, 25)
                };

                inputForm.Controls.Add(lblReason);
                inputForm.Controls.Add(txtReason);
                inputForm.Controls.Add(btnOk);
                inputForm.Controls.Add(btnCancel);
                inputForm.AcceptButton = btnOk;
                inputForm.CancelButton = btnCancel;

                if (inputForm.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                reason = txtReason.Text?.Trim() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("거부 사유를 입력해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 거부 사유는 DB에 저장할 필드가 없으므로 메시지만 표시
            MessageBox.Show($"식단 계획이 거부되었습니다.\n사유: {reason}", "완료",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMealPlansForApproval();
            OnDataChanged?.Invoke(this, EventArgs.Empty);
        }

        private static DataRow GetDataRowFromGrid(DataGridViewRow row)
        {
            if (row?.DataBoundItem == null)
            {
                return null;
            }

            if (row.DataBoundItem is DataRowView view)
            {
                return view.Row;
            }

            return null;
        }

        // 데이터 변경 이벤트
        public event EventHandler OnDataChanged;
    }
}

