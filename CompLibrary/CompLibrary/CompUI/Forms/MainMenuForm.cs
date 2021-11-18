using CompUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    public partial class MainMenuForm : TemplateFormResizable
    {
        public MainMenuForm()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private void VehicleButton_Click(object sender, EventArgs e)
        {
            Program.VehicleManagerFormInstance = new();
            Program.VehicleManagerFormInstance.Show();
            this.Hide();
        }

        private void GetRandomButton_Click(object sender, EventArgs e)
        {
            Program.RandomChoiceFormInstance = new();
            Program.RandomChoiceFormInstance.Show();
            this.Hide();
        }

        private void CompetitionButton_Click(object sender, EventArgs e)
        {
            Program.CompetitionManagerFormInstance = new();
            Program.CompetitionManagerFormInstance.Show();
            this.Hide();
        }
    }
}
