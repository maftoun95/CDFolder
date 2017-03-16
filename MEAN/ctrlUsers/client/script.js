var ctrlModule = angular.module('ctrlMod', [])

ctrlModule.controller('userController', function($scope){
    $scope.userArr = [];
    $scope.newser = {}
    
    $scope.add = function(){
        $scope.userArr.push($scope.newser);
        $scope.newser = {};
    }
    $scope.delete = function(idx){
        $scope.userArr.splice(idx,1)
    }
    console.log($scope)
})