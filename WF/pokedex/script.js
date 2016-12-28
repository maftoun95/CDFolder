function requestPokedex (pokeID, callback) {
	$.get(pokeID, function(res) {
		console.log(res, 'got json');
		callback(res);
		$('.name').html(`<h4>Name: ${res.name}</h4>`);
		$('.height').html(`<h4>Height: ${res.height}</h4>`);
		$('.weight').html(`<h4>Weight: ${res.weight}</h4>`);
		// loop for a pokemons types
		for(var x = 0; x<res.types.length; x++) {
			if (x > 0){
				$('.type').append(`<h4> ${res.types[x].name}</h4>`);
			} else {
				$('.type').html(`<h4>Type(s): ${res.types[x].name}</h4>`);
			}
		}
	}, 'json');
}

$(function() {
	$('#main').on('click','img', function() {
		var pokeID = `http://pokeapi.co/api/v1/pokemon/${$(this).attr("id")}`;
		var pokemonPicture = `http://pokeapi.co/media/img/${$(this).attr("id")}.png`;
		$('.pic').html(`<img src="${pokemonPicture}" />`);
		console.log(pokemonPicture);
		requestPokedex(pokeID, function(data) {
			console.log('great success',data);
		});
	});

	for(var i =1; i < 152; i++){
		var pokepic = `<div id="stash"><img id="${i}" src="http://pokeapi.co/media/img/${i}.png"></div>`
		$('#main').append(pokepic);
	}
})