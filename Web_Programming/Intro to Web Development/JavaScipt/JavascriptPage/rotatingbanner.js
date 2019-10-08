
window.onload= initBannerLinks;

var thisAd = 0;

function initBannerLinks()
{
	if(document.getElementById("adbanner").parentNode.tagName == "A")
	{
		document.getElementById("adBanner").parentNode.onclick = newLocation;
	}
	rotate();
	
}

function newLocation()
{
	var adUrl = new Array("reddit.com", "youtube.com", "wetd.fm");
	document.location.href="http://www." + adUrl[thisAd];
	return false;
}

function rotate()
{
	var adImages = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
	
	thisAd++;
	
	if(thisAd == adImages.length)
	{
		thisAd = 0;
	}
	
	document.getElementById("adBanner").src = adImages[thisAd];
	
	setTimeout(rotate, 5 * 1000);
}










