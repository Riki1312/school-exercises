var root = new Vue({
    el: '#formroot',
    data: {
        email: "",
        password: "",
        remember: true,
        errors: false,
        errorText: "Incorrect email or password"
    },
    methods: {
        SingIn: function(event)
        {
            AJAXCall("php/singin.php?usr=" + this.email + "&pas=" + this.password, (response) => {
                if (!response.includes("ERROR"))
                {
                    sessionStorage.setItem('email', response.split(";")[0]);
                    sessionStorage.setItem('nome', response.split(";")[1]);
                    sessionStorage.setItem('cognome', response.split(";")[2]);
                    sessionStorage.setItem('logged', 'true');

                    window.location.href = "main.html";
                }
                else { this.errors = true; }
            });
        }
    }
});

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