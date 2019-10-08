//	File Type: 		JavaScript
//	File for: 		more_effective_rollover.html
//	

window.onload = rolloverInit;

	function rolloverInit()
	{
		for(var i = 0; i < document.images.length; i++)
		{
			if(document.images[i].parentNode.tagName == "DIV")
			{
				setupRollover(document.images[i]);
			}
		}
	}
	
	function setupRollover(thisImage)
	{
		thisImage.outImage = new Image();
		thisImage.outImage.src = thisImage.src;
		thisImage.onmouseout = function()
		{
			this.src = this.outImage.src;
		}
		thisImage.overImage = new Image();
		thisImage.overImage.src = "../images/People/" + thisImage.id + "_roll.png";
		thisImage.onmouseover = function()
		{
			this.src = this.overImage.src;
		}
		
	}
	
	
	
	
	
	
	
	
	
	
	