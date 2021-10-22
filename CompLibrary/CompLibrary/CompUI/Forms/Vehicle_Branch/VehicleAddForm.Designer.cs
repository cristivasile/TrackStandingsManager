﻿
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
            this.abortButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.vehiclePicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.removeCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abortButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.abortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.abortButton.Location = new System.Drawing.Point(713, 299);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(125, 40);
            this.abortButton.TabIndex = 28;
            this.abortButton.Text = "Exit";
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insertButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.insertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.insertButton.Location = new System.Drawing.Point(32, 299);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(125, 40);
            this.insertButton.TabIndex = 27;
            this.insertButton.Text = "Add";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(426, 231);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(237, 38);
            this.categoryComboBox.TabIndex = 25;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryLabel.Location = new System.Drawing.Point(286, 231);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 30);
            this.categoryLabel.TabIndex = 24;
            this.categoryLabel.Text = "Category:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModelLabel.Location = new System.Drawing.Point(286, 151);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(77, 30);
            this.ModelLabel.TabIndex = 23;
            this.ModelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.modelTextBox.Location = new System.Drawing.Point(426, 151);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(237, 35);
            this.modelTextBox.TabIndex = 22;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brandLabel.Location = new System.Drawing.Point(286, 71);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(72, 30);
            this.brandLabel.TabIndex = 21;
            this.brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.brandTextBox.Location = new System.Drawing.Point(426, 71);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(237, 35);
            this.brandTextBox.TabIndex = 20;
            // 
            // vehiclePicture
            // 
            this.vehiclePicture.Location = new System.Drawing.Point(32, 74);
            this.vehiclePicture.Name = "vehiclePicture";
            this.vehiclePicture.Size = new System.Drawing.Size(206, 187);
            this.vehiclePicture.TabIndex = 15;
            this.vehiclePicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(32, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(125, 30);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "New vehicle";
            // 
            // messagePanel
            // 
            this.messagePanel.AutoScroll = true;
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.messagePanel.Location = new System.Drawing.Point(204, 299);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(459, 40);
            this.messagePanel.TabIndex = 31;
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.BackColor = System.Drawing.Color.LightCoral;
            this.removeCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.removeCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.removeCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeCategoryButton.ForeColor = System.Drawing.Color.White;
            this.removeCategoryButton.Location = new System.Drawing.Point(689, 237);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(90, 27);
            this.removeCategoryButton.TabIndex = 32;
            this.removeCategoryButton.Text = "Remove";
            this.removeCategoryButton.UseVisualStyleBackColor = false;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeCategoryButton_Click);
            // 
            // VehicleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 357);
            this.Controls.Add(this.removeCategoryButton);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.vehiclePicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleAddForm";
            this.Text = "New Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.PictureBox vehiclePicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel messagePanel;
        private System.Windows.Forms.Button removeCategoryButton;
    }
}