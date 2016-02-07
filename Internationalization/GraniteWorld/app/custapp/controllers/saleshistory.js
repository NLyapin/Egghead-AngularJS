(function () {
    'use strict';

    // TODO: replace app with your module name
    angular.module('app').controller('SalesHistory', saleshistory);

    saleshistory.$inject = ['$scope', 'webapi'];

    function saleshistory($scope, webapi) {
        var vm = this;

        vm.activate = activate;
        vm.title = 'saleshistory';
        vm.customerChanged = customerChanged;
        vm.searchStart = null;
        vm.searchEnd = null;

        vm.findSales = findSales;
        vm.customerSales = [];

        // Error check flags
        vm.dateOrderError = false;
        vm.errorMessage = '';

        // Customers
        vm.currentCustomer = "";
        vm.currentCustomerObj = null;
        vm.customerChanged = customerChanged;
        webapi.getCustomers().success(function (data) {
            vm.customerList = data;
        }).error(function (data) {
            alert(data);
        });

        function activate() { }

        function customerChanged() {
            vm.customerList.forEach(function (cust) {
                if (cust.CustomerId.toString() === vm.currentCustomer) {
                    vm.currentCustomerObj = cust;
                }
            })
        }

        function findSales() {
            vm.dateOrderError = false;
            vm.errorMessage = '';

            var start = Date.parse(vm.searchStart);
            var end = Date.parse(vm.searchEnd);

            if (start > end) {
                vm.dateOrderError = true;
                return;
            }

            webapi.getCustomerSales(vm.currentCustomer, vm.searchStart, vm.searchEnd).success(function (data) {
                vm.customerSales = data;
                if (data.length == 0) vm.errorMessage = 'No rows found';
            }).error(function (data) {
                alert(data);
            });
        }
    }
})();
