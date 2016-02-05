var app = angular.module("egghead", []);

app.directive("bank", function () {
    return {
        restrict: "E",
        template: "<div>Click to deposit $10</div>",
        require: "ngModel",
        link: function (scope, element, attrs, ngModel) {
            element.on("click", function () {
                ngModel.$setViewValue(ngModel.$viewValue + 10);
                scope.$apply();
            })
        }
    }
})