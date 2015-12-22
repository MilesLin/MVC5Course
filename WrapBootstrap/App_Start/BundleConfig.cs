using System.Web;
using System.Web.Optimization;

namespace WrapBootstrap
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.DirectoryFilter.Clear();
            bundles.DirectoryFilter.Ignore("*.intellisense.js");
            bundles.DirectoryFilter.Ignore("*-vsdoc.js");
            bundles.DirectoryFilter.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            // bundles.DirectoryFilter.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            bundles.DirectoryFilter.Ignore("*.min.css", OptimizationMode.WhenDisabled);

            bundles.Add(new ScriptBundle("~/bundles/WrapBootstrap").Include(
                "~/js/jquery-1.9.1*",
                "~/js/jquery-migrate-1.0.0.min.js",
                "~/js/jquery-ui-1.10.0.custom.min.js",
                "~/js/jquery.ui.touch-punch.js",
                "~/js/modernizr*",
                "~/js/bootstrap*",
                "~/js/jquery.cookie.js",
                "~/js/fullcalendar.min.js",
                "~/js/jquery.dataTables.min.js",
                "~/js/excanvas.js",
                "~/js/jquery.flot.js",
                "~/js/jquery.flot.pie.js",
                "~/js/jquery.flot.stack.js",
                "~/js/jquery.flot.resize.min.js",
                "~/js/jquery.chosen.min.js",
                "~/js/jquery.uniform.min.js",
                "~/js/jquery.cleditor.min.js",
                "~/js/jquery.noty.js",
                "~/js/jquery.elfinder.min.js",
                "~/js/jquery.raty.min.js",
                "~/js/jquery.iphone.toggle.js",
                "~/js/jquery.uploadify-3.1.min.js",
                "~/js/jquery.gritter.min.js",
                "~/js/jquery.imagesloaded.js",
                "~/js/jquery.masonry.min.js",
                "~/js/jquery.knob.modified.js",
                "~/js/jquery.sparkline.min.js",
                "~/js/counter.js",
                "~/js/retina.js",
                "~/js/custom.js"));

        }
    }
}
