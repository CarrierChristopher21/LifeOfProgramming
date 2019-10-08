/*
	File Type:	Javascript for display
	File:		javascript-style.js

*/
/*
function disInput($)
{*/

var val = $("#categoryfilter option:selected").val();
$("#categoryfilter").change(function()
	{
		if(val == "By File")
		{
			$("#categoryfile").prop("disabled", false);
			alert("hi");
		}
		else
		{
			$("#categoryfile").prop("disabled", true);
			alert("Hi");
		}
	}
)
//}
