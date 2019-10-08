function updateImages(data)
{
  for (i=0; i<data.length; i++)
  {
    var imageInfo =data[i];
    var img = "<img src = '../images/" + imageInfo.image + "' />";
    var title = "<p>" + imageInfo.title +  "</p>";
    var div = div + img + title
    alert(img);
  }
  	$("#images").append(div);
}
$(document).ready(function()
{
  $.getJSON("data/images.json", updateImages());
});