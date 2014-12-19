using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace steelcm.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // **** VENDOR SCRIPTS
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Vendor/jquery", "https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.1.1.min.js").Include("~/Assets/Scripts/Vendor/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Vendor/jquery.validate", "https://ajax.aspnetcdn.com/ajax/jquery.validate/1.13.0/jquery.validate.min.js").Include("~/Assets/Scripts/Vendor/jquery.validate-{version}.js"));
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Vendor/jquery.validate.unobtrusive", "https://ajax.aspnetcdn.com/ajax/mvc/5.1/jquery.validate.unobtrusive.min.js").Include("~/Assets/Scripts/Vendor/jquery.validate.unobtrusive-{version}.js"));
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Vendor/angular", "https://ajax.googleapis.com/ajax/libs/angularjs/1.3.0-rc.3/angular.min.js").Include("~/Assets/Scripts/Vendor/angular-{version}.js"));
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Vendor/angular.resource", "https://ajax.googleapis.com/ajax/libs/angularjs/1.3.0-rc.3/angular-resource.min.js").Include("~/Assets/Scripts/Vendor/angular-resource-{version}.js"));

            // **** PROJECT SCRIPTS
            bundles.Add(new ScriptBundle("~/Assets/Scripts/Projects")
                .Include("~/Assets/Scripts/Project-App.js")
                .Include("~/Assets/Scripts/Project-Controller.js")
                .Include("~/Assets/Scripts/Project-Services.js")
                );
            
            // **** VENDOR STYLES
            bundles.Add(new StyleBundle("~/Assets/Stylesheets/Vendor/Bootstrap")
                .IncludeDirectory("~/Assets/Stylesheets/Vendor/Bootstrap-3.2.0", "*.css"));

            // **** PROJECT STYLES
            bundles.Add(new StyleBundle("~/Assets/Stylesheets/Custom")
                .Include("~/Assets/Stylesheets/Stylesheet.css"));
        }
    }
}