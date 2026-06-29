using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using Serilog;
namespace WebApplication3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //Get the file path of the log folder in WCF rest API
            var appRoot = HttpRuntime.AppDomainAppPath;
            var logFolder = Path.Combine(appRoot, "Logs");

            Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File(path: Path.Combine(logFolder, "log.txt"), rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss}] [{Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
            System.Diagnostics.Debug.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Root: {appRoot}");




            Log.Information("REST API Service Running");
            


        }

    }

}