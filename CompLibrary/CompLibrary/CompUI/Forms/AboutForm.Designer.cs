
namespace CompUI.Forms
{
    partial class AboutForm
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
            this.AppPicture = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GitHubImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AppPicture
            // 
            this.AppPicture.Location = new System.Drawing.Point(155, 35);
            this.AppPicture.Name = "AppPicture";
            this.AppPicture.Size = new System.Drawing.Size(50, 50);
            this.AppPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppPicture.TabIndex = 58;
            this.AppPicture.TabStop = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.VersionLabel.Location = new System.Drawing.Point(136, 129);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(88, 19);
            this.VersionLabel.TabIndex = 59;
            this.VersionLabel.Text = "Version 1.0.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(71, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Created by: Vasile George-Cristian";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GitHubImage
            // 
            this.GitHubImage.Image = global::CompUI.Properties.Resources.GitHub_Logo;
            this.GitHubImage.Location = new System.Drawing.Point(143, 90);
            this.GitHubImage.Margin = new System.Windows.Forms.Padding(0);
            this.GitHubImage.Name = "GitHubImage";
            this.GitHubImage.Size = new System.Drawing.Size(75, 30);
            this.GitHubImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GitHubImage.TabIndex = 61;
            this.GitHubImage.TabStop = false;
            this.GitHubImage.Click += new System.EventHandler(this.GitHubImage_Click);
            this.GitHubImage.MouseLeave += new System.EventHandler(this.GitHubImage_MouseLeave);
            this.GitHubImage.MouseHover += new System.EventHandler(this.GitHubImage_MouseHover);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 197);
            this.Controls.Add(this.GitHubImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AppPicture);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
            this.Controls.SetChildIndex(this.AppPicture, 0);
            this.Controls.SetChildIndex(this.VersionLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GitHubImage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AppPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AppPicture;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GitHubImage;
    }
}