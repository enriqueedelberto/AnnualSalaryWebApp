'use strict';

angular.module('myApp.home', ['ngRoute'])

      
    .controller('HomeCtrl', ['$scope', '$http', function ($scope, $http) {

        const urlAPI = "http://localhost:8092/api/Employee/";  
        $scope.lstEmployees = [];
        $scope.employee = {
            id: ''
        };



        $scope.getEmployees = function() {
            $http({
                method: "get",
                url: `${urlAPI}${$scope.employee.id}`
            }).then(function (response) {
                $scope.lstEmployees = response.data;
            }, function () {
                alert("Error Occur");
            }) 
        }
    }]);