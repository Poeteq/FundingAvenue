(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('HomeController', HomeController);

    /* @ngInject */
    function HomeController($window) {
        var vm = this;
        
        vm.navigateToProduct = navigateToProduct;

        function navigateToProduct(product) {
            $window.location.href = "/product/" + product;
        }
        
    }

})();
