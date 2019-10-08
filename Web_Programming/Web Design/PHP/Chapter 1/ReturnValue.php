<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Return Value</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$Value1 = 2;
				$Value2 = 3;
				echo "<p>The following are the return value calculations: </p>";
				echo '<p>$Value1 = 2 and $Value2 = 3', "<br />";
				
				//1
				$ReturnValue1 = ($Value1 == $Value2 ? "true" : "false");
				echo '<p>1.) $Value1 is equal to $Value2 is: ', $ReturnValue1, "<br />";
				
				//2
				$ReturnValue2 = "2" + "3";
				echo '<p>2.) $Value1 + $Value2 is: =  "2" + "3" = ', $ReturnValue2, "<br />";
				
				//3
				$ReturnValue3 = ($Value1 >= $Value2 ? "true" : "false");
				echo '<p>3.) $Value1 is greater than or equal to $Value2: ', $ReturnValue3, "<br />";
				
				//4
				$ReturnValue4  = ($Value1 <= $Value2 ? "true" : "false");
				echo '<p>4.) $Value1 is less than or equal to $Value2: ', $ReturnValue4, "<br />";
				
				//5
				$ReturnValue5 = $Value1 + $Value2;
				echo '<p>5.) $ReturnValue5 after addition expression is: ', $ReturnValue5, "<br />";
				
				//6
				$ReturnValue6 = ($Value1 >= $Value2) && ($Value1 > $Value2) ? "true" : "false";
				echo '<p>6.) ($Value1 is greater than or equal to $Value2) AND ($Value1 is greater than $Value2): ', $ReturnValue6, "<br />";
				//7
				$ReturnValue7 = ($Value1 >= $Value2) || ($Value1 > $Value2) ? "true" : "false";
				echo '<p>7.) ($Value1 is greater than or equal to $Value2) OR ($Value1 is greater than $Value2): ', $ReturnValue6, "<br />";
				
				
			?>
		</body>
	</html>