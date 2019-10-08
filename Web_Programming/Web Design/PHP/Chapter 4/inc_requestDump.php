<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Include Request Dump</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				function displayError($fieldName, $errorMsg){
					global $errorCount;
					echo "Error for \"$fieldName\": $errorMsg<br />\n";
					++$errorCount;
				}
				
				function validateWord($data, $fieldName){
					global $errorCount;
					if(empty($data)){
						displayError($fieldName, "This is required");
						$retval = "";
					}
					else{	// Only clean up the input if it isn't empty
						$retval = trim($data);
						$retval = stripslashes($retval);
						$retval = htmlentities($retval);
						if((strlen($retval) < 2) || (strlen($retval) > 20)){
							displayError($fieldName, "Words must be at least four and at most twenty letters long");
						}
						if(preg_match("/^[a-z]+$/i",$retval) == 0){
							displayError(fieldName, "Words must be only letters");
						}
					}
					$retval = strtoupper($retval);
					return($retval);
				}
				$errorCount = 0;
				$firstNames = array();
				$lastNamses = array();
				
				
				$fNames[] = validateWord($_REQUEST['fName'], "First Name");
				$lNames[] = validateWord($_REQUEST['lName'], "Last Name");
				$cities[] = validateWord($_REQUEST['city'], "City");
				$states[] = validateWord($_REQUEST['state'], "State");
				
				if($errorCount > 0){
					echo "Please use the \"Back\" button to re-enter the data.<br />\n";
				}
				else{		// Output
					$wordnum = 0;
					foreach($fNames as $fName)	// First Name
						echo ++$wordnum.".) First Name: $fName<br />\n";
					foreach($lNames as $lName)	// Last Name
						echo ++$wordnum.".) Last Name: $lName<br />\n";
					foreach($cities as $city)	// City
						echo ++$wordnum.".) City: $city<br />\n";
					foreach($states as $state)	// State
						echo ++$wordnum.".) State: $state<br />\n";
				}
				
			?>
		</body>
	</html>