(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('HomeController', HomeController);

    /* @ngInject */
    function HomeController($window) {
        var vm = this;

        vm.navigateToTier1 = navigateToTier1;
        vm.navigateToTier2 = navigateToTier2;
        vm.navigateToTier3 = navigateToTier3;

        function navigateToTier1() {
            $window.location.href = "/products/tier1";
        }

        function navigateToTier2() {
            $window.location.href = "/products/tier2";
        }

        function navigateToTier3() {
            $window.location.href = "/products/tier3";
        }
    }

})();
