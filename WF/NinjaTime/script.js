$(function() {
  $('img').click(function() {
  	$(this).hide();
  });
  $('.hi').click(function() {
  	console.log('clicked');
  	$('img').show();
  });
});