using System;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WTP_Report_Manager.Workers
{
    public static class SqlManagment
    {
        public static void SqlTestConnection(string sqlConnectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            SqlCommand command = new SqlCommand("SELECT 1", sqlConnection);

            try
            {
                sqlConnection.Open();
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception($"SqlManagement.SqlTestConnection - {ex.Message}");
            }
        }

        public static DataTable SqlGetDbUsage(string sqlConnectionString)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                SqlCommand command = new SqlCommand("exec sp_spaceused", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception("SqlManagement.SqlGetDbUsage - Failed", ex.InnerException);
            }

            return dataTable;
        }

        public static DataTable SqlExecuteQuery(string sqlConnectionString, string qry)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                SqlCommand command = new SqlCommand(qry, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception($"SqlManagement.SqlExecuteQuery - {ex.Message}");
            }

            return dataTable;

        }

        public static async Task<DataTable> SqlExecuteQueryAsync(string sqlConnectionString, string qry)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                SqlCommand command = new SqlCommand(qry, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                await Task.Run(() => dataAdapter.Fill(dataTable));
            }
            catch (Exception ex)
            {
                throw new Exception("SqlManagement.SqlExecuteQuery - Sql Query Failed", ex.InnerException);
            }

            return dataTable;

        }
    }
}
