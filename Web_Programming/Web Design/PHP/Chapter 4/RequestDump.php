<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Request Dump</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			
			<h2 style="text-align:center">Request Dump</h2>
			<form name="RequestDump" action="inc_requestDump.php" method="post">
				First Name: <input type="text" name="fName" /><br />
				Last Name: <input type="text" name="lName" /><br />
				City: <input type="text" name="city" /><br />
				State: <input type="text" name="state" /><br />
				<input type="reset" value="Clear Form" />&nbsp;
				&nbsp;<input type="submit" name="Submit" value="Send Form" /><br />
			</form>
			
			<?php	
			?>
			
		</body>
	</html>