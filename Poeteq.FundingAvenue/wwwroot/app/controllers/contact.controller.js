(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ContactController', ContactController);

    // contact.$inject = ['$scope'];
    /* @ngInject */
    function ContactController($scope, $http) {
        $scope.title = 'contact';
        
        $scope.contactInfo = {
            Name: '',
            Email: '',
            PhoneNum: '',
            Title: '',
            Service: '',
            Message: ''
        };

        $scope.SendContactInfo = function (contactInfo) {
            $http.post("Contact/SendEmail", contactInfo)
                .then(function (response) {
                    console.log(response.data);
                    window.alert("Message Sent");
                });
        };
    }
})();
