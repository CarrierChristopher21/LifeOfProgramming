<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Pay Check PHP</title>
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
						
						$retvalue = "";
					}
					else{	// Only clean up the input if it isn't empty
							$retvalue = trim($data);
							$retvalue = stripslashes($retvalue);
							
							if((strlen($retvalue) < 2) || (strlen($retvalue) > 10)){
								displayError($fieldName, " Entries must be at least two and at most ten numbers long");
							}
							if(preg_match("/^[0-9]+$/i", $retvalue) == 1){
								displayError($fieldName, " Entries must be numbers only");
							}
							if(is_numeric($retvalue)){
								$retvalue = number_format($retvalue, 2);
								
							}
					}
				
					$retvalue = strtoupper($retvalue);
					return($retvalue);
				}
				$errorCount = 0;
				$overTime = 0;
				$regularTime = 0;
				$hoursworkeds = array();
				$hourlywages = array();
				
				$hoursworkeds[] = validateWord($_POST['HoursWorked'], "HoursWorked");
				$hourlywages[] = validateWord($_POST['HourlyWage'], "HourlyWage");
				
				if($errorCount > 0){
					echo "Please use the \"Back\" button to re-enter the data.<br />\n";
				}
				else{
					$num = 0;
					foreach($hoursworkeds as $hoursworked)
						echo ++$num.".) Hours Worked: $hoursworked<br />\n";
					foreach($hourlywages as $hourlywage)
						echo ++$num.".) Hourly Wage: $$hourlywage<br />\n";
					echo "\n";
					
					//Calculation
					$hoursworkeds = $hoursworked;
					$hourlywages = $hourlywage;
					if($hoursworked > 40){
						$overTime = (($hoursworked - 40) * ($hourlywage * 1.5));
						$overTimeTotal = (($hourlywage * 40) + $overTime);
						$overTimeTotal = number_format($overTimeTotal, 2);
						printf("<p>Your paycheck for the week is: $%s.</p>\n", $overTimeTotal);
					}
					else{
						$regularTime = $hoursworked * $hourlywage;
						$regularTime = number_format($regularTime, 2);
						printf("<p>Your paycheck for the week is: $%s.</p>\n", $regularTime);
					}
					
				}

			?>
		</body>
	</html>