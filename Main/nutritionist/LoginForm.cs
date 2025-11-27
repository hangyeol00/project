using System;
using System.Drawing;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public class LoginForm : Form
    {
        private readonly (string Id, string Password, string Name, string Role)[] _builtinUsers =
        {
            ("admin", "admin123", "관리자", "ADMIN"),
            ("user1", "user123", "일반 사용자", "USER")
        };

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
            foreach (var user in _builtinUsers)
            {
                if (string.Equals(user.Id, userId, StringComparison.OrdinalIgnoreCase) &&
                    user.Password == password)
                {
                    return new UserSession(user.Id, user.Name, user.Role);
                }
            }

            const string sql =
                "SELECT USER_ID, USER_NAME, USER_ROLE " +
                "FROM APP_USER " +
                "WHERE USER_ID = :USER_ID AND USER_PASSWORD = :USER_PASSWORD";

            using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(new OracleParameter("USER_ID", userId));
                cmd.Parameters.Add(new OracleParameter("USER_PASSWORD", password));

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    var id = reader["USER_ID"]?.ToString() ?? userId;
                    var name = reader["USER_NAME"]?.ToString() ?? id;
                    var role = reader["USER_ROLE"]?.ToString() ?? "USER";
                    return new UserSession(id, name, role);
                }
            }
        }
    }
}
