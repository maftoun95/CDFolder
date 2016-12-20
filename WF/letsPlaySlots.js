function letsPlaySlots(coins, limit){
	//set up a function that will run when you hit the jackpot
	var jackpot = function(){
		coins += Math.trunc(Math.random() * 50)+50;
		console.log("CONGRATS! You've now got " + coins + " coins!!");
	};
	//if no limit is set, set the limit to a biiiiiiiiig number
	if(arguments.length === 1){
		limit=10000000000000;
	}
	//while, there are coins to play with AND
	while(coins>0 && coins<limit) {
		var odds = Math.floor(Math.random()*100);
		if (odds === 17) {
			coins += Math.trunc(Math.random() * 50)+50;
			console.log("CONGRATS! You've now got " + coins + " coins!!");
		} else {
			console.log("Not a winner, play again! You have " + coins + " coins left..");
		};
		//once weve played the game, account for the coin we just used
		coins--;
	}

};

//first test is no limit, second supposes the player wants to duck out if they get to 449 coins
letsPlaySlots(200);
//letsPlaySlots(200,449);