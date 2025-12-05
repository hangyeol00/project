using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nutritionist
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                var session = loginForm.Session;
                if (result != DialogResult.OK || session == null)
                {
                    return;
                }

                if (session.IsAdmin)
                {
                    Application.Run(new AdminForm(session));
                }
                else
                {
                    Application.Run(new NutritionistForm(session));
                }
            }
        }
    }
}
