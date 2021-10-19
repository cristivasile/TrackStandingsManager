
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.filterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averagePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectCompetitionLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortTypeLabel = new System.Windows.Forms.Label();
            this.scoreTypeLabel = new System.Windows.Forms.Label();
            this.competitionPicture = new System.Windows.Forms.PictureBox();
            this.descriptionContainer = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.scoreTypeOutputLabel = new System.Windows.Forms.Label();
            this.sortedTypeOutputLabel = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionPicture)).BeginInit();
            this.descriptionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1371, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // filterByToolStripMenuItem
            // 
            this.filterByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.filterByToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
            this.filterByToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterByToolStripMenuItem.Text = "Filter by";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averagePositionToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.sortByToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // averagePositionToolStripMenuItem
            // 
            this.averagePositionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.averagePositionToolStripMenuItem.Name = "averagePositionToolStripMenuItem";
            this.averagePositionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.averagePositionToolStripMenuItem.Text = "Average position";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // vehicleFlowPanel
            // 
            this.vehicleFlowPanel.Location = new System.Drawing.Point(12, 178);
            this.vehicleFlowPanel.Name = "vehicleFlowPanel";
            this.vehicleFlowPanel.Size = new System.Drawing.Size(1347, 703);
            this.vehicleFlowPanel.TabIndex = 3;
            // 
            // selectCompetitionLabel
            // 
            this.selectCompetitionLabel.AutoSize = true;
            this.selectCompetitionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectCompetitionLabel.Location = new System.Drawing.Point(12, 34);
            this.selectCompetitionLabel.Name = "selectCompetitionLabel";
            this.selectCompetitionLabel.Size = new System.Drawing.Size(193, 30);
            this.selectCompetitionLabel.TabIndex = 30;
            this.selectCompetitionLabel.Text = "Select Competition:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(484, 38);
            this.comboBox1.TabIndex = 31;
            // 
            // sortTypeLabel
            // 
            this.sortTypeLabel.AutoSize = true;
            this.sortTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortTypeLabel.Location = new System.Drawing.Point(966, 112);
            this.sortTypeLabel.Name = "sortTypeLabel";
            this.sortTypeLabel.Size = new System.Drawing.Size(69, 25);
            this.sortTypeLabel.TabIndex = 53;
            this.sortTypeLabel.Text = "Sorted:";
            this.sortTypeLabel.Click += new System.EventHandler(this.sortTypeLabel_Click);
            // 
            // scoreTypeLabel
            // 
            this.scoreTypeLabel.AutoSize = true;
            this.scoreTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scoreTypeLabel.Location = new System.Drawing.Point(966, 60);
            this.scoreTypeLabel.Name = "scoreTypeLabel";
            this.scoreTypeLabel.Size = new System.Drawing.Size(100, 25);
            this.scoreTypeLabel.TabIndex = 51;
            this.scoreTypeLabel.Text = "Score type:";
            // 
            // competitionPicture
            // 
            this.competitionPicture.Location = new System.Drawing.Point(1172, 27);
            this.competitionPicture.Name = "competitionPicture";
            this.competitionPicture.Size = new System.Drawing.Size(187, 141);
            this.competitionPicture.TabIndex = 46;
            this.competitionPicture.TabStop = false;
            // 
            // descriptionContainer
            // 
            this.descriptionContainer.Controls.Add(this.descriptionTextBox);
            this.descriptionContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.descriptionContainer.Location = new System.Drawing.Point(12, 75);
            this.descriptionContainer.Name = "descriptionContainer";
            this.descriptionContainer.Size = new System.Drawing.Size(683, 97);
            this.descriptionContainer.TabIndex = 55;
            this.descriptionContainer.TabStop = false;
            this.descriptionContainer.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 28);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(656, 58);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // scoreTypeOutputLabel
            // 
            this.scoreTypeOutputLabel.AutoSize = true;
            this.scoreTypeOutputLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTypeOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scoreTypeOutputLabel.Location = new System.Drawing.Point(1072, 60);
            this.scoreTypeOutputLabel.Name = "scoreTypeOutputLabel";
            this.scoreTypeOutputLabel.Size = new System.Drawing.Size(64, 25);
            this.scoreTypeOutputLabel.TabIndex = 56;
            this.scoreTypeOutputLabel.Text = "<null>";
            // 
            // sortedTypeOutputLabel
            // 
            this.sortedTypeOutputLabel.AutoSize = true;
            this.sortedTypeOutputLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortedTypeOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortedTypeOutputLabel.Location = new System.Drawing.Point(1072, 112);
            this.sortedTypeOutputLabel.Name = "sortedTypeOutputLabel";
            this.sortedTypeOutputLabel.Size = new System.Drawing.Size(64, 25);
            this.sortedTypeOutputLabel.TabIndex = 57;
            this.sortedTypeOutputLabel.Text = "<null>";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // StandingsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.sortedTypeOutputLabel);
            this.Controls.Add(this.scoreTypeOutputLabel);
            this.Controls.Add(this.descriptionContainer);
            this.Controls.Add(this.sortTypeLabel);
            this.Controls.Add(this.scoreTypeLabel);
            this.Controls.Add(this.competitionPicture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectCompetitionLabel);
            this.Controls.Add(this.vehicleFlowPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StandingsViewerForm";
            this.Text = "Standings Viewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionPicture)).EndInit();
            this.descriptionContainer.ResumeLayout(false);
            this.descriptionContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem filterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averagePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel vehicleFlowPanel;
        private System.Windows.Forms.Label selectCompetitionLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label sortTypeLabel;
        private System.Windows.Forms.Label scoreTypeLabel;
        private System.Windows.Forms.PictureBox competitionPicture;
        private System.Windows.Forms.GroupBox descriptionContainer;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label scoreTypeOutputLabel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label sortedTypeOutputLabel;
    }
}