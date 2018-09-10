using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Es02_CasaEditrice
{
    class QueryManager
    {
        static DatabaseManager DataBase = new DatabaseManager("DBCasaEditrice");

        static public int Q_NumeroAbbonamenti(string cognome, string nome)
        {
            return Convert.ToInt32(DataBase.ExecuteScalar("SELECT COUNT(*) FROM Abbonamento, Abbonato WHERE Abbonamento.id_abbonato = Abbonato.id_abbonato AND Abbonato.cognome LIKE '" + cognome + "' AND Abbonato.nome LIKE '" + nome + "'"));
        }
        static public DataTable Q_NumeroAbbonati()
        {
            return DataBase.ExecuteQuery("SELECT titolo, COUNT(*) AS Abbonati FROM Abbonamento, Rivista  WHERE Abbonamento.id_rivista = Rivista.id_rivista GROUP BY titolo");
        }
        static public int Q_NumAbbonatiAnnuali(string titolo)
        {
            return Convert.ToInt32(DataBase.ExecuteScalar("SELECT COUNT(*) FROM Rivista, Abbonamento WHERE Abbonamento.periodo = 3 AND Abbonamento.id_rivista = Rivista.id_rivista AND Rivista.titolo like '" + titolo + "'"));
        }
        static public DataTable Q_AbbonatiMinimi(int numMinimo = 5000)
        {
            return DataBase.ExecuteQuery("SELECT titolo, COUNT(*) AS numAbbonati FROM Rivista, Abbonamento WHERE Abbonamento.id_rivista = Rivista.id_rivista AND Abbonamento.periodo = 1 GROUP BY titolo HAVING COUNT(*) > " + numMinimo);
        }
        static public DataTable Q_SenzaAbbonati()
        {
            return DataBase.ExecuteQuery("SELECT titolo FROM Rivista WHERE id_rivista NOT IN (SELECT id_rivista FROM Abbonamento)");
        }
        static public DataTable Q_NumAbbonatiCitta(int numMinimo = 1)
        {
            string sql = "SELECT Citta.stringa, COUNT(*) AS numAbbonamenti FROM  Abbonato, Citta ";
            sql += "WHERE Abbonato.citta = Citta.id_citta AND Abbonato.id_abbonato IN(SELECT DISTINCT id_abbonato FROM Abbonamento)";
            sql += "GROUP BY Citta.stringa HAVING COUNT(*) > 1";

            return DataBase.ExecuteQuery(sql);
        }

        static public void Ins_Persona(string cognome, string nome, int codcitta, DateTime data)
        {
            string sql = "INSERT INTO Abbonato (cognome, nome, citta, nascita)";
            sql += "VALUES ('" + cognome + "', '" + nome + "', " + codcitta + ", '" + data.ToShortDateString() + "')";

            DataBase.ExecuteNonQuery(sql);
        }
        static public void Ins_Rivista(string titolo, int codPeriodo, string prezzo)
        {
            string sql = "INSERT INTO Rivista (titolo, periodo, prezzo) VALUES('" + titolo + "', " + codPeriodo + ", " + prezzo + ")";
            DataBase.ExecuteNonQuery(sql);
        }
        static public void Ins_Abbonamento(int codAbbonato, int periodo, DateTime data, int codRivista)
        {
            string sql = "INSERT INTO Abbonamento(id_abbonato, periodo, dataValidità, id_rivista)";
            sql += " VALUES (" + codAbbonato + ", " + periodo + ", '" + data.ToShortDateString() + "', " + codRivista + ")";

            DataBase.ExecuteNonQuery(sql);
        }
        static public void Ins_Periodo(string str)
        {
            DataBase.ExecuteNonQuery("INSERT INTO Periodi (valore) VALUES ('" + str + "')");
        }
        static public void Ins_Citta(string str)
        {
            DataBase.ExecuteNonQuery("INSERT INTO Citta (valore) VALUES ('" + str + "')");
        }
    }
}
