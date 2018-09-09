/*
!!! ATTENZIONE !!!
Questa è la versione vecchia, la nuova è in es 02.
 */

///Istanziare un oggetto AwesomeDB e scegliere il tipo di database da utilizzare
///Esempio: var adb = new AwesomeDB().MySQL;
function AwesomeDB()
{
    this.MySQL = Object.create(Adb_MySQL);
}

var Adb_MySQL = {

    // !!--Library objects--!!
    Data: {
        host: "", user: "", password: "", dbname: ""
    },
    Methods: {
        ajaxCall: function(url, functionResponse, method = "GET", async = true)
        {
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.onreadystatechange = function() {
                if (this.readyState === 4 && this.status === 200) {
                    functionResponse(this.responseText);
                }
            };
            xmlhttp.open(method, url, async);
            xmlhttp.send();
        }
    },
    Settings: {
        printErrors: true, idStringDb: "ID"
    },
    Errors: {
        Last: "",
        All: [],
        Add: function(message)
        {
            this.Last = message;
            this.All.push(message);

            if (Adb_MySQL.Settings.printErrors) { console.error("AwesomeDB Error message: \n" + message); }
        }
    },

    // !!--Basic--!!

    ///Setta i dati per la connessione al database.
    Conn: function(host, user, password, dbname)
    {
        this.Data.host = host;
        this.Data.user = user;
        this.Data.password = password;
        this.Data.dbname = dbname;

        return this;
    },

    ///Esegue una query al database, i dati vengono
    ///restituiti come array di oggetti (vuoto se non ci sono dati o se ci sono errori nella query).
    Qu: function(qstring, f_response)
    {
        let ret = -1;

        this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Qu=true` +
            `&p_settings=${JSON.stringify(this.Settings)}` +
            `&p_host=${this.Data.host}` +
            `&p_user=${this.Data.user}` +
            `&p_password=${this.Data.password}` +
            `&p_dbname=${this.Data.dbname}` +
            `&p_qstring=${qstring}`
        , (response) =>
        {
            try { ret = JSON.parse(response); }
            catch { ret = -1; this.Errors.Add(response); }
            f_response(ret);
        });

        return this;
    },

    // !!--Awesome--!!

    ///Rimuove i record dati gli id (come array) da una tabella specificata
    ///La funzione di risposta viene eseguita al termine di tutte le eliminazioni
    ///(il parametro "ret" della funzzione di risposta contiene il risultato di ogni eliminazione).
    Rem: function(table, idArray, f_response)
    {
        let ret = [];

        if (!Array.isArray(idArray)) { idArray = [idArray]; }

        idArray.forEach((id, index) =>
        {
            ret.push(-1);

            this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Rem=true` +
                `&p_settings=${JSON.stringify(this.Settings)}` +
                `&p_host=${this.Data.host}` +
                `&p_user=${this.Data.user}` +
                `&p_password=${this.Data.password}` +
                `&p_dbname=${this.Data.dbname}` +
                `&p_table=${table}` +
                `&p_id=${id}`
            , (response) =>
            {
                try { ret[index] = JSON.parse(response); }
                catch { ret[index] = -1; this.Errors.Add(response); }

                if (index === idArray.length - 1)
                    f_response(ret);
            });
        });

        return this;
    },

    ///Aggiorna uno o più record secondo queste modalità:
    ///- id non array e recordObj non array: modifica il singolo record come specificato.
    ///- id array e recordObj non array: modifica tutti i record (del array di id) con lo stesso valore specificato.
    ///- id array e recordObj array: modifica tutti i record (del array di id) con tutti i dati specificati (del array di recordObj)
    ///  (Attenzione: le lunghezze dei due array devono essere uguali).
    ///I nuovi dati sono da passare come ogetto
    ///(l'oggetto deve avere i nomi delle proprietà coerenti con quelle sul database).
    Upd: function(table, idArray, recordArrayObj, f_response)
    {
        let ret = [];

        if (!Array.isArray(idArray))
        {
            idArray = [idArray];
            recordArrayObj = [recordArrayObj];
        }
        else if (!Array.isArray(recordArrayObj))
        {
            let _recordArrayObj = []
            for (let i = 0; i < idArray.length; i++)
                _recordArrayObj.push(recordArrayObj);
            recordArrayObj = _recordArrayObj;
        }
        else if (idArray.length !== recordArrayObj.length)
        {
            this.Errors.Add("Error Upd: idArray.length !== recordArrayObj.length");
            f_response(false);
            return this;
        }

        idArray.forEach((id, index) =>
        {
            ret.push(-1);
            let recordNames = Object.getOwnPropertyNames(recordArrayObj[index]);
            let newValues = Object.values(recordArrayObj[index]);

            this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Upd=true` +
                `&p_settings=${JSON.stringify(this.Settings)}` +
                `&p_host=${this.Data.host}` +
                `&p_user=${this.Data.user}` +
                `&p_password=${this.Data.password}` +
                `&p_dbname=${this.Data.dbname}` +
                `&p_table=${table}` +
                `&p_id=${id}` +
                `&p_recordNames=${JSON.stringify(recordNames)}` +
                `&p_newValues=${JSON.stringify(newValues)}`
            , (response) =>
            {
                try { ret[index] = JSON.parse(response); }
                catch { ret[index] = -1; this.Errors.Add(response); }

                if (index === idArray.length - 1)
                    f_response(ret);
            });
        });

        return this;
    },

    ///Inserisce in una specifica tabella dei nuovi dati da passera come array di oggetti
    ///(ogni oggetto deve avere i nomi delle proprietà coerenti con quelle sul database)
    ///La funzione di risposta viene eseguita al termine di tutti gli inserimenti
    ///(il parametro "ret" della funzzione di risposta contiene il risultato di ogni inserimento).
    Ins: function(table, recordArrayObj, f_response)
    {
        let ret = [];

        if (!Array.isArray(recordArrayObj)) { recordArrayObj = [recordArrayObj]; }

        recordArrayObj.forEach((recordObj, index) =>
        {
            ret.push(-1);
            let recordNames = Object.getOwnPropertyNames(recordObj);
            let newValues = Object.values(recordObj);

            this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Ins=true` +
                `&p_settings=${JSON.stringify(this.Settings)}` +
                `&p_host=${this.Data.host}` +
                `&p_user=${this.Data.user}` +
                `&p_password=${this.Data.password}` +
                `&p_dbname=${this.Data.dbname}` +
                `&p_table=${table}` +
                `&p_recordNames=${JSON.stringify(recordNames)}` +
                `&p_newValues=${JSON.stringify(newValues)}`
            , (response) =>
            {
                try { ret[index] = JSON.parse(response); }
                catch { ret[index] = -1; this.Errors.Add(response); }

                if (index === recordArrayObj.length - 1)
                    f_response(ret);
            });
        });

        return this;
    },

    ///Ottiene tutti i dati di una tabella specifica
    ///restituiti come array di oggetti (vuoto se non ci sono dati o la tabella non esiste).
    All: function(table, f_response)
    {
        let ret = -1;

        this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_All=true` +
            `&p_settings=${JSON.stringify(this.Settings)}` +
            `&p_host=${this.Data.host}` +
            `&p_user=${this.Data.user}` +
            `&p_password=${this.Data.password}` +
            `&p_dbname=${this.Data.dbname}` +
            `&p_table=${table}`
        , (response) =>
        {
            try { ret = JSON.parse(response); }
            catch { ret = -1; this.Errors.Add(response); }
            f_response(ret);
        });

        return this;
    },
};
