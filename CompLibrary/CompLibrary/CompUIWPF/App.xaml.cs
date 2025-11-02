using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
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
            // Global exception handler
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            // Log process exit for debugging
            AppDomain.CurrentDomain.ProcessExit += (s, ev) =>
            {
                Debug.WriteLine("ProcessExit triggered.");
            };

            // Initializing DB and image connections
            GlobalConfig.InitializeDataConnections(true);
            GlobalConfig.InitializeImageConnections();

            try
            {
                GlobalData.InitializeLists();
            }
            catch
            {
                GlobalConfig.RestoreBackup();
                GlobalData.InitializeLists();
            }

            GlobalConfig.CreateBackup();

            // Create and show main window
            var main = new MainWindow();
            main.Show();

            base.OnStartup(e);
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"Unhandled exception: {e.Exception.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Debug.WriteLine("Application.OnExit called");

            // 1. Close all windows
            foreach (Window w in this.Windows.Cast<Window>().ToList())
            {
                if (w.IsVisible)
                {
                    Debug.WriteLine($"Closing window: {w.Title}");
                    w.Close();
                }
            }

            // 2. Force Dispatcher shutdown
            Dispatcher.CurrentDispatcher.BeginInvokeShutdown(DispatcherPriority.Background);

            base.OnExit(e);
        }

    }
}
