<?php
	session_start();
	$_SESSION = array();
	session_destroy();
	
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>User Registration</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h1>User Registration</h1>
			<h2>Register / Log In</h2>
			<p>New user's, please complete the top form to register as a new user. Returning user's, please complete 
				the second form to log in.</p>
			<hr />
			<h3>User Registration</h3>
			<form method="post" action="Register.php?<?php echo SID; ?>">
				<p>Enter your Name: 
					First <input type="text" name="first" />
					Last <input type="text" name="last" />
				</p>
				<p>Enter your e-mail address:
					<input type="text" name="email" />
				</p>
				<p>Enter your password:
					<input type="password" name="password" />
				</p>
				<p>Confirm your password:
					<input type="password" name="password2" />
				</p>
				<p>
					<em>(Passwords are case-sensitive and must be at least 6 characters long)</em>
				</p>
				<input type="reset" name="reset" value="Reset Registration Form" />
				<input type="submit" name="register" value="Register" />
			</form>
			<hr />
			<?php
				$nag_counter = 0;
				if(isset($_COOKIE['userVisit']))
					$UserVisit = "<p>Your visit number is $nag_counter was on " . $_COOKIE['userVisit'];
					
				else
					$UserVisit = "<p>This is your first visit!</p>\n";
				
				++$nag_counter;
				setcookie("userVisit", date("F j, Y, g:i a"), time()+60*60*24*365);
			?>
			<?php 
				echo $UserVisit; 
			?>
		</body>
	</html>