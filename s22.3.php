<html>
<body>
<?php
error_reporting(0);
$multi = "/usr/local/apache2/htdocs/email_list.txt";
$to_mail= file('$email_list.txt');
$from = "youname@example.com";

for ($i= 0;$i<count($to_mail);$i++)
{
    $to_mail[$i] = trim($to_mail[$i]);
    $to = implode(",",$to_mail);
    $subject = "An example";
    $body = "this an example for the mail() function.";
    mail ($to,$subject,$body,$from);
    echo "Mail was sent to all the addresses !!!";
}
?>
</body>
</html>