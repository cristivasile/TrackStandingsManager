
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleUpdateForm));
            this.ImageInfoLabel = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.VehiclePicture = new System.Windows.Forms.PictureBox();
            this.MiddleDividePanel = new System.Windows.Forms.Panel();
            this.DeleteVehicleButton = new System.Windows.Forms.Button();
            this.UndoChangesButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageInfoLabel
            // 
            this.ImageInfoLabel.AutoSize = true;
            this.ImageInfoLabel.BackColor = System.Drawing.Color.White;
            this.ImageInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageInfoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ImageInfoLabel.Location = new System.Drawing.Point(32, 153);
            this.ImageInfoLabel.Name = "ImageInfoLabel";
            this.ImageInfoLabel.Size = new System.Drawing.Size(160, 42);
            this.ImageInfoLabel.TabIndex = 47;
            this.ImageInfoLabel.Text = "Click to paste \r\nimage from clipboard";
            this.ImageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImageInfoLabel.Click += new System.EventHandler(this.VehiclePicture_Click);
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MessagePanel.Location = new System.Drawing.Point(184, 305);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(338, 40);
            this.MessagePanel.TabIndex = 46;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(12, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(247, 30);
            this.TitleLabel.TabIndex = 45;
            this.TitleLabel.Text = "Manage Existing Vehicles";
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AbortButton.Location = new System.Drawing.Point(12, 305);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 44;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.Location = new System.Drawing.Point(693, 305);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 40);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CategoryComboBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(406, 237);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(237, 38);
            this.CategoryComboBox.TabIndex = 42;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CategoryLabel.Location = new System.Drawing.Point(266, 237);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(101, 30);
            this.CategoryLabel.TabIndex = 41;
            this.CategoryLabel.Text = "Category:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModelLabel.Location = new System.Drawing.Point(266, 165);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(77, 30);
            this.ModelLabel.TabIndex = 40;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ModelTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.ModelTextBox.Location = new System.Drawing.Point(406, 162);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(237, 35);
            this.ModelTextBox.TabIndex = 39;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BrandLabel.Location = new System.Drawing.Point(266, 99);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(72, 30);
            this.BrandLabel.TabIndex = 38;
            this.BrandLabel.Text = "Brand:";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.BrandTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.BrandTextBox.Location = new System.Drawing.Point(406, 94);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(237, 35);
            this.BrandTextBox.TabIndex = 37;
            // 
            // VehiclePicture
            // 
            this.VehiclePicture.Location = new System.Drawing.Point(12, 80);
            this.VehiclePicture.Name = "VehiclePicture";
            this.VehiclePicture.Size = new System.Drawing.Size(206, 187);
            this.VehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VehiclePicture.TabIndex = 36;
            this.VehiclePicture.TabStop = false;
            this.VehiclePicture.Click += new System.EventHandler(this.VehiclePicture_Click);
            this.VehiclePicture.MouseLeave += new System.EventHandler(this.VehiclePicture_MouseLeave);
            this.VehiclePicture.MouseHover += new System.EventHandler(this.VehiclePicture_MouseHover);
            // 
            // MiddleDividePanel
            // 
            this.MiddleDividePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MiddleDividePanel.Location = new System.Drawing.Point(385, 92);
            this.MiddleDividePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddleDividePanel.Name = "MiddleDividePanel";
            this.MiddleDividePanel.Size = new System.Drawing.Size(2, 185);
            this.MiddleDividePanel.TabIndex = 48;
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteVehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.DeleteVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteVehicleButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteVehicleButton.ForeColor = System.Drawing.Color.White;
            this.DeleteVehicleButton.Location = new System.Drawing.Point(548, 305);
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.Size = new System.Drawing.Size(125, 40);
            this.DeleteVehicleButton.TabIndex = 52;
            this.DeleteVehicleButton.Text = "Delete vehicle";
            this.DeleteVehicleButton.UseVisualStyleBackColor = false;
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicleButton_Click);
            // 
            // UndoChangesButton
            // 
            this.UndoChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.UndoChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.UndoChangesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UndoChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoChangesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UndoChangesButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UndoChangesButton.Location = new System.Drawing.Point(704, 237);
            this.UndoChangesButton.Name = "UndoChangesButton";
            this.UndoChangesButton.Size = new System.Drawing.Size(108, 36);
            this.UndoChangesButton.TabIndex = 53;
            this.UndoChangesButton.Text = "Reset fields";
            this.UndoChangesButton.UseVisualStyleBackColor = false;
            this.UndoChangesButton.Click += new System.EventHandler(this.UndoChangesButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Location = new System.Drawing.Point(704, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(108, 36);
            this.SearchButton.TabIndex = 54;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VehicleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.VehicleComboBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(373, 33);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(310, 38);
            this.VehicleComboBox.TabIndex = 55;
            this.VehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.VehicleComboBox_SelectedIndexChanged);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectedLabel.Location = new System.Drawing.Point(271, 36);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(96, 30);
            this.SelectedLabel.TabIndex = 56;
            this.SelectedLabel.Text = "Selected:";
            // 
            // VehicleUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.VehicleComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UndoChangesButton);
            this.Controls.Add(this.DeleteVehicleButton);
            this.Controls.Add(this.MiddleDividePanel);
            this.Controls.Add(this.ImageInfoLabel);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.VehiclePicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Updater";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleUpdateForm_FormClosed);
            this.Controls.SetChildIndex(this.VehiclePicture, 0);
            this.Controls.SetChildIndex(this.BrandTextBox, 0);
            this.Controls.SetChildIndex(this.BrandLabel, 0);
            this.Controls.SetChildIndex(this.ModelTextBox, 0);
            this.Controls.SetChildIndex(this.ModelLabel, 0);
            this.Controls.SetChildIndex(this.CategoryLabel, 0);
            this.Controls.SetChildIndex(this.CategoryComboBox, 0);
            this.Controls.SetChildIndex(this.SaveButton, 0);
            this.Controls.SetChildIndex(this.AbortButton, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.MessagePanel, 0);
            this.Controls.SetChildIndex(this.ImageInfoLabel, 0);
            this.Controls.SetChildIndex(this.MiddleDividePanel, 0);
            this.Controls.SetChildIndex(this.DeleteVehicleButton, 0);
            this.Controls.SetChildIndex(this.UndoChangesButton, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.VehicleComboBox, 0);
            this.Controls.SetChildIndex(this.SelectedLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ImageInfoLabel;
        private System.Windows.Forms.FlowLayoutPanel MessagePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.PictureBox VehiclePicture;
        private System.Windows.Forms.Panel MiddleDividePanel;
        private System.Windows.Forms.Button DeleteVehicleButton;
        private System.Windows.Forms.Button UndoChangesButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox VehicleComboBox;
        private System.Windows.Forms.Label SelectedLabel;
    }
}