// Wrapper around the Pines Notify Plugin to simplify the creation of some basic messages
(function (bid, $) {
    // Create the pines wrapper object
    var pinesWrapper = function () {

        // ====================================================================================
        //     Properties - Contains stack information for customizing the way the notifiactions are displayed
        // ====================================================================================

        var stack_topleft = { "dir1": "down", "dir2": "right", "push": "top" };
        var stack_bottomleft = { "dir1": "right", "dir2": "up", "push": "top" };
        var stack_custom = { "dir1": "right", "dir2": "down" };
        var stack_custom2 = { "dir1": "left", "dir2": "up", "push": "top" };
        var stack_bar_top = { "dir1": "down", "dir2": "right", "push": "top", "spacing1": 0, "spacing2": 0 };
        var stack_bar_bottom = { "dir1": "up", "dir2": "right", "spacing1": 0, "spacing2": 0 };

        var stack_bottomright = { "dir1": "up", "dir2": "left", "firstpos1": 25, "firstpos2": 25 };

        // The stack beeing used
        var usingStack = undefined;
        var stackClassName = "";

        // ====================================================================================
        //     Initialization
        // ====================================================================================

        // The initialization function
        var init = function () {
            // setup some default pines settings
            $.pnotify.defaults.delay = 5000;

            usingStack = stack_bottomright;
            stackClassName = "stack-bottomright";
        };

        // ====================================================================================
        //     Success
        // ====================================================================================

        // Display a success pines notify message
        var success = function (title, message) {
            var opts = getOpts('success');

            opts.title = title;
            opts.text = message;

            $.pnotify(opts);
        };

        // ====================================================================================
        //     Info
        // ====================================================================================

        // Display a regular info pines notify message
        var info = function (title, message) {
            var opts = getOpts('info');

            opts.title = title;
            opts.text = message;

            $.pnotify(opts);
        };

        // ====================================================================================
        //     Error
        // ====================================================================================

        // Display a error pines notify message
        var error = function (title, message, otherOpts) {
            var opts = getOpts('error');

            opts.title = title;
            opts.text = message;

            if (tm.params.isDefinedAndHasValue(otherOpts)) {
                $.extend(opts, otherOpts);
            }

            // check if custom fade time was provided
            if (typeof time === "number") {
                opts.time = time;
            }

            $.pnotify(opts);
        };

        /*
            Display a generic error message to be used in places of alerts and/or non localized error callback
        */

        var genericError = function () {
            var options = getOpts('error');

            options.title = "Апликација";
            options.text = "Грешка во апликацијата. Пробајте поново.";

            $.pnotify(options);
        };

        // ====================================================================================
        //     Private Methods
        // ====================================================================================

        var getOpts = function (type) {

            var opts = {
                history: false,
                type: type,
                styling: 'bootstrap3'
            };

            // Check if another stack has been defined.
            // If so we are going to set it to the default opts
            if (typeof usingStack !== "undefined") {

                opts.stack = usingStack;
                opts.addclass = stackClassName;
            }

            return opts;
        };

        // ====================================================================================
        //     RPM
        // ====================================================================================

        // define the public functions for the pines wrapper
        return {
            Init: init,

            Success: success,

            Info: info,

            GenericError: genericError,
            Error: error,
        };
    }();

    // namespace the pines wrapper in a short reference under main namespaec
    bid.namespace("pmsg", pinesWrapper);

})(window.BID = window.BID || {}, jQuery);