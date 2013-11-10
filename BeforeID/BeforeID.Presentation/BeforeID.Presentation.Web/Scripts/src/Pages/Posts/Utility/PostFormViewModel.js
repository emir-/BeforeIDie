(function (bid, $) {

    var viewModel = function () {

        /*
           Private properties
           ================================================================================================
       */

        var postModel = function (text, catId) {
            this.PostCategoryId = catId;
            this.PostText = text;
        };

        /*
            Observables
            ================================================================================================
        */

        var postText = ko.observable("");

        var categoryId = ko.observable(null);

        /*
           Public functions
           ================================================================================================
       */

        var init = function (catId) {
            // initialize the category id
            categoryId(catId);
        };

        /*
            Event Handlers
            ================================================================================================
        */

        /*
            Event handler for publishing posts
        */

        var publishPost = function () {
            if (postText() == "" || postText().trim() == "") {
                return false;
            }

            var post = new postModel(postText(), categoryId());

            bid.load.MaskHtml();
            
            $.ajax({
                type: "POST",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify(post),
                url: "/PostData/Save",

                success: savePostSuccess,
                error: savePostError
            });
        };

        /*
           Ajax Handlers
           ================================================================================================
       */

        // success callback for saving posts
        var savePostSuccess = function (response, status, object) {
            bid.load.ClearHtml();
            if (response.Status) {
                // clear the post text
                postText("");
                
                // tell whoever cares that a new post has been saved
                amplify.publish(bid.AmplifyKeys.ActionKeys.NewPostSaved, response.Data);
                
            } else {
                console.log("Post Success callback with failed response");
            }
        };

        // error callback for saving posts
        var savePostError = function (object, status, thrown) {
            bid.load.ClearHtml();
            console.log("Post Error callback");
        };

        /*
            RMP
            =====================================================================
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