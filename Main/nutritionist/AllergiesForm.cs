using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class AllergiesForm : Form
    {
        private readonly UserSession _session;

        public AllergiesForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvAllergies);
            if (txtAllergyCode != null) txtAllergyCode.ReadOnly = true;
            if (txtAllergyName != null) txtAllergyName.ReadOnly = true;
            if (txtAllergyDescription != null) txtAllergyDescription.ReadOnly = true;
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
            Load += AllergiesForm_Load;
            if (dgvAllergies != null)
            {
                dgvAllergies.CellClick += DgvAllergies_CellClick;
            }
        }

        private void AllergiesForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllergies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadAllergies();
        }

        private void LoadAllergies()
        {
            const string sql =
                "SELECT AllergyID, AllergyCode, AllergyName, Description " +
                "FROM Allergy ORDER BY AllergyName";

            if (dgvAllergies != null)
            {
                dgvAllergies.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvAllergies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAllergies?.CurrentRow == null) return;
            DisplayAllergy(dgvAllergies.CurrentRow);
        }

        private void DisplayAllergy(DataGridViewRow row)
        {
            if (txtAllergyCode != null)
            {
                txtAllergyCode.Text = row.Cells["ALLERGYCODE"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtAllergyName != null)
            {
                txtAllergyName.Text = row.Cells["ALLERGYNAME"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtAllergyDescription != null)
            {
                txtAllergyDescription.Text = row.Cells["DESCRIPTION"]?.Value?.ToString() ?? string.Empty;
            }
        }
    }
}

