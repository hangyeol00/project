using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class PurchaseApprovalForm : Form
    {
        private const string PurchaseStatusRequested = "REQUESTED";
        private const string PurchaseStatusApproved = "APPROVED";
        private const string PurchaseStatusRejected = "REJECTED";

        private readonly UserSession _session;
        private int? _selectedPurchaseRequestId;

        public PurchaseApprovalForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvPurchaseRequests);
            if (txtRawName != null) txtRawName.ReadOnly = true;
            if (txtDetails != null) txtDetails.ReadOnly = true;
            if (txtStatus != null) txtStatus.ReadOnly = true;
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
            Load += PurchaseApprovalForm_Load;
            if (dgvPurchaseRequests != null)
            {
                dgvPurchaseRequests.CellClick += DgvPurchaseRequests_CellClick;
            }
            if (btnApprove != null) btnApprove.Click += BtnApprove_Click;
            if (btnReject != null) btnReject.Click += BtnReject_Click;
        }

        private void PurchaseApprovalForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPurchaseRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadPurchaseRequests();
        }

        private void LoadPurchaseRequests()
        {
            try
            {
                const string sql =
                    "SELECT pr.PurchaseRequestID, r.RawName, pr.Quantity, pr.UnitPriceEstimate, pr.Status, " +
                    "       pr.RequestedDate, pr.ExpectedDeliveryDate, NVL(req.UserName, pr.RequestedBy) AS RequestedByName, " +
                    "       NVL(app.UserName, pr.ApprovedBy) AS ApprovedByName, pr.Remark " +
                    "FROM PurchaseRequest pr " +
                    "LEFT JOIN RawMaterial r ON pr.RawID = r.RawID " +
                    "LEFT JOIN AppUser req ON pr.RequestedBy = req.UserID " +
                    "LEFT JOIN AppUser app ON pr.ApprovedBy = app.UserID " +
                    "ORDER BY pr.RequestedDate DESC, pr.PurchaseRequestID DESC";

                var table = DatabaseHelper.ExecuteDataTable(sql);
                if (dgvPurchaseRequests != null)
                {
                    dgvPurchaseRequests.DataSource = table;
                    ConfigureGrid(dgvPurchaseRequests);

                    if (dgvPurchaseRequests.Rows.Count > 0)
                    {
                        dgvPurchaseRequests.Rows[0].Selected = true;
                        SetSelectedPurchaseRequestFromRow(dgvPurchaseRequests.Rows[0]);
                    }
                    else
                    {
                        _selectedPurchaseRequestId = null;
                        DisplayPurchaseRequestDetail(null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"발주 요청 목록 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPurchaseRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPurchaseRequests?.CurrentRow == null)
            {
                return;
            }

            SetSelectedPurchaseRequestFromRow(dgvPurchaseRequests.CurrentRow);
        }

        private void SetSelectedPurchaseRequestFromRow(DataGridViewRow row)
        {
            var dataRow = GetDataRowFromGrid(row);
            if (dataRow == null)
            {
                _selectedPurchaseRequestId = null;
                DisplayPurchaseRequestDetail(null);
                return;
            }

            _selectedPurchaseRequestId = DatabaseHelper.ToIntNullable(dataRow["PurchaseRequestID"]);
            DisplayPurchaseRequestDetail(dataRow);
        }

        private void DisplayPurchaseRequestDetail(DataRow row)
        {
            if (txtRawName != null)
            {
                txtRawName.Text = row?["RawName"]?.ToString() ?? string.Empty;
            }
            if (txtDetails != null)
            {
                var quantity = row?["Quantity"]?.ToString() ?? "0";
                var unitPrice = row?["UnitPriceEstimate"]?.ToString() ?? "0";
                txtDetails.Text = $"수량: {quantity}, 예상 단가: {unitPrice}원";
            }
            if (txtStatus != null)
            {
                var status = row?["Status"]?.ToString() ?? string.Empty;
                var requestedBy = row?["RequestedByName"]?.ToString() ?? string.Empty;
                var requestedDate = row?["RequestedDate"]?.ToString() ?? string.Empty;
                txtStatus.Text = $"상태: {status}, 요청자: {requestedBy}, 요청일: {requestedDate}";
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseRequestId == null)
            {
                MessageBox.Show("승인할 발주 요청을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                const string sql =
                    "UPDATE PurchaseRequest SET Status = :STATUS, ApprovedBy = :APPROVEDBY, ApprovedDate = SYSDATE " +
                    "WHERE PurchaseRequestID = :ID";

                var rows = DatabaseHelper.ExecuteNonQuery(sql,
                    new OracleParameter("STATUS", PurchaseStatusApproved),
                    new OracleParameter("APPROVEDBY", _session?.UserId ?? "ADMIN"),
                    new OracleParameter("ID", _selectedPurchaseRequestId));

                if (rows > 0)
                {
                    MessageBox.Show("발주 요청이 승인되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPurchaseRequests();
                    OnDataChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"발주 승인 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseRequestId == null)
            {
                MessageBox.Show("거부할 발주 요청을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 거부 사유 입력 다이얼로그
            using (var inputForm = new Form())
            {
                inputForm.Text = "발주 요청 거부";
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

                var reason = txtReason.Text?.Trim() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("거부 사유를 입력해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    const string sql =
                        "UPDATE PurchaseRequest SET Status = :STATUS, ApprovedBy = :APPROVEDBY, ApprovedDate = SYSDATE, Remark = :REMARK " +
                        "WHERE PurchaseRequestID = :ID";

                    var rows = DatabaseHelper.ExecuteNonQuery(sql,
                        new OracleParameter("STATUS", PurchaseStatusRejected),
                        new OracleParameter("APPROVEDBY", _session?.UserId ?? "ADMIN"),
                        new OracleParameter("REMARK", reason),
                        new OracleParameter("ID", _selectedPurchaseRequestId));

                    if (rows > 0)
                    {
                        MessageBox.Show("발주 요청이 거부되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPurchaseRequests();
                        OnDataChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"발주 거부 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        // 데이터 변경 이벤트 (대시보드 새로고침용)
        public event EventHandler OnDataChanged;
    }
}

