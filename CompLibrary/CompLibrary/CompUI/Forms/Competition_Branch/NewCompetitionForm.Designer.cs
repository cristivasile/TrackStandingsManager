
namespace CompUI.Forms.Competition_Branch
{
    partial class NewCompetitionForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CompetitionPicture = new System.Windows.Forms.PictureBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PointsButton = new System.Windows.Forms.RadioButton();
            this.TimingsButton = new System.Windows.Forms.RadioButton();
            this.TimingsTypeBox = new System.Windows.Forms.ComboBox();
            this.SortTypeLabel = new System.Windows.Forms.Label();
            this.DescendingButton = new System.Windows.Forms.RadioButton();
            this.AscendingButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(37, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(172, 30);
            this.TitleLabel.TabIndex = 39;
            this.TitleLabel.Text = "New competition";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AbortButton.Location = new System.Drawing.Point(37, 327);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 38;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateButton.Location = new System.Drawing.Point(827, 327);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(125, 40);
            this.UpdateButton.TabIndex = 37;
            this.UpdateButton.Text = "Add";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(291, 176);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(123, 30);
            this.DescriptionLabel.TabIndex = 34;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(431, 176);
            this.ModelTextBox.Multiline = true;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(237, 110);
            this.ModelTextBox.TabIndex = 33;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameLabel.Location = new System.Drawing.Point(291, 85);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 30);
            this.NameLabel.TabIndex = 32;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.BrandLabel_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(431, 85);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(237, 35);
            this.NameTextBox.TabIndex = 31;
            // 
            // CompetitionPicture
            // 
            this.CompetitionPicture.Location = new System.Drawing.Point(37, 88);
            this.CompetitionPicture.Name = "CompetitionPicture";
            this.CompetitionPicture.Size = new System.Drawing.Size(206, 198);
            this.CompetitionPicture.TabIndex = 30;
            this.CompetitionPicture.TabStop = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TypeLabel.Location = new System.Drawing.Point(711, 85);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(115, 30);
            this.TypeLabel.TabIndex = 40;
            this.TypeLabel.Text = "Score type:";
            this.TypeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PointsButton
            // 
            this.PointsButton.AutoSize = true;
            this.PointsButton.Checked = true;
            this.PointsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PointsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PointsButton.Location = new System.Drawing.Point(723, 118);
            this.PointsButton.Name = "PointsButton";
            this.PointsButton.Size = new System.Drawing.Size(64, 23);
            this.PointsButton.TabIndex = 41;
            this.PointsButton.TabStop = true;
            this.PointsButton.Text = "Points";
            this.PointsButton.UseVisualStyleBackColor = true;
            // 
            // TimingsButton
            // 
            this.TimingsButton.AutoSize = true;
            this.TimingsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TimingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimingsButton.Location = new System.Drawing.Point(723, 147);
            this.TimingsButton.Name = "TimingsButton";
            this.TimingsButton.Size = new System.Drawing.Size(74, 23);
            this.TimingsButton.TabIndex = 42;
            this.TimingsButton.Text = "Timings";
            this.TimingsButton.UseVisualStyleBackColor = true;
            // 
            // TimingsTypeBox
            // 
            this.TimingsTypeBox.Enabled = false;
            this.TimingsTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimingsTypeBox.FormattingEnabled = true;
            this.TimingsTypeBox.Location = new System.Drawing.Point(827, 147);
            this.TimingsTypeBox.Name = "TimingsTypeBox";
            this.TimingsTypeBox.Size = new System.Drawing.Size(134, 25);
            this.TimingsTypeBox.TabIndex = 43;
            this.TimingsTypeBox.Text = "Select time format";
            // 
            // SortTypeLabel
            // 
            this.SortTypeLabel.AutoSize = true;
            this.SortTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SortTypeLabel.Location = new System.Drawing.Point(711, 176);
            this.SortTypeLabel.Name = "SortTypeLabel";
            this.SortTypeLabel.Size = new System.Drawing.Size(55, 30);
            this.SortTypeLabel.TabIndex = 44;
            this.SortTypeLabel.Text = "Sort:";
            // 
            // DescendingButton
            // 
            this.DescendingButton.AutoSize = true;
            this.DescendingButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DescendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DescendingButton.Location = new System.Drawing.Point(723, 238);
            this.DescendingButton.Name = "DescendingButton";
            this.DescendingButton.Size = new System.Drawing.Size(98, 23);
            this.DescendingButton.TabIndex = 46;
            this.DescendingButton.Text = "Descending";
            this.DescendingButton.UseVisualStyleBackColor = true;
            // 
            // AscendingButton
            // 
            this.AscendingButton.AutoSize = true;
            this.AscendingButton.Checked = true;
            this.AscendingButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AscendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AscendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AscendingButton.Location = new System.Drawing.Point(723, 209);
            this.AscendingButton.Name = "AscendingButton";
            this.AscendingButton.Size = new System.Drawing.Size(90, 23);
            this.AscendingButton.TabIndex = 45;
            this.AscendingButton.TabStop = true;
            this.AscendingButton.Text = "Ascending";
            this.AscendingButton.UseVisualStyleBackColor = true;
            // 
            // NewCompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 389);
            this.Controls.Add(this.DescendingButton);
            this.Controls.Add(this.AscendingButton);
            this.Controls.Add(this.SortTypeLabel);
            this.Controls.Add(this.TimingsTypeBox);
            this.Controls.Add(this.TimingsButton);
            this.Controls.Add(this.PointsButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CompetitionPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NewCompetitionForm";
            this.Text = "New Competition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCompetitionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox CompetitionPicture;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.RadioButton PointsButton;
        private System.Windows.Forms.RadioButton TimingsButton;
        private System.Windows.Forms.ComboBox TimingsTypeBox;
        private System.Windows.Forms.Label SortTypeLabel;
        private System.Windows.Forms.RadioButton DescendingButton;
        private System.Windows.Forms.RadioButton AscendingButton;
    }
}