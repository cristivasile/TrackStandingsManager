
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
            this.SeeStandingsButton = new System.Windows.Forms.Button();
            this.AddCompetitionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeeStandingsButton
            // 
            this.SeeStandingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeStandingsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SeeStandingsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.SeeStandingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SeeStandingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeStandingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SeeStandingsButton.Location = new System.Drawing.Point(344, 54);
            this.SeeStandingsButton.Name = "SeeStandingsButton";
            this.SeeStandingsButton.Size = new System.Drawing.Size(230, 120);
            this.SeeStandingsButton.TabIndex = 4;
            this.SeeStandingsButton.Text = "See\r\nStandings\r\n";
            this.SeeStandingsButton.UseVisualStyleBackColor = false;
            this.SeeStandingsButton.Click += new System.EventHandler(this.SeeStandingsButton_Click);
            // 
            // AddCompetitionButton
            // 
            this.AddCompetitionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCompetitionButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddCompetitionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddCompetitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCompetitionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddCompetitionButton.Location = new System.Drawing.Point(27, 54);
            this.AddCompetitionButton.Name = "AddCompetitionButton";
            this.AddCompetitionButton.Size = new System.Drawing.Size(230, 120);
            this.AddCompetitionButton.TabIndex = 3;
            this.AddCompetitionButton.Text = "Add\r\nCompetition";
            this.AddCompetitionButton.UseVisualStyleBackColor = false;
            this.AddCompetitionButton.Click += new System.EventHandler(this.AddCompetitionButton_Click);
            // 
            // CompetitionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 221);
            this.Controls.Add(this.SeeStandingsButton);
            this.Controls.Add(this.AddCompetitionButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CompetitionManagerForm";
            this.Text = "Competition Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompetitionManagerForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeeStandingsButton;
        private System.Windows.Forms.Button AddCompetitionButton;
    }
}