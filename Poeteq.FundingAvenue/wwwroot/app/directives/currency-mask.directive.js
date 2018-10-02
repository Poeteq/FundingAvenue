(function () {
    'use strict';

    angular
        .module('FundingAvenue')
        .directive('faCurrencyMask', CurrencyMask);

    function CurrencyMask($parse) {
        return {
            restrict: 'A',
            require: 'ngModel',
            link: function (scope, element, attrs, ngModel) {

                var formatNumber = function (value) {

                    value = value.toString();
                    value = value.replace(/[^0-9\.]/g, "");
                    var parts = value.split('.');
                    parts[0] = parts[0].replace(/\d{1,3}(?=(\d{3})+(?!\d))/g, "$&,");
                    if (parts[1] && parts[1].length > 2) {
                        parts[1] = parts[1].substring(0, 2);
                    }

                    return parts.join(".");
                };
                var applyFormatting = function () {
                    var value = element.val();
                    var original = value;
                    if (!value || value.length == 0) {
                        return
                    }
                    value = formatNumber(value);
                    if (value != original) {
                        element.val(value);
                        element.triggerHandler('input')
                    }
                };
                element.bind('keyup', function (e) {
                    var keycode = e.keyCode;
                    var isTextInputKey =
                        (keycode > 47 && keycode < 58) || // number keys
                        keycode == 32 || keycode == 8 || // spacebar or backspace
                        (keycode > 64 && keycode < 91) || // letter keys
                        (keycode > 95 && keycode < 112) || // numpad keys
                        (keycode > 185 && keycode < 193) || // ;=,-./` (in order)
                        (keycode > 218 && keycode < 223); // [\]' (in order)
                    if (isTextInputKey) {
                        applyFormatting();
                    }
                });
                element.bind('blur', function (evt) {
                    //if (angular.isDefined(attrs.ngModel)) {
                        if (angular.isDefined(ngModel.$viewValue)) {
                            var val = ngModel.$viewValue.split('.');
                        if (val && val.length == 1) {
                            if (val != "") {
                                ngModel.$setViewValue(val + '.00');
                                ngModel.$render();
                            }
                        } else if (val && val.length == 2) {
                            if (val[1] && val[1].length == 1) {
                                ngModel.$setViewValue(val[0] + '.' + val[1] + '0');
                                ngModel.$render();
                            } else if (val[1].length == 0) {
                                ngModel.$setViewValue(val[0] + '.00');
                                ngModel.$render();
                            }
                            applyFormatting();
                        }
                    }
                });
                //ngModelController.$parsers.push(function (value) {
                //    if (!value || value.length == 0) {
                //        return value;
                //    }
                //    value = value.toString();
                //    value = value.replace(/[^0-9\.]/g, "");
                //    return value;
                //});
                //ngModelController.$formatters.push(function (value) {
                //    if (!value || value.length == 0) {
                //        return value;
                //    }
                //    value = formatNumber(value);
                //    return value;
                //});

            }


        };
    }
    
})();