var app = angular.module('phoneApp',[]);


app.controller("AppCtrl", function ($scope) {
    this.sayHi = function () {

    }
});

app.directive("panel", function () {
    return {
        restrict: "E",
        transclude: true,
        template: '<div class="panel" ng-transclude>This is a ' +
        'panel commponent\n<p>sfdsfsfs</p>\n</div>'
    }
});