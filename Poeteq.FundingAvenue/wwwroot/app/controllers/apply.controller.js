(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ApplyController', ApplyController);

    ApplyController.$inject = ['$scope', '$http'];

    function ApplyController($scope, $http) {

        $scope.creditCard = {
            lender: '',
            balance: '',
            limit: ''
        };

        
        $scope.linesOfCredit = {
            isSecured: false,
            lender: '',
            balance: '',
            limit: ''
        };

        $scope.applyInfo = {
            firstName: '',
            lastName: '',
            address: '',
            city: '',
            state: '',
            zipCode: '',
            phoneNumber: '',
            email: '',
            businessName: '',
            businessType: '',
            businessEntityType: '',
            applicationCreatedDate: '',
            businessIncorpDate: '',
            businessCreditCards: [],
            businessCreditLines: [],
            amountRequested: 0.0,
            hasFiledForBankruptcy: false,
            hasBeenInForeclosure: false,
            hasJudgementsCollectionsLiens: false,
            comments: '',


        };


        //////ADD and DELETE creditcards//////
        $scope.addCreditCard = function () {
            $scope.applyInfo.businessCreditCards.push(angular.copy($scope.creditCard));
        };
        $scope.deleteCreditCard = function () {
            $scope.applyInfo.businessCreditCards.pop();
        };
        $scope.addLineOfCredit = function () {
            $scope.applyInfo.businessCreditLines.push(angular.copy($scope.linesOfCredit));
        };
        $scope.deleteLineOfCredit = function () {
            $scope.applyInfo.businessCreditLines.pop();
        };
        ////////////////////////////////////


        $scope.init = function () { // runs when the controller/compiler is ready //last step
            $scope.applyInfo.businessCreditCards.push(angular.copy($scope.creditCard));
            $scope.applyInfo.businessCreditLines.push(angular.copy($scope.linesOfCredit));
            console.log($scope.applyInfo);
        };


        /////SEND APPLICATION and HTTP POST call//////
        $scope.sendApplication = function () {
            console.log($scope.applyInfo); console.log($scope.creditCardArray);

            $http.post("Application/Form", $scope.applyInfo)
                .then(function (response) {
                    window.alert("Application Sent");
                    console.log(response);
                }, function (error) {
                    console.log(error);
                });
        };
        /////////////////////////////////
        
    }
})();
