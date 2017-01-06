//Part I
var students = [
     {first_name:  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
]

function whoDat(arr) {
	for (var key in arr) {
        var obj = arr[key];
        console.log(`${obj.first_name} ${obj.last_name}`);
	}
}

whoDat(students);

//Part II

var users = {
 'Students': [
     {first_name:  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
  ],
 'Instructors': [
     {first_name : 'Michael', last_name : 'Choi'},
     {first_name : 'Martin', last_name : 'Puryear'}
  ]
 }

 function whoDem(arr) {
    for (var key in arr){
        console.log(key);
        var userArray = users[key]
        for(var o in userArray) {
            var num = o;
            num++;
            var object = userArray[o];
            var strlen = (object.first_name.length)+(object.last_name.length);

            console.log(`${num} - ${object.first_name} ${object.last_name} - ${strlen}`);
        }
    }
 }

 whoDem(users);