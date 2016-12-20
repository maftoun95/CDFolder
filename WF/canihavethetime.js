var time = function(h,m,p){
	if(m <= 30 && p==="AM") {
		console.log("It's just after " + h + " in the morning");
	} else if(m <= 30 && p==="PM") {
		console.log("It's just after " + h + " in the evening");
	} else if(m >= 30 && p==="AM") {
		console.log("It's almost " + (h+1) + " in the morning");
	} else if(m >= 30 && p==="PM") {
		console.log("It's almost " + (h+1) + " in the evening");
	}
};

time(7,35,"PM");