(function(bid, $) {

    var viewModel = (function() {

        /*
            Child view model references
            ====================================================================
        */

        var form = bid.ViewModels.Pages.Posts.PostForm;
        var posts = bid.ViewModels.Pages.Posts.PostsOverview;
        
        /*
            Public Functions
            ====================================================================
        */

        var init = function () {
            form.Init();
            posts.Init();
        };
        
        /*
            RMP
        */
        return {
            
            // Chile view models
            Form: form,
            Posts: posts,
            
            // Public initialization
            Init: init
        };
    })();

    // namespace the view model
    bid.namespace("ViewModels.Pages.Posts.Main", viewModel);

})(window.BID = window.BID || {}, jQuery);