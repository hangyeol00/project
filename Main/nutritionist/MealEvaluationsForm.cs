using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public partial class MealEvaluationsForm : Form
    {
        private readonly UserSession _session;

        public MealEvaluationsForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            InitializeLayout();
            AttachEventHandlers();
        }

        private void InitializeLayout()
        {
            ConfigureGrid(dgvMealEvaluations);
            LoadComboBoxes();
            if (nudEvaluationScore != null)
            {
                nudEvaluationScore.Minimum = 1;
                nudEvaluationScore.Maximum = 5;
                nudEvaluationScore.Value = 3;
            }
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
            if (cmbEvaluationMeal != null)
            {
                const string mealSql = "SELECT DISTINCT MealID, TO_CHAR(MealDate, 'YYYY-MM-DD') || ' ' || MealType AS MealDisplay " +
                                       "FROM Meal ORDER BY MealDate DESC, MealType";
                var mealTable = DatabaseHelper.ExecuteDataTable(mealSql);
                cmbEvaluationMeal.DataSource = mealTable;
                cmbEvaluationMeal.DisplayMember = "MEALDISPLAY";
                cmbEvaluationMeal.ValueMember = "MEALID";
            }

            if (cmbEvaluationUser != null)
            {
                const string userSql = "SELECT UserID, UserName FROM AppUser WHERE UserType = 'STUDENT' ORDER BY UserName";
                var userTable = DatabaseHelper.ExecuteDataTable(userSql);
                cmbEvaluationUser.DataSource = userTable;
                cmbEvaluationUser.DisplayMember = "USERNAME";
                cmbEvaluationUser.ValueMember = "USERID";
            }
        }

        private void AttachEventHandlers()
        {
            Load += MealEvaluationsForm_Load;
            if (dgvMealEvaluations != null)
            {
                dgvMealEvaluations.CellClick += DgvMealEvaluations_CellClick;
            }
            if (btnRefreshEvaluation != null)
            {
                btnRefreshEvaluation.Click += BtnRefreshEvaluation_Click;
            }
        }

        private void MealEvaluationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMealEvaluations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reload()
        {
            LoadMealEvaluations();
        }

        private void LoadMealEvaluations()
        {
            const string sql =
                "SELECT me.EvaluationID, TO_CHAR(m.MealDate, 'YYYY-MM-DD') || ' ' || m.MealType AS MealDisplay, " +
                "       u.UserName, me.Score, me.Comment " +
                "FROM MealEvaluation me " +
                "JOIN Meal m ON me.MealID = m.MealID " +
                "JOIN AppUser u ON me.UserID = u.UserID " +
                "ORDER BY m.MealDate DESC, u.UserName";

            if (dgvMealEvaluations != null)
            {
                dgvMealEvaluations.DataSource = DatabaseHelper.ExecuteDataTable(sql);
            }
        }

        private void DgvMealEvaluations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMealEvaluations?.CurrentRow == null) return;
            DisplayEvaluation(dgvMealEvaluations.CurrentRow);
        }

        private void DisplayEvaluation(DataGridViewRow row)
        {
            if (cmbEvaluationMeal != null)
            {
                var mealDisplay = row.Cells["MEALDISPLAY"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(mealDisplay))
                {
                    var index = cmbEvaluationMeal.FindString(mealDisplay);
                    if (index >= 0) cmbEvaluationMeal.SelectedIndex = index;
                }
            }
            if (cmbEvaluationUser != null)
            {
                var userName = row.Cells["USERNAME"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(userName))
                {
                    var index = cmbEvaluationUser.FindString(userName);
                    if (index >= 0) cmbEvaluationUser.SelectedIndex = index;
                }
            }
            if (nudEvaluationScore != null)
            {
                var score = row.Cells["SCORE"]?.Value;
                if (score != null && score != DBNull.Value)
                {
                    nudEvaluationScore.Value = Convert.ToDecimal(score);
                }
            }
            if (txtEvaluationComment != null)
            {
                txtEvaluationComment.Text = row.Cells["COMMENT"]?.Value?.ToString() ?? string.Empty;
            }
        }

        private void BtnRefreshEvaluation_Click(object sender, EventArgs e)
        {
            LoadMealEvaluations();
        }
    }
}

