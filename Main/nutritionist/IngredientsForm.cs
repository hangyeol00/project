using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class IngredientsForm : Form
    {
        private readonly UserSession _session;
        private int? _selectedPurchaseRequestId;

        public IngredientsForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvIngredients);
            if (txtIngredientName != null) txtIngredientName.ReadOnly = true;
            if (txtIngredientUnit != null) txtIngredientUnit.ReadOnly = true;
            if (txtIngredientNutrient != null) txtIngredientNutrient.ReadOnly = true;
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
            Load += IngredientsForm_Load;
            if (dgvIngredients != null)
            {
                dgvIngredients.CellClick += DgvIngredients_CellClick;
            }
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPurchaseRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadPurchaseRequests();
        }

        private void LoadPurchaseRequests()
        {
            const string sql =
                "SELECT pr.PurchaseRequestID, r.RawName, pr.Quantity, pr.UnitPriceEstimate, pr.Status, " +
                "       pr.RequestedDate, pr.ExpectedDeliveryDate, NVL(req.UserName, pr.RequestedBy) AS RequestedByName, " +
                "       NVL(app.UserName, pr.ApprovedBy) AS ApprovedByName, pr.Remark " +
                "FROM PurchaseRequest pr " +
                "LEFT JOIN RawMaterial r ON pr.RawID = r.RawID " +
                "LEFT JOIN AppUser req ON pr.RequestedBy = req.UserID " +
                "LEFT JOIN AppUser app ON pr.ApprovedBy = app.UserID " +
                "ORDER BY pr.PurchaseRequestID DESC";

            if (dgvIngredients != null)
            {
                dgvIngredients.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvIngredients?.CurrentRow == null) return;
            DisplayPurchaseRequest(dgvIngredients.CurrentRow);
        }

        private void DisplayPurchaseRequest(DataGridViewRow row)
        {
            if (row?.Cells["PURCHASEREQUESTID"]?.Value == null)
            {
                _selectedPurchaseRequestId = null;
                return;
            }

            _selectedPurchaseRequestId = Convert.ToInt32(row.Cells["PURCHASEREQUESTID"].Value);
            if (txtIngredientName != null)
            {
                txtIngredientName.Text = row.Cells["RAWNAME"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtIngredientUnit != null)
            {
                txtIngredientUnit.Text = row.Cells["QUANTITY"]?.Value?.ToString() ?? string.Empty;
            }
            if (txtIngredientNutrient != null)
            {
                txtIngredientNutrient.Text = row.Cells["STATUS"]?.Value?.ToString() ?? string.Empty;
            }
        }
    }
}

