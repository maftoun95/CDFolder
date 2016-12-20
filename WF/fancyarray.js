var fancy = function(arr, sym, reverse) {
	//set default symbol if one is not provided
	if(sym === undefined){
  	sym = "->"
  }
  //if reverse is true, reverse the string. otherwise, run like normal.
  if (reverse) {
  	for(var i = arr.length-1;i>=0; i--){
    	console.log(i + sym + arr[i]);
    }
  } else { for ( var i = 0; i < arr.length; i++) {
			console.log(i + sym + arr[i]);
		}
  }
}

//run the function with a special symbol in reverse order
fancy([ "James", "Jill", "Jane", "Jack" ], "********", true);
//run the function with a special symbol
fancy([ "James", "Jill", "Jane", "Jack" ], "********");
//standard function call, nothing special
fancy([ "James", "Jill", "Jane", "Jack" ]);