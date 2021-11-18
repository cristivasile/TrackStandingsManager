using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI.Forms
{
    public partial class RandomChoiceForm : TemplateFormResizable
    {
        public RandomChoiceForm()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private void RandomChoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
        }
    }
}
