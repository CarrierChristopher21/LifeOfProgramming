<!DOCTYPE html>

<head>
	<link rel="stylesheet" href="../css/format.css" type="text/css"/>
	<link rel="stylesheet" href="../css/review-styles.css" type="text/css">
	<title>Admin Login</title>
</head>

<body>
<script src="javascript/jquery-1.11.1.min.js"></script>

<div id="container">
<div id="header">
	<img src="../images/header.png" alt="sugardaddys logo">
</div>

<div id="center">
	<div id="content" style="margin-bottom: 250px; margin-top: 100px;">
		<h2>Admin Login</h2>
		<form action="../php/verify.php" method="POST">
			<label for="name" name="user">username: </label><input type="text"><br><br>
			<label class="field" for="pass">password: </label><input name="pass" type="text"><br><br>

			<button type="submit">Log in as Admin</button>
		</form>
	</div>

</div>
	<div id="footer">
		<address>SugarDaddy's Ice Cream Grill, 50 N Main St,  Wellsville, NY 14895</address>
	</div> 
</div> <!-- Container -->


<div id="navigation">
	<ul>
		<li><a href="index.html" title ="Home Page">Home</a></li>

		<li><a href="events.html" title ="table">Events</a></li>

		<li><a href="review.html" title ="Experience Review">Review</a></li>

		<li><a href="directions.html" title ="Interactive map">Map Directions</a></li>

		<li><a href="menu.html" title ="Menu Items">Menu</a></li>
	</ul>
</div> <!-- Navigation -->

</body>
</html>