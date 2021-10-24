
namespace CompUI
{
    partial class VehicleUpdateForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.SelectVehicleLabel = new System.Windows.Forms.Label();
            this.VehicleSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.VehiclePicture = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteButton.Location = new System.Drawing.Point(684, 310);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 40);
            this.DeleteButton.TabIndex = 28;
            this.DeleteButton.Text = "Remove";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateButton.Location = new System.Drawing.Point(528, 310);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(125, 40);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Modify";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(425, 242);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(237, 38);
            this.CategoryComboBox.TabIndex = 25;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryLabel.Location = new System.Drawing.Point(285, 242);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(101, 30);
            this.CategoryLabel.TabIndex = 24;
            this.CategoryLabel.Text = "Category:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModelLabel.Location = new System.Drawing.Point(285, 162);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(77, 30);
            this.ModelLabel.TabIndex = 23;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(425, 162);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(237, 35);
            this.ModelTextBox.TabIndex = 22;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BrandLabel.Location = new System.Drawing.Point(285, 82);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(72, 30);
            this.BrandLabel.TabIndex = 21;
            this.BrandLabel.Text = "Brand:";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(425, 82);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(237, 35);
            this.BrandTextBox.TabIndex = 20;
            // 
            // SelectVehicleLabel
            // 
            this.SelectVehicleLabel.AutoSize = true;
            this.SelectVehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectVehicleLabel.Location = new System.Drawing.Point(425, 20);
            this.SelectVehicleLabel.Name = "SelectVehicleLabel";
            this.SelectVehicleLabel.Size = new System.Drawing.Size(143, 30);
            this.SelectVehicleLabel.TabIndex = 19;
            this.SelectVehicleLabel.Text = "Select vehicle:";
            this.SelectVehicleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleSelectionComboBox
            // 
            this.VehicleSelectionComboBox.FormattingEnabled = true;
            this.VehicleSelectionComboBox.Location = new System.Drawing.Point(574, 17);
            this.VehicleSelectionComboBox.Name = "VehicleSelectionComboBox";
            this.VehicleSelectionComboBox.Size = new System.Drawing.Size(237, 38);
            this.VehicleSelectionComboBox.TabIndex = 16;
            // 
            // VehiclePicture
            // 
            this.VehiclePicture.Location = new System.Drawing.Point(31, 90);
            this.VehiclePicture.Name = "VehiclePicture";
            this.VehiclePicture.Size = new System.Drawing.Size(206, 187);
            this.VehiclePicture.TabIndex = 15;
            this.VehiclePicture.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(31, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(245, 30);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "Manage existing vehicles";
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AbortButton.Location = new System.Drawing.Point(31, 310);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 26;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VehicleUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 368);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.SelectVehicleLabel);
            this.Controls.Add(this.VehicleSelectionComboBox);
            this.Controls.Add(this.VehiclePicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleUpdateForm";
            this.Text = "VehicleUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleUpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.VehicleUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label SelectVehicleLabel;
        private System.Windows.Forms.ComboBox VehicleSelectionComboBox;
        private System.Windows.Forms.PictureBox VehiclePicture;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AbortButton;
    }
}