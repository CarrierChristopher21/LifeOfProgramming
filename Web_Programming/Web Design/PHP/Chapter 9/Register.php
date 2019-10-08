<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Default</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$nag_counter = 0;
				if(isset($_COOKIE['userVisit']))
					$UserVisit = "<p>Your visit number is $nag_counter was on " . $_COOKIE['userVisit'];
					++$nag_counter;
				else{
					$UserVisit = "<p>This is your first visit!</p>\n";
					++$nag_counter;
				}
				setcookie("userVisit", date("F j, Y, g:i a"), time()+60*60*24*365);
			?>
		</body>
	</html>