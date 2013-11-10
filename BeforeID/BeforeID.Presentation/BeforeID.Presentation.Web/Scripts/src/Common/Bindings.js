(function () {

    /*
        On enter keypress binding, that calls a function 
        when the enter key is pressed inside an input
    */
    ko.bindingHandlers.onEnterKey = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            var callbackFunction = valueAccessor();

            if (typeof callbackFunction != "function") {
                return false;
            }

            $(element).on('keypress', function (e) {
                var code = e.keyCode || e.which;
                console.log("KEYPRESS:" + code);
                if (code == 13) { //Enter keycode
                    // call the bound function
                    console.log("ENTER");
                    callbackFunction();
                }
            });

            return true;
        }
    };
})(window.BID = window.BID || {}, jQuery);