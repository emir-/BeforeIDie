(function (bid, $) {

    var app = (function () {

        var init = function () {
            bid.pmsg.Init();
        };

        return {
            Init: init
        };
    })();

    // namespace the main app module
    bid.namespace("App", app);

})(BID = window.BID || {}, jQuery);