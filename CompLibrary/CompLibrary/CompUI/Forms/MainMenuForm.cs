﻿using CompUI.Forms;
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
            InitializeControls();
            //alerts the user that an error was encountered while trying to read from disk and a back-up was used.
            if (Program.ReadErrorEncountered)
            {
                ShowReadError();
                //user was alerted, reset read error
                Program.ReadErrorEncountered = false;
            }
        }

        private void InitializeControls()
        {
            this.MenuStrip.Width = this.Width;
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

        public static void ShowReadError()
        {
            MessageBox.Show("An error was encountered while trying to read from local storage, data was restored from last backup.", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BugsAndSuggestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For suggestions and bug reports please email TrackStandingsManager@gmail.com!");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.AboutFormInstance = new();
            Program.AboutFormInstance.Show();
        }
    }
}
