﻿using System.Web;
using System.Web.Optimization;

namespace Exam.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/unobrtrusive")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // The Kendo Script bundle
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/Kendo/kendo.all.min.js",
                "~/Scripts/Kendo/kendo.aspnetmvc.min.js"));

            // The Kendo CSS bundle
            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                        "~/Content/Kendo/kendo.common.min.css",
                        "~/Content/Kendo/kendo.black.min.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-responsive.css"));

            // Clear all items from the ignore list to allow minified CSS and JavaScript files in debug mode
            bundles.IgnoreList.Clear();

            // Add back the default ignore list rules sans the ones which affect minified files and debug mode
            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
        }
    }
}
