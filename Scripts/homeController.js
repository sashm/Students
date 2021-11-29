////app.controller("HomeController", function ($scope, $http) {

////    $scope.btntext = "Fill Table";
////    $scope.filltable = function () {
////        $scope.btntext = "Please wait....";
////        $http({
////            method: "POST",
////            url: '/Home/GetData',
////            data: $scope.Users
////        }).then(function (response) {
////            var k = JSON.parse(JSON.stringify(response.data));
////            $scope.que = k;
////            $scope.btntext = "Fill Table";
////        }, function (error) {
////            var k = JSON.parse(JSON.stringify(response.data));
////            alert(k.message);
////            $scope.btntext = "Fill Table";
////        });
////    }
////})
debugger;

//var app = angular.module('angularTable', ['angularUtils.directives.dirPagination']);

//app.controller('listdata', function ($scope, $http) {

    //$http.get('/Home/getrecord').then(function (d) {

    //    $scope.regdata = d.data;

    //}, function (error) {

    //    alert('failed');

    //});
//    $scope.btntext = "Fill Table";
//    $scope.filltable = function () {
//        debugger;
//        $scope.btntext = "Please wait....";
//        $http({
//            method: "POST",
//            url: '/Home/getrecord',
//            data: $scope.regdata
//        }).then(function (response) {
//            var k = JSON.parse(JSON.stringify(response.data));
//            $scope.que = k;
//            $scope.btntext = "Fill Table";
//        }, function (error) {
//            var k = JSON.parse(JSON.stringify(response.data));
//            alert(k.message);
//            $scope.btntext = "Fill Table";
//        });
//    }

//    $scope.sort = function (keyname) {
//        $scope.sortKey = keyname;   //set the sortKey to the param passed
//        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
//    }
//});

var app = angular.module('angularTable', ['angularUtils.directives.dirPagination']);

app.controller('listdata', function ($scope, $http) {
    debugger;
    $scope.regdata = []; //declare an empty array
    $http({
            method: "POST",
            url: '/Home/getrecord',
            data: $scope.regdata
    }).then(function (response) {
        debugger;
            var k = JSON.parse(JSON.stringify(response.data));
        $scope.regdata = k;
        }, function (error) {
            var k = JSON.parse(JSON.stringify(response.data));
            alert(k.message);
        });
    
    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;   //set the sortKey to the param passed
        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }
});