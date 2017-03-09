//bwomp is an object containing my custom methods
// methods are invoked by calling bwomp.<METHOD NAME>()
var bwomp = {
    map: function(list, cb) {
        if ((typeof cb === 'function') && (typeof list === 'object')){
            for (var pos in list){
                list[pos] = cb(list[pos]);
            }
        }
        return list;
    },

    reduce: function(list, cb, memo) {
        if(!memo){
            memo = 0;
        }

        if(Array.isArray(list)){
            for (var pos in list){
                memo = cb(list[pos], memo);
            }
        }
        return memo;
    },

    find: function(list, cb) {   
        for (var pos in list){
            if (cb(list[pos])){
                return list[pos];
            }
        }
        return undefined;
    },

    filter: function(list, cb) {
        var result = []
        for (var pos in list){
            if (cb(list[pos])){
                result.push(list[pos]);
            }
        }
        if(result){
            return result;
        } else {
            return undefined;
        }
    },

    reject: function(list, cb) { 
        var result = []
        for (var pos in list){
            if (!cb(list[pos])){
                result.push(list[pos]);
            }
        }
        if(result){
            return result;
        } else {
            return undefined;
        }
    }
}

var testArr = [1,2,0o11];


console.log(bwomp.reduce(testArr,function(a,b){return a+b}))
