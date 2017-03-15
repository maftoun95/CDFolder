var app = angular.module('myMod', [])

app.controller("divController", function($scope){
    $scope.myName = 'James Earl Jones';
    $scope.myFavoriteLanguage = 'JavaScript';
    $scope.myFavoriteJSLibrary = 'Meteor';

    console.log($scope);
})