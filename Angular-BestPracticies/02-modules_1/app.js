angular.module("app", ['app3', 'app2']);
angular.module("app2", []);
angular.module("app3", []);

angular.module("app2").controller("FirstCtrl", function ($scope) {
    $scope.message = "FirstCtrl in app2"
});

angular.module("app3").controller("FirstCtrl", function ($scope) {
    $scope.message = "FirstCtrl in app3"
});

