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

            adb.Qu(`SELECT * FROM utenti WHERE Email='${this.email}' AND Password='${this.password}' LIMIT 1`, (qdata) => {
                console.log(qdata);
                if (qdata.length > 0)
                {
                    sessionStorage.setItem('email', qdata[0].Email);
                    sessionStorage.setItem('nome', qdata[0].Nome);
                    sessionStorage.setItem('cognome', qdata[0].Cognome);
                    sessionStorage.setItem('logged', 'true');

                    window.location.href = "main.html";
                }
                else { this.errors = true; }
            });
        }
    }
});