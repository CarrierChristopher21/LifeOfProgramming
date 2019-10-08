
var newWindow = null;

window.onload = initWinLinks;

function initWinLinks()
{
	for(var i = 0; i < document.links.length; i++)
	{
		document.links[i].onclick = chgWindowState;
	}
	
}

function windowOpen()
{
	if(newWindow && !newWindow.closed)
	{
		return true;
	}
	return false;
}

function chgWindowState()
{
	if(this.id == "closeWin")
	{
		if(windowOpen())
		{
			newWindow.close();
		}
		else{
			alert("The window is not open!");
		}
	}
	if(this.id == "openWin")
	{
		if(windowOpen())
		{
			alert("The window is not open!");
		}
		else
		{
			newWindow = window.open("slideshow.html", "newWin", "toolbar, location=yes,width=350,height=350");
		}
	}
}











