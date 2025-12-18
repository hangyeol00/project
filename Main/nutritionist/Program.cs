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

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show($"프로그램 실행 중 오류가 발생했습니다.\n\n오류 메시지: {ex.Message}\n\n스택 트레이스:\n{ex.StackTrace}", 
                    "치명적 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
