<?php
session_start();
$myname = $_SESSION['myname'];
?>
<html>
<head>
    <title>
        Homepage
    </title>
</head>
<body>
Welcome
<?php echo $myname ?> to My page.com<br>
</body>
</html>
