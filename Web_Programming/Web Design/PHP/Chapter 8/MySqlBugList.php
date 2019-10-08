<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>MySql Bug List</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h2>Bug List</h2>
			<?php
				
				$Dir = ".";
				$BugFileCount = 0;

				$DirList = scandir($Dir);
				echo "<table border=\"1\">\n";
				echo "<td><strong>Product name</strong></td>"; 
				echo "<td><strong>Product version</strong></td>"; 
				echo "<td><strong>Type of hardware</strong></td>"; 
				echo "<td><strong>Operating system</strong></td>"; 
				echo "<td><strong>Frequency of occurrence</strong></td>"; 
				echo "<td><strong>Proposed solution</strong></td>"; 
				echo "<td>&nbsp;</td></tr>\n"; 
				foreach ($DirList as $File) {
					 if (preg_match("/^Bug\.\d*\.\d*\.txt$/i",$File)) {
						  ++$BugFileCount;
						  $BugFileContents = file($File);
						  echo "<tr><td colspan='7'>&nbsp;</td></tr>\n"; 
						  echo "<tr><td><strong>Description:</td>"; 
						  echo "<td colspan='5'><strong>" . $BugFileContents[0] . "</strong></td>"; 
						  echo "<td rowspan=\"3\"><a href=\"MySqlBugReport.php?BugFile=$File\">Details</a></td></tr>\n"; 
						  echo "<tr><td>" . $BugFileContents[1] . "</td>"; 
						  echo "<td>" . $BugFileContents[2] . "</td>"; 
						  echo "<td>" . $BugFileContents[3] . "</td>"; 
						  echo "<td>" . $BugFileContents[4] . "</td>"; 
						  echo "<td>" . $BugFileContents[5] . "</td>"; 
						  echo "<td>" . $BugFileContents[6] . "</td></tr>\n"; 
						  $linecount = count($BugFileContents);
						  if ($linecount>7) {
							   echo "<tr><td><strong>Last Update:</strong></td>"; 
							   echo "<td colspan='5'>" . $BugFileContents[$linecount-1] . "</td></tr>\n"; 
						  }
						  else
							   echo "<tr><td colspan='6'>There are no updates</td></tr>\n"; 
					 }
				}
				if ($BugFileCount==0) {
					 echo "<tr><td colspan='7'>There are no bug reports</td></tr>\n"; 
				}
				echo "</table>\n";
			?>
			
			<h3><br />New Bug Report:</h3>
			<form action="MySqlBugReportCreate.php" method="post">
				<table border="1">
					<tr><td colspan="2">(*)Bug Description:</td></tr>
					<tr><td colspan="2"><textarea cols="80" rows="6" name="Description"></textarea></td></tr>
					<tr><td>(*)Product name</td><td><input type="text" name="ProductName" /></td></tr> 
					<tr><td>(*)Product version</td><td><input type="text" name="ProductVersion" /></td></tr> 
					<tr><td>Type of hardware</td><td><input type="text" name="HardwareType" /></td></tr> 
					<tr><td>Operating system</td><td><input type="text" name="OS" /></td></tr> 
					<tr><td>Frequency of occurrence</td><td><input type="text" name="Frequency" /></td></tr> 
					<tr><td>Proposed solution</td><td><input type="text" name="Solution" /></td></tr> 
				</table>
				<input type="submit" name="create" value="Create New Report" />
			</form>
			Fields marked with an asterisk (*) are required.
		</body>
	</html>

