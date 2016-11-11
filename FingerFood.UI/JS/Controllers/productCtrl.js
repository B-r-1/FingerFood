angular.module("app.controllers").controller('ProductCtrl',
    function ($scope, $http, $routeParams) {
        $scope.saludo = "Bienvenidos a los productos";
        $scope.products = {};
        $scope.product = {};
        var id = $routeParams.id;

        var getAll = function () {
            $http.get("http://localhost:8187/api/products").then(function (products) {

                $scope.products = products.data;
            });
        };
        
        var getById = function (id) {
            $http.get("http://localhost:8187/api/products/" + id).then(function (product) {

                $scope.product = product.data;
            });
        };

       
        $scope.save = function (product) {
            $http.put("http://localhost:8187/api/products/" + product).then(function () {
                console.log("saved");
            })
        };

        if (id != null || id != "") {
            getById(id);
        };
        if (Object.keys($scope.products).length === 0 ) {
            getAll()
        };

        
    });

