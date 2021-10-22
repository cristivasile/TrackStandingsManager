
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.selectVehicleLabel = new System.Windows.Forms.Label();
            this.vehicleSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.vehiclePicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(684, 310);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 40);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateButton.Location = new System.Drawing.Point(528, 310);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 40);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Modify";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(425, 242);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(237, 38);
            this.categoryComboBox.TabIndex = 25;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryLabel.Location = new System.Drawing.Point(285, 242);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 30);
            this.categoryLabel.TabIndex = 24;
            this.categoryLabel.Text = "Category:";
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
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(425, 162);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(237, 35);
            this.modelTextBox.TabIndex = 22;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brandLabel.Location = new System.Drawing.Point(285, 82);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(72, 30);
            this.brandLabel.TabIndex = 21;
            this.brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(425, 82);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(237, 35);
            this.brandTextBox.TabIndex = 20;
            // 
            // selectVehicleLabel
            // 
            this.selectVehicleLabel.AutoSize = true;
            this.selectVehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectVehicleLabel.Location = new System.Drawing.Point(425, 20);
            this.selectVehicleLabel.Name = "selectVehicleLabel";
            this.selectVehicleLabel.Size = new System.Drawing.Size(143, 30);
            this.selectVehicleLabel.TabIndex = 19;
            this.selectVehicleLabel.Text = "Select vehicle:";
            this.selectVehicleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehicleSelectionComboBox
            // 
            this.vehicleSelectionComboBox.FormattingEnabled = true;
            this.vehicleSelectionComboBox.Location = new System.Drawing.Point(574, 17);
            this.vehicleSelectionComboBox.Name = "vehicleSelectionComboBox";
            this.vehicleSelectionComboBox.Size = new System.Drawing.Size(237, 38);
            this.vehicleSelectionComboBox.TabIndex = 16;
            // 
            // vehiclePicture
            // 
            this.vehiclePicture.Location = new System.Drawing.Point(31, 90);
            this.vehiclePicture.Name = "vehiclePicture";
            this.vehiclePicture.Size = new System.Drawing.Size(206, 187);
            this.vehiclePicture.TabIndex = 15;
            this.vehiclePicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(31, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 30);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "Manage existing vehicles";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelButton.Location = new System.Drawing.Point(31, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // VehicleUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 368);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.selectVehicleLabel);
            this.Controls.Add(this.vehicleSelectionComboBox);
            this.Controls.Add(this.vehiclePicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleUpdateForm";
            this.Text = "VehicleUpdateForm";
            this.Load += new System.EventHandler(this.VehicleUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label selectVehicleLabel;
        private System.Windows.Forms.ComboBox vehicleSelectionComboBox;
        private System.Windows.Forms.PictureBox vehiclePicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}