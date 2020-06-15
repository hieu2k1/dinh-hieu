<?php
$counter = 0;
echo "the even numbers are: <br>";
do {
    echo "$counter<br>";
    $counter = $counter+2;
}
while($counter <= 10);
echo "The loop ends because the condition is satisfiled.";
?>