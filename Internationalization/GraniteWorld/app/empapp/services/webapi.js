(function () {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').factory('webapi', webapi);

    webapi.$inject = ['$http'];

    function webapi($http) {
        var service = {
            getProducts: getProducts,
            addInventory: addInventory
        };

        return service;

        function getProducts() {
            return $http.get('/api/products');
        }

        function addInventory(productId, width, length, weight, receiveDate) {
            return $http.post('/api/addinventory', {
                ProductId: productId,
                Width: width,
                Length: length,
                Weight: weight,
                ReceiveDate: receiveDate.toString()
            });
        }
    }
})();