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
    public partial class EntryInsertForm : TemplateFormResizable
    {
        public EntryInsertForm()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private void BrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EntryInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CompetitionManagerFormInstance.Enabled = true;
            Program.CompetitionManagerFormInstance.BringToFront();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
