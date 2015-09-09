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
		
		$id=$_POST['id'];
		$udate=$_POST['udate'];
		
		
		$currentDate=date("Y-m-d");
	
	$diff = abs(strtotime($currentDate) - strtotime($udate));
	$years = floor($diff / (365*60*60*24));
	$months = floor(($diff - $years * 365*60*60*24) / (30*60*60*24));
		
		$query="update information_table set userDate='$udate', month='$months' where ID='$id'";
		
		if(!($database=mysql_connect("localhost","root","")))
			die("<p>Could not conncet to Database</p></body></html>");
			
		if(!mysql_select_db("blood",$database))
			die("<p>could not open blood</p></body></html>");
	
	
			
		if(!($result=mysql_query($query,$database)))
		{
			print("<p>could not execute query</p>");
			die(mysql_error()."</body></html>");
		}
		
		
		if(!($result=mysql_query($query,$database)))
		{
			print("<p>could not execute query</p>");
			die(mysql_error()."</body></html>");
		}
	
		print("<h2>You have successfully updated your last donation date!!!!!!!!!!!!</h2></body></html>");
		
		
		
				?>
		
		<li><a href="http://localhost/badhan/index.html">Back</a></li>
			
		
			
	</body>
	
</html>