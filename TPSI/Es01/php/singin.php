<?php

include_once('funzioni.php');

if(get_request("usr") != null && get_request("pas") != null)
{
    $db = db_connect("localhost", "root", "", "compitivacanzees1");

    $usr = get_request("usr");
    $pas = get_request("pas");
    $row = db_QueryRow($db, "SELECT * FROM utenti WHERE Email='$usr' AND Password='$pas' LIMIT 1"); 

    if($row != -1)
    {
        echo $row['Email'] . ";" . $row['Nome'] . ";" . $row['Cognome'];
    }
    else { echo "ERROR: Wrong data"; }
}
else { echo "ERROR: Parameters not found"; }

?>