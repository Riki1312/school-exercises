<?php

$Functins = array(
    "f_Qu",
    "f_Rem",
    "f_Upd",
    "f_Ins",
    "f_All"
);
foreach ($Functins as $key=>$functin)
    if (isset($_REQUEST["$functin"]))
        switch ($key)
        {
            case 0: echo f_Qu(); break;
            case 1: echo f_Rem(); break;
            case 2: echo f_Upd(); break;
            case 3: echo f_Ins(); break;
            case 4: echo f_All(); break;
        }

// !!--Global data--!!
$GLOBALS['host'] = "";
$GLOBALS['user'] = "";
$GLOBALS['password'] = "";
$GLOBALS['dbname'] = "";
$GLOBALS['settings'] = "";

// !!--Functions--!!
function f_Qu()
{
    GetGlobalData();
    $qstring = get_request("p_qstring");
    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_Query($db, $qstring);
    $db->close();
    $return = array();

    if ($qredult)
        while ($row = $qredult->fetch_assoc())
            $return[] = $row;
    return json_encode($return);
}
function f_Rem()
{
    GetGlobalData();
    $table = get_request("p_table");
    $id = get_request("p_id");
    $settings = json_decode($GLOBALS['settings']);

    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_remove($db, $settings->idStringDb, $table, $id);
    $db->close();
    $return = array();

    if ($qredult)
            $return[] = $qredult;
    return json_encode($return);
}
function f_Upd()
{
    GetGlobalData();
    $table = get_request("p_table");
    $id = get_request("p_id");
    $recordNames = json_decode(get_request("p_recordNames"));
    $newValues = json_decode(get_request("p_newValues"));
    $settings = json_decode($GLOBALS['settings']);

    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_update($db, $settings->idStringDb, $table, $id, $recordNames, $newValues);
    $db->close();
    $return = array();

    if ($qredult)
            $return[] = $qredult;
    return json_encode($return);
}
function f_Ins()
{
    GetGlobalData();
    $table = get_request("p_table");
    $recordNames = json_decode(get_request("p_recordNames"));
    $newValues = json_decode(get_request("p_newValues"));

    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_insert($db, $table, $recordNames, $newValues);
    $db->close();
    $return = array();

    if ($qredult)
            $return[] = $qredult;
    return json_encode($return);
}
function f_All()
{
    GetGlobalData();
    $table = get_request("p_table");
    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_Query($db, "SELECT * FROM $table");
    $db->close();
    $return = array();

    if ($qredult)
        while ($row = $qredult->fetch_assoc())
            $return[] = $row;
    return json_encode($return);
}

// !!--Global methods--!!
function GetGlobalData()
{
    $GLOBALS['host'] = get_request("p_host");
    $GLOBALS['user'] = get_request("p_user");
    $GLOBALS['password'] = get_request("p_password");
    $GLOBALS['dbname'] = get_request("p_dbname");
    $GLOBALS['settings'] = get_request("p_settings");
}
function get_request($data)
{
    if (isset($_REQUEST["$data"]))
        return $_REQUEST["$data"];
    else
        die("ERRORE: Parametro: '$data' mancante");
}
function db_connect($host, $user, $password, $dbname)
{
    $db = new mysqli($host, $user, $password, $dbname);
    $db->set_charset("utf8");   //json_encode(...) Funziona solo con utf8.

    if ($db -> connect_error)
        die("ERRORE: Connessione al database non riuscita:" . $db->connect_errno ." - " . $db->connect_error);
    else
        return $db;
}
function db_Query($database, $query)
{
    return $result = $database->query("$query");
}
function db_remove($database, $idStringDb, $table, $id)
{
    $result = $database->query("DELETE FROM $table WHERE $idStringDb=$id");
    if ($result)
        return $result;
    else
        die("ERRORE: Remove non risuscito");
}
function db_update($database, $idStringDb, $table, $id, $recordNames, $newValues)
{
    $sqlQuery = "UPDATE $table SET ";
    foreach ($recordNames as $i => $recordName)
    {
        if ($i > 0)
            $sqlQuery .= ", ";
        $sqlQuery .= "$recordName='$newValues[$i]' ";
    }
    $sqlQuery .= "WHERE $idStringDb=$id";

    $result = $database->query($sqlQuery);
    if ($result)
        return $result;
    else
        die("ERRORE: Update non risuscito: " . $sqlQuery);
}
function db_insert($database, $table, $recordNames, $newValues)
{
    $sqlQuery = "INSERT INTO $table(";
    foreach ($recordNames as $i => $recordName)
    {
        if ($i > 0)
            $sqlQuery .= ", ";
        $sqlQuery .= "$recordName";
    }
    $sqlQuery .= ") VALUES (";
    foreach ($newValues as $i => $newValue)
    {
        if ($i > 0)
            $sqlQuery .= ", ";
        $sqlQuery .= "'$newValue'";
    }
    $sqlQuery .= ")";

    $result = $database->query($sqlQuery);
    if ($result)
        return $result;
    else
        die("ERRORE: Insert non risuscito: " . $sqlQuery);
}

?>