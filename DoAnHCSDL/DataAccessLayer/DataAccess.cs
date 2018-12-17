using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection connection = null;
        private Exception error = null;
        public Exception Error
        {
            get
            {
                return error;
            }
        }
        public DataAccess()
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();

            connectionBuilder.DataSource = ConfigurationSettings.AppSettings["Server"];
            connectionBuilder.InitialCatalog = ConfigurationSettings.AppSettings["Database"];
            connectionBuilder.UserID = ConfigurationSettings.AppSettings["UserID"];
            connectionBuilder.Password = ConfigurationSettings.AppSettings["Password"];
            connectionBuilder.IntegratedSecurity = ConfigurationSettings.AppSettings["IntergratedSecurity"] == "true";

            connection = new SqlConnection(connectionBuilder.ConnectionString);

        }
        public SqlDataReader GetReader(string sqlCommand)
        {
            error = null;
            try
            {
                SqlCommand command = new SqlCommand(sqlCommand);
                command.Connection = connection;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
            catch (Exception ex)
            {
                error = ex;
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                return null;
            }
        }

        public int Execute(string commandText, params SqlParameter[] parameters)
        {
            int result = -1;
            error = null;
            try
            {
                SqlCommand command = new SqlCommand(commandText);
                command.Parameters.AddRange(parameters);
                command.Connection = connection;

                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex;       
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
        }
        public DataSet GetDataSet(string commandText, params SqlParameter[] parameters)
        {
            DataSet result = new DataSet();
            error = null;
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, connection);
                dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                connection.Open();
                dataAdapter.Fill(result);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
        }
    }
}
