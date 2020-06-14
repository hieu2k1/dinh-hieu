<?php
$A = $_GET['NAME'];
if($A > 60)
{
    echo "Congrats!";
    echo "You have got Grade 1.";
}
else if($A < 60  and $A > 40)
{
    echo "congats";
    echo "you have got Grade2.";

}else
{
    echo "Sorry . You have failed";
}
?>