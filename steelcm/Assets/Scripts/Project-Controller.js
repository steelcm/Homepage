projectApp.controller('ProjectController', ['$scope', 'ProjectList', function ($scope, projectList) {

    $scope.myVar = "Hello World2!";
    $scope.projects = projectList.query();

}]);