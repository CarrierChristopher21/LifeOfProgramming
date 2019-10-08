<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Create a Bug Report</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h2>Create a Bug Report</h2>
			<?php
				$errors = 0;
				$create_set = FALSE;
				$BugReport = array();
				if (isset($_POST['create'])) {
					 $create_set = TRUE;
					 // The three required fields
					 if ((empty($_POST['Description'])) || (strlen(trim($_POST['Description']))==0)) {
						  ++$errors;
						  echo "<p>You must enter a description of the bug.</p>\n";
					 }
					 else
						  $BugReport[] = htmlentities($_POST['Description']) . "\n";
						  
					 if ((empty($_POST['ProductName'])) || (strlen(trim($_POST['ProductName']))==0)) {
						  ++$errors;
						  echo "<p>You must enter a product name.</p>\n";
					 }
					 else
						  $BugReport[] = htmlentities($_POST['ProductName']) . "\n";
						  
					 if ((empty($_POST['ProductVersion'])) || (strlen(trim($_POST['ProductVersion']))==0)) {
						  ++$errors;
						  echo "<p>You must enter a product version.</p>\n";
					 }
					 else
						  $BugReport[] = htmlentities($_POST['ProductVersion']) . "\n";
						  
					 // The four optional fields
					 if (!empty($_POST['HardwareType']))
						  $BugReport[] = htmlentities($_POST['HardwareType']) . "\n";
						  
					 if (!empty($_POST['OS']))
						  $BugReport[] = htmlentities($_POST['OS']) . "\n";
						  
					 if (!empty($_POST['Frequency']))
						  $BugReport[] = htmlentities($_POST['Frequency']) . "\n";
						  
					 if (!empty($_POST['Solution']))
						  $BugReport[] = htmlentities($_POST['Solution']) . "\n";
				}
				   
				if (($create_set==TRUE) && ($errors==0)) {
					 $BugFile = "Bug." . microtime(TRUE) . ".txt";
					 file_put_contents($BugFile, $BugReport);
					 echo "<table border=\"1\">\n";
					 echo "<tr><td colspan='2'><strong>" . $BugReport[0] . "</strong></td></tr>\n"; 
					 echo "<tr><td><strong>Product name</strong></td><td>" . $BugReport[1] . "</td></tr>\n"; 
					 echo "<tr><td><strong>Product version</strong></td><td>" . $BugReport[2] . "</td></tr>\n"; 
					 echo "<tr><td><strong>Type of hardware</strong></td><td>" . $BugReport[3] . "</td></tr>\n"; 
					 echo "<tr><td><strong>Operating system</strong></td><td>" . $BugReport[4] . "</td></tr>\n"; 
					 echo "<tr><td><strong>Frequency of occurrence</strong></td><td>" . $BugReport[5] . "</td></tr>\n"; 
					 echo "<tr><td><strong>Proposed solution</strong></td><td>" . $BugReport[6] . "</td></tr>\n"; 
					 echo "</table>\n";
				}
				else
					 echo "<p>Cannot read from the file.</p>\n";

			?>
			
			<p>Return to the <a href="BugList.php">bug list</a>.</p>
		
		</body>
	</html>

