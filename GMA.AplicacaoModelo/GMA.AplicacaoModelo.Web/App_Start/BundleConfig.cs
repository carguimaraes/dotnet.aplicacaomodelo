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
                         .Include("~/Scripts/jquery-ui-1.10.0.min.js")
                       );
 

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                       .Include("~/Scripts/modernizr-*")
                       );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                        .Include("~/Scripts/bootstrap.js")
                        );

            bundles.Add(new ScriptBundle("~/Scripts/angular")
                        .Include("~/Scripts/angular.min.js")
                        .Include("~/Scripts/angular-route.min.js")
                       );


            bundles.Add(new StyleBundle("~/Content/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/site.css")
                        .Include("~/Content/bootstrap-responsive.css")
                        .Include("~/Content/ui.jqgrid-bootstrap-ui.css")
                        .Include("~/Content/ui.jqgrid-bootstrap.css")
                        .Include("~/Content/ui.jqgrid.css")
                        
                        );

            bundles.Add(new ScriptBundle("~/Scripts/componentesExternos")
                         .Include("~/Scripts/i18n/grid.locale-pt-br.js")
                         .Include("~/Scripts/jquery.jqGrid.min.js")
                       );                  


           


        }
    }
}
