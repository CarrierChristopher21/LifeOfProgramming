
function validate()
			{
				for(index = 0; index < document.myForm.elements.length; ++index)
				{
					var control = document.myForm.elements[index];
					if(control.type == "text" && control.value == "")
					{
						alert("Please enter your: " + control.name);
						control.focus();//place cursor into the offending text box
						return false; //stop form from submitting
					}
					
				}
				//validate age for numeric value
				if(isNaN(document.myForm.Age.value))
				{
					alert("Age must be numberic"); //clear contents of text box
					document.myForm.Age.focus(); // place the cursor int the text box
					return false; //prevent form from being sumbitting
					
				}
				var fName = document.myForm.FirstName.value;
				var lName = document.myForm.LastName.value;
				var age = document.myForm.Age.value;
				var email = document.myForm.Email.value; 
				var aposition = email.indexOf("@"); //get the position of the @
				var dotposition = email.lastIndexOf(".");//get the position of the .
				var len = email.length;
				//determine if there is at least one character BEFORE the @
				if(aposition < 1)
				{
					alert("Email is invalid");
					return false; //stop form from submitting
				}//are there at least two characters AFTER the LAST dot
				
				else if(len - dotposition < 3)
				{
					alert("Email is invalid");
					return false; //stop form from submitting
				}
				else if(dotposition - aposition < 2)
				{
					alert("Email is invalid");
					return false; //stop form from submitting
				}
				
			}
			
			function process()
			{
				document.myForm.txtOutput.value = "You Selected: \n";
				//define a for loop to cycle through the elements collection
				//the elements collection is "built in"
				for(index = 0; index < document.myForm.elements.length; ++index)
				{
					//create a "shortcut" reference
					var control = document.myForm.elements[index];
					
					//grab the data from the form elements
					if(control.type == "text")
						document.myForm.txtOutput.value += control.value + "\n";
					else if((control.type == "checkbox" || control.type == "radio") && control.checked == true)
						document.myForm.txtOutput.value += control.value + "\n";
				}
			}