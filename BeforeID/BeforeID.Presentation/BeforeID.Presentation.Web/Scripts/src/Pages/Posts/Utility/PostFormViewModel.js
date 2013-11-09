(function (bid, $) {

    var viewModel = function () {

        /*
            Observables
            ================================================================================================
        */

        var postText = ko.observable("");
        
        /*
           Public functions
           ================================================================================================
       */

        var init = function () {
        };

        /*
            Event Handlers
            ================================================================================================
        */

        /*
            Event handler for publishing posts
        */

        var publishPost = function () {
            alert("Publishing post");
        };

        /*
            RMP
        */
        return {
            // Observables
            PostText: postText,

            // Public functions
            Init: init,

            // Event handlers
            PublishPost: publishPost
        };
    }();

    // namespace the view model
    bid.namespace("ViewModels.Pages.Posts.PostForm", viewModel);

})(window.BID = window.BID || {}, jQuery)