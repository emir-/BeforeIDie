using System.Web.Optimization;
using BeforeID.Presentation.Web.Infrastructure.UrlTransforms;
using BundleTransformer.Core.Transformers;

namespace BeforeID
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Script Bundling

            // add jquery scropt bundles
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/knockout-3.0.0.js",
                        "~/Scripts/amplify.js",
                        "~/Scripts/jquery.isotope.js",
                        "~/Scripts/jquery.loadmask.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // add boostrap bundles
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // add app script bundles
            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                "~/Scripts/src/Main/namespace.js",
                "~/Scripts/src/Main/App.js",

                // utilities
                "~/Scripts/src/Common/AmplifyKeys.js",
                "~/Scripts/src/Common/Bindings.js",
                "~/Scripts/src/Common/LoadmaskWrapper.js",

                // Post Page View Models
                "~/Scripts/src/Pages/Posts/Utility/PostFormViewModel.js",
                "~/Scripts/src/Pages/Posts/Utility/PostsOverviewViewModel.js",
                "~/Scripts/src/Pages/Posts/PostPageViewModel.js"
            ));

            #endregion

            #region Content Bunlding

            // add basic third party content bundles
            bundles.Add(new StyleBundle("~/Content/common")
                        .Include("~/Content/bootstrap.css", new CssPathTransform())
                        .Include("~/Content/loadmask/jquery.loadmask.css", new CssPathTransform()));

            // add app contente bundles
            bundles.Add(new StyleBundle("~/Content/appcss")
                .Include("~/Content/css/App.css")
            );

            AddAppLessBundle(bundles);

            #endregion
        }

        #region Content Bundling

        private static void AddAppLessBundle(BundleCollection bundles)
        {
            var lessBundle = new StyleBundle("~/Content/css/less").Include(
                "~/Content/css/App.less"
                );

            lessBundle.Transforms.Add(new CssTransformer());
            lessBundle.Transforms.Add(new CssMinify());

            bundles.Add(lessBundle);
        }

        #endregion
    }
}

