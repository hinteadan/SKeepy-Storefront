using System.Web;
using System.Web.Optimization;

namespace SKeepyStorefrontWebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.dropotron.min.js",
                        "~/Scripts/jquery.scrollex.min.js",
                        "~/Scripts/jquery.scrolly.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                        "~/Scripts/skel.min.js",
                        "~/Scripts/util.js",
                        "~/Scripts/main.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                "~/Content/font-awesome.min.css",
                "~/Content/main.css"
                ));
        }
    }
}
