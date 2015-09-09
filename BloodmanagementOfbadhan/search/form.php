<html>

	<head>
		<title> this is a php form </title>
		
		<style type="text/css">
		
		body{background-color:#FF9412}
		h2{margin-left:300px}
	label {width:3cm; float:left;}
	div{margin-bottom:5px;}
	table{
		background-color:lightblue;
		border:1px solid gray;
		border-collaps:collaps;
			}
		th,td{padding:5px;border:1px solid gray}
			tr:nth-child(even){background-color:white}
			tr:first-child(even){background-color:white}
	
</style>
	
	
	</head>

	<body>
		<?php
		
		if(!($database=mysql_connect("localhost","root","")))
			die("<p>Could not conncet to Database</p></body></html>");
			
		if(!mysql_select_db("blood",$database))
			die("<p>could not open blood</p></body></html>");
	$id="";	
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
	
	if($checkbox=='Yes'){
	$query="insert into information_table values('$id',
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
													
	
			
		if(!($result=mysql_query($query,$database)))
		{
			print("<p>could not execute query</p>");
			die(mysql_error()."</body></html>");
		}else{
		
		print("<h2>You have registered yourself successfully  !!!!!!!!!!!!</h2></body></html>");
		}
		}else{
		
		print("<h2>Please check the agreement box    !!!!!!!!!!!!</h2></body></html>");
		}
		?>
		<li><a href="http://localhost/badhan/index.html">Back</a></li>
			
	</body>
	
</html>