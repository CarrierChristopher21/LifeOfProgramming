<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Temperature Conversion</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$Fahrenheit = 0;
				$Celsius = 0;
				$Number = 1;
				while($Fahrenheit <= 100){
					
					$Celsius = (($Fahrenheit - 32) * (5/9));
					$Fahrenheit = (($Celsius * (9/5)) + 32);
					
					echo "<p>", $Number, ".) The converted temperature from Fahrenheit to Celsius is: "; 
					echo round($Celsius, 1), "<br />";
					
					echo "The converted temperature from Celsius to Fahrenheit is: ", 
						$Fahrenheit, "<br />";
					
					++$Number;
					++$Fahrenheit;
				}
				
			?>
			
		</body>
		
	</html>