<html>
	<head>
		<title>This is Title
		
		</title>
		
		<link rel="stylesheet" type="text/css" href="result.css"/>
		
		<style type="text/css">
	label {width:3cm; float:left;}
	
	h2{color:#FF9412}
	div{margin-bottom:5px;}
	table{
		background-color:#fff;
		border:1px solid gray;
		border-collaps:collaps;
			}
		th,td{padding:5px;border:1px solid gray}
			tr:nth-child(even){background-color:white}
			tr:first-child(even){background-color:white}
	
</style>
	</head>
	
	<body>
		<div class="slider_area fix">
			
			<div class="fix slider">
			<div class="slider-wrapper theme-light">
			<div class="nivoSlider" id="slider">
			
			<img src="images/b1.jpg"   />
			<img src="images/b5.jpg"   />
			<img src="images/b2.png"   />
			<img src="images/b3.png"   />
			<img src="images/b4.jpg"   />
					
					
				</div>
			</div>
		</div>
		</div>
				<div class="mainmenu fix">
					<ul>
						<li><a href="http://localhost/badhan/index.html">Home</a></li>
						<li><a href="http://localhost/badhan/about_us/index.html">About Us</a></li>
						
						<li><a href="http://localhost/badhan/demo/demo.html">Newsletter</a></li>
						<li><a href="http://localhost/badhan/contruct_us/contract.html">Contact Us</a></li>
					</ul>
				</div>
			</div>
		</div>
		
		<div class="maincontent_area fix">
			<div class="stracture maincontent fix">
			
			
			
			<div class="content fix floatright">
			
				<?php
		
	
		$query="select ID,fullname,hallname,deptname,batch,email,phone,blood_group from information_table";
		
		if(!($database=mysql_connect("localhost","root","")))
			die("<p>Could not conncet to Database</p></body></html>");
			
		if(!mysql_select_db("blood",$database))
			die("<p>could not open blood</p></body></html>");
	
	
			
		if(!($result=mysql_query($query,$database)))
		{
			print("<p>could not execute query</p>");
			die(mysql_error()."</body></html>");
		}
		
		
		?>
		<h2 align="">The name and contacts of doner are given below</h2>
		
			<table>
			
				<tr>
					<th>ID</th>
					
					
					
					<th>FULL NAME</th>
					<th>HALL NAME</th>
					<th>DEPT NAME</th>
					<th>BATCH NAME</th>
					
					
					<th>EMAIL</th>
					<th>PHONE</th>
					
					
					<th>BLOOD GROUP</th>
					
				</tr>	
				
				<?php
			
				while($row=mysql_fetch_row($result))
				{
					print("<tr>");
					
					foreach ($row as $key=>$value)
						print("<td>$value</td>");
						
						print("</tr>");
				}
			?>
		
		</table>
		
		</br>
		</br>
		</br>
		</br>
		
		<?php print("<h2>The Total members are      ".mysql_num_rows($result)."</h2>");?>
		
			
			
		</div>
		
	</div>
	</div>
		<div class="footer_area fix">
			<div class="stracture footer fix">
				<div class="copyright floatleft fix">
					<p>&copy;  Dept. of Computer Science and Engineering,JU</p>
				</div>
				<div class="social_bookmark floatleft fix">
					<p>Stay Connected</p>
					<a href="https://www.yahoo.com/"><img src="images/yahoo.png" alt=""/></a>
					<a href="https://www.facebook.com/"><img src="images/facebook.png" alt=""/></a>
					<a href="https://www.twitter.com/"><img src="images/twitter.png" alt=""/></a>
					<a href="https://www.linkedin.com/"><img src="images/linkedin.png" alt=""/></a>
				</div>
				<div class="footermenu floatright fix">
					<ul>
						<li><a href="http://localhost/badhan/index.html">Home</a></li>
						<li><a href="http://localhost/badhan/about_us/index.html">About Us</a></li>
						
						<li><a href="http://localhost/badhan/demo/demo.html">Newsletter</a></li>
						<li><a href="http://localhost/badhan/contruct_us/contract.html">Contact Us</a></li>
					</ul>
				</div>
			</div>
		</div>
		
		<script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
		<script type="text/javascript" src="js/jquery.nivo.slider.pack.js"></script>
		<script type="text/javascript">
		$(window).load(function() {
			$('#slider').nivoSlider();
		});
		</script>
	</body>
</html>