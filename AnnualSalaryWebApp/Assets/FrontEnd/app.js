'use strict'


angular.module('myApp', [
    'ngRoute',
    'ngMaterial',
    'ngMessages',
    'myApp.home', 
])
    .config(['$locationProvider', '$routeProvider', '$mdThemingProvider', function ($locationProvider, $routeProvider, $mdThemingProvider) {
        $locationProvider.hashPrefix('!');


        $routeProvider.otherwise({ redirectTo: '/home' });




    }]);