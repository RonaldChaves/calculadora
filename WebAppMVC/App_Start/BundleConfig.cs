﻿using System.Web.Optimization;

namespace WebAppMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/calculator").Include("~/Scripts/calculator/index.js"));
            bundles.Add(new ScriptBundle("~/bundles/calculatorTwo").Include("~/Scripts/calculatorTwo/index.js"));
            #endregion

            #region Styles
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css",
                                                                 "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/calculatorTwo").Include("~/Content/CalculatorTwo/calculatorTwo.css"));
            #endregion

            BundleTable.EnableOptimizations = false;
        }
    }
}