<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Box Array</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				//Box Array
				$SmallBox = array("length" => 12, "width" => 10, "depth" => 2.5); 	// Length
				$MediumBox = array("length" => 30, "width" => 20, "depth" => 4); 		// Width
				$LargeBox = array("length" => 60, "width" => 40, "depth" => 11.5);	// Depth
				// Box Conversion
				$VolumeConversion = array("SmallBox" => $SmallBox, "MediumBox" => $MediumBox, 
					"LargeBox" => $LargeBox);
				//Volume Conversion
				$Volume["Volume"] = $VolumeConversion;
				//Small Box
				echo "<p>The Volume of the Small Box is (" . $Volume['Volume']['SmallBox']['length'] 
					. " * " .  $Volume['Volume']['SmallBox']['width'] . " * " . $Volume['Volume']['SmallBox']['depth'] . ").\n";
				//Medium Box
				echo "<p>The Volume of the Medium Box is (" . $Volume['Volume']['MediumBox']['length'] . " * " .  
					$Volume['Volume']['MediumBox']['width'] . " * " . $Volume['Volume']['MediumBox']['depth'] . ").\n";
				//Large Box	
				echo "<p>The Volume of the Large Box is (" . $Volume['Volume']['LargeBox']['length'] . " * " .  
					$Volume['Volume']['LargeBox']['width'] . " * " . $Volume['Volume']['LargeBox']['depth'] . ").</p>";
			?>
		</body>
	</html>