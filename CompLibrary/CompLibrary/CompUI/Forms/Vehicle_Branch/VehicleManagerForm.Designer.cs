
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
            VehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            TitleLabel = new System.Windows.Forms.Label();
            SortedByLabel = new System.Windows.Forms.Label();
            SortedByValueLabel = new System.Windows.Forms.Label();
            FilteredByValueLabel = new System.Windows.Forms.Label();
            FilteredByLabel = new System.Windows.Forms.Label();
            VehicleFlowPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            ShowPicturesCheck = new System.Windows.Forms.CheckBox();
            InsertButton = new System.Windows.Forms.Button();
            MenuStrip = new System.Windows.Forms.MenuStrip();
            FilterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AveragePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // VehicleFlowPanel
            // 
            VehicleFlowPanel.Location = new System.Drawing.Point(12, 133);
            VehicleFlowPanel.Name = "VehicleFlowPanel";
            VehicleFlowPanel.Size = new System.Drawing.Size(1347, 749);
            VehicleFlowPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            TitleLabel.Location = new System.Drawing.Point(12, 39);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(237, 57);
            TitleLabel.TabIndex = 36;
            TitleLabel.Text = "Vehicles list";
            // 
            // SortedByLabel
            // 
            SortedByLabel.AutoSize = true;
            SortedByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SortedByLabel.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            SortedByLabel.Location = new System.Drawing.Point(1039, 54);
            SortedByLabel.Name = "SortedByLabel";
            SortedByLabel.Size = new System.Drawing.Size(157, 45);
            SortedByLabel.TabIndex = 37;
            SortedByLabel.Text = "Sorted by";
            // 
            // SortedByValueLabel
            // 
            SortedByValueLabel.AutoSize = true;
            SortedByValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SortedByValueLabel.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            SortedByValueLabel.Location = new System.Drawing.Point(1113, 54);
            SortedByValueLabel.Name = "SortedByValueLabel";
            SortedByValueLabel.Size = new System.Drawing.Size(138, 45);
            SortedByValueLabel.TabIndex = 38;
            SortedByValueLabel.Text = "<value>";
            // 
            // FilteredByValueLabel
            // 
            FilteredByValueLabel.AutoSize = true;
            FilteredByValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FilteredByValueLabel.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            FilteredByValueLabel.Location = new System.Drawing.Point(915, 54);
            FilteredByValueLabel.Name = "FilteredByValueLabel";
            FilteredByValueLabel.Size = new System.Drawing.Size(138, 45);
            FilteredByValueLabel.TabIndex = 40;
            FilteredByValueLabel.Text = "<value>";
            // 
            // FilteredByLabel
            // 
            FilteredByLabel.AutoSize = true;
            FilteredByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FilteredByLabel.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            FilteredByLabel.Location = new System.Drawing.Point(835, 54);
            FilteredByLabel.Name = "FilteredByLabel";
            FilteredByLabel.Size = new System.Drawing.Size(170, 45);
            FilteredByLabel.TabIndex = 39;
            FilteredByLabel.Text = "Filtered by";
            // 
            // VehicleFlowPanelHeader
            // 
            VehicleFlowPanelHeader.BackColor = System.Drawing.Color.SteelBlue;
            VehicleFlowPanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            VehicleFlowPanelHeader.Location = new System.Drawing.Point(12, 104);
            VehicleFlowPanelHeader.Name = "VehicleFlowPanelHeader";
            VehicleFlowPanelHeader.Size = new System.Drawing.Size(1347, 29);
            VehicleFlowPanelHeader.TabIndex = 1;
            // 
            // ShowPicturesCheck
            // 
            ShowPicturesCheck.AutoSize = true;
            ShowPicturesCheck.BackColor = System.Drawing.Color.Transparent;
            ShowPicturesCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ShowPicturesCheck.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            ShowPicturesCheck.Location = new System.Drawing.Point(47, 72);
            ShowPicturesCheck.Name = "ShowPicturesCheck";
            ShowPicturesCheck.Size = new System.Drawing.Size(248, 49);
            ShowPicturesCheck.TabIndex = 0;
            ShowPicturesCheck.Text = "show pictures";
            ShowPicturesCheck.UseVisualStyleBackColor = false;
            ShowPicturesCheck.CheckedChanged += ShowPicturesCheck_CheckChanged;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = System.Drawing.Color.FromArgb(228, 246, 255);
            InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(228, 246, 255);
            InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            InsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InsertButton.ForeColor = System.Drawing.Color.SteelBlue;
            InsertButton.Location = new System.Drawing.Point(1236, 50);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new System.Drawing.Size(108, 32);
            InsertButton.TabIndex = 1;
            InsertButton.Text = "Add new";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.AutoSize = false;
            MenuStrip.BackColor = System.Drawing.Color.FromArgb(228, 246, 255);
            MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FilterByToolStripMenuItem, SortByToolStripMenuItem, ResetToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2 });
            MenuStrip.Location = new System.Drawing.Point(9, 3);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new System.Drawing.Size(175, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // FilterByToolStripMenuItem
            // 
            FilterByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { BrandToolStripMenuItem, CategoryToolStripMenuItem, clearFiltersToolStripMenuItem });
            FilterByToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem";
            FilterByToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            FilterByToolStripMenuItem.Text = "Filter by";
            // 
            // BrandToolStripMenuItem
            // 
            BrandToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            BrandToolStripMenuItem.Name = "BrandToolStripMenuItem";
            BrandToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            BrandToolStripMenuItem.Text = "Brand";
            BrandToolStripMenuItem.Click += BrandToolStripMenuItem_Click;
            // 
            // CategoryToolStripMenuItem
            // 
            CategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            CategoryToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            CategoryToolStripMenuItem.Text = "Category";
            CategoryToolStripMenuItem.Click += CategoryToolStripMenuItem_Click;
            // 
            // clearFiltersToolStripMenuItem
            // 
            clearFiltersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            clearFiltersToolStripMenuItem.Text = "Clear filters";
            clearFiltersToolStripMenuItem.Click += ClearFiltersToolStripMenuItem_Click;
            // 
            // SortByToolStripMenuItem
            // 
            SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AveragePositionToolStripMenuItem, NameToolStripMenuItem });
            SortByToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            SortByToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            SortByToolStripMenuItem.Text = "Sort by";
            // 
            // AveragePositionToolStripMenuItem
            // 
            AveragePositionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            AveragePositionToolStripMenuItem.Name = "AveragePositionToolStripMenuItem";
            AveragePositionToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            AveragePositionToolStripMenuItem.Text = "Average position";
            AveragePositionToolStripMenuItem.Click += AveragePositionToolStripMenuItem_Click;
            // 
            // NameToolStripMenuItem
            // 
            NameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(1, 128, 255);
            NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            NameToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            NameToolStripMenuItem.Text = "Name";
            NameToolStripMenuItem.Click += NameToolStripMenuItem_Click;
            // 
            // ResetToolStripMenuItem
            // 
            ResetToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            ResetToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            ResetToolStripMenuItem.Text = "Reset";
            ResetToolStripMenuItem.Click += ResetToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(20, 20);
            // 
            // VehicleManagerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(23F, 57F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1371, 900);
            Controls.Add(MenuStrip);
            Controls.Add(InsertButton);
            Controls.Add(ShowPicturesCheck);
            Controls.Add(VehicleFlowPanelHeader);
            Controls.Add(FilteredByValueLabel);
            Controls.Add(FilteredByLabel);
            Controls.Add(SortedByValueLabel);
            Controls.Add(SortedByLabel);
            Controls.Add(TitleLabel);
            Controls.Add(VehicleFlowPanel);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MinimumSize = new System.Drawing.Size(1371, 900);
            Name = "VehicleManagerForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vehicle Viewer";
            FormClosed += VehicleViewerForm_FormClosed;
            Controls.SetChildIndex(VehicleFlowPanel, 0);
            Controls.SetChildIndex(TitleLabel, 0);
            Controls.SetChildIndex(SortedByLabel, 0);
            Controls.SetChildIndex(SortedByValueLabel, 0);
            Controls.SetChildIndex(FilteredByLabel, 0);
            Controls.SetChildIndex(FilteredByValueLabel, 0);
            Controls.SetChildIndex(VehicleFlowPanelHeader, 0);
            Controls.SetChildIndex(ShowPicturesCheck, 0);
            Controls.SetChildIndex(InsertButton, 0);
            Controls.SetChildIndex(MenuStrip, 0);
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}