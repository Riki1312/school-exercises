var Adb_MySQL = {

    //Library objects
    Data: {
        host: "", user: "", password: "", dbname: ""
    },
    Methods: {
        ajaxCall: function(url, functionResponse, method = "GET", async = true)
        {
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.onreadystatechange = function() {
                if (this.readyState == 4 && this.status == 200) {
                    functionResponse(this.responseText);
                }
            };
            xmlhttp.open(method, url, async);
            xmlhttp.send();
        }
    },
    Errors: {
        Last: "",
        All: [],
        Add: function(message)
        {
            this.Last = message;
            All.push(message);
        }
    },

    //Basic
    Conn: function(host, user, password, dbname)
    {
        this.Data.host = host;
        this.Data.user = user;
        this.Data.password = password;
        this.Data.dbname = dbname;

        return this;
    },
    Qu: function(qstring, f_response)
    {
        let ret = -1;

        this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Qu=true` +
            `&p_host=${this.Data.host}` +
            `&p_user=${this.Data.user}` +
            `&p_password=${this.Data.password}` +
            `&p_dbname=${this.Data.dbname}` +
            `&p_qstring=${qstring}`
        , (response) =>
        {
            ret = JSON.parse(response);
            f_response(ret);
        });
    },

    //Awesome
    Rem: function(table, id)
    {
        return this;
    },
    Upd: function(table, id, recordNames, newValues)
    {
        return this;
    },
    Ins: function(table, recordNames, newValues)
    {
        return this;
    },
    All: function(table, f_response)
    {
        let ret = -1;

        this.Methods.ajaxCall(`AwesomeDB_MySQL.php?f_Qu=true` +
            `&p_host=${this.Data.host}` +
            `&p_user=${this.Data.user}` +
            `&p_password=${this.Data.password}` +
            `&p_dbname=${this.Data.dbname}` +
            `&p_table=${table}`
        , (response) =>
        {
            ret = JSON.parse(response);
            f_response(ret);
        });

        return ret;
    },
}