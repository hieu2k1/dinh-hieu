<html>
<head>
    <title>User Information</title>
</head>
<body>
<?php
$myname = $_POST['myname'];
$myage = $_POST['myage'];
if ($myage==""){
    echo "Please enter your name";
}
else
{
    if ($myage=="")
    {
        echo $myname;
        echo ",you did not enter your age!";
    }
    else
    {
        echo "Hi ";
        echo $myname;
        echo ". ";
        echo "Your age is ";
        echo $myage;
        echo ". ";
    }
}
?>
<br>
<a href="s11.2.php">Back</a>
</body>
</html>