<?php
$connect_mysql = mysqli_connect('localhost','root','','publication');
$result = mysqli_query($connect_mysql,'SELECT * FROM Employees');
while ($row = mysqli_fetch_row($result)){
    printf("%s (%s)\n<br>", $row[0], $row[1]);
}