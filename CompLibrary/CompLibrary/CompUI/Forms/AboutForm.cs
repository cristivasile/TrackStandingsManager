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
            AppPicture.Image = Properties.Resources.Icon;
            AppPicture.ResizeToFit();
            VersionLabel.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
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
