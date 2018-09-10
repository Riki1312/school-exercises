using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DBManager;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ConcertiRock
{
    class Prenotazione
    {
        DatabaseManager db = new DatabaseManager("concerti");

        public delegate void Del();
        public delegate void Del2(string value);
        public event Del2 RegistrazioneEseguita;
        public event Del BigliettiGiaConsegnati;
        public event Del BigliettiConsegnati;
        //PROPERTIES
        string codFiscale;
        string nome;
        string cognome;
        int nPostiPresi;

        //non necessita di particolari controlli
        public bool consegnata = false;       

        //interfacce + controlli
        public string CodFiscale
        {
            get { return codFiscale; }
            set {
                string regex = @"^[A-Za-z]{6}[0-9]{2}[A-Za-z]{1}[0-9]{2}[A-Za-z]{1}[0-9]{3}[A-Za-z]{1}$";

                if (!Regex.IsMatch(value, regex))
                    throw new Exception("Codice Fiscale non valido");
                else
                    codFiscale = value;
            }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                if(value.Trim().Length <= 0 || value.Trim().Length > 20)
                    throw new Exception("Formato nome errato");
                else
                    nome = value;
            }
        }
        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (value.Trim().Length <= 0 || value.Trim().Length > 20)
                    throw new Exception("Formato cognome errato");
                else
                    cognome = value;
            }
        }
        public int NPostiPresi
        {
            get { return nPostiPresi; }
            set
            {
                if (value <= 0)
                    throw new Exception("Numero di posti non valido");
                else
                    nPostiPresi = value;
            }
        }

        //METHODS
        public void RegistraPrenotazione(string desc)
        {
            string query2 = "SELECT cod_citta FROM Citta WHERE descrizione = '" + desc + "'";
            DataTable codiceCitta = db.ExecuteQuery(query2);
            if (Convert.ToInt32(codiceCitta.Rows[0][0]) > 0)
            {
                string query = "INSERT INTO Prenotazioni(cod_fiscale,cognome,nome,nPostiPrenotati,consegnata,cod_citta)" +
                " VALUES(@cf,@co,@n,@nP,@c,@cC) SELECT SCOPE_IDENTITY()";
                SqlCommand commandObj = new SqlCommand();
                commandObj.CommandText += query;
                commandObj.Parameters.AddWithValue("@cf", this.codFiscale);
                commandObj.Parameters.AddWithValue("@co", cognome);
                commandObj.Parameters.AddWithValue("@n", nome);
                commandObj.Parameters.AddWithValue("@nP", this.nPostiPresi);
                commandObj.Parameters.AddWithValue("@c", 0);
                commandObj.Parameters.AddWithValue("@cC", codiceCitta.Rows[0][0]);
                try
                {
                    object newId = db.ExecuteScalar(commandObj);
                    RegistrazioneEseguita(newId.ToString());
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
                throw new Exception("Nessun posto rimasto per la destinazione scelta");            
        }

        public void RitiraBiglietti(int codPrenotazione)
        {
            string check = "SELECT consegnata FROM Prenotazioni WHERE cod_prenotazione = "+codPrenotazione;
            DataTable dtQuery = db.ExecuteQuery(check);
            string boh = dtQuery.Rows[0][0].ToString();
            if (dtQuery.Rows[0][0].ToString() == "False")
            {
                string query = "UPDATE Prenotazioni SET consegnata = 1 WHERE cod_prenotazione LIKE @cP";
                SqlCommand commandObj = new SqlCommand();
                commandObj.CommandText += query;
                commandObj.Parameters.AddWithValue("@cP", codPrenotazione);
                try
                {
                    db.ExecuteNonQuery(commandObj);
                    BigliettiConsegnati();
                }
                catch
                {
                }
            }
            else
                BigliettiGiaConsegnati();            
        }
    }
}
