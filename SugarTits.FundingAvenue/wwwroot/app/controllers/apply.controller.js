(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ApplyController', ApplyController);

    ApplyController.$inject = ['$scope', '$http'];

    function ApplyController($scope, $http) {
        $scope.title = 'apply';

      

        $scope.creditCard = {
            Lender: '',
            Balance: '',
            Limit: ''
        };

        $scope.linesOfCredit = {
            IsSecured: false,
            Lender: '',
            Balance: '',
            Limit: ''
        };

        $scope.applyInfo = {
            FirstName: '',
            LastName: '',
            Address: '',
            City: '',
            State: '',
            ZipCode: '',
            PhoneNumber: '',
            //PhoneType: '',
            Email: '',
            BusinessName: '',
            BusinessType: '',
            BusinessEntityType: '',
            ApplicationCreatedDate: '',
            BusinessIncorpDate: '',
            BusinessCreditCards: [$scope.creditCard],
            BusinessCreditLines: [$scope.linesOfCredit],
            AmountRequested: 0.0,
            HasFiledForBankruptcy: false,
            HasBeenInForeclosure: false,
            HasJudgementsCollectionsLiens: false,
            Comments: '',
            

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
