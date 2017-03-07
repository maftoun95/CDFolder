//Problem 1:

// first_variable gets a space in memory but no value untill its assigned later
var first_variable = undefined;
//firstFunc gets hoisted
// within this func, first_variable will have its own value independant of the global scope.
//interestingly, this doesnt matter because this funtion never gets called.
function firstFunc() {
  first_variable = "Not anymore!!!";
  console.log(first_variable);
}
//since first_variable still hasnt been assigned, this will print undefined to the console
console.log(first_variable);
//finally, assigned
var first_variable = "Yipee I was first!";
//log first_variable new value
console.log(first_variable);

// Problem 2:

//food gets its spot in memory but no value
var food;
//eat gets hoisted
function eat() {
  food = "half-chicken";
  console.log(food);
  var food = "gone";       // CAREFUL!
  console.log(food);
}
//food gets a value
var food = "Chicken";
//this function call will log its own value for food, half-chicken and then gone
eat();
//since the food variable in the function was scoped locally, the global food wasnt touched. this will log Chicken
console.log(food);

// Problem 3:

//memory
var new_word;
//hoist
function lastFunc() {
  new_word = "old";
}

var new_word = "NEW!";
//again, this function definition is meaningless without a function call
//however, even if the function did get called, the value of new_word that would get logged would still be NEW!
console.log(new_word);