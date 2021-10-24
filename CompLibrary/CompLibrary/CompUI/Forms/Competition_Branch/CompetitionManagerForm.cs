using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI.Forms.Competition_Branch
{
    public partial class CompetitionManagerForm : Form
    {
        public CompetitionManagerForm()
        {
            InitializeComponent();
        }

        private void CompetitionManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
        }

        private void AddCompetitionButton_Click(object sender, EventArgs e)
        {
            Program.NewCompetitionFormInstance = new();
            Program.NewCompetitionFormInstance.Show();
            this.Enabled = false;
        }

        private void SeeStandingsButton_Click(object sender, EventArgs e)
        {
            Program.StandingsViewerFormInstance = new();
            Program.StandingsViewerFormInstance.Show();
            this.Hide();
        }
    }
}
