<?php

function db_connect($host, $user, $password, $dbname)
{
    $db = new mysqli($host, $user, $password, $dbname);
    if ($db -> connect_error)
        die("ERRORE: Connessione al database non riuscita:" . $db->connect_errno ." - " . $db->connect_error);
    else
        return $db;
}

function get_request($data)
{
    if (isset($_REQUEST["$data"]))
        return $_REQUEST["$data"];
    else
        die("ERRORE: Parametro: '$data' mancante");
}

function db_remove($database, $table, $id)
{
    $result = $database->query("DELETE FROM $table WHERE id=$id");
    if ($result)
        return $result;
    else
        die("ERRORE: Remove non risuscito");
}

//Funziona ma è ancora "Sperimentale"
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

//Funziona ma è ancora "Sperimentale"
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

function db_Query($database, $query)
{
    return $result = $database->query($query);
}

//Non testata!
function db_QueryRow($database, $query)
{
    $result = $database->query($query);
    if ($result->num_rows > 0)
        return $result->fetch_assoc();
    else
        return -1;
}

?>