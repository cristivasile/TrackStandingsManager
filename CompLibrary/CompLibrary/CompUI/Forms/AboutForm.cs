using CompUI.Forms.Templates;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace CompUI.Forms
{
    public partial class AboutForm : TemplateFormNotResizable
    {
        public AboutForm()
        {
            InitializeComponent();
            InitializeBorder();
            InitializeControls();
        }

        private void InitializeControls()
        {
            string version = $"Version {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
            AppPicture.Image = Properties.Resources.Icon;
            AppPicture.ResizeToFit();
            //remove last 2 characters (.0) from version string
            VersionLabel.Text = version.Substring(0, version.Length - 2);
            GitHubImage.Image = Properties.Resources.GitHub_Logo;
        }

        private void AboutForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Enabled = true;
        }

        private void GitHubImage_Click(object sender, System.EventArgs e)
        {
            ProcessStartInfo GitLink = new ProcessStartInfo
            { 
              FileName = "https://github.com/cristivasile/TrackStandingsManager",
              UseShellExecute = true 
            };
            Process.Start(GitLink);
        }

        private void GitHubImage_MouseHover(object sender, System.EventArgs e)
        {
            GitHubImage.BackColor = Color.LightGray;
        }

        private void GitHubImage_MouseLeave(object sender, System.EventArgs e)
        {
            GitHubImage.BackColor = Color.White;
        }
    }
}
