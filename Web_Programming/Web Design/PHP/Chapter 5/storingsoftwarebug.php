<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Storing Software Develop Bug</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				$formfields = array('product', 'version', 'typehardware', 'operatingsystem', 'frequencyoccurrence', 
					'proposedsolution');
				$output = "";
				$failed = FALSE;
				$Dir = "Files";
				
				//Directory Check
				/*if(is_dir($Dir) == $failed){
					mkdir($Dir);
				}
				else{
					$failed = TRUE;
				}*/
				
				//Field Check
				foreach($formfields as $fields){
					if(empty($_POST[$fields])){
						echo "<p>You must enter every " . $fields . ". Click your browser's Back button
							to return to the Bug Report.</p>\n";
							$failed = TRUE;
					}
					else{
						$_POST[$fields] = addslashes($_POST[$fields]);
						$output = $output . "\n " . $_POST[$fields];
					}
				}

				//Output
				if(!$failed){
					$NewBugReport = fopen("bugreport.txt", "w+");
					if(is_writeable("bugreport.txt")){
						if(fwrite($NewBugReport, $output . "\n ")){
							//chmod("bugreport.txt", 0766);
							echo "<p>Bug Report Successfully Entered!</p>\n";
							echo "<hr />";
							echo "<h2>Bug Report</h2>";
							echo "<hr />";
							echo "<pre>\n";
							readfile("bugreport.txt");
							echo "</pre>\n";
							echo "<hr />\n";
						}
						else{
							echo "<p>Couldn't Enter Bug Report!! >:( </p>\n";
						}
					}
					else
						echo "<p>Cannot write to the file.</p>\n";
					fclose($NewBugReport);
				}
				
				//File Move
				/*if(isset($_POST['submit'])){
					if(isset($_FILES['new_file'])){
						if(move_uploaded_file($_FILES['new_file']['tmp_name'], $Dir . "/" . $_FILES['new_file']['name']) == TRUE){
							chmod($Dir . "/" . $_FILES['new_file']['name'], 0766);
							echo "File \"" . htmlentities($_FILES['new_file']['name']) . "\" successfully uploaded. <br />\n";
						}
						else{
							echo "There was an error uploading \"" . htmlentities($_FILES['new_file']['name']) . "\".<br />\n";
						}
					}
				}*/
			?>
			
		</body>
	</html>
	
	
	
	
	
	
	
	
	
	