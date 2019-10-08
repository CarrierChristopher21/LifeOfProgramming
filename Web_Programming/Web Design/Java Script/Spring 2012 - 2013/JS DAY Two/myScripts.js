
window.onload = initAll;

function initAll()
{
	document.getElementById("redirect").onclick = redirectF;
}

function redirectF()
{
	window.location = "http://news.google.com";
	return false;
}

function promptDemo()
{
	//display a message to the user
	alert("This is an alert box . . . consider yourself alerted");
	
	//ask the user for some input
	var input = prompt("Enter your age");
	
	//validate the input
	if(!input || isNaN(input) || input < 0)
	{
		alert("INVALID INPUT");
	}else
	{
		var root = Math.sqrt(input);
		alert("The square root of " + input + " is " + root);
	}
	if(input < 21)
	{
		alert("You can't come in");
		window.location = "http://news.google.com";
	}
	
	//ask the user a yes or no question
	if(confirm("Are you sure you want to do that?"))
		alert("You said YES");
	else
		alert("You said NO");
 }