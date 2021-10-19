
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
            this.vehicleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.filterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averagePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleFlowPanel
            // 
            this.vehicleFlowPanel.Location = new System.Drawing.Point(12, 27);
            this.vehicleFlowPanel.Name = "vehicleFlowPanel";
            this.vehicleFlowPanel.Size = new System.Drawing.Size(1347, 861);
            this.vehicleFlowPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1371, 24);
            this.menuStrip.TabIndex = 1;
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
            this.filterByToolStripMenuItem.Click += new System.EventHandler(this.filterByToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // VehicleViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.vehicleFlowPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleViewerForm";
            this.Text = "Vehicle Viewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vehicleFlowPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem filterByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averagePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}