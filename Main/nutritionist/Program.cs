using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

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
                // 데이터베이스 초기화는 로그인 후 필요할 때 수행
                // (시작 시 초기화하면 프로세스 종료 문제 발생 가능)
                
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
            catch (OracleException ex)
            {
                if (ex.Number == 1017 || ex.Number == 1034) // 로그인 실패
                {
                    MessageBox.Show(
                        "데이터베이스 연결에 실패했습니다.\n" +
                        "데이터베이스가 실행 중인지 확인해 주세요.",
                        "연결 오류",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        $"데이터베이스 오류가 발생했습니다.\n\n오류 코드: {ex.Number}\n오류 메시지: {ex.Message}",
                        "데이터베이스 오류",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
