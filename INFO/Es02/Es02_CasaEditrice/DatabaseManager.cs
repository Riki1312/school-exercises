using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Es02_CasaEditrice
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

        public DataTable ExecuteQuery(string query)
        {
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText += query;
            SqlDataAdapter adp;
            commandObj.Connection = connection;
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter(commandObj);

            DEBUG_Query(query);

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
        public int ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
            int ris = -1;

            cmd.Connection = connection;

            DEBUG_Query(query);
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
        public object ExecuteScalar(string query)
        {
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText += query;
            object ris = -1;
            commandObj.Connection = connection;

            DEBUG_Query(query);

            try
            {
                ris = commandObj.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ris;
        }

        /* Funzione per ottenre la query con i dati al suo interno */
        private void DEBUG_Query(string query)
        {

        }
    }
}
