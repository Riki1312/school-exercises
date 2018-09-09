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
window.onload = function()
{
    if (sessionStorage.getItem('ES02_logged') === 'true')
        NavBar.login_username = sessionStorage.getItem('ES02_nome') + " " + sessionStorage.getItem('ES02_cognome');
    else { window.location.href = "singin.html"; }
};
function Logout(username)
{
    sessionStorage.setItem('ES02_logged', 'false');
    window.location.href = "singin.html";
}