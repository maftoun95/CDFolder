var myApp = angular.module("appModule",[])

myApp.factory('productFactory', function(){
    var products = [
        {name:"PS4",price:350},
        {name:"TV",price:650},
        {name:"Deep Fryer",price:125},
        {name:"2 X 4's",price:4.50}
    ];
    var factory = {};
    factory.index = function (callback){
        callback(products);
    }
    factory.add = function(prod){
        products.push(prod)
    }
    factory.delete = function(idx){
        products.splice(idx,1);
    }
    return factory;
})

myApp.controller('productController', ['$scope', 'productFactory', function($scope, productFactory){
    $scope.products = [];
    $scope.newProd = {};
    $scope.sortorder = false;
    productFactory.index(function(data){
        $scope.products = data;
    })
    $scope.add = function(){
        console.log($scope.newProd)
        productFactory.add($scope.newProd);
        $scope.newProd = {}
    }

    $scope.delete = function(idx){
        productFactory.delete(idx);
    }


    console.log($scope);
}]);