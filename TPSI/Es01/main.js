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
      '<div class="card">' +
      '<img class="card-img-top" src="Img/download.svg" alt="Card image cap">' +
      '<div class="card-body">' +
      '<h5 class="card-title">{{title}}</h5>' +
      '<p class="card-text">{{desc}}</p>' +
      '<a href="#" class="btn btn-secondary" v-on:click="BeforeModal" data-toggle="modal" data-target="#cardModal">Dettagli</a>' +
      '</div></div>',
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

  AJAXCall("php/main.php?veicoloid=null", (response) => {
    if (!response.includes("ERROR"))
    {
        var data = JSON.parse(response);
        console.log(data);

        var rows = data.map((x) => { return {id: x.ID, titolo: `${x.Marca} ${x.Modello}`, desc: x.Descrizione}; });
        for (var i = 0; i < rows.length; i += 4) { CardsContainer.rows.push(rows.splice(i, i + 4)); }
        if (rows.length % 4 !== 0) { CardsContainer.rows.push(rows.splice(rows.length - rows.length % 4, rows.length)); }
    }
    else { console.log(response); }
  });
};
function Serch(text, filter)
{
  alert('Search: ' + text + '\nFilter: ' + filter);
  CardsContainer.rows = [];

  //Aggiungere nel db il campo tipo (auto o moto)
}
function Logout(username)
{
  sessionStorage.setItem('logged', 'false');
  window.location.href = "singin.html";
}
function BeforeModalOpen(cardid)
{
  //Settare i dati per la modal (repuperarli dal server con l'ID)
  alert('Opening modal cardid: ' + cardid);
  CardsContainer.modalData = [];
  CardsContainer.modalData.push("Nome: ciao", "Cognome: hello");
}

//AJAX
function AJAXCall(url, functionResponse, method = "GET", async = true)
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
