using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseManager
{
    class DatabaseManager
    {
        private SqlConnection connection;

        public DatabaseManager(string databaseName)
        {
            string cnString;
            try
            {
                cnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\" + databaseName + ".mdf" + ";Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection();
                connection.ConnectionString = cnString;
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecuteQuery(string cmd)
        {
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText += cmd;
            SqlDataAdapter adp;
            commandObj.Connection = connection;
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter(commandObj);
            try
            {
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            int ris = -1;
            cmd.Connection = connection;
            try
            {
                ris = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ris;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            object ris = -1;
            cmd.Connection = connection;
            try
            {
                ris = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ris;
        }
    }
}
