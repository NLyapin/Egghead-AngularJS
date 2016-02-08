﻿using System.Web;
using System.Web.Optimization;

namespace GraniteWorld
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/scripts/angular-route.js",
                        "~/Scripts/angular-animate.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/app/empapp/app.js",

                        // Controllers
                        "~/app/empapp/controllers/main.js",
                        "~/app/empapp/controllers/shell.js",
                        "~/app/empapp/controllers/loadinventory.js",
                        
                        // Services
                        "~/app/empapp/services/webapi.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/custapp").Include(
                        "~/app/custapp/app.js",

                        // Controllers
                        "~/app/custapp/controllers/main.js",
                        "~/app/custapp/controllers/shell.js",
                        "~/app/custapp/controllers/loadinventory.js",
                        
                        // Services
                        "~/app/custapp/services/context.js",
                        "~/app/custapp/services/webapi.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
