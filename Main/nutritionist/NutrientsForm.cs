using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class NutrientsForm : Form
    {
        private readonly UserSession _session;

        public NutrientsForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvNutrients);
            if (txtNutrientCode != null) txtNutrientCode.ReadOnly = true;
            if (txtNutrientName != null) txtNutrientName.ReadOnly = true;
            if (txtNutrientUnit != null) txtNutrientUnit.ReadOnly = true;
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
            Load += NutrientsForm_Load;
            if (dgvNutrients != null)
            {
                dgvNutrients.CellClick += DgvNutrients_CellClick;
            }
            if (btnSearchNutrient != null)
            {
                btnSearchNutrient.Click += BtnSearchNutrient_Click;
            }
        }

        private void NutrientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNutrients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadNutrients();
        }

        private void LoadNutrients()
        {
            const string sql =
                "SELECT NutrientID, NutrientCode, NutrientName, Unit, ActiveFlag " +
                "FROM Nutrient ORDER BY NutrientName";

            if (dgvNutrients != null)
            {
                dgvNutrients.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvNutrients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNutrients?.CurrentRow == null) return;
            DisplayNutrient(dgvNutrients.CurrentRow);
        }

        private void DisplayNutrient(DataGridViewRow row)
        {
            if (txtNutrientCode != null)
            {
                txtNutrientCode.Text = row.Cells["NUTRIENTCODE"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtNutrientName != null)
            {
                txtNutrientName.Text = row.Cells["NUTRIENTNAME"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtNutrientUnit != null)
            {
                txtNutrientUnit.Text = row.Cells["UNIT"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void BtnSearchNutrient_Click(object sender, EventArgs e)
        {
            LoadNutrients();
        }
    }
}

