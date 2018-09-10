using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Esercizio_1
{
    class clsPrenotazioni
    {
        private string nomeDB = "dbCitta";
        private DatabaseManager database;

        public delegate void Successo (string msg);
        public event Successo AvvenutaPrenotazione;
        public event Successo AvvenutaConsegna;

        private string codFiscale;
        private string nome;
        private string cognome;
        private int nPostiPrenotati;
        private bool consegna;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                    nome = ToUpperFirst(value);
                else
                    throw new Exception("Il campo nome deve contenere almeno un carattere");
            }
            get
            {
                return nome;
            }
        }
        public string Cognome
        {
            set
            {
                if (value != string.Empty)
                    cognome = ToUpperFirst(value);
                else
                    throw new Exception("Il campo cognome deve contenere almeno un carattere");
            }
            get
            {
                return cognome;
            }
        }
        public int NPostiPrenotati
        {
            set
            {
                if (value > 0)
                    nPostiPrenotati = value;
                else
                    throw new Exception("I posti prenotati devono essere più di 0.");
            }
            get
            {
                return nPostiPrenotati;
            }
        }
        public bool Consegna
        {
            set
            {
                consegna = value;
            }
            get
            {
                return consegna;
            }
        }
        public string CodFiscale
        {
            set
            {
                if (Regex.IsMatch(value, "^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$"))
                    codFiscale = value;
                else
                    throw new Exception("Il codice fiscale non rispetta il regex");
            }

            get
            {
                return codFiscale;
            }
        }

        public clsPrenotazioni()
        {
            database = new DatabaseManager(nomeDB);
        }

        public int RegistraPrenotazioni(string descrizioneCitta)
        {
            int cod_citta = Convert.ToInt32(database.ExecuteScalar("SELECT cod_citta FROM Citta WHERE descrizione like '" + ToUpperFirst(descrizioneCitta) + "'"));
            string sql = "INSERT INTO Prenotazionie(codFiscale, cognome, nome, nPostiPrenotati, consegna, cod_citta) ";
            sql += "VALUES('"+CodFiscale+"', '"+Cognome+"', '"+Nome+"', "+nPostiPrenotati+", 0, "+cod_citta+")";

            int maxConcerto = Convert.ToInt32(database.ExecuteScalar("SELECT nPostiDisponibili FROM Citta WHERE descrizione like '" + ToUpperFirst(descrizioneCitta) + "'"));
            int attualiConcerto = Convert.ToInt32(database.ExecuteScalar("SELECT SUM(nPostiPrenotati) FROM Citta, Prenotazionie WHERE descrizione like '" + ToUpperFirst(descrizioneCitta) + "'"));

            if (maxConcerto > (attualiConcerto + NPostiPrenotati))
                database.ExecuteNonQuery(sql);
            else
                throw new Exception("Posti non disponibili");

            AvvenutaPrenotazione("Prenotazione avvenuta correttamente");

            return Convert.ToInt32(database.ExecuteScalar("SELECT TOP 1 cod_prenotazione FROM Prenotazionie ORDER BY cod_prenotazione DESC"));
        }
        public void RitiraBiglietti(int cod_prenotazione)
        {
            bool consegna = Convert.ToBoolean(database.ExecuteScalar("SELECT consegna FROM Prenotazionie WHERE cod_prenotazione = " + cod_prenotazione));
            if (!consegna)
                database.ExecuteNonQuery("UPDATE Prenotazionie SET consegna = 1 WHERE cod_prenotazione = " + cod_prenotazione);
            else
                AvvenutaConsegna("I biglietti sono già stati ritirati");
        }
        
        private string ToUpperFirst(string str)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
