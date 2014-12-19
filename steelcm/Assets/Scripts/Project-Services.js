var projectServices = angular.module('projectServices', ['ngResource']);

projectServices.factory('ProjectList', ['$resource',
    function ($resource) {
        return $resource('/api/projectsapi', {}, {
            query: { method: 'GET', isArray: true }
        });
    }
]);