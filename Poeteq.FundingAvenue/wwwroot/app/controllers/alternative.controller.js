(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('AlternativeController', AlternativeController);

    /* @ngInject */
    function AlternativeController() {
        var vm = this;

        vm.recommendation = null;
        vm.products = {
            one: false,
            two: false,
            three: false
        };

        vm.toggleProduct = toggleProduct;

        function toggleProduct(selection) {
            if (selection === 1) {
                vm.products.one = !vm.products.one;
            }
            if (selection === 2) {
                vm.products.two = !vm.products.two;
            }
            if (selection === 3) {
                vm.products.three = !vm.products.three;
            }

            calculateProduct();
        }

        function calculateProduct() {
            if (vm.products.one && !vm.products.two && !vm.products.three) {
                vm.recommendation = "Business Revolving Credit Lines";
            }
            else if (!vm.products.one && vm.products.two && !vm.products.three) {
                vm.recommendation = "Personal Revolving Credit Lines";
            }
            else if (!vm.products.one && !vm.products.two && vm.products.three) {
                vm.recommendation = "Personal Cash Loans";
            }
            else if (vm.products.one && vm.products.two && !vm.products.three) {
                vm.recommendation = "Alternative A";
            }
            else if (vm.products.one && !vm.products.two && vm.products.three) {
                vm.recommendation = "Alternative B";
            }
            else if (!vm.products.one && vm.products.two && vm.products.three) {
                vm.recommendation = "Alternative B";
            }
            else if (vm.products.one && vm.products.two && vm.products.three) {
                vm.recommendation = "Alternative C";
            }
            else {
                vm.recommendation = null;
            }
        }
    }

})();
