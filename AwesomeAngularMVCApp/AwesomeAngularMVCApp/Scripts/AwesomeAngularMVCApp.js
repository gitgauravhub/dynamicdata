//ng-app="AwesomeAngularMVCApp" in index.html
var AwesomeAngularMVCApp = angular.module('AwesomeAngularMVCApp', ['ngRoute']);
//ng-controller="LandingPageController" in index.html
AwesomeAngularMVCApp.controller('LandingPageController', LandingPageController);


//routes information in the application module's config function(also mention ngroute in module)
var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        //.when('/routeTwo', {
        //    templateUrl: 'routesDemo/two'
        //})

        //Parameterized template :donuts
        .when('/routeTwo/:donuts', {
            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        });
}
configFunction.$inject = ['$routeProvider'];

AwesomeAngularMVCApp.config(configFunction);