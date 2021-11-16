
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FilterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AveragePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SortedByLabel = new System.Windows.Forms.Label();
            this.SortedByValueLabel = new System.Windows.Forms.Label();
            this.FilteredByValueLabel = new System.Windows.Forms.Label();
            this.FilteredByLabel = new System.Windows.Forms.Label();
            this.VehicleFlowPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPicturesCheck = new System.Windows.Forms.CheckBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleFlowPanel
            // 
            this.VehicleFlowPanel.Location = new System.Drawing.Point(12, 133);
            this.VehicleFlowPanel.Name = "VehicleFlowPanel";
            this.VehicleFlowPanel.Size = new System.Drawing.Size(1347, 749);
            this.VehicleFlowPanel.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterByToolStripMenuItem,
            this.SortByToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 1);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(172, 24);
            this.MenuStrip.TabIndex = 1;
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
            this.BrandToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.BrandToolStripMenuItem.Text = "Brand";
            this.BrandToolStripMenuItem.Click += new System.EventHandler(this.BrandToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.CategoryToolStripMenuItem.Text = "Category";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
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
            this.ResetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ResetToolStripMenuItem.Text = "Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1322, 4);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinimizeButton.Size = new System.Drawing.Size(22, 18);
            this.MinimizeButton.TabIndex = 36;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1346, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseButton.Size = new System.Drawing.Size(22, 18);
            this.CloseButton.TabIndex = 35;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.TopBarPanel.Controls.Add(this.MinimizeButton);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Controls.Add(this.MenuStrip);
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1371, 25);
            this.TopBarPanel.TabIndex = 35;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VehicleViewerForm_MouseDown);
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
            this.ShowPicturesCheck.TabIndex = 41;
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
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InsertButton.Location = new System.Drawing.Point(1236, 50);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 32);
            this.InsertButton.TabIndex = 42;
            this.InsertButton.Text = "Add new";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.BottomBorderPanel.Location = new System.Drawing.Point(0, 898);
            this.BottomBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(1371, 2);
            this.BottomBorderPanel.TabIndex = 45;
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.RightBorderPanel.Location = new System.Drawing.Point(1369, 0);
            this.RightBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(2, 900);
            this.RightBorderPanel.TabIndex = 44;
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(2, 900);
            this.LeftBorderPanel.TabIndex = 43;
            // 
            // VehicleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Controls.Add(this.LeftBorderPanel);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ShowPicturesCheck);
            this.Controls.Add(this.VehicleFlowPanelHeader);
            this.Controls.Add(this.FilteredByValueLabel);
            this.Controls.Add(this.FilteredByLabel);
            this.Controls.Add(this.SortedByValueLabel);
            this.Controls.Add(this.SortedByLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.VehicleFlowPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleManagerForm";
            this.Text = "Vehicle Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleViewerForm_FormClosed);
            this.Load += new System.EventHandler(this.VehicleManagerForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel VehicleFlowPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FilterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AveragePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SortedByLabel;
        private System.Windows.Forms.Label SortedByValueLabel;
        private System.Windows.Forms.Label FilteredByValueLabel;
        private System.Windows.Forms.Label FilteredByLabel;
        private System.Windows.Forms.FlowLayoutPanel VehicleFlowPanelHeader;
        private System.Windows.Forms.CheckBox ShowPicturesCheck;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Panel BottomBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Panel LeftBorderPanel;
    }
}