window.onload = initLinks;

var myPix = new Array("../Images/menu1.jpg", "../Images/menu2.jpg", "../Images/menu3.jpg");

var thisPic = 0;

function initLinks()
{
	document.getElementById("menu1").onclick = processMenu1;
	document.getElementById("menu2").onclick = processMenu2;
	document.getElementById("menu3").onclick = processMenu3;
}

function processMenu1()
{
	document.getElementById("sugar_daddy").src = myPix[0];
	return false;
	
}

function processMenu2()
{
	document.getElementById("sugar_daddy").src = myPix[1];
	return false;
}

function processMenu3()
{
	document.getElementById("sugar_daddy").src = myPix[2];
	return false;
}



















