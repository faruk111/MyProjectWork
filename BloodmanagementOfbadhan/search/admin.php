<html>

	<head>
	
	
		<title> this is a php form </title>
		<style type="text/css">
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
		$givenname='Admin';
		$gpassword='fhjucse';
		$name=$_POST['name'];
		$password=$_POST['password'];
		
		if($givenname==$name && $gpassword==$password){
		
		<?   <li><a href="http://localhost/badhan/index.html">Home</a></li> php?>
		}
		else{
		echo "incorrect username and password";
		}
		
		
		?>
		
				
				
		</body>
			
	
</html>