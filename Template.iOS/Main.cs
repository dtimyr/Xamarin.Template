using System;
using System.Linq;
using System.Threading.Tasks;
using Template.Core.Interfaces;
using UIKit;
using Unity;

namespace Template.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                try
                {
                    var exception = (Exception)e?.ExceptionObject;
                    
                    var logService = DIContainer.Container.Resolve<ILogService>();
                    logService.LogException(exception, "Application.Main");
                }
                catch
                {
                    // ignored
                }
            };
            
            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                try
                {
                    var exception = e?.Exception.InnerExceptions.FirstOrDefault();
                    
                    var logService = DIContainer.Container.Resolve<ILogService>();
                    logService.LogException(exception, "Application.Main.Task");

                    e?.SetObserved();
                }
                catch
                {
                    // ignored
                }
            };
            
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
