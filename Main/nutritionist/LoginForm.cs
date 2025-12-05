using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public class LoginForm : Form
    {

        private Label lblTitle;
        private Label lblUserId;
        private Label lblPassword;
        private Label lblStatus;
        private TextBox txtUserId;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;

        public UserSession Session { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUserId = new Label();
            lblPassword = new Label();
            lblStatus = new Label();
            txtUserId = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();

            SuspendLayout();

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 230);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "로그인";

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Text = "급식 시스템 로그인";

            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(26, 60);
            lblUserId.Text = "아이디";

            txtUserId.Location = new Point(26, 80);
            txtUserId.Size = new Size(280, 23);

            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(26, 112);
            lblPassword.Text = "비밀번호";

            txtPassword.Location = new Point(26, 132);
            txtPassword.Size = new Size(280, 23);
            txtPassword.UseSystemPasswordChar = true;

            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Firebrick;
            lblStatus.Location = new Point(26, 162);
            lblStatus.Visible = false;

            btnLogin.Location = new Point(26, 186);
            btnLogin.Size = new Size(140, 30);
            btnLogin.Text = "로그인";

            btnCancel.Location = new Point(169, 186);
            btnCancel.Size = new Size(137, 30);
            btnCancel.Text = "취소";

            Controls.Add(lblTitle);
            Controls.Add(lblUserId);
            Controls.Add(txtUserId);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblStatus);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);

            AcceptButton = btnLogin;
            CancelButton = btnCancel;

            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = false;

            var userId = txtUserId.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "아이디와 비밀번호를 모두 입력하세요.";
                lblStatus.Visible = true;
                return;
            }

            try
            {
                var session = Authenticate(userId, password);
                if (session == null)
                {
                    lblStatus.Text = "아이디 또는 비밀번호가 올바르지 않습니다.";
                    lblStatus.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                Session = session;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"로그인 중 오류가 발생했습니다.\n{ex.Message}", "DB 오류");
            }
        }

        private UserSession Authenticate(string userId, string password)
        {
         

            const string sql =
                "SELECT USERID, USERNAME, USERTYPE, PASSWORDHASH, PASSWORDSALT, STATUS " +
                "FROM APPUSER WHERE USERID = :USER_ID";

            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(new OracleParameter("USER_ID", userId));

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    var status = reader["STATUS"]?.ToString() ?? "ACTIVE";
                    if (!string.Equals(status, "ACTIVE", StringComparison.OrdinalIgnoreCase))
                    {
                        return null;
                    }

                    var hash = reader["PASSWORDHASH"]?.ToString();
                    var salt = reader["PASSWORDSALT"]?.ToString();
                    MessageBox.Show(
                        $"입력 비밀번호: {password}\n계산된 해시: {ComputeHashPreview(password, salt)}\nDB 해시: {hash}",
                        "디버그",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (!VerifyPassword(password, hash, salt))
                    {
                        IncrementFailedLoginCount(conn, userId);
                        return null;
                    }

                    ResetFailedLoginCount(conn, userId);

                    var id = reader["USERID"]?.ToString() ?? userId;
                    var name = reader["USERNAME"]?.ToString() ?? id;
                    var role = reader["USERTYPE"]?.ToString() ?? "USER";
                    return new UserSession(id, name, role);
                }
            }
        }

        private static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            if (string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(storedHash) ||
                string.IsNullOrWhiteSpace(storedSalt))
            {
                return false;
            }

            try
            {
                var saltBytes = Convert.FromBase64String(storedSalt);
                var computedBytes = DeriveHash(password, saltBytes);
                var computed = Convert.ToBase64String(computedBytes);
                return string.Equals(computed, storedHash, StringComparison.Ordinal);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static string ComputeHashPreview(string password, string storedSalt)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(storedSalt))
            {
                return string.Empty;
            }

            try
            {
                var saltBytes = Convert.FromBase64String(storedSalt);
                var bytes = DeriveHash(password, saltBytes);
                return Convert.ToBase64String(bytes);
            }
            catch (FormatException)
            {
                return string.Empty;
            }
        }

        private static byte[] DeriveHash(string password, byte[] salt)
        {
            return new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256)
                .GetBytes(32);
        }

        private static void IncrementFailedLoginCount(OracleConnection connection, string userId)
        {
            using (var cmd = new OracleCommand(
                       "UPDATE APPUSER SET FAILEDLOGINCOUNT = NVL(FAILEDLOGINCOUNT, 0) + 1 WHERE USERID = :USER_ID",
                       connection))
            {
                cmd.Parameters.Add(new OracleParameter("USER_ID", userId));
                cmd.ExecuteNonQuery();
            }
        }

        private static void ResetFailedLoginCount(OracleConnection connection, string userId)
        {
            using (var cmd = new OracleCommand(
                       "UPDATE APPUSER SET FAILEDLOGINCOUNT = 0, LASTLOGINAT = SYSDATE WHERE USERID = :USER_ID",
                       connection))
            {
                cmd.Parameters.Add(new OracleParameter("USER_ID", userId));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
