using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataBaseManager;
using System.Data;
using System.Data.SqlClient;

namespace Es01_Concerti
{
    class ClsCitta
    {
        DatabaseManager database = new DatabaseManager("DB_Concerti");

        string descrizione;
        public string Descrizione
        {
            get { return descrizione; }
            set
            {
                if (value.Trim() == "")
                    throw new Exception("Errore: inserire una descrizione valida");
                else
                    descrizione = value;
            }
        }

        int postiDisponibili;
        public int PostiDisponibili
        {
            get { return postiDisponibili; }
            set
            {
                if (value < 0)
                    throw new Exception("Errore: numero di posti non valido");
                else
                    postiDisponibili = value;
            }
        }

        public string Inserisci()
        {
            string query = "INSERT INTO Citta(descrizione,postiDisponibili) VALUES (@descrizione,@postiDisponibili)";
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText += query;
            commandObj.Parameters.AddWithValue("@descrizione", this.descrizione);
            commandObj.Parameters.AddWithValue("@postiDisponibili", this.postiDisponibili);
            try
            {
                database.ExecuteNonQuery(commandObj);
                return "Record aggiunto correttamente";
            }
            catch (Exception ex) { throw new Exception(); }
        }

        public DataTable Cerca(string descrizione)
        {
            string query = "SELECT codiceCitta FROM Citta WHERE descrizione = '" + descrizione + "'";
            return database.ExecuteQuery(query);
        }

        public DataTable NumeroPosti(string codice)
        {
            string query = "SELECT postiDisponibili FROM Citta WHERE codiceCitta = " + codice;
            return database.ExecuteQuery(query);
        }
    }
}
