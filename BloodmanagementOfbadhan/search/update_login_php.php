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
		
		$name=$_POST['name'];
		$password=$_POST['password'];
		$query="select * from information_table where username='$name' and password='$password'";
		
		
		if(!($database=mysql_connect("localhost","root","")))
			die("<p>Could not conncet to Database</p></body></html>");
			
		if(!mysql_select_db("blood",$database))
			die("<p>could not open blood</p></body></html>");
	
	
			
		if(!($result=mysql_query($query,$database)))
		{
			print("<p>could not execute query</p>");
			die(mysql_error()."</body></html>");
		}
		
		
		
		$count=mysql_num_rows($result);
		
		
		
		
		
		if($count==1){
		
		
		header("location:http://localhost/badhan/search/update_html.html");
		}
		else{
		echo "incorrect username and password";
		}
		
		?>
		
		
			
		
			
	</body>
	
</html>