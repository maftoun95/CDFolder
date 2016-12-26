$(function() {
	$('button').click(function() {

	})


	$('form').submit(function(){
		var nameVar1 = $('.fnclass').val()
		var nameVar2 = $('.lnclass').val()
		var descVar = $('.dclass').val()
		$('rcol').append(`<tr><td> ${nameVar1}</td><td>${nameVar2}</td><td>${emailVar}</td><td>${contactVar}</td></tr>`)
		return false;
	});
});