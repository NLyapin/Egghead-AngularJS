var app = angular.module("egghead", []);

app.directive("bank", function () {
    return {
        restrict: "E",
        template: "<div>Click to deposit $10</div>",
        require: "ngModel"
    }
})