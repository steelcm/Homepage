projectApp.controller('ProjectController', ['$scope', 'ProjectList', function ($scope, projectList) {
    $scope.projects = [];
    projectList.query().$promise.then(function (projects) {
        $scope.projectsDTOs = projects;
        $scope.loadMoreProjects(); // run initial load
    });
    $scope.loadMoreProjects = function () {
        var start = $scope.projects.length;
        var end = start + 3;
        if (end > $scope.projectsDTOs.length) end = $scope.projectsDTOs.length;
        $scope.projects = $scope.projects.concat($scope.projectsDTOs.slice(start, end));
    }
    $scope.hasMoreProjects = function () {
        return $scope.projects.length < $scope.projectsDTOs.length;
    }
}]);