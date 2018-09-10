using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Esercizio_2
{
    class clsQuery
    {
        static DatabaseManager database = new DatabaseManager("dbEsercizio2");

        /*
         * Numero di abbonati per titolo
         */
        static public DataTable NumAbbonati()
        {
            return database.ExecuteQuery("SELECT titolo, COUNT(*) AS Abbonati FROM Abbonamento, Rivista  WHERE id_rivista = cod_rivista GROUP BY titolo");
        }
        /*
         * Numero di abbonamenti per una specifica anagrafica
         */
        static public int NumAbbonamenti(string cognome, string nome)
        {
            return Convert.ToInt32(database.ExecuteScalar("SELECT COUNT(*) FROM Abbonamento, Abbonato WHERE Abbonamento.id_abbonato = Abbonato.id_abbonato AND Abbonato.cognome LIKE '" + cognome + "' AND Abbonato.nome LIKE '" + nome + "'"));
        }
        /*
         * Dato il titolo restitusce il numero di abbonati annuali
         */
        static public int NumAbbonatiAnnuali(string titolo)
        {
            return Convert.ToInt32(database.ExecuteScalar("SELECT COUNT(*) FROM Rivista, Abbonamento WHERE Abbonamento.periodo = 3 AND id_rivista = cod_rivista AND Rivista.titolo like '" + titolo + "'"));
        }
        /*
         * Restituisce una DataTable contenente il titolo dei giornali
         * con più di n[parametro] abbonati
         */
        static public DataTable AbbonatiMinimi(int numMinimo = 5000)
        {
            return database.ExecuteQuery("SELECT titolo, COUNT(*) AS numAbbonati FROM Rivista, Abbonamento WHERE id_rivista = cod_rivista AND Abbonamento.periodo = 1 GROUP BY titolo HAVING COUNT(*) > "+numMinimo);
        }
        /*
         */
        static public DataTable SenzaAbbonati()
        {
            return database.ExecuteQuery("SELECT titolo FROM Rivista WHERE id_rivista NOT IN (SELECT id_rivista FROM Abbonamento)");
        }
        /*
         * Numero di abboanti per città solia minima[parametro]
         */
        static public DataTable NumAbbonatiCitta(int numMinimo = 1)
        {
            string sql = "SELECT Citta.stringa, COUNT(*) AS numAbbonamenti FROM  Abbonato, Citta ";
            sql += "WHERE Abbonato.citta = Citta.id_citta AND Abbonato.id_abbonato IN(SELECT DISTINCT id_abbonato FROM Abbonamento)";
            sql += "GROUP BY Citta.stringa HAVING COUNT(*) > 1";

            return database.ExecuteQuery(sql);
        }

        /* - Query inserimento dati - */
        static public void InsRivista(string titolo, int codPeriodo, string prezzo)
        {
            string sql = "INSERT INTO Rivista (titolo, periodo, prezzo) VALUES('" + titolo + "', " + codPeriodo + ", " + prezzo + ")";
            database.ExecuteNonQuery(sql);
        }
        static public void InsPersona(string cognome, string nome, int codcitta, DateTime data)
        {
            string sql = "INSERT INTO Abbonato (cognome, nome, citta, nascita)";
            sql += "VALUES ('" + cognome + "', '" + nome + "', " + codcitta + ", '" + data.ToShortDateString() + "')";

            database.ExecuteNonQuery(sql);
        }
        static public void InsCitta(string str)
        {
            database.ExecuteNonQuery("INSERT INTO Citta (stringa) VALUES ('" + str + "')");
        }
        static public void InsPeriodo(string str)
        {
            database.ExecuteNonQuery("INSERT INTO Periodi (stringa) VALUES ('" + str + "')");
        }
        static public void InsAbbonamento(int codAbbonato, int periodo, DateTime data, int codRivista)
        {
            string sql = "INSERT INTO Abbonamento(id_abbonato, periodo, data_validità, cod_rivista)";
            sql += " VALUES (" + codAbbonato + ", " + periodo + ", '" + data.ToShortDateString() + "', " + codRivista + ")";

            database.ExecuteNonQuery(sql);
        }
    }
}
