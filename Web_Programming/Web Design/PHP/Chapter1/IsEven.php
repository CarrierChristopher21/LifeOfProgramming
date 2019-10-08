<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Even Conditioning</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$NumberTest1 = 5.75;
				$NumberTest2 = "H";
				$NumberTest3 = 53.42;
				$NumberTest4 = 58.33;
				$NumberTest5 = 2;
				$NumberTest6 = 14.23;
				$NumberTest7 = "A";
				$NumberTest8 = 55.46;
				
				$Number1 = is_numeric($NumberTest1) ? "true." : "false.";
				$Number2 = is_numeric($NumberTest2) ? "true." : "false.";
				$Number3 = is_numeric($NumberTest3) ? "true." : "false.";
				$Number4 = is_numeric($NumberTest4) ? "true." : "false.";
				$Number5 = is_numeric($NumberTest5) ? "true." : "false.";
				$Number6 = is_numeric($NumberTest6) ? "true." : "false.";
				$Number7 = is_numeric($NumberTest7) ? "true." : "false.";
				$Number8 = is_numeric($NumberTest8) ? "true." : "false.";
				
				($NumberTest1 % 2 == 0) ? $Result1 = "This number is: even." : $Result1 = "This number is: odd.";
				($NumberTest2 % 2 == 0) ? $Result2 = "This number is: even." : $Result2 = "This number is: odd.";
				($NumberTest3 % 2 == 0) ? $Result3 = "This number is: even." : $Result3 = "This number is: odd.";
				($NumberTest4 % 2 == 0) ? $Result4 = "This number is: even." : $Result4 = "This number is: odd.";
				($NumberTest5 % 2 == 0) ? $Result5 = "This number is: even." : $Result5 = "This number is: odd.";
				($NumberTest6 % 2 == 0) ? $Result6 = "This number is: even." : $Result6 = "This number is: odd.";
				($NumberTest7 % 2 == 0) ? $Result7 = "This number is: even." : $Result7 = "This number is: odd.";
				($NumberTest8 % 2 == 0) ? $Result8 = "This number is: even." : $Result8 = "This number is: odd.";
				
				$Round1 = round($NumberTest1);
				$Round2 = round($NumberTest2);
				$Round3 = round($NumberTest3);
				$Round4 = round($NumberTest4);
				$Round5 = round($NumberTest5);
				$Round6 = round($NumberTest6);
				$Round7 = round($NumberTest7);
				$Round8 = round($NumberTest8);
				
				echo "<p>True = Number , False = Not Numeric <br />";
				
				echo "<p>This number is: ", $Number1, "<br />";
				echo $Result1, "<br />";
				echo $NumberTest1, " Rounds to: ", $Round1, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number2, "<br />";
				echo $Result2, "<br />";
				echo $NumberTest2, " Rounds to: ", $Round2, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number3, "<br />";
				echo $Result3, "<br />";
				echo $NumberTest3, " Rounds to: ", $Round3, "<br />";	//Rounds 
				
				echo "<p>This number is: ", $Number4, "<br />";
				echo $Result4, "<br />";
				echo $NumberTest4, " Rounds to: ", $Round4, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number5, "<br />";
				echo $Result5, "<br />";
				echo $NumberTest5, " Rounds to: ", $Round5, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number6, "<br />";
				echo $Result6, "<br />";
				echo $NumberTest6, " Rounds to: ", $Round6, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number7, "<br />";
				echo $Result7, "<br />";
				echo $NumberTest7, " Rounds to: ", $Round7, "<br />";	//Rounds
				
				echo "<p>This number is: ", $Number8, "<br />";
				echo $Result8, "<br />";
				echo $NumberTest8, " Rounds to: ", $Round8, "<br />";	//Rounds
			?>
		</body>
	</html>