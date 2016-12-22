$(function() {
	$('img').click(function() {
		var temp = $(this).attr('src');
		// var temp2 = $(this).attr('sneaky');
		$(this).attr('src', $(this).attr('sneaky'));
		$(this).attr('sneaky', temp);
	});
});