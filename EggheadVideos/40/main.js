var app = angular.module("app", []);

app.config(function ($provide) {
    $provide.provider("game", function(){
        return {
            $get: function(){
                return {
                    title: "StartCraft"
                }
            }
        }
    })
});




//app.factory("game", function () {
//    return {
//        title: "StartCraft"
//    }
//})

app.controller("AppCtrl", function ($scope, game) {
    $scope.title = game.title;
})
