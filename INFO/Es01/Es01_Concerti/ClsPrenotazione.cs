using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataBaseManager;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Es01_Concerti
{
    class ClsPrenotazione
    {
        DatabaseManager database = new DatabaseManager("DB_Concerti");

        public delegate void DelegateBiglietti();
        public delegate void DelegateRegistrazione(string value);

        public event DelegateBiglietti BigliettiGiaConsegnati;
        public event DelegateBiglietti BigliettiConsegnati;
        public event DelegateRegistrazione RegistrazioneEseguita;

        public bool consegnata = false;

        string codiceFiscale;
        public string CodiceFiscale
        {
            get { return codiceFiscale; }
            set
            {
                string regex = @"^[A-Za-z]{6}[0-9]{2}[A-Za-z]{1}[0-9]{2}[A-Za-z]{1}[0-9]{3}[A-Za-z]{1}$";

                if (!Regex.IsMatch(value, regex))
                    throw new Exception("Errore: codice Fiscale non valido");
                else
                    codiceFiscale = value;
            }
        }

        string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if(value.Trim().Length <= 0 || value.Trim().Length > 20)
                    throw new Exception("Errore: formato nome errato");
                else
                    nome = value;
            }
        }

        string cognome;
        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (value.Trim().Length <= 0 || value.Trim().Length > 20)
                    throw new Exception("Errore: formato cognome errato");
                else
                    cognome = value;
            }
        }

        int postiPrenotati;
        public int PostiPrenotati
        {
            get { return postiPrenotati; }
            set
            {
                if (value <= 0)
                    throw new Exception("Errore: numero di posti errato");
                else
                    postiPrenotati = value;
            }
        }

        public void RitiraBiglietti(int codice)
        {
            string querySelect = "SELECT consegnata FROM Prenotazioni WHERE codicePrenotazione = " + codice;
            DataTable qResult = database.ExecuteQuery(querySelect);
            string boh = qResult.Rows[0][0].ToString();

            if (qResult.Rows[0][0].ToString() == "False")
            {
                string queryUpdate = "UPDATE Prenotazioni SET consegnata = 1 WHERE codicePrenotazione LIKE @cP";

                SqlCommand commandObj = new SqlCommand();
                commandObj.CommandText += queryUpdate;
                commandObj.Parameters.AddWithValue("@cP", codice);

                try
                {
                    database.ExecuteNonQuery(commandObj);
                    BigliettiConsegnati();
                }
                catch {}
            }
            else
                BigliettiGiaConsegnati();            
        }

        public void Registra(string descrizione)
        {
            string querySelect = "SELECT codiceCitta FROM Citta WHERE descrizione = '" + descrizione + "'";
            DataTable codiceCitta = database.ExecuteQuery(querySelect);

            if (Convert.ToInt32(codiceCitta.Rows[0][0]) > 0)
            {
                string queryInsert = "INSERT INTO Prenotazioni(codiceFiscale,cognome,nome,postiPrenotati,consegnata,codiceCitta)" + " VALUES(@cf,@co,@no,@po,@con,@coc) SELECT SCOPE_IDENTITY()";

                SqlCommand commandObj = new SqlCommand();
                commandObj.CommandText += queryInsert;
                commandObj.Parameters.AddWithValue("@cf", this.codiceFiscale);
                commandObj.Parameters.AddWithValue("@co", cognome);
                commandObj.Parameters.AddWithValue("@no", nome);
                commandObj.Parameters.AddWithValue("@po", this.postiPrenotati);
                commandObj.Parameters.AddWithValue("@con", 0);
                commandObj.Parameters.AddWithValue("@coc", codiceCitta.Rows[0][0]);

                try
                {
                    object newId = database.ExecuteScalar(commandObj);
                    RegistrazioneEseguita(newId.ToString());
                }
                catch (Exception ex) { throw new Exception(ex.Message); }
            }
            else
                throw new Exception("Non sono rimasti posti disponibili");
        }
    }
}
