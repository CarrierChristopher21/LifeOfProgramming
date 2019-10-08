<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
	<html xmlns="http://www.w3.org/1999/xhtml">
		<head>
			<title>Movie Calculations!</title>
			<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
		</head>
		<body>
			<?php
				class Movies{
					public $full_price_ticket = 10;
					private $Age = "";
					public function ticketfunction(){
						$price = "";
						if($this->Age < 5){
							$price = 0;
						}
						else if(($this->Age >= 5) && ($this->Age <= 17)){
							$price = (($this->full_price_ticket) / 2);
						}
						else if(($this->Age >= 18) && ($this->Age <= 55)){
							$price = $this->full_price_ticket;
						}
						else if($this->Age > 55){
							$price = (($this->full_price_ticket) - 2);
						}
						else{
							echo "<p>This is not a number. Please enter a correct number and try again.</p>\n";
						}
						return $price;
					}
					public function setAge($NewAge){
						$this->Age = $NewAge;
					}
				}
				$Movie = new Movies();
				$Movie->setAge($_POST["age"]);
				echo "<p>Your name is " . $_POST["first"] . " " . $_POST["last"] . ".</p>\n";
				echo "<p>Your ticket price is $" . $Movie->ticketfunction() . ".</p>\n";
			?>
		</body>
	</html>