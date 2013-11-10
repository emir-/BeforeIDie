(function (bid, $) {

    /*
        On enter keypress binding, that calls a function 
        when the enter key is pressed inside an input
        ========================================================================================================
    */
    ko.bindingHandlers.onEnterKey = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            var callbackFunction = valueAccessor();

            if (typeof callbackFunction != "function") {
                return false;
            }

            $(element).on('keypress', function (e) {
                var code = e.keyCode || e.which;

                if (code == 13) { //Enter keycode
                    // call the bound function
                    callbackFunction();
                }
            });

            return true;
        }
    };

    /*
        Binding for the max character counter for text inputs
        ========================================================================================================
    */

    ko.bindingHandlers.maxCharacters = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            var maxCharacters = valueAccessor();

            if (typeof maxCharacters != "number") {
                return false;
            }

            $(element).on('keyup', function (e) {
                var value = $(this).val();

                if (value.length > maxCharacters) {
                    $(this).val(value.substring(0, maxCharacters));
                }
            });

            return true;
        }
    };

    /*
       Binding for the color picker input
       ========================================================================================================
   */

    ko.bindingHandlers.colorPicker = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            // call default value init method
            ko.bindingHandlers.value.init(element, valueAccessor, allBindings, viewModel, bindingContext);

            if ($(element).data("picker-init") !== true) {
                $(element).colorPicker();
                $(element).data("picker-init", true);
            }
            
            return true;
        },

        update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            // call default value upddate method
            ko.bindingHandlers.value.update(element, valueAccessor, allBindings, viewModel, bindingContext);
            $(element).change();
            return true;
        }
    };

})(window.BID = window.BID || {}, jQuery);