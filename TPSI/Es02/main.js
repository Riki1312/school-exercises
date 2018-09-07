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
            place.select = !place.select;
            if (this.id_selected.indexOf(place.id) >= 0)
                this.id_selected.splice(this.id_selected.indexOf(place.id), 1);
            else
                this.id_selected.push(place.id);
        },
        Confirm: function (event) { ConfermaPrenotazione(this.id_selected); }
    }
});

//Setup global vars

//Functions
window.onload = function()
{
    console.log("Loadpage");

    if (sessionStorage.getItem('ES02_logged') === 'true')
        NavBar.login_username = sessionStorage.getItem('ES02_nome') + " " + sessionStorage.getItem('ES02_cognome');
    else { window.location.href = "singin.html"; }

    //Get data from DB and print map ombrelloni
    DrawnMap();
};
function DrawnMap()
{
    //var rows = data.map((x) => { return {id: x.ID, titolo: `${x.Marca} ${x.Modello}`, desc: x.Descrizione}; });
    for (let i = 0; i < /*rows.length*/30; i += 4)
        MainMap.rows.push(/*rows.splice(0, 4)*/ [{ id: 1, select: false }, { id: 2, select: false }, { id: 3, select: false }, { id: 4, select: false }]);
    //if (rows.length % 4 !== 0) { CardsContainer.rows.push(rows.splice(0, rows.length)); }
}
function ConfermaPrenotazione() {

}
function Logout(username)
{
    sessionStorage.setItem('ES02_logged', 'false');
    window.location.href = "singin.html";
}
