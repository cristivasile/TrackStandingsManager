
namespace CompUI.Forms
{
    partial class VehicleManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleManagerForm));
            this.VehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SortedByLabel = new System.Windows.Forms.Label();
            this.SortedByValueLabel = new System.Windows.Forms.Label();
            this.FilteredByValueLabel = new System.Windows.Forms.Label();
            this.FilteredByLabel = new System.Windows.Forms.Label();
            this.VehicleFlowPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPicturesCheck = new System.Windows.Forms.CheckBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FilterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AveragePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleFlowPanel
            // 
            this.VehicleFlowPanel.Location = new System.Drawing.Point(12, 133);
            this.VehicleFlowPanel.Name = "VehicleFlowPanel";
            this.VehicleFlowPanel.Size = new System.Drawing.Size(1347, 749);
            this.VehicleFlowPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(12, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(120, 30);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "Vehicles list";
            // 
            // SortedByLabel
            // 
            this.SortedByLabel.AutoSize = true;
            this.SortedByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortedByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortedByLabel.Location = new System.Drawing.Point(1039, 54);
            this.SortedByLabel.Name = "SortedByLabel";
            this.SortedByLabel.Size = new System.Drawing.Size(77, 21);
            this.SortedByLabel.TabIndex = 37;
            this.SortedByLabel.Text = "Sorted by";
            // 
            // SortedByValueLabel
            // 
            this.SortedByValueLabel.AutoSize = true;
            this.SortedByValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortedByValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortedByValueLabel.Location = new System.Drawing.Point(1113, 54);
            this.SortedByValueLabel.Name = "SortedByValueLabel";
            this.SortedByValueLabel.Size = new System.Drawing.Size(69, 21);
            this.SortedByValueLabel.TabIndex = 38;
            this.SortedByValueLabel.Text = "<value>";
            // 
            // FilteredByValueLabel
            // 
            this.FilteredByValueLabel.AutoSize = true;
            this.FilteredByValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilteredByValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilteredByValueLabel.Location = new System.Drawing.Point(915, 54);
            this.FilteredByValueLabel.Name = "FilteredByValueLabel";
            this.FilteredByValueLabel.Size = new System.Drawing.Size(69, 21);
            this.FilteredByValueLabel.TabIndex = 40;
            this.FilteredByValueLabel.Text = "<value>";
            // 
            // FilteredByLabel
            // 
            this.FilteredByLabel.AutoSize = true;
            this.FilteredByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilteredByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilteredByLabel.Location = new System.Drawing.Point(835, 54);
            this.FilteredByLabel.Name = "FilteredByLabel";
            this.FilteredByLabel.Size = new System.Drawing.Size(83, 21);
            this.FilteredByLabel.TabIndex = 39;
            this.FilteredByLabel.Text = "Filtered by";
            // 
            // VehicleFlowPanelHeader
            // 
            this.VehicleFlowPanelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.VehicleFlowPanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehicleFlowPanelHeader.Location = new System.Drawing.Point(12, 104);
            this.VehicleFlowPanelHeader.Name = "VehicleFlowPanelHeader";
            this.VehicleFlowPanelHeader.Size = new System.Drawing.Size(1347, 29);
            this.VehicleFlowPanelHeader.TabIndex = 1;
            // 
            // ShowPicturesCheck
            // 
            this.ShowPicturesCheck.AutoSize = true;
            this.ShowPicturesCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowPicturesCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowPicturesCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ShowPicturesCheck.Location = new System.Drawing.Point(47, 72);
            this.ShowPicturesCheck.Name = "ShowPicturesCheck";
            this.ShowPicturesCheck.Size = new System.Drawing.Size(125, 25);
            this.ShowPicturesCheck.TabIndex = 0;
            this.ShowPicturesCheck.Text = "show pictures";
            this.ShowPicturesCheck.UseVisualStyleBackColor = false;
            this.ShowPicturesCheck.CheckedChanged += new System.EventHandler(this.ShowPicturesCheck_CheckChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.InsertButton.Location = new System.Drawing.Point(1236, 50);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 32);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Add new";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterByToolStripMenuItem,
            this.SortByToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(9, 3);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(175, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FilterByToolStripMenuItem
            // 
            this.FilterByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrandToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.clearFiltersToolStripMenuItem});
            this.FilterByToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem";
            this.FilterByToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.FilterByToolStripMenuItem.Text = "Filter by";
            // 
            // BrandToolStripMenuItem
            // 
            this.BrandToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem";
            this.BrandToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.BrandToolStripMenuItem.Text = "Brand";
            this.BrandToolStripMenuItem.Click += new System.EventHandler(this.BrandToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CategoryToolStripMenuItem.Text = "Category";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // clearFiltersToolStripMenuItem
            // 
            this.clearFiltersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            this.clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearFiltersToolStripMenuItem.Text = "Clear filters";
            this.clearFiltersToolStripMenuItem.Click += new System.EventHandler(this.ClearFiltersToolStripMenuItem_Click);
            // 
            // SortByToolStripMenuItem
            // 
            this.SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AveragePositionToolStripMenuItem,
            this.NameToolStripMenuItem});
            this.SortByToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            this.SortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.SortByToolStripMenuItem.Text = "Sort by";
            // 
            // AveragePositionToolStripMenuItem
            // 
            this.AveragePositionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AveragePositionToolStripMenuItem.Name = "AveragePositionToolStripMenuItem";
            this.AveragePositionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.AveragePositionToolStripMenuItem.Text = "Average position";
            this.AveragePositionToolStripMenuItem.Click += new System.EventHandler(this.AveragePositionToolStripMenuItem_Click);
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.NameToolStripMenuItem.Text = "Name";
            this.NameToolStripMenuItem.Click += new System.EventHandler(this.NameToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ResetToolStripMenuItem.Text = "Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // VehicleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ShowPicturesCheck);
            this.Controls.Add(this.VehicleFlowPanelHeader);
            this.Controls.Add(this.FilteredByValueLabel);
            this.Controls.Add(this.FilteredByLabel);
            this.Controls.Add(this.SortedByValueLabel);
            this.Controls.Add(this.SortedByLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.VehicleFlowPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1371, 900);
            this.Name = "VehicleManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleViewerForm_FormClosed);
            this.Controls.SetChildIndex(this.VehicleFlowPanel, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.SortedByLabel, 0);
            this.Controls.SetChildIndex(this.SortedByValueLabel, 0);
            this.Controls.SetChildIndex(this.FilteredByLabel, 0);
            this.Controls.SetChildIndex(this.FilteredByValueLabel, 0);
            this.Controls.SetChildIndex(this.VehicleFlowPanelHeader, 0);
            this.Controls.SetChildIndex(this.ShowPicturesCheck, 0);
            this.Controls.SetChildIndex(this.InsertButton, 0);
            this.Controls.SetChildIndex(this.MenuStrip, 0);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel VehicleFlowPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SortedByLabel;
        private System.Windows.Forms.Label SortedByValueLabel;
        private System.Windows.Forms.Label FilteredByValueLabel;
        private System.Windows.Forms.Label FilteredByLabel;
        private System.Windows.Forms.FlowLayoutPanel VehicleFlowPanelHeader;
        private System.Windows.Forms.CheckBox ShowPicturesCheck;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FilterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AveragePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
    }
}