/*
	Application Animation JQuery
	
*/

var i = 0;
var item1 = $("h1");
var item2 = $("h2");
var item3 = $("h3");
var item4 = $("#message");

while(i < 5)
{
	/*item1.fadeOut(3000);
	item1.fadeIn(3000);
	item1.css("color", "orange").
	item1.css("text-align", "center");
	item1.css("background-color", "#8B4513");
	item1.text("BOO!!!!");*/
	
	item1.text("BOO!!!!").css("background-color", "#8B4513").css("color", "orange").css("text-align", "center").fadeOut(3000).fadeIn(3000);
	item2.text("BOO!!!!").css("background-color", "orange").css("color", "#8B4513").css("text-align", "center").slideUp(1000).slideDown(1000);
	item3.text("BOO!!!!").css("background-color", "#8B4513").css("color", "orange").css("text-align", "center").fadeOut(1000).slideUp(500).slideDown(1000);
	item4.text("BOO!!!!").css("background-color", "orange").css("color", "#8B4513").css("text-align", "center").hide();
	i++;
}

/* //	div tag id = play
$("#play").on("mouseenter", function(){
		$(this).css("background-color", "yellow");
		$("div div").text("mouse has entered");
}).on("mouseleave",function(){
			$(this).css("background-color", "pink");
			$("div div").text("mouse has exited");
});
*/












