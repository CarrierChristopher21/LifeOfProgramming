<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Days Arrays</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$EnglishDay1 = "Sunday";
				$EnglishDay2 = "Monday";
				$EnglishDay3 = "Tuesday";
				$EnglishDay4 = "Wednesday";
				$EnglishDay5 = "Thursday";
				$EnglishDay6 = "Friday";
				$EnglishDay7 = "Saturday";
				
				$Days = array($EnglishDay1, $EnglishDay2, $EnglishDay3, $EnglishDay4,
					$EnglishDay5, $EnglishDay6, $EnglishDay7);
					
				echo "<p>The days of the week in English are: </p><p>";
				echo "1.) $Days[0]<br />";
				echo "2.) $Days[1]<br />";
				echo "3.) $Days[2]<br />";
				echo "4.) $Days[3]<br />";
				echo "5.) $Days[4]<br />";
				echo "6.) $Days[5]<br />";
				echo "7.) $Days[6]</p>";
				
				$FrenchDay1 = "Dimanche";
				$FrenchDay2 = "Lundi";
				$FrenchDay3 = "Mardi";
				$FrenchDay4 = "Mercredi";
				$FrenchDay5 = "Jeudi";
				$FrenchDay6 = "Vendredi";
				$FrenchDay7 = "Samedi";
				
				$Days = array($FrenchDay1, $FrenchDay2, $FrenchDay3, $FrenchDay4,
					$FrenchDay5, $FrenchDay6, $FrenchDay7);
					
				echo "<p>The days of the week in French are: </p><p>";
				echo "1.) $Days[0]<br />";
				echo "2.) $Days[1]<br />";
				echo "3.) $Days[2]<br />";
				echo "4.) $Days[3]<br />";
				echo "5.) $Days[4]<br />";
				echo "6.) $Days[5]<br />";
				echo "7.) $Days[6]</p>";
				
				
			?>
		</body>
	</html>