using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace nutritionist
{
    public static class DatabaseHelper
    {
        public static DataTable ExecuteDataTable(string sql, params OracleParameter[] parameters)
        {
            try
            {
                using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
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
            catch (OracleException)
            {
                // OracleException은 그대로 다시 throw (원래 예외 정보 유지)
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"데이터 조회 중 오류가 발생했습니다: {ex.Message}", ex);
            }
        }

        public static object ExecuteScalar(string sql, params OracleParameter[] parameters)
        {
            try
            {
                using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
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
                    return cmd.ExecuteScalar();
                }
            }
            catch (OracleException)
            {
                // OracleException은 그대로 다시 throw (원래 예외 정보 유지)
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"데이터 조회 중 오류가 발생했습니다: {ex.Message}", ex);
            }
        }

        public static int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            try
            {
                using (var conn = new OracleConnection(DatabaseConfig.ConnectionString))
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
            catch (OracleException)
            {
                // OracleException은 그대로 다시 throw (원래 예외 정보 유지)
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"데이터 실행 중 오류가 발생했습니다: {ex.Message}", ex);
            }
        }

        public static int ToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            // DataRowView 처리
            if (value is System.Data.DataRowView rowView)
            {
                // DataRowView의 첫 번째 컬럼 값을 사용
                if (rowView.Row.ItemArray.Length > 0)
                {
                    value = rowView.Row.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            // DataRow 처리 (인덱서로 접근한 경우)
            else if (value is System.Data.DataRow dataRow)
            {
                // DataRow의 첫 번째 컬럼 값을 사용
                if (dataRow.ItemArray.Length > 0)
                {
                    value = dataRow.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            return Convert.ToInt32(value);
        }

        public static int? ToIntNullable(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            // DataRowView 처리
            if (value is System.Data.DataRowView rowView)
            {
                // DataRowView의 첫 번째 컬럼 값을 사용
                if (rowView.Row.ItemArray.Length > 0)
                {
                    value = rowView.Row.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            // DataRow 처리 (인덱서로 접근한 경우)
            else if (value is System.Data.DataRow dataRow)
            {
                // DataRow의 첫 번째 컬럼 값을 사용
                if (dataRow.ItemArray.Length > 0)
                {
                    value = dataRow.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            return Convert.ToInt32(value);
        }

        public static decimal ToDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            // DataRowView 처리
            if (value is System.Data.DataRowView rowView)
            {
                // DataRowView의 첫 번째 컬럼 값을 사용
                if (rowView.Row.ItemArray.Length > 0)
                {
                    value = rowView.Row.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            // DataRow 처리 (인덱서로 접근한 경우)
            else if (value is System.Data.DataRow dataRow)
            {
                // DataRow의 첫 번째 컬럼 값을 사용
                if (dataRow.ItemArray.Length > 0)
                {
                    value = dataRow.ItemArray[0];
                    if (value == null || value == DBNull.Value)
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            return Convert.ToDecimal(value);
        }

        public static string ToStringSafe(object value)
        {
            return value?.ToString() ?? string.Empty;
        }
    }
}

