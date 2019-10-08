$(document).ready(function(){

	function bob(e){
	
		alert("Clicked on the ID Heading");
	
	}
	
	function mary(){
	
			alert("Clicked on the Name Heading");
	
	}
	
	function lisa(){
	
				alert("Clicked on the Description Heading");
	
	}
	
	$("#categoryId").bind("click", bob);
	$("#categoryName").bind("click", mary);
	$("#description").bind("click", lisa);
});