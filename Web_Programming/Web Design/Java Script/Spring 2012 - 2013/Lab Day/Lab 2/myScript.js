
window.onload = "calcShipping()";

	function  calcShipping()
	{
					//validate age for numeric value
		/*			
		//var xposition = document.myform.purchaseprice.indexOf("x");
		//for(num = 0; num < document.forms.myForm.elements.length; ++num)
		*/
		var x = document.forms.myForm.purchaseprice.value;
		if(document.forms.myForm.purchaseprice.type == "text" && 
			document.forms.myForm.purchaseprice.value == "")
		{
			alert("Please enter a purchase Price");
			document.myForm.purchaseprice.focus(); // place the cursor int the text box
			return false; //stop form from submitting
		}
		else if(isNaN(document.forms.myForm.purchaseprice.value))
		{
			alert("Purchase Price must be numeric"); //clear contents of text box
			document.myForm.purchaseprice.focus(); // place the cursor int the text box
			return false; //prevent form from being sumbitting		
		}
		
		/*else if (document.forms.myForm.coupon.type == "text" && 
			document.forms.myForm.coupon.value == "")
		{
			alert("Coupon must be filled out");
			document.myForm.coupon.focus(); // place the cursor int the text box
			return false;
		}
		//var x = document.forms.myForm.purchaseprice.value;
		*/
		
		else if (x == null || x == "")
		{
			alert("Purchase Price must be filled out");
			
			return false;
		}
		
		//var x = document.forms.myForm.purchaseprice.value;
		var y = document.forms.myForm.coupon.value;
		if(x < 25 && x > 0)		// Less than 25
		{
			if(document.forms.myForm.coupon.length == 5 && (y[0] = "x" || y[0] == "X"))	
			{			// Less than 25 but with coupon
			
				var s = (1.50 - (1.50 * .05));
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
				
			}
			else		// Less than 25
			{
				var s = 1.50;
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
				
			}
		}
		else if(x >= 25 || x < 75)		// Between 25 and 75
		{
			if(document.forms.myForm.coupon.length == 5 && (y[0] = "x" || y[0] == "X"))
			{			// Between 25 and 75 but with coupon
			
				var s = ((x * .10) - ((x * .10) * .05));
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
				
			}
			else		// Between 25 and 75
			{
				var s = x * .10;
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
				
			}
		}
		else if(x >= 75)		//Above 75
		{
			if(document.forms.myForm.coupon.length == 5 && (y[0] = "x" || y[0] == "X"))
			{			//Above 75 but with coupon
			
				var s = ((x * .15) - ((x * .10) * .05));
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
			}
			else		//Above 75
			{
				var s = x * .15;
				var total = x + s;
				document.getElementById("myHeader").innerHTML = "$" + x + " + $" + s + " = $" + total;
			}
		}
			
	}

/*
	•In an external script file write a function called calcShipping() that will perform the 
	calculations based on the following criteria: 
	
		1.) The text field should be validated to ensure that it is not blank and numeric
		
		2.) Minimum shipping and handling is $1.50 for any purchase less than $25.00
		
		3.) For orders between $25.00 and $75.00 add 10% to the total purchase but DO NOT 
			include the $1.50
			
		4.) For orders greater than $75.00 add 15% to the total purchase but DO NOT include 
			the $1.50
			
		5.) A coupon is valid if: 
				1.) It is five characters in length
				2.) It begins with an "X"
				3.) Research the JavaScript String Object for built in functions to process 
					strings

		6.) If the coupon is valid deduct 5% from the shipping charge

	•Display the purchase price, the shipping charges and the order total as a level one 
		heading on the web page
*/