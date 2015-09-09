<!DOCTYPE HTML>
<html lang="bn">
	<head>
	<meta charset="utf-8">
		<title>This is Title
		
		</title>
		<link rel="stylesheet" type="text/css" href="css/bar/bar.css"/>
		<link rel="stylesheet" type="text/css" href="css/dark/dark.css"/>
		<link rel="stylesheet" type="text/css" href="css/default/default.css"/>
		<link rel="stylesheet" type="text/css" href="css/light/light.css"/>
		<link rel="stylesheet" type="text/css" href="css/nivo-slider.css"/>
		<link rel="stylesheet" type="text/css" href="style.css"/>
		
		
		<style type="text/css">
	
	table{
		
		marging-left:100px;
		background-color:#fff;
		border:3px solid gray;
		border-collaps:collaps;
		color:#fff;
			}
			table th{color:#111111}
		th,tr{padding:8px;border:1px solid gray}
			td:nth-child(even){background-color:red;padding:5px;}
			td:nth-child(odd){background-color:green}
	
</style>
	</head>
	
	<body>
	


		<div class="slider_area fix">
		
		<div class="slider_area_logo fix">
		<div class="slider_logo fix">
		
		
		
			<img src="images/logo.jpg"   />
		</div>
		
		
		
			<div class="fix slider">
			<div class="slider-wrapper theme-light">
			<div class="nivoSlider" id="slider">
			
			
			<img src="images/b5.jpg"   />
			<img src="images/b1.jpg"   />
			<img src="images/b2.png"   />
			<img src="images/b3.png"   />
			<img src="images/b4.jpg"   />
					
					
				</div>
			</div>
		</div>
		</div>
		</div>
			<div class="mainmenu ">	<nav>
	<ul>
		<li><a href="http://localhost/badhan/index.php">Home</a></li>
		<li><a href="http://localhost/badhan/search/member.php">All Donors List</a>
		<li><a href="#">Donors by Group</a>
			<ul>
				<li><a href="http://localhost/badhan/search/A_negative.php">A negative(-)</a></li>
		<li><a href="http://localhost/badhan/search/A_positive.php">A positive(+)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/AB_negative(-)">AB negative(-)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/AB_positive(+)">AB positive(+)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/B_negative(-)">B negative(-)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/B_positive(+)">B positive(+)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/O_negative(-)">O negative(-)</a></li>
		<li><a href="http://www.blooddonorsbd.com/group/O_positive(+)">O positive(+)</a></li>
		</ul>
	<li class=""><a href="http://www.blooddonorsbd.com/districts.php">Donors by Village</a></li>
	<li class=""><a href="#" rel="ddsubmenu1">About Blood</a>
	
			<ul>
		<li><a href="http://www.blooddonorsbd.com/whydonateblood.php">Why Donate Blood?</a></li>
		<li><a href="http://www.blooddonorsbd.com/eligibilitytodonateblood.php">Eligibility to Donate Blood</a></li>
		<li><a href="http://www.blooddonorsbd.com/tipsforasuccessfuldonation.php">Tips for Successful Donation</a></li>
		<li><a href="http://www.blooddonorsbd.com/whathappenstodonatedblood.php">What Happens to Donated Blood?</a></li>
	</ul>
	</li>
	<li class=""><a href="http://www.blooddonorsbd.com/requestblood.php">About Us</a></li>
	<li><a href="http://localhost/badhan/contruct_us/contract.html">Contact Us</a></li>
	</ul>
 </nav>
		</div>
			
		
		<div class="maincontent_area fix">
			<div class="stracture maincontent fix">
			
			<?php
		
		
		$query="select ID,month,name,father_name,mother_name,village,po,phone,gender,weight,blood_group,Date,checkbox from information_table where blood_group='O-' and month>='3'";
		
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
		<h2 align="center">The name and contacts of doner are given below</h2>
		
			<table>
			
				<tr>
					<th>ID</th>
					<th>Duration</th>
					<th>NAME</th>
					
					
					<th>FATHER NAME</th>
					<th>MOTHER NAME</th>
					<th>VILLAGE</th>
					<th>P.O</th>
					
					
					<th>PHONE</th>
					<th>GENDER</th>
					<th>WEIGHT</th>
					
					<th>BLOOD GROUP</th>
					<th>Donation Date</th>
					<th>Interest</th>
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
		
			</div>
			
		
		</div>
		<div class="footer_area fix">
		
			<div class="stracture footer fix">
				<div class="copyright floatleft fix">
					<p>&copy; All Rights Reserved By SBP</p>
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
			
		
		<script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
		<script type="text/javascript" src="js/jquery.nivo.slider.pack.js"></script>
		<script type="text/javascript">
		$(window).load(function() {
			$('#slider').nivoSlider();
		});
		</script>
	</body>
</html>