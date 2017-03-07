//1
var x = [3,5,"Dojo", "rocks", "Michael", "Sensei"]
var i;
while (i < x.length){
  console.log(x[i]);
  i++;
}

//2

x.push(100);

//3

x.push(["hello", "world", "JavaScript is Fun"]);
console.log(x);

//4

var sum = 0;
for(var i = 0;i<501;i++){
  sum += i;
}
console.log(sum);

//5

var testArr = [1, 5, 90, 25, -3, 0], min = testArr[0], len = testArr.length;
for(var i = 1;i<len;i++){
  if(testArr[i]<min){
    min = testArr[i];
  }
}
console.log(min);

//6
var totes = 0;
for(var i = 0;i<len;i++){
  totes += testArr[i];
  console.log("totes is currently: "+totes)
}
console.log(totes/len);

//7

var newNinja = {
 name: 'Jessica',
 profession: 'coder',
 favorite_language: 'JavaScript', //like that's even a question!
 dojo: 'Dallas'
}

for (var key in newNinja){
  console.log(key + ": " + newNinja[key]);
}
