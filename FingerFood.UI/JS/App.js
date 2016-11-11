var app = angular.module('app', ['ngRoute', 'app.controllers', 'app.services']).
    config(function ($routeProvider) {
        $routeProvider

        .when('/', {
            templateUrl: 'JS/Templates/welcome.html',
            controller: 'WelcomeCtrl'
        })

        .when('/products', {
            templateUrl: 'JS/Templates/product.html',
            controller: 'ProductCtrl'
        })

        .when('/productEdit/:id', {
            templateUrl: 'JS/Templates/productEdit.html',
            controller: 'ProductCtrl'
        })

        .otherwise('/');

        app.constant('SERVER',
            { url: 'localhost:8187' });

    });
