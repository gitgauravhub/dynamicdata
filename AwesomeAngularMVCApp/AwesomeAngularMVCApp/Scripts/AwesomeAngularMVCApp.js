//ng-app="AwesomeAngularMVCApp" in index.html
var AwesomeAngularMVCApp = angular.module('AwesomeAngularMVCApp', ['ngRoute']);
//ng-controller="LandingPageController" in index.html
AwesomeAngularMVCApp.controller('LandingPageController', LandingPageController);

// tell our Angular app about, and configure it to use the interceptor
AwesomeAngularMVCApp.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);

//routes information in the application module's config function(also mention ngroute in module)
var configFunction = function ($routeProvider, $httpProvider)
{
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
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

AwesomeAngularMVCApp.config(configFunction);



