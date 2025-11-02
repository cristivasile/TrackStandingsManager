using System.Diagnostics;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Input;

namespace CompUIWPF.Common
{
 public partial class About : UserControl
 {
 public About()
 {
 InitializeComponent();
 var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0";
 // remove trailing .0 if present
 if (version.Length >2 && version.EndsWith(".0")) version = version[0..^2];
 VersionText.Text = "Version " + version;

 // set image if available in resources
 try
 {
 var res = System.Windows.Application.Current.TryFindResource("Icon") as System.Windows.Media.ImageSource;
 if (res != null) AppImage.Source = res;
 }
 catch { /* ignore */ }
 }

 private void GitHubButton_Click(object sender, System.Windows.RoutedEventArgs e)
 {
 var psi = new ProcessStartInfo
 {
 FileName = "https://github.com/cristivasile/TrackStandingsManager",
 UseShellExecute = true
 };
 Process.Start(psi);
 }
 }
}
