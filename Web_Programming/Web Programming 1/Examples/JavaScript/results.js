/*
	Javascript Result Page
*/


function Add(x, y)		// other way but not used much - var Add function (x, y){}
{
	var result = 0;
	var counter = 0;
	while(counter < arguments.length)
	{
		result = result + arguments[counter];
		counter = counter + 1; //	- Two other ways to add 1 to variable: counter++; or counter += + 1;
	}
	return result;
}

function isPositive(x)
{
	var result = false;
	if(x < 0)
	{
		result = false;
	}
	else
	{
		result = true;
	}
	return result;
}

/*
	This would probably be preferred due to bandwidth issues.
	function isPositive(x)
	{
		return result > 0;
	}
*/


/*	
function Add(x, y)
{
	if(typeof x === "number" && typeof y === "number")
	{
		var result = x + y;
	}
	else
	{
		throw "both arguements must be numbers";
	}	
	return result;
}*/


var results = document.getElementById("myresults");
var myAnswer = "";
var s1 = "Welcome to Javascript";
var n1 = 0;
var a1 = [1, 5, 65, 98, 45];
var a2 = [1, -5, 65, -98, -45];


myAnswer = myAnswer + "JavaScript functions <br />";
myAnswer = myAnswer + "Array a2 is: " + a2 + "<br />";
myAnswer = myAnswer + "This is passing a function into another function.<br />";
myAnswer = myAnswer + "Array a2 filtered for positive number is: " + a2.filter(isPositive) + "<br />";
myAnswer = myAnswer + "Array a2 filtered for nagative numbers is: " + a2.filter(function(x){return x<0}) + "<br />";

results.innerHTML = myAnswer;

/*	
myAnswer = myAnswer + "Add(2, 3) is: " + Add(2, 3) + "<br />";					//	-	\"boo\" escapes to allow the use of quotes		
myAnswer = myAnswer + "Add(2, 'boo') is: " + Add(2, "boo") + "<br />";		//	-	just like 'boo' 
myAnswer = myAnswer + "Add(2, 3,8, 9, 12, 2138) is: " + Add(2, 3, 8, 9, 12, 2138) + "<br />";
myAnswer = myAnswer + Add() is: " + Add() + "<br />";

*/

/*
myAnswer = myAnswer + "JavaScript now with arrays <br />";
myAnswer = myAnswer + "The orginal a1 is: " + a1 + "<br />";
a1[5] = "boo";
myAnswer = myAnswer + "The new a1 is: " + a1 + "<br />";
myAnswer = myAnswer + "The a1[5] in uppercase is: " + a1[5].toUpperCase() + "<br />";
*/

/*
myAnswer = myAnswer + "Number Crunching <br />";
myAnswer = myAnswer + "The orginal number is: " + n1 + "<br />";
n1 = "boo";
myAnswer = myAnswer + "variables can change data type -- bool!!!! <br />";
myAnswer = myAnswer + "the variable n1 is now = " + n1 + "!<br />";
n1 = 3;
myAnswer = myAnswer + "the variable n1 is now: " + n1 + "<br />";
myAnswer = myAnswer + "JavaScript has a Math Object <br />";
myAnswer = myAnswer + "Which is: n1 squared " + Math.pow(n1,2) + "<br />";
n1 = 5.14589;
myAnswer = myAnswer + "the variable n1 is now: " + n1 + "<br /";
myAnswer = myAnswer + "n1 rounded " Math.round(n1) + "<br />"
myAnswer = myAnswer + "n1 rounded using toFixed to three places is: " + n1.toFixed(3) + "<br />";
*/

/*
myAnswer = myAnswer + "Simple String manipulations<br />";
myAnswer = myAnswer + s1 + "<br />";
myAnswer = myAnswer + s1.toUpperCase() + "<br />";
myAnswer = myAnswer + s1.toLowerCase() + "<br />";
myAnswer = myAnswer + "The character at location 6 is: " + s1.charAt(5) + "<br />";
myAnswer = myAnswer + "Replace 'e' with 'E' " + s1.replace('e','E') + "<br />";
myAnswer = myAnswer + "Replace all the 'e' with 'E' using a regEx " + s1.replace(/e/g, 'E') + "<br />";
myAnswer = myAnswer + "The length of the string is: " + s1.length + "<br />";
myAnswer = myAnswer + s1 + "<br />";
*/

/*
function createTable()
{
	var message = "boo"; //	-	No output so it doesn't show up.
	
}

var aString = "Hello World";
var aNumber = 2;
var anotherNumber = 5;
var answer = aNumber + anotherNumber;
var aBoolean = true;
var anotherBoolean = false;

var anArea = document.getElementById("testarea");

while(aNumber <= 10) 
{
	var aTempvariable = "cat";
	aNumber = aNumber + 1;
	
}

alert(aTempvariable);

anArea.innerHTML = answer;

alert(message);	//	-	Message undefined if out of function*/















