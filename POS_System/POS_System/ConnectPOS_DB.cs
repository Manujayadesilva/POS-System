using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    internal class ConnectPOS_DB : IDisposable
    {
        private SqlConnection connection;
        private string connstring = @"data source=LAPTOP-P5VP3OC;initial catalog=POS;integrated security=true";

        public SqlConnection GetConn()
        {
            connection = new SqlConnection(connstring);
            connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void OpenConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Dispose()
        {
            CloseConnection();
            connection?.Dispose();
        }
    }
}
