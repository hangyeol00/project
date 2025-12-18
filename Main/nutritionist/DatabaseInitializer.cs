using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public static class DatabaseInitializer
    {
        /// <summary>
        /// 데이터베이스 테이블이 존재하는지 확인
        /// </summary>
        public static bool CheckTablesExist()
        {
            try
            {
                const string sql = @"
                    SELECT COUNT(*) 
                    FROM USER_TABLES 
                    WHERE TABLE_NAME IN (
                        'APPUSER', 'RAWCATEGORY', 'RAWMATERIAL', 'NUTRIENT', 
                        'RAWNUTRIENT', 'ALLERGY', 'RAWALLERGY', 'INGREDIENT', 
                        'INGREDIENTCOMP', 'FINALMENU', 'MENUTAG', 'MENUTAGMAP', 
                        'MENUCOMP', 'MEALPLAN', 'MEAL', 'MEALCOMP', 'CONSUMER', 
                        'CONSUMERALLERGY', 'ALTASSIGN', 'MEALREVIEW', 'MEALREVIEWITEM', 
                        'ALTREVIEW', 'VENDOR', 'RAWCONTRACT', 'PURCHASEREQUEST'
                    )";

                var count = DatabaseHelper.ToInt(DatabaseHelper.ExecuteScalar(sql));
                return count >= 24; // 최소 24개 테이블이 있어야 함
            }
            catch (OracleException ex)
            {
                // 데이터베이스 연결 실패 등 Oracle 예외는 다시 던짐
                throw;
            }
            catch
            {
                // 기타 예외는 false 반환
                return false;
            }
        }

        /// <summary>
        /// 데이터베이스 테이블 생성
        /// </summary>
        public static bool InitializeDatabase(bool showProgress = true)
        {
            try
            {
                if (showProgress)
                {
                    var result = MessageBox.Show(
                        "데이터베이스 테이블이 없거나 불완전합니다.\n테이블을 생성하시겠습니까?",
                        "데이터베이스 초기화",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                    {
                        return false;
                    }
                }

                var schemaPath = Path.Combine(
                    Application.StartupPath,
                    "schema.sql");

                if (!File.Exists(schemaPath))
                {
                    // 실행 파일과 같은 디렉토리에서 찾기
                    var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    var exeDir = Path.GetDirectoryName(exePath);
                    schemaPath = Path.Combine(exeDir, "schema.sql");

                    if (!File.Exists(schemaPath))
                    {
                        MessageBox.Show(
                            "schema.sql 파일을 찾을 수 없습니다.\n" +
                            $"다음 경로에서 찾았습니다:\n{Application.StartupPath}\n{exeDir}",
                            "오류",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                }

                var schemaSql = File.ReadAllText(schemaPath, Encoding.UTF8);
                
                // SQL 문을 세미콜론으로 분리하고 실행
                var statements = schemaSql
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrWhiteSpace(s) && 
                                !s.StartsWith("--", StringComparison.Ordinal) &&
                                !s.StartsWith("SET", StringComparison.OrdinalIgnoreCase) &&
                                !s.StartsWith("COMMIT", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                var progressForm = showProgress ? new Form
                {
                    Text = "데이터베이스 초기화 중...",
                    Size = new System.Drawing.Size(400, 100),
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                } : null;

                var progressLabel = showProgress ? new Label
                {
                    Text = "테이블 생성 중...",
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                } : null;

                if (showProgress)
                {
                    progressForm.Controls.Add(progressLabel);
                    progressForm.Show();
                    Application.DoEvents();
                }

                var successCount = 0;
                var errorCount = 0;

                foreach (var statement in statements)
                {
                    try
                    {
                        // CREATE TABLE 문만 실행
                        if (statement.Trim().StartsWith("CREATE", StringComparison.OrdinalIgnoreCase))
                        {
                            DatabaseHelper.ExecuteNonQuery(statement);
                            successCount++;
                        }
                    }
                    catch (OracleException ex)
                    {
                        // 테이블이 이미 존재하는 경우 무시
                        if (ex.Number != 955) // ORA-00955: name is already used by an existing object
                        {
                            errorCount++;
                            if (showProgress)
                            {
                                MessageBox.Show(
                                    $"SQL 실행 중 오류:\n{statement.Substring(0, Math.Min(100, statement.Length))}...\n\n{ex.Message}",
                                    "오류",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        errorCount++;
                        if (showProgress)
                        {
                            MessageBox.Show(
                                $"SQL 실행 중 오류:\n{ex.Message}",
                                "오류",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }

                if (showProgress)
                {
                    progressForm?.Close();
                    progressForm?.Dispose();

                    MessageBox.Show(
                        $"데이터베이스 초기화 완료.\n성공: {successCount}개\n오류: {errorCount}개",
                        "완료",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                return CheckTablesExist();
            }
            catch (Exception ex)
            {
                if (showProgress)
                {
                    MessageBox.Show(
                        $"데이터베이스 초기화 중 오류가 발생했습니다.\n{ex.Message}",
                        "오류",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                return false;
            }
        }

        /// <summary>
        /// 애플리케이션 시작 시 데이터베이스 초기화 확인
        /// </summary>
        public static void EnsureDatabaseInitialized()
        {
            try
            {
                if (!CheckTablesExist())
                {
                    InitializeDatabase(true);
                }
            }
            catch (OracleException)
            {
                // 예외를 다시 던져서 Program.cs에서 처리하도록 함
                throw;
            }
            catch (Exception)
            {
                // 예외를 다시 던져서 Program.cs에서 처리하도록 함
                throw;
            }
        }
    }
}

