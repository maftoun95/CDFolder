var mine = require('./mathlib')

//this should log 111
console.log(mine.add(51,60));
//expecting 60
console.log(mine.multiply(4,15));
//9801
console.log(mine.square(99));
//this should return a random number between 7 and 54 (inclusively)
//I got the impression that the prompt wanted both arguments to be inclusive
//If this is the case, Math.round is appropriate since the possibility exists
//  that the low end gets rounded down || the high end gets rounded up
console.log("A BUNCH OF RANDOM VALUES!!!!!")
console.log("all should land between 7 and 54 inclusively")
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));
console.log(mine.random(7,54));