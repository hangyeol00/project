using System;
using System.Windows.Forms;

namespace nutritionist
{
    public partial class AdminForm : Form
    {
        private readonly UserSession _session;

        public AdminForm() : this(null)
        {
        }

        public AdminForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            if (tabMain != null && tabDashboard != null)
            {
                tabMain.TabPages.Remove(tabDashboard);
            }
            var titleSuffix = !string.IsNullOrWhiteSpace(_session?.UserName)
                ? $" - {_session.UserName}"
                : string.Empty;
            Text = $"공급업체 / 관리자 도구{titleSuffix}";
        }
    }
}
