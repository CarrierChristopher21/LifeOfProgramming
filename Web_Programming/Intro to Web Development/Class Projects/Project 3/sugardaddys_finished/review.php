<?php
	require_once('php/commentFeed.php');
?>
<!DOCTYPE html>

<head>
	<link rel="stylesheet" href="css/format.css" type="text/css"/>
	<link rel="stylesheet" href="css/review-styles.css" type="text/css">
	
	<title>Customer Reviews</title>
	
	<meta http-equi="Content-type" content="text/html" chareset="utf-8" />
	<meta name="This is a site for Sugardaddy's ice cream in Wellsville NY" />
	<meta name="keywords" content="Sugardaddy's, Wellsville, ice cream" />
</head>

<body>
<script src="javascript/jquery-1.11.1.min.js"></script>
<script type="text/javascript" src="javascript/reviewpage.js"></script>
<div id="container">
<div id="header">
	<img src="images/header.png" alt="sugardaddys logo">
</div>

<div id="center">
	
	<!-- Comments -->
	<div id="content">
		<h2>Customer Reviews</h2>
		<div id="comments">
		<?php getComments("user");?>
		</div>
	</div>


	<div id="content">
		<h2>Your Input Matters To Us.</h2>
		<p>Rate your experience out of ten then, if you want, leave a comment about your experience with us at Sugardaddy's.</p>
	


		<h2>Leave a Comment</h2>

		<form action="php/comment.php" method="POST">
		
		
		<!-- Selection List -->
		<label class="field" for="rating">Rating: </label> 		
			<select name="rating" id="rating">
				<option value="1">1</option>
				<option value="2">2</option>
				<option value="3">3</option>
				<option value="4">4</option>
				<option value="5">5</option>
				<option value="6">6</option>
				<option value="7">7</option>
				<option value="8">8</option>
				<option value="9">9</option>
				<option value="10">10</option>
			</select>

			<!-- Rating Number -->
			<span id="outOfTen"><font color="#36DA82">1</font>/10<br></span> 
			<br><br>			
		
		<!-- Name Field -->
		<label class="field" for="Name">Name: </label><br><input type="text" id="textbox" name="name">
		<br><br>
				

		
		<label class="field" for="comment">Comment: </label>
		<textarea name="comment" id="comment" cols="95" rows="10" maxlength="250"></textarea>

		<button type="submit" onclick="validateForm();">Submit Comment</button>


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