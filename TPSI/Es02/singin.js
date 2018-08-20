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
            var adb = new AwesomeDB().MySQL;
            adb.Settings.relativePhat = "Libraries/AwesomeDB/";
            adb.Conn("localhost", "root", "", "compitivacanzees1");

            adb.Qu(`SELECT * FROM utenti`, (qdata) => {
                console.log(qdata);
            });
/*
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
            });*/
        }
    }
});