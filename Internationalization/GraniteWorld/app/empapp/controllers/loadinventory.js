(function () {
    'use strict';

    angular.module('app').controller('LoadInventory', loadinventory);

    loadinventory.$inject = ['$scope', '$location', 'webapi'];

    function loadinventory($scope, $location, webapi) {
        var vm = this;

        vm.title = 'loadinventory';

        // Products
        vm.currentProductObj = null;
        vm.selectionChanged = selectionChanged;
        webapi.getProducts().success(function (data) {
            vm.productList = data;
        }).error(function (data) {
            alert(data);
        });

        initModel();
        vm.addInventory = addInventory;

        function addInventory() {
            webapi.addInventory(vm.currentProduct, vm.width, vm.length, vm.weight, vm.receiveDate)
            .success(function (data) {
                alert('Inventory with id: ' + data.InventoryId + ' has been recorded.');
                initModel();
            })
            .error(function (data) {
                alert(data.ExceptionMessage);
            });
        }

        function initModel() {
            vm.currentProduct = undefined;
            vm.width = undefined;
            vm.length = undefined;
            vm.weight = undefined;
            vm.receiveDate = undefined;
        }

        function selectionChanged() {

        }
    }
})();
