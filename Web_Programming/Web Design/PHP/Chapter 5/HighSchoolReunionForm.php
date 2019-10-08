<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>High School Reunion Form</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<form action="DisplayReunionData.php" method="POST" enctype="multipart/form-data">
				<table>
					<tr>
						<td>Name: </td>
						<td><input type="text" name="name" required /><br /></td>
					</tr>
					<tr>
						<td>Image Description: </td>
						<td><input type="text" name="image_description" size="100" required /><br /></td>
					</tr>
					<tr>
						<td><hr width="600%" /></td>
					</tr>
					<tr>
						<td><input type="hidden" name="MAX_FILE_SIZE" value "25000" /><br /></td>
					</tr>
					<tr>
						<td>File Name: </td>
						<td><input type="file" name="file_name" required />(25,000 byte limit)<br /></td>
					</tr>
					<tr>
						<td><input type="reset" value="Clear Form" /></td>
						<td><input type="submit" name="upload" value="Upload the File" /></td>
					</tr>
				</table>	
			</form>
			
			<?php
			
			?>
			
		</body>
	</html>