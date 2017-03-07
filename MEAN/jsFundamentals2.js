//
function xySumsum(x,y){
    var sum = 0
    for (var i = x; i <= y; i++){
        sum += i;
    }
    console.log(sum);
}

function findMin(arr){
    if (arr.isArray){
        var min = arr[0];
        for (var i = 1; i<arr.length; i++){
            if (min > arr[i]){
                min = arr[i];
            }
        }
        return min;
    }
    return "This is not an array"
}

function avg(arr){
    if (arr.isArray){
        sum = 0
        len = arr.length;
        for (var i = 1; i < len; i++){
            sum += arr[i];
        }
    }
    return sum/len;
}

var xySumsum = function(x,y){
    var sum = 0
    for (var i = x; i <= y; i++){
        sum += i;
    }
    console.log(sum);
}

var findMin = function(arr){
    if (arr.isArray){
        var min = arr[0];
        for (var i = 1; i<arr.length; i++){
            if (min > arr[i]){
                min = arr[i];
            }
        }
        return min;
    }
    return "This is not an array"
}

var avg = function(arr){
    if (arr.isArray){
        sum = 0
        len = arr.length;
        for (var i = 1; i < len; i++){
            sum += arr[i];
        }
    }
    return sum/len;
}

var funcObj = {
    xySumsum:function(x,y){
    var sum = 0
    for (var i = x; i <= y; i++){
        sum += i;
    }
    console.log(sum);},
    findMin:function(arr){
    if (arr.isArray){
        sum = 0
        len = arr.length;
        for (var i = 1; i < len; i++){
            sum += arr[i];
        }
    }
    return sum/len;},
    avg:function(arr){
    if (arr.isArray){
        sum = 0
        len = arr.length;
        for (var i = 1; i < len; i++){
            sum += arr[i];
        }
    }
    return sum/len;}
};

var person = {
    name : "Guido",
    distance_traveled : 0,
    say_name : function(){
        alert(this.name);
    },
    propertysay_something : function(para){
        console.log(`${this.name} says ${para}`);
    },
    walk: function(){
        alert(`${this.name} is walking`);
        distance_traveled += 3;
        return distance_traveled;
    },
    run: function(){
        alert(`${this.name} is runing`);
        distance_traveled += 10
        return distance_traveled;;
    },
    crawl: function(){
        alert(`${this.name} is crawling`);
        distance_traveled += 1;
        return distance_traveled;
    }
}