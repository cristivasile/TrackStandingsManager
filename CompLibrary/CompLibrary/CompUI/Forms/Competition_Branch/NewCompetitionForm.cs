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
    public partial class NewCompetitionForm : TemplateForm
    {
        private Form parent;
        public NewCompetitionForm(Form sender)
        {
            parent = sender;
            InitializeComponent();
            InitializeBorder();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NewCompetitionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CompetitionManagerFormInstance.Enabled = true;
            Program.CompetitionManagerFormInstance.BringToFront();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            parent.BringToFront();
            this.Close();
        }
    }
}
