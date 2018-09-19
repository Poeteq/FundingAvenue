(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .controller('ComboController', ComboController);

    /* @ngInject */
    function ComboController() {
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
                vm.productLink = "/product/businesscreditlines";
                vm.isAlternative = false;
            }
            else if (!vm.products.one && vm.products.two && !vm.products.three) {
                vm.recommendation = "Personal Revolving Credit Lines";
                vm.productLink = "/product/personalcreditlines";
                vm.isAlternative = false;
            }
            else if (!vm.products.one && !vm.products.two && vm.products.three) {
                vm.recommendation = "Personal Cash Loans";
                vm.productLink = "/product/personalloans";
                vm.isAlternative = false;
            }
            else if (vm.products.one && vm.products.two && !vm.products.three) {
                vm.recommendation = "Combo A";
                vm.isAlternative = true;
                vm.id = "#alt-a";
            }
            else if ((vm.products.one && !vm.products.two && vm.products.three) || (!vm.products.one && vm.products.two && vm.products.three)) {
                vm.recommendation = "Combo B";
                vm.isAlternative = true;
                vm.id = "#alt-b";
            }
            //else if (!vm.products.one && vm.products.two && vm.products.three) {
            //    vm.recommendation = "Alternative B";
            //    vm.isAlternative = false;
            //}
            else if (vm.products.one && vm.products.two && vm.products.three) {
                vm.recommendation = "Combo C";
                vm.isAlternative = true;
                vm.id = "#alt-c";
            }
            else {
                vm.recommendation = null;
            }
        }
    }

})();
