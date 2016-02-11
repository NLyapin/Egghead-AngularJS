angular.module('app')
    .directive('animal', function() {
        return {
            restrict: "E",
            templateUrl: 'app/animals.html'
        };
    });
