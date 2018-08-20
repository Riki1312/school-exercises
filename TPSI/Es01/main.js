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

Vue.component('button-group', {
    data: function() {
      return {
        class_btn: "btn btn-outline-primary",
        class_current: "btn btn-primary",
        local_currentTab: this.currentTab
      }
    },
    props: ['currentTab', 'tabs'],
    template:
      '<div class="btn-group" role="group"><button ' +
      'v-for="tab in tabs" ' +
      'v-bind:key="tab" ' +
      'v-bind:class="[tab == local_currentTab ? class_current : class_btn]" ' +
      'v-on:click="local_currentTab = tab; $emit(`TabChange`, tab)" ' +
      '>{{tab}}</button></div> '
});

Vue.component('search-widget', {
    data: function() {
      return {
        searchText: "",
        currentTab: 'Entrambi',
        tabs: ['Entrambi', 'Auto', 'Moto']
      }
    },
    template:
      '<div class="form-inline my-2 my-lg-0">' +
      '<input class="form-control mr-sm-2" type="search" placeholder="Search" v-model="searchText">' +
      '<button-group v-bind:currentTab="currentTab" v-bind:tabs="tabs" v-on:TabChange="currentTab = $event"></button-group>' +
      '<button class="btn btn-outline-dark my-2 my-sm-0 ml-2" v-on:click="SearchStart">Search</button>' +
      '</div>',
    methods: {
      SearchStart: function(event){ Serch(this.searchText, this.currentTab); }
    },
});
var SearchBar = new Vue({el: '#searchbar'});

Vue.component('card-widget', {
    props: ["title", "desc", "itemid"],
    template:
      '<div class="card" style="height: 100%">' +
      //'<img class="card-img-top" src="Img/download.svg" alt="Card image cap">' +
      '<div class="card-body" style="height: 100%">' +
      '<h5 class="card-title">{{title}}</h5>' +
      '<p class="card-text">{{desc}}</p></div>' +
      '<a href="#" class="btn btn-secondary m-3" v-on:click="BeforeModal" data-toggle="modal" data-target="#cardModal">Dettagli</a>' +
      '</div>',
    methods: {
      BeforeModal: function(event){ BeforeModalOpen(this.itemid); }
    }
});
var CardsContainer = new Vue({
    el: '#cardscontainer',
    data: {
      rows: [],
      modalTitle: "Dettagli",
      modalData: []
    }
  });

//Setup global vars

//Functions
window.onload = function()
{
    console.log("Loadpage");

    if (sessionStorage.getItem('logged') === 'true')
        NavBar.login_username = sessionStorage.getItem('nome') + " " + sessionStorage.getItem('cognome');
    else { window.location.href = "singin.html"; }

    AJAXCall("php/main.php?", (response) => {
        if (!response.includes("ERROR"))
        {
            console.log(JSON.parse(response));
            PrintHtmlData(JSON.parse(response));
        }
        else { console.log(response); }
    });
};
function Serch(text, filter)
{
    CardsContainer.rows = [];
    var ajaxUrl = "php/main.php?";
    console.log(text);
    if (text !== "" || filter !== "Entrambi")
        ajaxUrl += "search=" + text + "&filter=" + filter;

    AJAXCall(ajaxUrl, (response) => {
        if (!response.includes("ERROR"))
        {
            console.log(JSON.parse(response));
            PrintHtmlData(JSON.parse(response));
        }
        else { console.log(response); }
    });
}
function Logout(username)
{
    sessionStorage.setItem('logged', 'false');
    window.location.href = "singin.html";
}
function BeforeModalOpen(cardid)
{
    CardsContainer.modalData = [];
    CardsContainer.modalData.push("Attendere", "Caricamento dati utente in corso ...");
    AJAXCall("php/main.php?veicoloid=" + cardid, (response) => {
        if (!response.includes("ERROR"))
        {
            var data = JSON.parse(response);
            console.log(data);

            CardsContainer.modalData = [];
            CardsContainer.modalData.push(`Nome: ${data.Nome}`, `Cognome: ${data.Cognome}`, `Telefono: ${data.Cellulare}`, `Email: ${data.Email}`);
        }
        else { console.log(response); }
    });
}

function PrintHtmlData(data)
{
    var rows = data.map((x) => { return {id: x.ID, titolo: `${x.Marca} ${x.Modello}`, desc: x.Descrizione}; });
    for (var i = 0; i < rows.length; i += 4)
        CardsContainer.rows.push(rows.splice(0, 4));
    if (rows.length % 4 !== 0) { CardsContainer.rows.push(rows.splice(0, rows.length)); }
}

//AJAX
function AJAXCall(url, functionResponse, method = "GET", async = true)
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
