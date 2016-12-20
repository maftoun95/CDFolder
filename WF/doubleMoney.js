var doubleMoney = function() {
	var payment = .01;
  	var money = 0;
	for (var i = 1; i <=30; i++){
  		money+=payment
		payment*=2;
	}
console.log("Its been 30 days. You've made a total of "+money+" dollars!!");
}

doubleMoney();