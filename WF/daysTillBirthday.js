function daysTillBirthday(num){
	if (num>29) {
		console.log("Aaaaaawe.... too long!")
	} else if (num>4){
		console.log("Almost here!!!")
	} else if (num>0) {
		console.log(num + " DAYS TILL MY BIRTHDAY!")
	} else { console.log("ITS MY BIRTHDAY!!!!!!!!!!! WOOT WOOT!")}
}

daysTillBirthday(45);
daysTillBirthday(24);
daysTillBirthday(3);
daysTillBirthday(0);