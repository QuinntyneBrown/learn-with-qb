angular.module("app", ["ngX", "ngX.components"]).config(["$routeProvider", function ($routeProvider) {
        $routeProvider.when("/", {
            "componentName": "homeComponet"
        });
    }]);











var HomeComponent = (function () {
    function HomeComponent() {
    }
    return HomeComponent;
})();










