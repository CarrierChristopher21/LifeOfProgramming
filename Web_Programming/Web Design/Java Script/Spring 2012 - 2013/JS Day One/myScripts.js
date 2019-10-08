function showDate()
{
	document.getElementById("demo").innerHTML = Date();
}

function showBrowser()
{
	var text; 
	text = "<p>Browser Code Name: " + navigator.appCodeName + "</p>";
	text += "<p>Browser Name : " + navigator.appName + "</p>";
	text += "<p>Browser Version : " + navigator.appVersion + "</p>";
	text += "<p>Cookies Enabled? : " + navigator.cookieEnabled + "</p>";
	
	//place message into HTML of <p> tag
	document.getElementById("browser").innerHTML = text;
}