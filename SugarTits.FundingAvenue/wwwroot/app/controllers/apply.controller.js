(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ApplyController', ApplyController);

    ApplyController.$inject = ['$scope', '$http'];

    function ApplyController($scope, $http) {

        $scope.title = 'apply';

      

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
            //PhoneType: '',
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

        $scope.init = function () { // runs when the controller/compiler is ready //last step
            $scope.applyInfo.businessCreditCards.push($scope.creditCard);
            $scope.applyInfo.businessCreditLines.push($scope.linesOfCredit);
            console.log($scope.applyInfo);
        };

        $scope.SendApplication = function (applyInfo) {
            console.log(applyInfo);
          
            $http.post("Application/Form", applyInfo)
                .then(function (response) {
                    console.log(response);
            

                });
            //$http.post("apply/form", applyInfo)
            //    .then(function (response) {
            //        console.log("yasss");
            //    });
        };

        
    }
})();
