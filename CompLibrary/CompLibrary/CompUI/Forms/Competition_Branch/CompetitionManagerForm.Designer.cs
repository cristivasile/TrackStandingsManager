
namespace CompUI.Forms.Competition_Branch
{
    partial class CompetitionManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionManagerForm));
            this.seeStandingsButton = new System.Windows.Forms.Button();
            this.addCompetitionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seeStandingsButton
            // 
            this.seeStandingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seeStandingsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.seeStandingsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seeStandingsButton.FlatAppearance.BorderSize = 0;
            this.seeStandingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.seeStandingsButton.Location = new System.Drawing.Point(344, 54);
            this.seeStandingsButton.Name = "seeStandingsButton";
            this.seeStandingsButton.Size = new System.Drawing.Size(230, 120);
            this.seeStandingsButton.TabIndex = 4;
            this.seeStandingsButton.Text = "See\r\nStandings\r\n";
            this.seeStandingsButton.UseVisualStyleBackColor = false;
            // 
            // addCompetitionButton
            // 
            this.addCompetitionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addCompetitionButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addCompetitionButton.FlatAppearance.BorderSize = 0;
            this.addCompetitionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCompetitionButton.Location = new System.Drawing.Point(27, 54);
            this.addCompetitionButton.Name = "addCompetitionButton";
            this.addCompetitionButton.Size = new System.Drawing.Size(230, 120);
            this.addCompetitionButton.TabIndex = 3;
            this.addCompetitionButton.Text = "Add\r\nCompetition";
            this.addCompetitionButton.UseVisualStyleBackColor = false;
            // 
            // CompetitionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 221);
            this.Controls.Add(this.seeStandingsButton);
            this.Controls.Add(this.addCompetitionButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CompetitionManagerForm";
            this.Text = "Competition Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seeStandingsButton;
        private System.Windows.Forms.Button addCompetitionButton;
    }
}