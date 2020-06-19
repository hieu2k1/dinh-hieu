<?php
$server = 'localhost';
$username = 'root';
$password = '';
//$db = "publication";
$connect_mysql = mysqli_connect($hn, $un, $pw, "publication");
if ($connect_mysql){
    echo "Connection established<br>";
}else{
    die("Unable to connect<br>");
}
$mysql_db = mysqli_select_db($connect_mysql,"publication");
if ($mysql_db){
    echo "Connected to the database<br>";
}else{
    die("Unable to connect to the database<br>");
}
$sql_table = "CREATE TABLE USER_CONTACT("."USER_ID INT NOT NULL PRIMARY KEY,
"."USER_NAME CHAR(25) NOT NULL, "." USER_EMAIL_ID CHAR(25)".")";

if (mysqli_query($connect_mysql, $sql_table)){
    echo "Table is created<br>";
}else{
    die("Unable to create the table<br>");
}