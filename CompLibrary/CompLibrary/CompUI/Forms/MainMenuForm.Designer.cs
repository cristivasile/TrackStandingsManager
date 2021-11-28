
namespace CompUI
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.VehicleButton = new System.Windows.Forms.Button();
            this.GetRandomButton = new System.Windows.Forms.Button();
            this.CompetitionButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.bugsAndSuggestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleButton
            // 
            this.VehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.VehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.VehicleButton.FlatAppearance.BorderSize = 0;
            this.VehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.VehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.VehicleButton.Location = new System.Drawing.Point(51, 91);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(230, 120);
            this.VehicleButton.TabIndex = 0;
            this.VehicleButton.Text = "Vehicle\r\nManager";
            this.VehicleButton.UseVisualStyleBackColor = false;
            this.VehicleButton.Click += new System.EventHandler(this.VehicleButton_Click);
            // 
            // GetRandomButton
            // 
            this.GetRandomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetRandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.GetRandomButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.GetRandomButton.FlatAppearance.BorderSize = 0;
            this.GetRandomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.GetRandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetRandomButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.GetRandomButton.Location = new System.Drawing.Point(147, 285);
            this.GetRandomButton.Name = "GetRandomButton";
            this.GetRandomButton.Size = new System.Drawing.Size(337, 120);
            this.GetRandomButton.TabIndex = 2;
            this.GetRandomButton.Text = "What should I play?";
            this.GetRandomButton.UseVisualStyleBackColor = false;
            this.GetRandomButton.Click += new System.EventHandler(this.GetRandomButton_Click);
            // 
            // CompetitionButton
            // 
            this.CompetitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompetitionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CompetitionButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.CompetitionButton.FlatAppearance.BorderSize = 0;
            this.CompetitionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CompetitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompetitionButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.CompetitionButton.Location = new System.Drawing.Point(350, 91);
            this.CompetitionButton.Name = "CompetitionButton";
            this.CompetitionButton.Size = new System.Drawing.Size(230, 120);
            this.CompetitionButton.TabIndex = 3;
            this.CompetitionButton.Text = "Competition\r\nManager\r\n";
            this.CompetitionButton.UseVisualStyleBackColor = false;
            this.CompetitionButton.Click += new System.EventHandler(this.CompetitionButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugsAndSuggestionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(2, 4);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(195, 24);
            this.MenuStrip.TabIndex = 58;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // bugsAndSuggestionsToolStripMenuItem
            // 
            this.bugsAndSuggestionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bugsAndSuggestionsToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.bugsAndSuggestionsToolStripMenuItem.Name = "bugsAndSuggestionsToolStripMenuItem";
            this.bugsAndSuggestionsToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.bugsAndSuggestionsToolStripMenuItem.Text = "Bugs and Suggestions";
            this.bugsAndSuggestionsToolStripMenuItem.Click += new System.EventHandler(this.BugsAndSuggestionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 443);
            this.Controls.Add(this.CompetitionButton);
            this.Controls.Add(this.GetRandomButton);
            this.Controls.Add(this.VehicleButton);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(706, 512);
            this.MinimumSize = new System.Drawing.Size(609, 428);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Standings Manager";
            this.Controls.SetChildIndex(this.MenuStrip, 0);
            this.Controls.SetChildIndex(this.VehicleButton, 0);
            this.Controls.SetChildIndex(this.GetRandomButton, 0);
            this.Controls.SetChildIndex(this.CompetitionButton, 0);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VehicleButton;
        private System.Windows.Forms.Button GetRandomButton;
        private System.Windows.Forms.Button CompetitionButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bugsAndSuggestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

