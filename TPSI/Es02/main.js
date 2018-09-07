//Setup Vue objects
var NavBar = new Vue({
    el: '#v-navbar',
    data: {
        login_username: 'username'
    },
    methods: {
        Logout: function(event){ Logout(this.login_username); }
    }
});
var FormDate = new Vue({
    el: '#v-formdate',
    data: {
        date_start: "",
        date_end: "",
        errors: false,
        error_text: "Selezionare un minimo di 7 giorni."
    },
    methods: {
        ControlError: function(event) {
            let dif = Math.floor((new Date(this.date_start) - new Date(this.date_end)) / 1000/60/60/24);
            this.errors = -dif < 7;
        }
    },
    watch: {
        date_start: function () { this.ControlError() },
        date_end: function () { this.ControlError() }
    }
});
var MainMap = new Vue({
    el: "#v-mainmap",
    data: {
        rows: [],
        id_selected: []
    },
    methods: {
        PlaceClick: function (place) {
            if (!place.reserved)
            {
                place.select = !place.select;
                if (this.id_selected.indexOf(place.id) >= 0)
                    this.id_selected.splice(this.id_selected.indexOf(place.id), 1);
                else
                    this.id_selected.push(place.id);
            }
        },
        Confirm: function (event){ ConfermaPrenotazione(this.id_selected); }
    }
});

//Setup global vars
var adb = new AwesomeDB().MySQL;

//Functions
window.onload = function()
{
    if (sessionStorage.getItem('ES02_logged') === 'true')
        NavBar.login_username = sessionStorage.getItem('ES02_nome') + " " + sessionStorage.getItem('ES02_cognome');
    else { window.location.href = "singin.html"; }

    adb.Settings.relativePhat = "Libraries/AwesomeDB/";
    adb.Conn("localhost", "root", "", "compitivacanzees2");
    DrawnMap();
};
function DrawnMap()
{
    adb.All("Ombrelloni", (data) => {
        MainMap.rows = [];
        let rows = data.map((x) => { return { id: x.ID, reserved: (x.Prenotato === "1") }; });
        for (let i = 0; i < rows.length; i += 1)
            MainMap.rows.push(rows.splice(0, 8));
        if (rows.length % 8 !== 0) { MainMap.rows.push(rows.splice(0, rows.length)); }
    });
}
function ConfermaPrenotazione(idSelected)
{
    console.log(idSelected);

    if (idSelected.length > 0 && true /*sostituire true con il cortrollo sul input date*/)
    {
        //Settare message box con text di conferma
        //aggiornare i dati db
        DrawnMap();
    }
    else
    {
        //Settre message box text per errori di imput (anche date)
    }

    //VIsualizzare message box
}
function Logout(username)
{
    sessionStorage.setItem('ES02_logged', 'false');
    window.location.href = "singin.html";
}
