<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>New Bug Report</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<form action="storingsoftwarebug.php" method="post" enctype="multipart/form-data">
				<table>
					<tr>
						<td>Product Name: </td>
						<td><input type="text" name="product" required /><br /></td>
					</tr>
					<tr>
						<td>Version: </td>
						<td><input type="text" name="version" required /><br /></td>
					</tr>	
					<tr>
						<td>Type of Hardware: </td>
						<td><input type="text" name="typehardware" required /><br /></td>
					</tr>
					<tr>
						<td>Operating System: </td>
						<td><input type="text" name="operatingsystem" required /><br /></td>
					</tr>
					<tr>
						<td>Frequency of Occurrence: </td>
						<td><input type="text" name="frequencyoccurrence" required /><br /></td>
					</tr>
					<tr>
						<td>Proposed Solutions: </td>
						<td><input type="text" name="proposedsolution" required /><br /></td>
					</tr>
					<tr>
						<td><input type="reset" value="Clear Form" /></td>
						<td><input type="submit" name="submit" value="Send Form" /></td>
					</tr>
				</table>	
			</form>
			<?php
			
			?>
		</body>
	</html>