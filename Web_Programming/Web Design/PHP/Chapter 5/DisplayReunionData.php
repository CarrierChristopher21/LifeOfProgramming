<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Display Reunion Data</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$formfields = array('name', 'image_description', 'file_name');
				$Dir = "Files";
				$output = "";
				$failed = FALSE;
				
				/*//Directory Check
				if(is_dir($Dir) == $failed){
					mkdir($Dir);
				}
				else{
					$failed = TRUE;
				}*/
				
				//Field Check
				foreach($formfields as $fields){
					if(empty($_POST[$fields])){
						echo "<p>Please complete all parts of this form. This field was not filled out: " . $fields . ". 
							Click your browser's Back button to return to the High School Renuion Form page.</p>\n";
							$failed = TRUE;
					}
					else{
						$_POST[$fields] = addslashes($_POST[$fields]);
						$output = $output . "\n " . $_POST[$fields];
					}
				}
				
				
				/*//File Move
				if(isset($_POST['upload'])){
					if(isset($_FILES['file_name'])){
						if(move_uploaded_file($_FILES['file_name']['tmp_name'], $Dir . "/" . $_FILES['file_name']['name']) == TRUE){
							chmod($Dir . "/" . $_FILES['file_name']['name'], 0766);
							echo "File \"" . htmlentities($_FILES['file_name']['name']) . "\" successfully uploaded. <br />\n";
						}
						else{
							echo "There was an error uploading \"" . htmlentities($_FILES['file_name']['name']) . "\".<br />\n";
						}
					}
				}*/
				

			
			?>
		</body>
	</html>