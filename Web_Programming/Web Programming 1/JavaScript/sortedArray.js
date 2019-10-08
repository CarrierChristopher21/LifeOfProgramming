

function compare(a, b){
	var result = 0;
	
	if(a.CategoryName < b.CategoryName){
		result = 1;	//	positive goes up - negative goes down
	}else if(b.CategoryName < a.CategoryName){
		result = -1; // negative goes up - positive go down
	}else{
		result = 0;
	}	
	return result;
}

function Category(aid, aname){

	this.CategoryId = aid;
	this.CategoryName = aname;
}

var category1 = new Category(1, "dairy");
var category2 = new Category(2, "beverages");
var myArray = [category1, category2];

var answer = document.getElementById("answer");

var sortedArray = myArray.sort(compare);

/*
var result = category1.CategoryId + " " + category1.CategoryName + "<br />";
var result = result + category2.CategoryId + " " + category2.CategoryName;
*/

var result = sortedArray[0].CategoryId + " " + sortedArray[0].CategoryName + "<br />";
result += sortedArray[1].CategoryId + " " + sortedArray[1].CategoryName;



answer.innerHTML = result;




















