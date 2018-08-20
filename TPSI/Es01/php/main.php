<?php

include_once('funzioni.php');
$db = db_connect("localhost", "root", "", "compitivacanzees1");

if(isset($_REQUEST["veicoloid"]))
{
    $vid = get_request("veicoloid");

    if($vid != null)
    {
        $uid = db_QueryRow($db, "SELECT Utente as id FROM veicoli WHERE ID='$vid'")["id"];
        $utenteData = db_QueryRow($db, "SELECT * FROM utenti WHERE ID='$uid'");

        sleep(3);
        echo json_encode($utenteData);
    }
    else { echo "ERROR: Wrong data"; }
}
else if (isset($_REQUEST["search"]) && isset($_REQUEST["filter"]))
{
    $search = $_REQUEST["search"];
    $filter = $_REQUEST["filter"];

    $veicoliData = db_Query($db, "SELECT * FROM veicoli WHERE (Marca like '%$search%' OR Modello like '%$search%') AND (Tipo='$filter' OR '$filter'='Entrambi')");
    $result = array();
    while ($row = $veicoliData->fetch_assoc())
        $result[] = $row;
    echo json_encode($result);
}
else
{
    $veicoliData = db_Query($db, "SELECT * FROM veicoli");
    $result = array();

    while ($row = $veicoliData->fetch_assoc())
        $result[] = $row;
    echo json_encode($result);
}

?>