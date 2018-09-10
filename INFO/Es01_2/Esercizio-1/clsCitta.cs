using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Threading;
using System.Data.SqlClient;

namespace Esercizio_1
{
    class clsCitta
    {
        private string nomeDB = "dbCitta";

        public int NPostiDisponibili
        {
            set
            {
                if (value > 0)
                    nPostiDisponibili = value;
                else
                    throw new Exception("Il numero dei posti deve essere maggiore di zero");
            }
            get
            {
                return nPostiDisponibili;
            }
        }
        public string Descrizione
        {
            set
            {
                if (value != string.Empty)
                    descrizione = ToUpperFirst(value);
                else
                    throw new Exception("Stringa descrizione vuota");
            }
            get
            {
                return descrizione;
            }
        }

        private int nPostiDisponibili;
        private string descrizione;

        private DatabaseManager database;

        public clsCitta()
        {
            database = new DatabaseManager(nomeDB);
        }

        public int PostiDisponibili(int codCitta)
        {
            string sql = "SELECT nPostiDisponibili FROM Citta WHERE cod_citta = " + codCitta.ToString();
            return Convert.ToInt32(database.ExecuteScalar(sql));
        }
        public int CercaCitta(string descrizioneCitta)
        {
            Descrizione = descrizioneCitta;
            string sql = "SELECT cod_citta FROM citta WHERE descrizione like '" + Descrizione + "'";
            return Convert.ToInt32(database.ExecuteScalar(sql));
        }
        public void InserisciCitta()
        {
            /*
                Per evitare problematiche nell'inserimento e nella ricerca della descrizione della città
                prima di effettura l'azione di insert viene utilizzato il metodo ToUpperFirst()
                che ha l'obbiettivo di uniformare la stringa, la prima lettera delle parole sarà maiuscola
                mentre le restanti saranno tutte minuscole.
            */

            string sql = "INSERT INTO Citta (descrizione, nPostiDisponibili) VALUES('" + Descrizione + "', "+NPostiDisponibili+")";

            if (ControlloDescrizione())
                database.ExecuteNonQuery(sql);
            else
                throw new Exception("Descrizione già presente, il campo deve essere univoco");

        }

        private string ToUpperFirst(string str)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
        /*
         * Con un return uguale a TRUE si può effettuare l'inseriemento,
         * altrimenti la descrizione è già presente
         */
        private bool ControlloDescrizione()
        {
            string sql = "SELECT COUNT(*) FROM Citta WHERE descrizione like '" + Descrizione + "'";

            int result = Convert.ToInt32(database.ExecuteScalar(sql));
            if (result == 0)
                return true;
            else
                return false;
        }
    }
}