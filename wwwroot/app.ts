angular.module("app", ["ngX", "ngX.components"]).config(["$routeProvider", $routeProvider => {
    $routeProvider.when("/", {
        "componentName": "homeComponet"
    });
}]);