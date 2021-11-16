
namespace CompUI.Forms
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            this.AbortButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.TopBarPanel.Controls.Add(this.MinimizeButton);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(467, 25);
            this.TopBarPanel.TabIndex = 36;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilterForm_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(420, 4);
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
            this.CloseButton.Location = new System.Drawing.Point(442, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseButton.Size = new System.Drawing.Size(22, 18);
            this.CloseButton.TabIndex = 35;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Segoe UI", 15.86F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilterLabel.Location = new System.Drawing.Point(12, 35);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(146, 30);
            this.FilterLabel.TabIndex = 37;
            this.FilterLabel.Text = "<label value>";
            // 
            // FilterCheckedListBox
            // 
            this.FilterCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.FilterCheckedListBox.CheckOnClick = true;
            this.FilterCheckedListBox.FormattingEnabled = true;
            this.FilterCheckedListBox.Location = new System.Drawing.Point(40, 106);
            this.FilterCheckedListBox.Name = "FilterCheckedListBox";
            this.FilterCheckedListBox.Size = new System.Drawing.Size(383, 436);
            this.FilterCheckedListBox.Sorted = true;
            this.FilterCheckedListBox.TabIndex = 38;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MiddlePanel.Controls.Add(this.CheckAll);
            this.MiddlePanel.Location = new System.Drawing.Point(40, 78);
            this.MiddlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(383, 28);
            this.MiddlePanel.TabIndex = 39;
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Checked = true;
            this.CheckAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAll.ForeColor = System.Drawing.Color.White;
            this.CheckAll.Location = new System.Drawing.Point(3, 6);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(38, 19);
            this.CheckAll.TabIndex = 40;
            this.CheckAll.Text = "all";
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AbortButton.Location = new System.Drawing.Point(12, 551);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(111, 29);
            this.AbortButton.TabIndex = 40;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.FilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.FilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.FilterButton.Location = new System.Drawing.Point(344, 551);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(111, 29);
            this.FilterButton.TabIndex = 41;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(2, 592);
            this.LeftBorderPanel.TabIndex = 42;
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.RightBorderPanel.Location = new System.Drawing.Point(465, 0);
            this.RightBorderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(2, 592);
            this.RightBorderPanel.TabIndex = 43;
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.BottomBorderPanel.Location = new System.Drawing.Point(0, 590);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(465, 2);
            this.BottomBorderPanel.TabIndex = 52;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 592);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Controls.Add(this.LeftBorderPanel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.FilterCheckedListBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.TopBarPanel.ResumeLayout(false);
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.CheckedListBox FilterCheckedListBox;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.CheckBox CheckAll;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Panel LeftBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Panel BottomBorderPanel;
    }
}