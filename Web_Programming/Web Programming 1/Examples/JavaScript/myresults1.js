function Add(x, y){
	var result = 0;
	var counter = 0;
	
	while(counter < arguments.length){
		result = result + arguments[counter];
		counter = counter + 1;
	}
	
	return result;
}

function isPositive(x){
	
	var result = false;
	
	if(x < 0){
		result = false;
	}else{
		result = true;
	}
	
	return result;
}

/*
this would probably be preferred due to bandwidth issues
function isPositive(x){
		
	return x > 0;
}
*/


/*
function Add(x, y){
	if(typeof x === "number" && typeof y === "number"){
		var result = x + y;
	}else{
		throw "both arguments must be numbers";
	}
	return result;
}
*/

var results = document.getElementById("myresults");
var myAnswer = "";
var s1 = "Welcome to JavaScript";
var n1 = 0;
var a1 = [1, 5 , 65 ,98, 45 ];
var a2 = [1, -5 , 65 ,-98, -45 ];

myAnswer = myAnswer + "JavaScript functions <br />";
myAnswer = myAnswer + "Array a2 is: " + a2 + "<br />";
myAnswer = myAnswer + "This is passing a function into another function<br />";
myAnswer = myAnswer + "Array a2 filtered for positive numbers is: " + a2.filter(isPositive) + "<br />";
myAnswer = myAnswer + "Array a2 filtered for negative numbers is: " + a2.filter(function (x){return x<0; }) + "<br />";



//myAnswer = myAnswer + " Add(2, 3) is : " + Add(2,3) + "<br />";
//myAnswer = myAnswer + " Add(2, 'boo') is : " + Add(2,"boo") + "<br />"
//myAnswer = myAnswer + " Add(2, 3, 8 ,9 ,12, 2138) is : " + Add(2, 3, 8 ,9 ,12, 2138) + "<br />";
//myAnswer = myAnswer + " Add() is : " + Add() + "<br />";

/*
myAnswer = myAnswer + "JavaScript now with arrays <br />";
myAnswer = myAnswer + "The original a1 is: " + a1 + "<br />";
a1[5] = "boo";
myAnswer = myAnswer + "The new a1 is: " + a1 + "<br />";
myAnswer = myAnswer + "The a1[5] in uppercase is: " + a1[5].toUpperCase() + "<br />";
*/

/*
myAnswer = myAnswer + "Number Crunching <br />";
myAnswer = myAnswer + "The original n1 is: " + n1 + "<br />";
n1 = "boo";
myAnswer = myAnswer + "variables can change data type -- boo!!!! <br />";
myAnswer = myAnswer + "the variable n1 is now = " + n1 + "<br />";
n1 = 3;
myAnswer = myAnswer + "the variable n1 is now: " + n1 + "<br />";
myAnswer = myAnswer + "JavaScript has a Math Object " +  "<br />";
myAnswer = myAnswer + "n1 squared " + Math.pow(n1,2) +  "<br />";
n1 = 3.16987654;
myAnswer = myAnswer + "the variable n1 is now: " + n1 + "<br />";
myAnswer = myAnswer + "n1 rounded " + Math.round(n1) +  "<br />";
myAnswer = myAnswer + "n1 rounded using toFixed to three places is " + n1.toFixed(3) +  "<br />";
*/






/*
myAnswer = myAnswer + "Simple String manipulations<br />";
myAnswer = myAnswer + s1 + "<br />";
myAnswer = myAnswer + s1.toUpperCase() + "<br />";
myAnswer = myAnswer + s1.toLowerCase() + "<br />";
myAnswer = myAnswer + "The character at location 6 is: " + s1.charAt(5) + "<br />";
myAnswer = myAnswer + "Replace 'e' with 'E' " + s1.replace('e','E') + "<br />";
myAnswer = myAnswer + "Replace all the 'e' with 'E' using a regEx" + s1.replace(/e/g,'E') + "<br />";
myAnswer = myAnswer + "The length of the string is: " + s1.length + "<br />";
myAnswer = myAnswer + s1 + "<br />";
*/



results.innerHTML = myAnswer;