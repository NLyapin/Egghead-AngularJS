(function () {
    'use strict';

    // TODO: Inject modules as needed.
    angular.module('app', [
        // Angular modules 
        'ngAnimate',        // animations
        'ngRoute'           // routing

        // Custom modules 

        // 3rd Party Modules
        
    ])
    .config(configure)
    .run(['$route', '$q', '$rootScope',
        function ($route, $q, $rootScope) {

        }]);

    configure.$inject = ['$routeProvider', '$locationProvider'];

    function configure($routeProvider, $locationProvider) {
        console.log('Loading route provider');
        $routeProvider
	        .when('/saleshistory', {
	            templateUrl: "/app/custapp/views/saleshistory.html",
	            controller: "SalesHistory",
	            controllerAs: 'vm'
	        })
        .otherwise(
            {
                redirectTo: '/saleshistory'
            });
    }

})();