<?php

$Functins = array(
    "f_Qu",
    "f_Rem",
    "f_Upd",
    "f_Ins",
    "f_All"
);
foreach ($Functins as $functin)
    if (isset($_REQUEST["$functin"]))
        echo f_Qu();

//Global data
$GLOBALS['host'] = "";
$GLOBALS['user'] = "";
$GLOBALS['password'] = "";
$GLOBALS['dbname'] = "";

//Functions
function f_Qu()
{
    GetDbData();
    $qstring = get_request("p_qstring");
    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_Query($db, $qstring);
    $return = array();

    while ($row = $qredult->fetch_assoc())
        $return[] = $row;
    return json_encode($return);
}
function f_Rem()
{
    
}
function f_Upd()
{
    
}
function f_Ins()
{
    
}
function f_All()
{
    GetDbData();
    $table = get_request("p_table");
    $db = db_connect($GLOBALS['host'], $GLOBALS['user'], $GLOBALS['password'], $GLOBALS['dbname']);
    $qredult = db_Query($db, "SELECT * FROM " + $table);
    $return = array();

    while ($row = $qredult->fetch_assoc())
        $return[] = $row;
    return json_encode($return);
}

//Global methods
function GetDbData()
{
    $GLOBALS['host'] = get_request("p_host");
    $GLOBALS['user'] = get_request("p_user");
    $GLOBALS['password'] = get_request("p_password");
    $GLOBALS['dbname'] = get_request("p_dbname");
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
    return $result = $database->query($query);
}
function db_remove($database, $table, $id)
{
    $result = $database->query("DELETE FROM $table WHERE id=$id");
    if ($result)
        return $result;
    else
        die("ERRORE: Remove non risuscito");
}
function db_update($database, $table, $id, $recordNames, $newValues)
{
    $sqlQuery = "UPDATE $table SET ";
    foreach ($recordNames as $i => $recordName)
    {
        if ($i > 0)
            $sqlQuery .= ", ";
        $sqlQuery .= "$recordName='$newValues[$i]' ";
    }
    $sqlQuery .= "WHERE id=$id";

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