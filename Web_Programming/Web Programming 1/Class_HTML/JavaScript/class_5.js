
/*
	Class 5
	9/14/15
	Chris Carrier
*/

function Category(id, name)
{
	this.Categoryid = id;
	this.CategoryName = name;	
}

var category1 = new Category(1, "dairy");
var category2 = new Category(2, "beverages");
var myArray = [category1, category2];


var answer = document.getElementById("answer");
/*
var result = category1.Categoryid + " " + category1.CategoryName + "<br />";
var result = result + category2.Categoryid + " " + category2.CategoryName;
*/

var result = myArray[0].Categoryid + " " + myArray[0].CategoryName + "<br />";
result += myArray[1].Categoryid + " " + myArray[1].CategoryName;

answer.innerHTML = result;





/*
var myArray = [10, 9, 8, 7, 70, 700, 7000, 60, 6, 100, 5, 4, 3, 2, 1];

myArray.sort(compare);

answer.innerHTML = myArray;

function compare(a, b)
{
	var result = 0;
	if(a.CategoryName < b.CategoryName)
	{
		result = -1; 	//  neg A-Z, negative low to high - positive high to low
	}
	else if(b.CategoryName < a.CategoryName)
	{
		result = 1;		// pos Z-A, negative low to high - positive high to low
	}
	else
	{
		result = 0;
	}
	return result;
	
}*/





/*
var index = 0;
var result = "";

while index < myArray.length)
{
	result = result + myArray[index] + "  ";
	index++;
}
*/























