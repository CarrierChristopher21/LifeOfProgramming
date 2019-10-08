<?php
	require_once('../php/commentFeed.php');
?>
<!DOCTYPE html>

<head>
	<link rel="stylesheet" href="../css/format.css" type="text/css"/>
	<link rel="stylesheet" href="../css/review-styles.css" type="text/css">
	
	<title>Sugardaddy's</title>
	
	<meta http-equi="Content-type" content="text/html" chareset="utf-8" />
	<meta name="This is a site for Sugardaddy's ice cream in Wellsville NY" />
	<meta name="keywords" content="Sugardaddy's, Wellsville, ice cream" />
</head>

<body>
<script src="javascript/jquery-1.11.1.min.js"></script>
<script type="text/javascript">
	//Assigns button click to php function delete()

</script>
<div id="container">
<div id="header">
	<img src="../images/header.png" alt="sugardaddys logo">
</div>

<div id="center">
	
	<!-- Comments -->
	<div id="content">
		<h2>Customer Reviews</h2>
		<div id="comments">
		<?php getComments("admin");?>
		</div>
	</div>

	<div id="content">
		<form action="../php/delete.php" method="POST">
			<!-- Post ID Field -->
			<h2>Delete Post</h2>
			<label class="field" for="Id">Post ID: </label><br><input type="text" id="textbox" name="id">
			<br><br>

			<button type="submit">Delete Post</button>
		</form>
		
	</div>

</div>
	<div id="footer">
		<address>SugarDaddy's Ice Cream Grill, 50 N Main St,  Wellsville, NY 14895</address>
	</div> 
</div> <!-- Container -->


<div id="navigation">
	<div id="navhead">
		
	</div>
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