﻿'use strict';

angular.module('myApp.home', ['ngRoute'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/home', { 
            controller: 'HomeCtrl'
        });
    }])
      
    .controller('HomeCtrl', ['$scope', '$http', function ($scope, $http) {

        const urlAPI = "http://localhost:8092/api/Employee/";  
        $scope.lstEmployees = [];
        $scope.employee = {
            id: ''
        };

        $scope.errorMessages = [];



        $scope.getEmployees = function () {
          
            if ($scope.myForm.$invalid) {
                $scope.errorMessages.push("Fields should be verified");
                return;
            }

            //Call Http API
            $http({
                method: "get",
                url: `${urlAPI}${$scope.employee.id}`
            }).then(function (response) {
                $scope.lstEmployees = response.data;
            }, function () { 
                    $scope.errorMessages.push("Error Occur");
            }) 
        }


        $scope.clear = function () {
            $scope.employee = {
                id: ''
            };

            $scope.lstEmployees = [];

              $scope.errorMessages = [];
        }

        $scope.closeAlert = function () {
            $scope.errorMessages = [];
        }
    }]);