<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>MySql Bug Report</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h2>MySql Bug Report</h2>
			<?php
				if (isset($_GET['BugFile'])) {
					if (is_readable($_GET['BugFile'])) {
						  $BugReport = file($_GET['BugFile']);
						  echo "<table border=\"1\">\n";
						  echo "<tr><td colspan='2'><strong>" . $BugReport[0] . "</strong></td></tr>\n"; 
						  echo "<tr><td><strong>Product name</strong></td><td>" . $BugReport[1] . "</td></tr>\n"; 
						  echo "<tr><td><strong>Product version</strong></td><td>" . $BugReport[2] . "</td></tr>\n"; 
						  echo "<tr><td><strong>Type of hardware</strong></td><td>" . $BugReport[3] . "</td></tr>\n"; 
						  echo "<tr><td><strong>Operating system</strong></td><td>" . $BugReport[4] . "</td></tr>\n"; 
						  echo "<tr><td><strong>Frequency of occurrence</strong></td><td>" . $BugReport[5] . "</td></tr>\n"; 
						  echo "<tr><td><strong>Proposed solution</strong></td><td>" . $BugReport[6] . "</td></tr>\n"; 
						  $LineCount = count($BugReport);
						  for ($i=7; $i<$LineCount; ++$i) {
							   echo "<tr><td colspan=\"2\"><strong>Update " . ($i-6) . "</strong></td></tr>\n";
							   echo "<tr><td colspan=\"2\">" . $BugReport[$i] . "</td></tr>\n"; 
						  }
						  echo "</table>\n";
			?>
			<h3><br />Add an update:</h3>
			<form action="MySqlBugReportUpdate.php" method="post">
				<input type="hidden" name="BugFile" value="<?php echo $_GET['BugFile']; ?>" />
				<textarea name="UpdateText" rows="6" cols="80"></textarea><br />
				<input type="submit" name="update" value="Update MySql Bug Report" />
			</form>
			<?php
					}
					 else
						  echo "<p>Cannot read from the file.</p>\n";
				}
				else{
				   echo "<p>Please <a href=\"MySqlBugList.php\">select a bug</a>.</p>\n";
				}
			?>
		</body>
	</html>

