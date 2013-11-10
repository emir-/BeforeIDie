(function (bid, $) {

    var app = (function () {

        var init = function () {
        };

        return {
            Init: init
        };
    })();

    // namespace the main app module
    bid.namespace("App", app);

})(BID = window.BID || {}, jQuery);