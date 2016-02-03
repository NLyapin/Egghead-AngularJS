var app = angular.module('app',[]);

app.directive("dumbPassword", function () {
    return {
        restrict: "E",
        template: '<div>\n    <input type="text" ng>\n    \n    \n</div>'
    }
});