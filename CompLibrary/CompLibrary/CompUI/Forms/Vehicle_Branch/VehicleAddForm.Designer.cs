
using System.Windows.Forms;

namespace CompUI
{
    partial class VehicleAddForm
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
            this.AbortButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.VehiclePicture = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveCategoryButton = new System.Windows.Forms.Button();
            this.ImageInfoLabel = new System.Windows.Forms.Label();
            this.DecorationPanelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AbortButton.Location = new System.Drawing.Point(697, 307);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 28;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InsertButton.Location = new System.Drawing.Point(16, 307);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(125, 40);
            this.InsertButton.TabIndex = 27;
            this.InsertButton.Text = "Add";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(410, 239);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(237, 38);
            this.CategoryComboBox.TabIndex = 25;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryLabel.Location = new System.Drawing.Point(270, 239);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(101, 30);
            this.CategoryLabel.TabIndex = 24;
            this.CategoryLabel.Text = "Category:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModelLabel.Location = new System.Drawing.Point(270, 159);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(77, 30);
            this.ModelLabel.TabIndex = 23;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ModelTextBox.Location = new System.Drawing.Point(410, 159);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(237, 35);
            this.ModelTextBox.TabIndex = 22;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BrandLabel.Location = new System.Drawing.Point(270, 79);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(72, 30);
            this.BrandLabel.TabIndex = 21;
            this.BrandLabel.Text = "Brand:";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.BrandTextBox.Location = new System.Drawing.Point(410, 79);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(237, 35);
            this.BrandTextBox.TabIndex = 20;
            // 
            // VehiclePicture
            // 
            this.VehiclePicture.Location = new System.Drawing.Point(16, 82);
            this.VehiclePicture.Name = "VehiclePicture";
            this.VehiclePicture.Size = new System.Drawing.Size(206, 187);
            this.VehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VehiclePicture.TabIndex = 15;
            this.VehiclePicture.TabStop = false;
            this.VehiclePicture.Click += new System.EventHandler(this.VehiclePicture_Click);
            this.VehiclePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.VehiclePicture_Paint);
            this.VehiclePicture.MouseLeave += new System.EventHandler(this.VehiclePicture_MouseLeave);
            this.VehiclePicture.MouseHover += new System.EventHandler(this.VehiclePicture_MouseHover);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(16, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(125, 30);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "New vehicle";
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MessagePanel.Location = new System.Drawing.Point(188, 307);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(459, 40);
            this.MessagePanel.TabIndex = 31;
            // 
            // RemoveCategoryButton
            // 
            this.RemoveCategoryButton.BackColor = System.Drawing.Color.LightCoral;
            this.RemoveCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.RemoveCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RemoveCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveCategoryButton.ForeColor = System.Drawing.Color.White;
            this.RemoveCategoryButton.Location = new System.Drawing.Point(673, 245);
            this.RemoveCategoryButton.Name = "RemoveCategoryButton";
            this.RemoveCategoryButton.Size = new System.Drawing.Size(90, 27);
            this.RemoveCategoryButton.TabIndex = 32;
            this.RemoveCategoryButton.Text = "Remove";
            this.RemoveCategoryButton.UseVisualStyleBackColor = false;
            this.RemoveCategoryButton.Click += new System.EventHandler(this.RemoveCategoryButton_Click);
            // 
            // ImageInfoLabel
            // 
            this.ImageInfoLabel.AutoSize = true;
            this.ImageInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageInfoLabel.Location = new System.Drawing.Point(36, 155);
            this.ImageInfoLabel.Name = "ImageInfoLabel";
            this.ImageInfoLabel.Size = new System.Drawing.Size(160, 42);
            this.ImageInfoLabel.TabIndex = 33;
            this.ImageInfoLabel.Text = "Click to paste \r\nimage from clipboard";
            this.ImageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImageInfoLabel.Click += new System.EventHandler(this.VehiclePicture_Click);
            this.ImageInfoLabel.MouseLeave += new System.EventHandler(this.VehiclePicture_MouseLeave);
            this.ImageInfoLabel.MouseHover += new System.EventHandler(this.VehiclePicture_MouseHover);
            // 
            // DecorationPanelTop
            // 
            this.DecorationPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.DecorationPanelTop.Location = new System.Drawing.Point(-2, -1);
            this.DecorationPanelTop.Name = "DecorationPanelTop";
            this.DecorationPanelTop.Size = new System.Drawing.Size(852, 25);
            this.DecorationPanelTop.TabIndex = 34;
            this.DecorationPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VehicleAddForm_MouseDown);
            // 
            // VehicleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.DecorationPanelTop);
            this.Controls.Add(this.ImageInfoLabel);
            this.Controls.Add(this.RemoveCategoryButton);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.VehiclePicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleAddForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VehicleAddForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.PictureBox VehiclePicture;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.FlowLayoutPanel MessagePanel;
        private System.Windows.Forms.Button RemoveCategoryButton;
        private System.Windows.Forms.Label ImageInfoLabel;
        private Panel DecorationPanelTop;
    }
}