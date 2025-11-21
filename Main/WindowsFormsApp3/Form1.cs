using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString =
            "User Id=cho; Password=1111; Data Source=" +
            "(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.menuReload.Click += MenuReload_Click;
            this.menuExit.Click += MenuExit_Click;
            this.dgvStudents.CellClick += DgvStudents_CellClick;
            this.dgvMenus.CellClick += DgvMenus_CellClick;
            this.btnServeMeal.Click += BtnServeMeal_Click;
            this.btnCancelMeal.Click += BtnCancelMeal_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void MenuReload_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadAll()
        {
            try
            {
                LoadSummary();
                LoadStudents();
                LoadMenus();
                LoadMealLogs();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private DataTable ExecuteDataTable(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(_connectionString))
            using (var cmd = new OracleCommand(sql, conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }

                var table = new DataTable();
                conn.Open();
                adapter.Fill(table);
                return table;
            }
        }

        private int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(_connectionString))
            using (var cmd = new OracleCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        private void LoadSummary()
        {
            var sqlTotalStudent = "SELECT COUNT(*) FROM STUDENT";
            var sqlTodayMeal =
                "SELECT COUNT(*) FROM MEAL_LOG " +
                "WHERE TRUNC(SERVE_TIME) = TRUNC(SYSDATE) AND CANCEL_YN = 'N'";
            var sqlNotMeal =
                "SELECT (SELECT COUNT(*) FROM STUDENT) - " +
                "       (SELECT COUNT(*) FROM MEAL_LOG " +
                "         WHERE TRUNC(SERVE_TIME) = TRUNC(SYSDATE) AND CANCEL_YN = 'N') " +
                "FROM DUAL";

            var total = ExecuteDataTable(sqlTotalStudent);
            var today = ExecuteDataTable(sqlTodayMeal);
            var notMeal = ExecuteDataTable(sqlNotMeal);

            lblTotalStudentValue.Text = total.Rows.Count > 0 ? total.Rows[0][0].ToString() : "0";
            lblTodayMealValue.Text = today.Rows.Count > 0 ? today.Rows[0][0].ToString() : "0";
            lblNotMealValue.Text = notMeal.Rows.Count > 0 ? notMeal.Rows[0][0].ToString() : "0";
        }

        private void LoadStudents()
        {
            var sql =
                "SELECT STUDENT_ID, NAME, GRADE, CLASS_NAME " +
                "FROM STUDENT ORDER BY STUDENT_ID";
            dgvStudents.DataSource = ExecuteDataTable(sql);
        }

        private void LoadMenus()
        {
            var sql =
                "SELECT MENU_CODE, MENU_NAME, PRICE " +
                "FROM MENU ORDER BY MENU_CODE";
            dgvMenus.DataSource = ExecuteDataTable(sql);
        }

        private void LoadMealLogs()
        {
            var sql =
                "SELECT L.LOG_ID, L.STUDENT_ID, S.NAME AS STUDENT_NAME, " +
                "       L.MENU_CODE, M.MENU_NAME, L.SERVE_TIME, L.CANCEL_YN " +
                "FROM MEAL_LOG L " +
                "JOIN STUDENT S ON L.STUDENT_ID = S.STUDENT_ID " +
                "JOIN MENU M ON L.MENU_CODE = M.MENU_CODE " +
                "ORDER BY L.SERVE_TIME DESC, L.LOG_ID DESC";
            dgvMealLogs.DataSource = ExecuteDataTable(sql);
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvStudents.CurrentRow == null)
            {
                return;
            }

            var studentId = dgvStudents.CurrentRow.Cells["STUDENT_ID"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(studentId))
            {
                txtStudentId.Text = studentId;
            }
        }

        private void DgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMenus.CurrentRow == null)
            {
                return;
            }

            var menuCode = dgvMenus.CurrentRow.Cells["MENU_CODE"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(menuCode))
            {
                txtMenuCode.Text = menuCode;
            }
        }

        private void BtnServeMeal_Click(object sender, EventArgs e)
        {
            var studentId = txtStudentId.Text.Trim();
            var menuCode = txtMenuCode.Text.Trim();

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(menuCode))
            {
                MessageBox.Show("학생 ID와 메뉴 코드를 모두 입력해 주세요.", "알림");
                return;
            }

            var sql =
                "INSERT INTO MEAL_LOG (LOG_ID, STUDENT_ID, MENU_CODE, SERVE_TIME, CANCEL_YN) " +
                "VALUES (MEAL_LOG_SEQ.NEXTVAL, :STUDENT_ID, :MENU_CODE, SYSDATE, 'N')";

            try
            {
                var rows = ExecuteNonQuery(sql,
                    new OracleParameter("STUDENT_ID", studentId),
                    new OracleParameter("MENU_CODE", menuCode));

                if (rows > 0)
                {
                    MessageBox.Show("급식 처리가 완료되었습니다.", "완료");
                    ReloadAll();
                }
                else
                {
                    MessageBox.Show("급식 처리에 실패했습니다.", "오류");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"급식 처리 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private void BtnCancelMeal_Click(object sender, EventArgs e)
        {
            if (dgvMealLogs.CurrentRow == null)
            {
                MessageBox.Show("취소할 급식 기록을 선택해 주세요.", "알림");
                return;
            }

            var logIdObj = dgvMealLogs.CurrentRow.Cells["LOG_ID"].Value;
            if (logIdObj == null || !int.TryParse(logIdObj.ToString(), out var logId))
            {
                MessageBox.Show("선택한 급식 기록의 LOG_ID가 올바르지 않습니다.", "알림");
                return;
            }

            var sql =
                "UPDATE MEAL_LOG " +
                "SET CANCEL_YN = 'Y' " +
                "WHERE LOG_ID = :LOG_ID";

            try
            {
                var rows = ExecuteNonQuery(sql, new OracleParameter("LOG_ID", logId));
                if (rows > 0)
                {
                    MessageBox.Show("급식 기록이 취소되었습니다.", "완료");
                    ReloadAll();
                }
                else
                {
                    MessageBox.Show("급식 취소에 실패했습니다.", "오류");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"급식 취소 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }
    }
}

