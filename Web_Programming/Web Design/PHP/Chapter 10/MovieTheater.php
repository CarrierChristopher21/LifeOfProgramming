<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Movie Schedule</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h1>Movie Theater Schedule</h1>
			<h2>Ticket Stand</h2>
			<p>Please enter your name and age in the slots below.</p>
			<hr />
			<form method="post" action="MovieCalculation.php">
				<p>Enter your Name: </p>
				<p>
					First <input type="text" name="first" /> &nbsp; &nbsp;
					Last <input type="text" name="last" />
				</p>
				<p>Age:
					<input type="text" name="age" />
				</p>
				<input type="reset" name="reset" value="Reset Movie Form" />
				<input type="submit" name="register" value="Register" />
			</form>
			<?php
				
			?>
		</body>
	</html>