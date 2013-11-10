(function () {

    /*
        Module containing all keys used for messages
        for the amplify pub sub functionality.
    */
    var keyCollection = function () {

        var actionKeys = {
            NewPostSaved: "NewPostSaved"
        };

        return {
            ActionKeys: actionKeys
        };
    }();

    BID.namespace("AmplifyKeys", keyCollection);

})(BID = window.BID || {}, jQuery);