
$(document).ready(function () {

	$("#jqxcalendar").jqxCalendar({ width: '250px', height: '250px' });

	$('#jqxcalendar').bind('valuechanged', function (event) {

		var date = event.args.date;

		$("#log").text(date.toDateString());

	});

});