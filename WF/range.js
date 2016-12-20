var printRange = function(start,end,skip) {
	if(arguments.length==1){
		for(var i = 0; i < start; i++) {
			console.log(i);
		}
	} else if(arguments.length==2){
		for(var i = start; i < end; i++) {
			console.log(i);
		}
	} else {
		for(var i = start; i < end; i+=skip) {
			console.log(i);
		}
	}
};

//only running one function call at a time. feel free to add/delet comments as needed to call w/ various argument lengths
//the following are the 3 test cases from the assignment instructions.
printRange(2,10,2);
//printRange(4,8);
//printRange(4);