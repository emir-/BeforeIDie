(function (bid, $) {

    var app = (function () {

        var init = function() {
            console.log("Initializing app");
        };

        return {
            Init: init
        };
    })();

    // namespace the main app module
    bid.namespace("App", app);

})(BID = window.BID || {}, jQuery);