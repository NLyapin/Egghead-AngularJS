(function () {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').factory('webapi', webapi);

    webapi.$inject = ['$http'];

    function webapi($http) {
        var service = {
            getCustomers: getCustomers,
            getCustomerSales: getCustomerSales
        };

        return service;

        function getCustomers() {
            return $http.get('/api/customers');
        }

        function getCustomerSales(customerId, searchStart, searchEnd) {
            var query = '/api/customers/' + customerId + '/sales';
            if (searchStart) query += '?fromDate=' + searchStart;
            if (!searchStart && searchEnd) query += '?toDate=' + searchEnd;
            if (searchStart && searchEnd) query += '&toDate=' + searchEnd;

            return $http.get(query);
        }


    }
})();