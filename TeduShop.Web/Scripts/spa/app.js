/// <reference path="../../wwwroot/lib/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller('myController', myController);

myController.$inject = ['$scope'];

//declare controller
function myController($scope) {
    $scope.message = "This is my message from Controller";
}