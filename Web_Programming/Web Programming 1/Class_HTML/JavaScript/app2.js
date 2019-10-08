/*
	JavaScript Page for play.html
*/

var item1 = $("h1");
var item2 = $("h2");
var item3 = $("h3");
var paragraphs = $("p");

paragraphs.not(":first").hide();

item1.on("click", function(){
	var aHeading = $(this);
	paragraphs.fadeOut("1000");
	aHeading.next().fadeIn("1000");
	
});

item2.on("click", function(){
	var aHeading = $(this);
	paragraphs.fadeOut("1000");
	aHeading.next().fadeIn("1000");
	
});

item3.on("click", function(){
	var aHeading = $(this);
	paragraphs.fadeOut("1000");
	aHeading.next().fadeIn("1000");
	
});
















