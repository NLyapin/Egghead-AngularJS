angular.module("app", []);
//
//angular.module("app")
//    .directive("myDirective", function () {
//        return {
//            restrict: 'E',
//            replace: true,
//            template: '<div>this is my first directive</div>'
//        }
//    });
angular.module("app")
    .directive("myDirective", function () {
        return {
            restrict: 'E',
            replace: true,
            template: '<div>this is my second directive</div>'
        }
    });



