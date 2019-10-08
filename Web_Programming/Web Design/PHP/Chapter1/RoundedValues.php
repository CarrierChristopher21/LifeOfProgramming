<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Rounded Values</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$Stock1 = 11.269;	//round down
				$Stock2 = 75.546;	//round up
				$Stock3 = 70.181;	//floor - rounds down
				$Stock4 = 160.799;	//floor - rounds down
				$Stock5 = 25.244;	//Ceil - rounds up
				$Stock6 = 53.678;	//Ceil - rounds up
				$WholeNumber1 = round($Stock1);
				$WholeNumber2 = round($Stock2);
				$WholeNumber3 = floor($Stock3);
				$WholeNumber4 = floor($Stock4);
				$WholeNumber5 = ceil($Stock5);
				$WholeNumber6 = ceil($Stock6);
				
				echo "<p>round() - rounds to the closest whole number. <br />";
				echo "<p>ceil() - rounds up to the closest whole number. <br />";
				echo "<p>floor() - rounds down to the closest whole numbers. <br />";
				
				echo "<p>", $Stock1, " Rounds to: ", $WholeNumber1, "<br />";	//Rounds rounds down
				echo "<p>", $Stock2, " Rounds to: ", $WholeNumber2, "<br />";	//Rounds - rounds up
				echo "<p>", $Stock3, " Rounds to: ", $WholeNumber3, "<br />";	//Floor - rounds down
				echo "<p>", $Stock4, " Rounds to: ", $WholeNumber4, "<br />";	//Floor - rounds down
				echo "<p>", $Stock5, " Rounds to: ", $WholeNumber5, "<br />";	//Ceil - rounds up
				echo "<p>", $Stock6, " Rounds to: ", $WholeNumber6, "<br />";	//Ceil - rounds up
				
			?>
		</body>
	</html>
	
	
	