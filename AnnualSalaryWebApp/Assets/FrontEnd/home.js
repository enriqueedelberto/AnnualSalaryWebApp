'use strict';

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

        var self = this;
        self.determinateValue = 30;
        self.determinateValue2 = 30;

        self.showList = [];


        $scope.errorMessages = [];


        $scope.showLoadingBar = false;

        $scope.getEmployees = function () {

            if ($scope.myForm.$invalid) {
                $scope.errorMessages.push("Fields should be verified");
                return;
            }

            $scope.showLoadingBar = true;

            //Call Http API
            $http({
                method: "get",
                url: `${urlAPI}${$scope.employee.id}`
            }).then(function (response) {
                $scope.showLoadingBar = false;
                $scope.lstEmployees = response.data;
            }, function () {
                $scope.showLoadingBar = false;
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