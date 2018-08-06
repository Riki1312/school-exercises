<?php

include_once('funzioni.php');
$db = db_connect("localhost", "root", "", "compitivacanzees1");

if(get_request("veicoloid") == 'null')
{
    $veicoliData = db_Query($db, "SELECT * FROM veicoli");
    $result = array();

    while ($row = $veicoliData->fetch_assoc())
        $result[] = $row;

    echo json_encode($result);
}
else
{
    $vid = get_request("veicoloid");

    if($vid != null)
    {
        $uid = db_QueryRow($db, "SELECT Utente FROM veicoli WHERE ID='$vid'");
        $utenteData = db_QueryRow($db, "SELECT * FROM utenti WHERE ID='$uid'");

        $utenteObj->id = $veicolo['ID'];
        $utenteObj->nome = $veicolo['Nome'];
        $utenteObj->cognome = $veicolo['Cognome'];
        $utenteObj->email = $veicolo['Email'];
        $utenteObj->password = $veicolo['Password'];
        $utenteObj->cellulare = $veicolo['Cellulare'];

        echo json_encode($utenteObj);
    }
    else { echo "ERROR: Wrong data"; }
}

?>