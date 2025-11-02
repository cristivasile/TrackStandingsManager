using System.Configuration;
using System.Data;
using System.Windows;
using CompLibrary;

namespace CompUIWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // optional: global exception handlers
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            //Initializing DB Connection
            GlobalConfig.InitializeDataConnections(true);
            //Initializing image storage connection
            GlobalConfig.InitializeImageConnections();

            try
            {
                //Initializing List variables
                GlobalData.InitializeLists();
            }
            catch
            {
                GlobalConfig.RestoreBackup();
                GlobalData.InitializeLists();
            }

            // TODO - Recalculate the average positions for competitions on startup to avoid retarded issues.

            //If the program got to this point a data back-up is created
            GlobalConfig.CreateBackup();

            // Now create and show the first window (guaranteed to happen after init)
            var main = new MainWindow();
            main.Show();

            // Do NOT call base.OnStartup(e) after showing window (base doesn't auto-show when StartupUri absent).
            // but it's safe to call it before or after in most cases:
            base.OnStartup(e);
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            // handle/log exceptions, optionally set e.Handled = true;
            MessageBox.Show($"Unhandled exception: {e.Exception.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }

}
