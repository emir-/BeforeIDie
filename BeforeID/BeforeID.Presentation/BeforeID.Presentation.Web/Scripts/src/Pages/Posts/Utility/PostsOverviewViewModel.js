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
            // subscribe to the new post added
            // so we can refresh the post overview
            amplify.subscribe(bid.AmplifyKeys.ActionKeys.NewPostSaved, handleNewPostAdded);
        };
        
        /*
           Utilities
           ==========================================
       */
        
        /*
            Amplify message handler for new post added
        */

        var handleNewPostAdded = function() {
            alert("Handling new post save from post overview view model");
        };

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