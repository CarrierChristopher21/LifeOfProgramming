<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Password Strength</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$Passwords = array(	//At Least 10 Test's, at least 6 fails, at least 4 passes
												//	1 fail all tests, 1 fail length test
					"Password#",//No Number
					"Password1",//No special character
					"Simon#1",//Less than 8 characters 
					"chris#21",//No Uppercase
					"CHRIS#21",//No lowercase
					"Chris #21", //Failed because of space
					"Christopher#12/19/1991", // +16 characters Too long
					"       ", //FAILS EVERYTHING WEEEEEEE
					"Password#2048", //Pass 1
					"Simon68%", // Pass Test 2
					"Scream#5", //Pass Test 3
					"TammySmith#1", // Pass Test 4
					"Mississippi'13", //Pass Test 5
					
				);
				foreach($Passwords as $PasswordTest){
					echo "The Password &ldquo;" . $PasswordTest . "&rdquo; ";
					
					if(preg_match("/[^0-9A-Za-z]/", $PasswordTest) == 1){
						echo " is a Strong Password. <br />";
					}
					else{
						echo " is not a Strong Password. <br />";
					}
				}
			?>
		</body>
	</html>
	
	
	
	
	
	
	
	
	
	
	
	
	