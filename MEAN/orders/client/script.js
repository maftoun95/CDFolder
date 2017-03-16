var orderApp = angular.module('orderMod', [])

orderApp.factory('productFactory', function(){
    var products = [
        {name:"PS4",price:350},
        {name:"TV",price:650},
        {name:"Deep Fryer",price:125},
        {name:"2 X 4's",price:4.50}
    ];
    var factory = {};

    factory.index = function(callback){
        callback(products);
    };
    factory.add = function(prod){
        products.push(prod);
    };
    factory.delete = function(idx){
        products.splice(idx,1);
    };
    return factory;
})

orderApp.factory('orderFactory', function(){
    var orders = [
        
    ]
})