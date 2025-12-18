using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class AllergyRelationsForm : Form
    {
        private readonly UserSession _session;

        public AllergyRelationsForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvAllergyRelations);
            LoadComboBoxes();
        }

        private static void ConfigureGrid(DataGridView grid)
        {
            if (grid == null) return;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadComboBoxes()
        {
            if (cmbRelationUser != null)
            {
                const string userSql = "SELECT UserID, UserName FROM AppUser WHERE UserType = 'STUDENT' ORDER BY UserName";
                var userTable = DatabaseHelper.ExecuteDataTable(userSql);
                cmbRelationUser.DataSource = userTable;
                cmbRelationUser.DisplayMember = "USERNAME";
                cmbRelationUser.ValueMember = "USERID";
            }

            if (cmbRelationAllergy != null)
            {
                const string allergySql = "SELECT AllergyID, AllergyName FROM Allergy ORDER BY AllergyName";
                var allergyTable = DatabaseHelper.ExecuteDataTable(allergySql);
                cmbRelationAllergy.DataSource = allergyTable;
                cmbRelationAllergy.DisplayMember = "ALLERGYNAME";
                cmbRelationAllergy.ValueMember = "ALLERGYID";
            }
        }

        private void AttachEventHandlers()
        {
            Load += AllergyRelationsForm_Load;
            if (dgvAllergyRelations != null)
            {
                dgvAllergyRelations.CellClick += DgvAllergyRelations_CellClick;
            }
        }

        private void AllergyRelationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllergyRelations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadAllergyRelations();
        }

        private void LoadAllergyRelations()
        {
            const string sql =
                "SELECT ar.RelationID, u.UserName, a.AllergyName, ar.Notes " +
                "FROM AllergyRelation ar " +
                "JOIN AppUser u ON ar.UserID = u.UserID " +
                "JOIN Allergy a ON ar.AllergyID = a.AllergyID " +
                "ORDER BY u.UserName, a.AllergyName";

            if (dgvAllergyRelations != null)
            {
                dgvAllergyRelations.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvAllergyRelations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAllergyRelations?.CurrentRow == null) return;
            DisplayRelation(dgvAllergyRelations.CurrentRow);
        }

        private void DisplayRelation(DataGridViewRow row)
        {
            if (cmbRelationUser != null)
            {
                var userName = row.Cells["USERNAME"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(userName))
                {
                    var index = cmbRelationUser.FindString(userName);
                    if (index >= 0) cmbRelationUser.SelectedIndex = index;
                }
            }
            if (cmbRelationAllergy != null)
            {
                var allergyName = row.Cells["ALLERGYNAME"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(allergyName))
                {
                    var index = cmbRelationAllergy.FindString(allergyName);
                    if (index >= 0) cmbRelationAllergy.SelectedIndex = index;
                }
            }
            if (txtRelationNotes != null)
            {
                txtRelationNotes.Text = row.Cells["NOTES"]?.Value?.ToString() ?? string.Empty;
            }
        }
    }
}

