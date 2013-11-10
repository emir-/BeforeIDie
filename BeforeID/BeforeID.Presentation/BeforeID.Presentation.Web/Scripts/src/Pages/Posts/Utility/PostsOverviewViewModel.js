(function (bid, $) {

    var viewModel = function () {

        /*
            Config Properties
            ==========================================
        */

        var pageSize = 10;

        /*
            Observables
            ==========================================
        */

        var posts = ko.observableArray([]);

        /*
           Public functions
           ==========================================
       */

        var init = function () {
            // subscribe to the new post added
            // so we can refresh the post overview
            amplify.subscribe(bid.AmplifyKeys.ActionKeys.NewPostSaved, handleNewPostAdded);

            // get initial post data:
            getPosts();
        };

        /*
            Private Utilities
            ==========================================
       */

        var getPosts = function () {
            
            var queryData = {
                take: pageSize,
                skip: posts().length
            };

            var ajaxConfigObject = {
                type: "POST",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify(queryData),
                url: "/PostData/ReadPosts",

                success: readPostsSuccess,
                error: readPostError
            };
            
            // Mask the html before loading posts
            bid.load.MaskHtml();
            $.ajax(ajaxConfigObject);
        };

        /*
            Utilities
            ==========================================
       */

        /*
            Amplify message handler for new post added
        */

        var handleNewPostAdded = function (data) {
            // data is the new post
            // this will add the new post at the beginning of the array
            posts.splice(0, 0, data);
        };

        /*
            Callbacks
            ==========================================
        */

        // Success callback 
        var readPostsSuccess = function (response, status, object) {
            bid.load.ClearHtml();
            if (response.Status) {
                var responseData = response.Data;
                
                for (var i = 0, length = responseData.length; i < length; i++) {
                    var post = responseData[i];
                    posts.push(post);
                }

            } else {
                console.log("Sucess callback failed status");
            }
        };

        // Error callback
        var readPostError = function (object, status, thrown) {
            bid.load.ClearHtml();
            console.log("Read post error");
        };
        
        /*
            Event Handlers
            ==========================================
       */

        var loadMorePosts = function() {
            getPosts();
        };

        /*
          RMP
          ==========================================
        */
        
        return {
            // public functionality
            Init: init,

            // observables
            Posts: posts,
            
            //event handlers
            LoadMorePosts: loadMorePosts
        };
    }();

    // namespace the view model
    bid.namespace("ViewModels.Pages.Posts.PostsOverview", viewModel);

})(window.BID = window.BID || {}, jQuery)