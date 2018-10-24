(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ApplyController', ApplyController);

    ApplyController.$inject = ['$scope', '$http'];

    function ApplyController($scope, $http) {


        $scope.GIsEnabled = false;
        $scope.secretText = "Contact Us";
        $scope.years = [];
        $scope.fundingType;
        $scope.toHide;
     

        $scope.menuSelected = function (appType) {

            if (appType == "Personal Credit Lines" || appType == "Personal Cash Loans" || appType == "Real Estate") {
               
                $scope.toHide = true;
                $scope.fundingType = appType;

            }

            if ( appType == "Business Credit Lines" || appType == "Business Entity Creation" || appType == "Combo Funding") {
                $scope.toHide = false;
                $scope.fundingType = appType;
            }

        };

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
            applicationType: '',
            firstName: '',
            lastName: '',
            address: '',
            city: '',
            state: '',
            zipCode: '',
            phoneNumber: '',
            birthYear: '',
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


        //////ADD and DELETE Button creditcards/lines of credits //////
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


        function initYears() {
            var year = new Date().getFullYear();
            var range = [];

            for (var i = 0; i < 50; i++) {
                range.push({
                    label: year - i,
                    value: parseInt(String(year - i).slice(0, 4))
                });
            }

            $scope.years = range;
        }
        




        ///////////////////////////////



        $scope.init = function () { // runs when the controller/compiler is ready //last step
            initYears();
            $scope.applyInfo.businessCreditCards.push(angular.copy($scope.creditCard));
            $scope.applyInfo.businessCreditLines.push(angular.copy($scope.linesOfCredit));
            console.log($scope.applyInfo);
            console.log($scope.applyInfo.amountRequested);
        };




        /////SEND APPLICATION and HTTP POST call//////
        $scope.sendApplication = function () {
            $scope.applyInfo.applicationType = $scope.fundingType;
            $scope.applyInfo.GIsEnabled = $scope.GIsEnabled;

            console.log($scope.applyInfo.birthYear);

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
