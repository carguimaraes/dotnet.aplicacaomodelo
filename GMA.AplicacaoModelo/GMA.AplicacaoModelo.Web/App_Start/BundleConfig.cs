using System.Web;
using System.Web.Optimization;

namespace GMA.AplicacaoModelo.Web
{
    public class BundleConfig
    {
     
        public static void RegisterBundles(BundleCollection bundles)
        {

         //bundles.Add(new ScriptBundle("~/Scripts/jquery")
         //             .Include("~/Scripts/jquery-2.1.4.min.js")
         //             .Include("~/Scripts/jquery-ui-1.10.0.min.js")
         //            );



            bundles.Add(new ScriptBundle("~/bundles/jquery")
                        .Include("~/Scripts/jquery-{version}.js")
                         .Include("~/Scripts/jquery.validate*")
                       );
 

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                       .Include("~/Scripts/modernizr-*")
                       );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                        .Include("~/Scripts/bootstrap.js")
                        );

            bundles.Add(new StyleBundle("~/Content/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/site.css")
                        .Include("~/Content/bootstrap-responsive.css")
                        );
        }
    }
}
