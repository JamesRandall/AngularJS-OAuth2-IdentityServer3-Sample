'use strict';

/**
 * @ngdoc function
 * @name uiApp.controller:AboutCtrl
 * @description
 * # AboutCtrl
 * Controller of the uiApp
 */
angular.module('uiApp')
  .controller('WebAPiCtrl', function ($scope, $http) {
    $scope.claims = null;
    
    $scope.httpCall = function() {
    	$http.get('https://localhost:44310/claims').success(function(data, status, headers, config) {
    		$scope.claims = data;
    	}).error(function(data, status, headers, config) {

    	});
    };
  });
