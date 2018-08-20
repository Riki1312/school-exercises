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
        $uid = db_QueryRow($db, "SELECT id FROM veicoli WHERE ID='$vid'")["id"];
        $utenteData = db_QueryRow($db, "SELECT * FROM utenti WHERE ID='$uid'");

        sleep(3);
        echo json_encode($utenteData);
    }
    else { echo "ERROR: Wrong data"; }
}

?>