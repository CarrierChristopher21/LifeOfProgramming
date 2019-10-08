<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Bug Report Update</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<h2>Update a Bug Report</h2>
			
			<?php
				$errors = 0;
				$update_set = FALSE;
				if (isset($_POST['update'])) {
					 $update_set = TRUE;
					 if (empty($_POST['BugFile'])) {
						  ++$errors;
						  echo "<p>You must select a bug first.</p>\n";
					 }
					 else if (!is_file($_POST['BugFile'])) {
						  ++$errors;
						  echo "<p>You must select a bug file first.</p>\n";
					 }
					 else if (!is_readable($_POST['BugFile'])) {
						  ++$errors;
						  echo "<p>There is a file read permission problem.</p>\n";
					 }
					 else if (!is_writeable($_POST['BugFile'])) {
						  ++$errors;
						  echo "<p>There is a file write permission problem.</p>\n";
					 }
					 if (empty($_POST['UpdateText'])) {
						  ++$errors;
						  echo "<p>You must enter some text for the update.</p>\n";
					 }
				}
			   
				if (($update_set==TRUE) && ($errors==0)) {
					 $BugReport = file($_POST['BugFile']);
					 $BugReport[] = htmlentities($_POST['UpdateText']) . "\n";
					 file_put_contents($_POST['BugFile'],$BugReport);
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
						  echo "<tr><td colspan=\"2\"><strong>Update " . ($i-6) . ":</strong></td></tr>\n";
						  echo "<tr><td colspan=\"2\">" . $BugReport[$i] . "</td></tr>\n"; 
					 }
					 echo "</table>\n";
			?>
			
			<p>Add another update to <a href="BugReport.php?BugFile=<?php echo $_POST['BugFile']; ?>">this bug</a>.</p>
			<p> or</p>
			
			<?php
				}
				else
					 echo "<p>Cannot read from the file.</p>\n";

			?>
			
				<p>Return to the <a href="BugList.php">bug list</a>.</p>
				
		</body>
	</html>

