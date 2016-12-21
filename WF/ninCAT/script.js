$(function() {
	$('img').click(function() {
		var temp1 = $(this).attr('src');
		var temp2 = $(this).attr('sneaky');
		$(this).attr('src', temp2);
		$(this).attr('sneaky', temp1);
	});
});