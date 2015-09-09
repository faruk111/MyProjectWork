<html>
	<head>
		<title>This is Title
		
		</title>
		<link rel="stylesheet" type="text/css" href="css/bar/bar.css"/>
		<link rel="stylesheet" type="text/css" href="css/dark/dark.css"/>
		<link rel="stylesheet" type="text/css" href="css/default/default.css"/>
		<link rel="stylesheet" type="text/css" href="css/light/light.css"/>
		<link rel="stylesheet" type="text/css" href="css/nivo-slider.css"/>
		<link rel="stylesheet" type="text/css" href="style.css"/>
		
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
						<li><a href="index.html">Home</a></li>
						<li><a href="about-us.html">About Us</a></li>
						<li><a href="singles-ministries.html">Singles Ministries</a></li>
						<li><a href="blog.html">Blog</a></li>
						<li><a href="newsletter.html">Newsletter</a></li>
						<li><a href="contact-us.html">Contact Us</a></li>
					</ul>
				</div>
			</div>
		</div>
		
		<table align="center">
	<form  name="form.html" action="search.php" method="post">
	
		
		<div><label>Searches Doner :</label>
			<input type="text" name="donar" placeholder ="A+"/>
			<input type="submit" value="search"/>
		</div>
		
		</form>
		</table>
		
		<div class="footer_area fix">
			<div class="stracture footer fix">
				<div class="copyright floatleft fix">
					<p>&copy; 2013 Events for Single Christians. All Rights Reserved</p>
				</div>
				<div class="social_bookmark floatleft fix">
					<p>Stay Connected</p>
					<a href=""><img src="images/yahoo.png" alt=""/></a>
					<a href=""><img src="images/facebook.png" alt=""/></a>
					<a href=""><img src="images/twitter.png" alt=""/></a>
					<a href=""><img src="images/linkedin.png" alt=""/></a>
				</div>
				<div class="footermenu floatright fix">
					<ul>
						<li><a href="about-us.html">About Us</a></li>
						<li><a href="blog.html">Blog</a></li>
						<li><a href="singles-ministries.html">Singles Ministries</a></li>
						<li><a href="newsletter.html">Newsletter</a></li>
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