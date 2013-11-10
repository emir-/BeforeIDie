(function (bid, $) {

    var app = (function () {

        // The coloction of available post colors
        var postColors = ["FFF", "82ca9c", "82bbca", "8294ca", "ae82ca", "c35a5a", "7caa65", "c67f39"];
        
        // Default post color
        var defaultPostColor = "FFF";

        var init = function () {
            bid.pmsg.Init();

            // overide color picker
            $.fn.colorPicker.defaults.colors = postColors;
        };

        return {
            Init: init,
            
            // Default post colors available for section,
            PostColors: postColors,
            
            DefaultPostColor: defaultPostColor
        };
    })();

    // namespace the main app module
    bid.namespace("App", app);

})(BID = window.BID || {}, jQuery);