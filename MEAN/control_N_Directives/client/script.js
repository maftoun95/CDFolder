var app = angular.module('myMod', [])

app.controller("formsController", function($scope){
    //$scope.foodArray = ["Teriyaki","Curry","Chicken Alfredo"];
    $scope.addIt = function(){
        $scope.foodArray.push($scope.food)
        $scope.food = "";
    }
    console.log($scope);
})