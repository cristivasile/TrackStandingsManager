
namespace CompUI.Forms.Competition_Branch
{
    partial class StandingsViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandingsViewerForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FilterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AveragePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectCompetitionLabel = new System.Windows.Forms.Label();
            this.CompetitionSelectBox = new System.Windows.Forms.ComboBox();
            this.SortTypeLabel = new System.Windows.Forms.Label();
            this.ScoreTypeLabel = new System.Windows.Forms.Label();
            this.CompetitionPicture = new System.Windows.Forms.PictureBox();
            this.DescriptionContainer = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTypeOutputLabel = new System.Windows.Forms.Label();
            this.SortedTypeOutputLabel = new System.Windows.Forms.Label();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).BeginInit();
            this.DescriptionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterByToolStripMenuItem,
            this.SortByToolStripMenuItem,
            this.ResetToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1371, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FilterByToolStripMenuItem
            // 
            this.FilterByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrandToolStripMenuItem,
            this.CategoryToolStripMenuItem});
            this.FilterByToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem";
            this.FilterByToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.FilterByToolStripMenuItem.Text = "Filter by";
            // 
            // BrandToolStripMenuItem
            // 
            this.BrandToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem";
            this.BrandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BrandToolStripMenuItem.Text = "Brand";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CategoryToolStripMenuItem.Text = "Category";
            // 
            // SortByToolStripMenuItem
            // 
            this.SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AveragePositionToolStripMenuItem,
            this.NameToolStripMenuItem});
            this.SortByToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            this.SortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.SortByToolStripMenuItem.Text = "Sort by";
            // 
            // AveragePositionToolStripMenuItem
            // 
            this.AveragePositionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AveragePositionToolStripMenuItem.Name = "AveragePositionToolStripMenuItem";
            this.AveragePositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AveragePositionToolStripMenuItem.Text = "Average position";
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NameToolStripMenuItem.Text = "Name";
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ResetToolStripMenuItem.Text = "Reset";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.DeleteToolStripMenuItem.Text = "Delete";
            // 
            // VehicleFlowPanel
            // 
            this.VehicleFlowPanel.Location = new System.Drawing.Point(12, 178);
            this.VehicleFlowPanel.Name = "VehicleFlowPanel";
            this.VehicleFlowPanel.Size = new System.Drawing.Size(1347, 703);
            this.VehicleFlowPanel.TabIndex = 3;
            // 
            // SelectCompetitionLabel
            // 
            this.SelectCompetitionLabel.AutoSize = true;
            this.SelectCompetitionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectCompetitionLabel.Location = new System.Drawing.Point(12, 34);
            this.SelectCompetitionLabel.Name = "SelectCompetitionLabel";
            this.SelectCompetitionLabel.Size = new System.Drawing.Size(193, 30);
            this.SelectCompetitionLabel.TabIndex = 30;
            this.SelectCompetitionLabel.Text = "Select Competition:";
            // 
            // CompetitionSelectBox
            // 
            this.CompetitionSelectBox.FormattingEnabled = true;
            this.CompetitionSelectBox.Location = new System.Drawing.Point(211, 31);
            this.CompetitionSelectBox.Name = "CompetitionSelectBox";
            this.CompetitionSelectBox.Size = new System.Drawing.Size(484, 38);
            this.CompetitionSelectBox.TabIndex = 31;
            // 
            // SortTypeLabel
            // 
            this.SortTypeLabel.AutoSize = true;
            this.SortTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortTypeLabel.Location = new System.Drawing.Point(966, 112);
            this.SortTypeLabel.Name = "SortTypeLabel";
            this.SortTypeLabel.Size = new System.Drawing.Size(69, 25);
            this.SortTypeLabel.TabIndex = 53;
            this.SortTypeLabel.Text = "Sorted:";
            this.SortTypeLabel.Click += new System.EventHandler(this.SortTypeLabel_Click);
            // 
            // ScoreTypeLabel
            // 
            this.ScoreTypeLabel.AutoSize = true;
            this.ScoreTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScoreTypeLabel.Location = new System.Drawing.Point(966, 60);
            this.ScoreTypeLabel.Name = "ScoreTypeLabel";
            this.ScoreTypeLabel.Size = new System.Drawing.Size(100, 25);
            this.ScoreTypeLabel.TabIndex = 51;
            this.ScoreTypeLabel.Text = "Score type:";
            // 
            // CompetitionPicture
            // 
            this.CompetitionPicture.Location = new System.Drawing.Point(1172, 27);
            this.CompetitionPicture.Name = "CompetitionPicture";
            this.CompetitionPicture.Size = new System.Drawing.Size(187, 141);
            this.CompetitionPicture.TabIndex = 46;
            this.CompetitionPicture.TabStop = false;
            // 
            // DescriptionContainer
            // 
            this.DescriptionContainer.Controls.Add(this.DescriptionTextBox);
            this.DescriptionContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DescriptionContainer.Location = new System.Drawing.Point(12, 75);
            this.DescriptionContainer.Name = "DescriptionContainer";
            this.DescriptionContainer.Size = new System.Drawing.Size(683, 97);
            this.DescriptionContainer.TabIndex = 55;
            this.DescriptionContainer.TabStop = false;
            this.DescriptionContainer.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(16, 28);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(656, 58);
            this.DescriptionTextBox.TabIndex = 0;
            // 
            // ScoreTypeOutputLabel
            // 
            this.ScoreTypeOutputLabel.AutoSize = true;
            this.ScoreTypeOutputLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreTypeOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScoreTypeOutputLabel.Location = new System.Drawing.Point(1072, 60);
            this.ScoreTypeOutputLabel.Name = "ScoreTypeOutputLabel";
            this.ScoreTypeOutputLabel.Size = new System.Drawing.Size(64, 25);
            this.ScoreTypeOutputLabel.TabIndex = 56;
            this.ScoreTypeOutputLabel.Text = "<null>";
            // 
            // SortedTypeOutputLabel
            // 
            this.SortedTypeOutputLabel.AutoSize = true;
            this.SortedTypeOutputLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortedTypeOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortedTypeOutputLabel.Location = new System.Drawing.Point(1072, 112);
            this.SortedTypeOutputLabel.Name = "SortedTypeOutputLabel";
            this.SortedTypeOutputLabel.Size = new System.Drawing.Size(64, 25);
            this.SortedTypeOutputLabel.TabIndex = 57;
            this.SortedTypeOutputLabel.Text = "<null>";
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEntryButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddEntryButton.Location = new System.Drawing.Point(782, 60);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(107, 62);
            this.AddEntryButton.TabIndex = 58;
            this.AddEntryButton.Text = "New\r\nEntry\r\n";
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // StandingsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.AddEntryButton);
            this.Controls.Add(this.SortedTypeOutputLabel);
            this.Controls.Add(this.ScoreTypeOutputLabel);
            this.Controls.Add(this.DescriptionContainer);
            this.Controls.Add(this.SortTypeLabel);
            this.Controls.Add(this.ScoreTypeLabel);
            this.Controls.Add(this.CompetitionPicture);
            this.Controls.Add(this.CompetitionSelectBox);
            this.Controls.Add(this.SelectCompetitionLabel);
            this.Controls.Add(this.VehicleFlowPanel);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StandingsViewerForm";
            this.Text = "Standings Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StandingsViewerForm_FormClosed);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).EndInit();
            this.DescriptionContainer.ResumeLayout(false);
            this.DescriptionContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FilterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AveragePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel VehicleFlowPanel;
        private System.Windows.Forms.Label SelectCompetitionLabel;
        private System.Windows.Forms.ComboBox CompetitionSelectBox;
        private System.Windows.Forms.Label SortTypeLabel;
        private System.Windows.Forms.Label ScoreTypeLabel;
        private System.Windows.Forms.PictureBox CompetitionPicture;
        private System.Windows.Forms.GroupBox DescriptionContainer;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label ScoreTypeOutputLabel;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label SortedTypeOutputLabel;
        private System.Windows.Forms.Button AddEntryButton;
    }
}