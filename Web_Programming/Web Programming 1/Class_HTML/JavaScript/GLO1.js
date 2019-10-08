/*
	Name: Chris Carrier
	Date: 11/11/15
	Class: MW 11-1 PM


*/

$(document).ready(function(){

//Shipper
var shipper1 = new Shipper(1, "Speedy Express", "(503) 555-9831");
var shipper2 = new Shipper(2, "United Package", "(503) 555-3199");
var shipper3 = new Shipper(3, "Federal Shipping", "(503) 555-9931");

var myArray = [shipper1, shipper2, shipper3];

var output;

//	Shipper
function Shipper(aShipperId, aCompanyName, aPhone)
{
	this.ShipperId = aShipperId;
	this.CompanyName = aCompanyName;
	this.Phone = aPhone;
}

//	Shippers Prototype - Second Option Object
Shipper.prototype.toRow = function()
{
	var result = "<tr><td>" + this.ShipperId + "</td>";
	result += "<td>" + this.CompanyName + "</td>";
	result += "<td>" + this.Phone + "</td>";
	return result;
}

//	Shippers - Second Object	-	In Progress
function Shippers (alist)
{
	this.myarray1 = alist;
}

//	Shippers Prototype - Second Object	-	in Progress
Shippers.prototype.toTable = function()
{
	var i = 0;
	var result = "";
	var aString1 = "";
	//var num = this.list.length;
	while(i < this.myarray1.length)
	{
		result += this.myarray1[i].toRow();
		i++;
	}
	//var aHeader = new Header();
	
	aString1 += "<table>" + Header() + result + "</table>";//alert(aString1);
	return aString1;
}

function Header()
{
	var head = "<tr>";
	head += "<th id=\"ShipperId\">ShipperId</th>";
	head+= "<th id=\"CompanyName\">Company Name</th>";
	head += "<th id=\"Phone\">Phone</th>";
	head += "</tr><br>";	
	return head;	
}

//	Receive Input placement
var result1 = document.getElementById("results");

var sortedArray;
var aShippers = new Shippers(myArray);

//	Calling Results
Results();
/*	Fade in out even odd
	$("tr:even").css("background-color", "white");
	$("tr:odd").css("background-color", "#90EE90");
*/
var i = 0;
while(i < 5)
{
	$("table").fadeOut(500).fadeIn(1500);
	i++;
}
function Results()
{
	//alert("hi");	
	result1.innerHTML = "ShipperId Table Ascending: <br><br>" + aShippers.toTable() + "<br>";

	$("#ShipperId").bind("click", function()
	{	
		ResultsIDDesc();
		$("#ShipperId").bind("click", function()
		{
			ResultsIDAsc();				
		});
	});
	$("#CompanyName").on("click", function()
	{
		ResultsNameAsc();
		$("#CompanyName").on("click", function()
		{
			ResultsNameDesc();
		});
	});
	$("#Phone").bind("click", function()
	{
		ResultsPhoneAsc();
		$("#Phone").bind("click", function()
		{
			ResultsPhoneDesc();
		});
	});
	
}

//	ShipperId Ascending
function ResultsIDAsc()
{
	sortedArray = myArray.sort(compareIdAsc);
	
	result1.innerHTML = "ShipperId Table Ascending: <br><br>" + aShippers.toTable() + "<br>";
}

//	ShipperId Descending
function ResultsIDDesc()
{
	sortedArray = myArray.sort(compareIdDesc);
	result1.innerHTML = "ShipperId Table Descending: <br><br>" + aShippers.toTable() + "<br>";
}

//	CompanyName Ascending
function ResultsNameAsc()
{
	sortedArray = myArray.sort(compareNameAsc);
	result1.innerHTML = "Company Name Table Ascending: <br><br>" + aShippers.toTable() + "<br>";
}

//	CompanyName Descending
function ResultsNameDesc()
{
	sortedArray = myArray.sort(compareNameDesc);
	result1.innerHTML = "Company Name Table Descending: <br><br>" + aShippers.toTable() + "<br>";
}

//	Phone Ascending
function ResultsPhoneAsc()
{
	sortedArray = myArray.sort(comparePhoneAsc);
	result1.innerHTML = "Phone Table Ascending: <br><br>" + aShippers.toTable() + "<br>";
}

//	Phone Descending
function ResultsPhoneDesc()
{
	sortedArray = myArray.sort(comparePhoneDesc);
	result1.innerHTML = "Phone Table Descending: <br><br>" + aShippers.toTable() + "<br>";
}

//		Comparing functions
//	Compare ShipperId Descending			- Result1
function compareIdDesc(a, b)
{
	var result = 0;	
	if(a.ShipperId < b.ShipperId)
	{
		result = 1;		// positive goes 77-1, negative goes 1-77
	}
	else if(a.ShipperId > b.ShipperId)
	{
		result = -1;	// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	
	return result;
}

//	Compare ShipperId Ascending 			- Result2
function compareIdAsc(a, b)
{
	var result = 0;	
	if(a.ShipperId < b.ShipperId)
	{
		result = -1;	// positive goes 77-1, negative goes 1-77
	}
	else if(a.ShipperId > b.ShipperId)
	{
		result = 1;		// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	
	return result;
}

//	Compare CompanyName Descending			- Result3
function compareNameDesc(a, b)
{
	var result = 0;
	
	if(a.CompanyName < b.CompanyName)
	{
		result = 1;		// positive goes 77-1, negative goes 1-77
	}
	else if(a.CompanyName > b.CompanyName)
	{
		result = -1;	// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	
	return result;
}

//	Compare CompanyName Ascending			- Result4
function compareNameAsc(a, b)
{
	var result = 0;	
	if(a.CompanyName < b.CompanyName)
	{
		result = -1;	// positive goes 77-1, negative goes 1-77
	}
	else if(a.CompanyName > b.CompanyName)
	{
		result = 1;		// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	
	return result;
}

//	Compare Shipper's Phone Descending	- Result5
function comparePhoneDesc(a, b)
{
		var result = 0;	
	if(a.CompanyName < b.CompanyName)
	{
		result = 1;	// positive goes 77-1, negative goes 1-77
	}
	else if(a.CompanyName > b.CompanyName)
	{
		result = -1;		// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	return result;
}

//	Compare Shipper's Phone Ascending	- Result6
function comparePhoneAsc(a, b)
{
		var result = 0;	
	if(a.CompanyName < b.CompanyName)
	{
		result = -1;	// positive goes 77-1, negative goes 1-77
	}
	else if(a.CompanyName > b.CompanyName)
	{
		result = 1;		// positive goes 1-77, negative goes 77-1
	}
	else
	{
		result = 0;
	}
	return result;
}


});

































