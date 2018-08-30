//Setup Vue objects
var NavBar = new Vue({
    el: '#navbar',
    data: {
        login_username: 'username'
    },
    methods: {
        Logout: function(event){ Logout(this.login_username); }
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
};
function Logout(username)
{
    sessionStorage.setItem('ES02_logged', 'false');
    window.location.href = "singin.html";
}
