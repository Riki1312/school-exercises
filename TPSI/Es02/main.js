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
        ControlError()  //Ma che caz..!
        {
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
        rows: []
    },
    methods: {
        PlaceClick: function (id, event) {

        }
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
    DrawnCanvas();
};
function DrawnCanvas()
{

}
function Logout(username)
{
    sessionStorage.setItem('ES02_logged', 'false');
    window.location.href = "singin.html";
}
