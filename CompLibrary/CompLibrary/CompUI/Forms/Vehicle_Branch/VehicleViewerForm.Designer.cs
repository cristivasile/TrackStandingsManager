
namespace CompUI.Forms
{
    partial class VehicleViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleViewerForm));
            this.VehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FilterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AveragePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleFlowPanel
            // 
            this.VehicleFlowPanel.Location = new System.Drawing.Point(12, 27);
            this.VehicleFlowPanel.Name = "VehicleFlowPanel";
            this.VehicleFlowPanel.Size = new System.Drawing.Size(1347, 861);
            this.VehicleFlowPanel.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterByToolStripMenuItem,
            this.SortByToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1371, 24);
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
            this.FilterByToolStripMenuItem.Click += new System.EventHandler(this.FilterByToolStripMenuItem_Click);
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
            // VehicleViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.VehicleFlowPanel);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleViewerForm";
            this.Text = "Vehicle Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleViewerForm_FormClosed);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
    }
}