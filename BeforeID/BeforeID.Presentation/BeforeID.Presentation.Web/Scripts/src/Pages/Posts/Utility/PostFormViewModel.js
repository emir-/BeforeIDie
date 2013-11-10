(function (bid, $) {

    var viewModel = function () {

        /*
           Private properties
           ================================================================================================
       */

        var postModel = function (text, catId, colorCode) {
            this.PostCategoryId = catId;
            this.PostText = text;
            this.PostColor = colorCode;
        };

        // the number of milliseconds where the user can post again.
        var timeConstraint = 0;

        // keeps track of the current milliseconds from last post
        var currentCounter = 0;

        // the interval at which timing  ( current counter ) is updated.
        var tick = 100;

        var interval = null;

        /*
            Observables
            ================================================================================================
        */

        var postText = ko.observable("");
        
        var postColor = ko.observable("");

        var categoryId = ko.observable(null);

        // Used to track timings for user posting
        var canPost = ko.observable(true);

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

            var post = new postModel(postText(), categoryId(), postColor());

            // clear the post text
            postText("");
            postColor(bid.App.DefaultPostColor);

            if (canPost()) {
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

                // disable posting and setup the timeout to renable it in the
                // given time constraint
                canPost(false);

                // set an interval decreasing the current counter
                var intervalFlag = setInterval(function () {
                    if (currentCounter <= 0) {
                        // rest current counter and the post flag
                        currentCounter = timeConstraint;

                        canPost(true);

                        // stop counting untill new flag
                        clearInterval(intervalFlag);

                    } else {
                        currentCounter = currentCounter - tick;
                    }
                }, tick);

            } else {
                var minutes = Math.floor((currentCounter / 1000) / 60);
                var seconds = Math.round((currentCounter / 1000) % 60);
                
                bid.pmsg.Info("Пост", "Не може да се постира веднаш по последниот пост. Мора да почекате " + minutes + ":" + seconds + " мин.");
            }

            return true;
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
            PostColor: postColor,

            // Public functions
            Init: init,

            // Event handlers
            PublishPost: publishPost
        };
    }();

    // namespace the view model
    bid.namespace("ViewModels.Pages.Posts.PostForm", viewModel);

})(window.BID = window.BID || {}, jQuery)