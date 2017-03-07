//1
function runningLogger(){
    console.log("I am running!");
}

//2
function multiplyByTen(num){
    var result = num * 10;
    return result;
}

var test = multiplyByTen(5);
console.log(test);

//3
function stringReturnOne(){
    return 6651;
}

function stringReturnTwo(){
    return 82;
}

//4
function caller(param){
    if (typeof param === 'function'){
        param();
    }
}

//5
function myDoubleConsoleLog(par1, par2){
    if (typeof par1 === 'function' && typeof par2 === 'function'){
        console.log(par1());
        console.log(par2());
    }
}

//6
function caller2(para){
    console.log("starting");
    if (typeof para === 'function'){
        setTimeout(para(), 2000)
    }
    console.log("ending?");
    console.log("interesting");
}

caller2(myDoubleConsoleLog(stringReturnOne(),stringReturnTwo()));