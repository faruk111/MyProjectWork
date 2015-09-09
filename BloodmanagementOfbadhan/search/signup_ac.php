<?php

include('config.php');

// table name
$tbl_name='temp_members_db';

// Random confirmation code
$confirm_code=md5(uniqid(rand()));

// values sent from form
	$username=$_POST['fname'];
	$password=$_POST['password'];
	$fullname=$_POST['lname'];
	$hallname=$_POST['father'];
	$deptname=$_POST['mother'];
	$batch=$_POST['village'];
	$email=$_POST['email'];
	$phone=$_POST['phone'];
	$gender=$_POST['gender'];
	$weight=$_POST['weight'];
	
	
	$blood_group=$_POST['Blood_Group'];
	
	$userDate=$_POST['date'];
	$currentDate=date("Y-m-d");
	
	$diff = abs(strtotime($currentDate) - strtotime($userDate));
	$years = floor($diff / (365*60*60*24));
	$months = floor(($diff - $years * 365*60*60*24) / (30*60*60*24));
	
	
	$checkbox=(strtolower($_POST['check'])=='yes')? 'Yes' : 'No';
	

	$sql="insert into $tbl_name(confirm_code,month,firstname,password,,lastname,father_name,mother_name,email,phone,gender,weight,blood_group,userDate,interest) values('$confirm_code',
													'$months',
													
													'$username',
													
													'$password',
													'$fullname',
													'$hallname',
													'$deptname',
													'$batch',
													'$email',
													'$phone',
													'$gender',
													'$weight',
													
													'$blood_group',
													'$userDate',
													'$checkbox'
													
													)";
$result=mysql_query($sql);

// if suceesfully inserted data into database, send confirmation link to email
if($result){

// ---------------- SEND MAIL FORM ----------------


// send e-mail to ...
$to=$email;

// Your subject
$subject="Your confirmation link here";

// From
$header="from: your name <your email>";

// Your message
$message="Your Comfirmation link \r\n";
$message.="Click on this link to activate your account \r\n";
$message.="http://www.yourweb.com/confirmation.php?passkey=$confirm_code";


// send email
$sentmail = mail($to,$subject,$message,$header);

}


// if not found
else {
echo "Not found your email in our database";
}


// if your email succesfully sent
if($sentmail){
echo "Your Confirmation link Has Been Sent To Your Email Address.";
}
else {
echo "Cannot send Confirmation link to your e-mail address";
}

?>