
$(document).ready(function()
{
	function handleMouseEnter(e)
	{
		$(this).css(
		{
			"border": "thick solid red",
			"opacity": "0.5"
		});
	};
	function handleMouseOut(e)
	{
		$(this).css(
		{
			"border": "",
			"opacity": ""
		});
	}
	
	$("#th.ProductId").bind("mouseenter", SortByName)
		.bind("mouseout", handleMouseOut);
});
















