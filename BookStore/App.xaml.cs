using BookSearch.BL;
using BookSearch.Module;
using BookStore.DAL;
using BookStore.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Prism.Ioc;
using Prism.Modularity;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookStore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            await HandleExceptions();
            base.OnStartup(e);
        }

        private async Task HandleExceptions()
        {
            AppCenter.Configure("f2d9092f-b3ab-4cca-b46a-625c58adf0ad");
            AppCenter.LogLevel = LogLevel.Info;
            Crashes.NotifyUserConfirmation(UserConfirmation.AlwaysSend);
            await Crashes.SetEnabledAsync(true);
            if (AppCenter.Configured)
            {
                AppCenter.Start(typeof(Analytics));
                AppCenter.Start(typeof(Crashes));
            }
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {




            containerRegistry.RegisterSingleton<IBookSearchBL2, BookSearchBL2>();

            containerRegistry.RegisterSingleton<BooksDBContext>();
            containerRegistry.RegisterSingleton(typeof(Serilog.ILogger), (obj) =>
            {
                var log = new LoggerConfiguration()
                .WriteTo.File("log.txt")
                // .WriteTo.AppCenterSink(levelSwitch: new Serilog.Core.LoggingLevelSwitch(LogEventLevel.Verbose), LogEventLevel.Verbose, AppCenterTarget.ExceptionsAsCrashesAndEvents)
                .CreateLogger();

                return log;
            });
        }

        // not abstract
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<BookSearchModule>();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Crashes.TrackError(e.Exception);
            var logger = Container.Resolve<ILogger>();
            logger.Error(e.Exception, "Error From Log");
            logger.Information("Test Info");

            MessageBox.Show("Unexpected error occured. Please inform the admin." + Environment.NewLine, "Unexpected error");

            e.Handled = true;
        }
    }
}