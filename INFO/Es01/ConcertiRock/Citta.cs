using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DBManager;
using System.Data;
using System.Data.SqlClient;

namespace ConcertiRock
{
    class Citta
    {
        //DBMANAGER 
        DatabaseManager db = new DatabaseManager("concerti");

        //PROPERTIES
        string descrizione;
        int nPostiDisponibili;

        public string Descrizione
        {
            get {
                return descrizione;
            }
            set {
                if (value.Trim() == "")
                    throw new Exception("Il campo descrizione non può essere vuoto");
                else
                    descrizione = value;
            }
        }

        public int NPostiDisponibili
        {
            get
            {
                return nPostiDisponibili;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Numero non valido");
                else
                    nPostiDisponibili = value;
            }
        }

        //METHODS
        public DataTable PostiDisponibili(string cod)
        {
            string query = "SELECT nPostiDisponibili FROM Citta WHERE cod_citta = "+cod;
            return db.ExecuteQuery(query);
        }

        public DataTable CercaCitta(string descrizione)
        {
            string query = "SELECT cod_citta FROM Citta WHERE descrizione = '" + descrizione + "'";
            return db.ExecuteQuery(query);
        }

        public string InserisciCitta()
        {
            string query = "INSERT INTO Citta(descrizione,nPostiDisponibili) VALUES (@descrizione,@nPostiDisponibili)";
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText += query;
            commandObj.Parameters.AddWithValue("@descrizione", this.descrizione);
            commandObj.Parameters.AddWithValue("@nPostiDisponibili", this.nPostiDisponibili);
            try
            {
                db.ExecuteNonQuery(commandObj);
                return "Record aggiunto correttamente";
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
