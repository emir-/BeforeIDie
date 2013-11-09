(function (bid, $) {

    var viewModel = function () {

        /*
            Observables
            ==========================================
        */
        
        /*
           Public functions
           ==========================================
       */
        
        var init = function () {
        };
        
        /*
           Utilities
           ==========================================
       */

        /*
          RMP
          ==========================================
        */
        return {
            Init: init
        };
    }();

    // namespace the view model
    bid.namespace("ViewModels.Pages.Posts.PostsOverview", viewModel);

})(window.BID = window.BID || {}, jQuery)