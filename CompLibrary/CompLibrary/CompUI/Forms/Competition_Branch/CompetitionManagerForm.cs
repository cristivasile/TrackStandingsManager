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
    public partial class CompetitionManagerForm : TemplateFormResizable
    {
        public CompetitionManagerForm()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private void SortTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StandingsViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
            Program.MainMenuFormInstance.BringToFront();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            Program.EntryInsertFormInstance = new();
            Program.EntryInsertFormInstance.Show();
            this.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.NewCompetitionFormInstance = new(this);
            Program.NewCompetitionFormInstance.Show();
            this.Enabled = false;
        }

        private void ReloadForm()
        {
            //TODO - implement this
        }
    }
}
