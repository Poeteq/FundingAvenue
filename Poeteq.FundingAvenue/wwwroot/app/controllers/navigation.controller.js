(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('NavigationController', NavigationController);

    NavigationController.$inject = ['$window'];
    function NavigationController($window) {
        var vm = this;

        vm.navigateTo = navigateTo;

        function navigateTo(page) {
            $window.location.href = page;
        }
    }
})();
