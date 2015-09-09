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
		
		$id=$_POST['id'];
		
		$query="delete from information_table where  ID='$id'";
		
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
		}else{
		
		print("<p>You have succeded!!!!!!!!!!!!</p></body></html>");
		}
		
		
		?>
		
		
			<li><a href="http://localhost/badhan/index.html">Back</a></li>
		
			
	</body>
	
</html>