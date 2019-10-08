
/*
	Week 2 Lab Assignment
	9/9/15
	Chris Carrier
	Due 9/16/15
	
*/

var s = document.getElementById("input");
var array = document.getElementById("answer");
var arraythrow = document.getElementById("answerthrow");
var arraythrowouput = document.getElementById("answerthrowoutput");
var myArray = [1, 5, -5, 6, 0, 9, -3, -4, -11, 4];
//	Styles Function
function Styles()
{
	//	Changing H1 text	
	s.innerHTML = reverse(s.innerHTML);
	array.innerHTML = CalculateArray(myArray);

	//	Making the document fontsize bigger
	document.body.style.fontSize = "larger";
}

function reverse(s)
{
	var backwards = "";
	for (var i = s.length - 1; i >= 0; i--)
	{
		backwards += s[i];
	}
	
	return backwards;
}

function CalculateArray(myArray) 
{
    var positive = 0;
    var negative = 0;
	var result;
    for (var i = 0; i < myArray.length; i++) {
        var num = myArray[i];
		//	Testing if num is more than 0
		//	Or less than 0 
		if (num >= 0) 
		{
			positive = positive + num;
		}
		else if(num < 0)
		{
			negative = negative + Math.abs(num);
		}
		
		//	Testing if positive is greater than or less than negative; 
		//	as well as testing if it is a number
		try
		{
			if(isNaN(num))
			{
				result = "not a number";
				throw result;
			}
			else if(positive > negative)
			{
				result = "true";
			}
			else if(positive < negative)
			{
				result = "false"
			}
		}
		catch(err)
		{
			arraythrowouput.innerHTML = "The number error is: " + err;
		}
    }
	
	alert(positive);
	alert(negative);
	arraythrow.innerHTML = "The input is: " + result;
    return positive > negative;
}

alert(s.innerHTML);
alert(reverse(s.innerHTML));

Styles();













