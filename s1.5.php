<html>
<head>
    <title>
        Global Variables
    </title>
</head>
<body>
<?php
$int1 = 68;
$int2 = 50;

function divsion()
{
    global $int1,$int2;
    $int3 = $int1/$int2;
    echo "the quotient for $int1/$int2=$int3";
}
divsion();
?>
</body>
</html>