using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class StudentAllergyForm : Form
    {
        private readonly UserSession _session;
        private int? _selectedConsumerId;
        private int? _selectedAllergyId;

        public StudentAllergyForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvStudents);
            ConfigureGrid(dgvAllergies);
            if (txtStudentInfo != null) txtStudentInfo.ReadOnly = true;
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
            Load += StudentAllergyForm_Load;
            if (dgvStudents != null)
            {
                dgvStudents.CellClick += DgvStudents_CellClick;
            }
            if (dgvAllergies != null)
            {
                dgvAllergies.CellClick += DgvAllergies_CellClick;
            }
            if (cmbAllergy != null)
            {
                cmbAllergy.SelectedIndexChanged += CmbAllergy_SelectedIndexChanged;
            }
            if (btnAdd != null) btnAdd.Click += BtnAdd_Click;
            if (btnRemove != null) btnRemove.Click += BtnRemove_Click;
        }

        private void StudentAllergyForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStudents();
                LoadAllergyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadStudents();
            if (_selectedConsumerId != null)
            {
                LoadStudentAllergies();
            }
        }

        private void LoadStudents()
        {
            try
            {
                const string sql =
                    "SELECT ConsumerID, Name, Grade, Class, ConsumerType, Status " +
                    "FROM Consumer " +
                    "WHERE ConsumerType = 'S' AND Status = 'ACTIVE' " +
                    "ORDER BY Grade, Class, Name";

                var table = DatabaseHelper.ExecuteDataTable(sql);
                if (dgvStudents != null)
                {
                    dgvStudents.DataSource = table;
                    ConfigureGrid(dgvStudents);

                    if (dgvStudents.Rows.Count > 0)
                    {
                        dgvStudents.Rows[0].Selected = true;
                        SetSelectedStudentFromRow(dgvStudents.Rows[0]);
                    }
                    else
                    {
                        _selectedConsumerId = null;
                        LoadStudentAllergies();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"학생 목록 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvStudents?.CurrentRow == null)
            {
                return;
            }

            SetSelectedStudentFromRow(dgvStudents.CurrentRow);
        }

        private void SetSelectedStudentFromRow(DataGridViewRow row)
        {
            var dataRow = GetDataRowFromGrid(row);
            if (dataRow == null)
            {
                _selectedConsumerId = null;
                LoadStudentAllergies();
                return;
            }

            _selectedConsumerId = DatabaseHelper.ToIntNullable(dataRow["ConsumerID"]);
            if (txtStudentInfo != null)
            {
                var name = dataRow["Name"]?.ToString() ?? string.Empty;
                var grade = dataRow["Grade"]?.ToString() ?? string.Empty;
                var className = dataRow["Class"]?.ToString() ?? string.Empty;
                txtStudentInfo.Text = $"{name} ({grade}학년 {className}반)";
            }
            LoadStudentAllergies();
        }

        private void LoadStudentAllergies()
        {
            try
            {
                if (_selectedConsumerId == null)
                {
                    if (dgvAllergies != null)
                    {
                        dgvAllergies.DataSource = null;
                    }
                    return;
                }

                const string sql =
                    "SELECT a.AllergyID, a.AllergyCode, a.AllergyName, a.Description " +
                    "FROM ConsumerAllergy ca " +
                    "INNER JOIN Allergy a ON ca.AllergyID = a.AllergyID " +
                    "WHERE ca.ConsumerID = :CONSUMERID " +
                    "ORDER BY a.AllergyCode";

                var table = DatabaseHelper.ExecuteDataTable(sql,
                    new OracleParameter("CONSUMERID", _selectedConsumerId));

                if (dgvAllergies != null)
                {
                    dgvAllergies.DataSource = table;
                    ConfigureGrid(dgvAllergies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"학생 알레르기 목록 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllergyList()
        {
            try
            {
                const string sql =
                    "SELECT AllergyID, AllergyCode, AllergyName " +
                    "FROM Allergy " +
                    "ORDER BY AllergyCode";

                var table = DatabaseHelper.ExecuteDataTable(sql);
                if (cmbAllergy != null)
                {
                    cmbAllergy.DataSource = table;
                    cmbAllergy.DisplayMember = "AllergyName";
                    cmbAllergy.ValueMember = "AllergyID";
                    cmbAllergy.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알레르기 목록 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbAllergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAllergy?.SelectedValue != null)
            {
                _selectedAllergyId = DatabaseHelper.ToIntNullable(cmbAllergy.SelectedValue);
            }
        }

        private void DgvAllergies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAllergies?.CurrentRow == null)
            {
                return;
            }

            var dataRow = GetDataRowFromGrid(dgvAllergies.CurrentRow);
            if (dataRow != null)
            {
                _selectedAllergyId = DatabaseHelper.ToIntNullable(dataRow["AllergyID"]);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedConsumerId == null)
            {
                MessageBox.Show("학생을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_selectedAllergyId == null)
            {
                MessageBox.Show("알레르기를 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 이미 등록된 알레르기인지 확인
                var exists = DatabaseHelper.ToInt(
                    DatabaseHelper.ExecuteScalar(
                        "SELECT COUNT(*) FROM ConsumerAllergy WHERE ConsumerID = :CONSUMERID AND AllergyID = :ALLERGYID",
                        new OracleParameter("CONSUMERID", _selectedConsumerId),
                        new OracleParameter("ALLERGYID", _selectedAllergyId)));

                if (exists > 0)
                {
                    MessageBox.Show("이미 등록된 알레르기입니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 알레르기 추가
                const string sql = "INSERT INTO ConsumerAllergy (ConsumerID, AllergyID) VALUES (:CONSUMERID, :ALLERGYID)";
                DatabaseHelper.ExecuteNonQuery(sql,
                    new OracleParameter("CONSUMERID", _selectedConsumerId),
                    new OracleParameter("ALLERGYID", _selectedAllergyId));

                MessageBox.Show("알레르기가 추가되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentAllergies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알레르기 추가 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (_selectedConsumerId == null)
            {
                MessageBox.Show("학생을 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_selectedAllergyId == null)
            {
                MessageBox.Show("삭제할 알레르기를 선택해 주세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("선택한 알레르기를 삭제하시겠습니까?", "확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                const string sql = "DELETE FROM ConsumerAllergy WHERE ConsumerID = :CONSUMERID AND AllergyID = :ALLERGYID";
                var rows = DatabaseHelper.ExecuteNonQuery(sql,
                    new OracleParameter("CONSUMERID", _selectedConsumerId),
                    new OracleParameter("ALLERGYID", _selectedAllergyId));

                if (rows > 0)
                {
                    MessageBox.Show("알레르기가 삭제되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentAllergies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알레르기 삭제 중 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

