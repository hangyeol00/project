using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class UsersForm : Form
    {
        private readonly UserSession _session;

        public UsersForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvUsers);
            if (txtUserName != null) txtUserName.ReadOnly = true;
            if (txtUserGrade != null) txtUserGrade.ReadOnly = true;
            if (txtUserClass != null) txtUserClass.ReadOnly = true;
            if (txtUserAllergyNotes != null) txtUserAllergyNotes.ReadOnly = true;
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
            Load += UsersForm_Load;
            if (dgvUsers != null)
            {
                dgvUsers.CellClick += DgvUsers_CellClick;
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            const string sql =
                "SELECT UserID, UserName, Grade, Class, AllergyNotes " +
                "FROM AppUser WHERE UserType = 'STUDENT' ORDER BY UserName";

            if (dgvUsers != null)
            {
                dgvUsers.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvUsers?.CurrentRow == null) return;
            DisplayUser(dgvUsers.CurrentRow);
        }

        private void DisplayUser(DataGridViewRow row)
        {
            if (txtUserName != null)
            {
                txtUserName.Text = row.Cells["USERNAME"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtUserGrade != null)
            {
                txtUserGrade.Text = row.Cells["GRADE"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtUserClass != null)
            {
                txtUserClass.Text = row.Cells["CLASS"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtUserAllergyNotes != null)
            {
                txtUserAllergyNotes.Text = row.Cells["ALLERGYNOTES"]?.Value?.ToString() ?? string.Empty;
            }
        }
    }
}

