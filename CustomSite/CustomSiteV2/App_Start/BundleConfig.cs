using System.Web.Optimization;

namespace CustomSiteV2
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                          "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/Scripts/_particles.js")
                .Include("~/Scripts/Jquery.Poptrox.min.js")
                .Include("~/Scripts/_ui.js")
                );
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                    .Include("~/Scripts/bootstrap.js",
                              "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/skel-noscript.css")
                .Include("~/Content/fontAwesome/font-awesome.css", new CssRewriteUrlTransform())
                .Include("~/Content/_style.css"));
        }
    }
}
