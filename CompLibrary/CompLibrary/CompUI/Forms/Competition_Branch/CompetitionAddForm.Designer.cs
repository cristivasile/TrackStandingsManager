
namespace CompUI.Forms.Competition_Branch
{
    partial class CompetitionAddForm
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TimingsTypeBox = new System.Windows.Forms.ComboBox();
            this.SortTypeLabel = new System.Windows.Forms.Label();
            this.DescendingButton = new System.Windows.Forms.RadioButton();
            this.AscendingButton = new System.Windows.Forms.RadioButton();
            this.MessagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AbortButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ImageInfoLabel = new System.Windows.Forms.Label();
            this.CompetitionPicture = new System.Windows.Forms.PictureBox();
            this.PointsButton = new System.Windows.Forms.RadioButton();
            this.TimingsButton = new System.Windows.Forms.RadioButton();
            this.ScoreRadioContainer = new System.Windows.Forms.Panel();
            this.SortRadioContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).BeginInit();
            this.ScoreRadioContainer.SuspendLayout();
            this.SortRadioContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(37, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(172, 30);
            this.TitleLabel.TabIndex = 39;
            this.TitleLabel.Text = "New competition";
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
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.DescriptionTextBox.Location = new System.Drawing.Point(431, 176);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PlaceholderText = "-optional-";
            this.DescriptionTextBox.Size = new System.Drawing.Size(237, 110);
            this.DescriptionTextBox.TabIndex = 33;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameLabel.Location = new System.Drawing.Point(291, 94);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 30);
            this.NameLabel.TabIndex = 32;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameTextBox.Location = new System.Drawing.Point(431, 88);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(237, 53);
            this.NameTextBox.TabIndex = 31;
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
            // 
            // TimingsTypeBox
            // 
            this.TimingsTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.TimingsTypeBox.Enabled = false;
            this.TimingsTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimingsTypeBox.ForeColor = System.Drawing.Color.SteelBlue;
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
            this.DescendingButton.Location = new System.Drawing.Point(9, 32);
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
            this.AscendingButton.Location = new System.Drawing.Point(9, 3);
            this.AscendingButton.Name = "AscendingButton";
            this.AscendingButton.Size = new System.Drawing.Size(90, 23);
            this.AscendingButton.TabIndex = 45;
            this.AscendingButton.TabStop = true;
            this.AscendingButton.Text = "Ascending";
            this.AscendingButton.UseVisualStyleBackColor = true;
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MessagePanel.Location = new System.Drawing.Point(277, 337);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(459, 40);
            this.MessagePanel.TabIndex = 60;
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AbortButton.Location = new System.Drawing.Point(37, 337);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 59;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.InsertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.InsertButton.Location = new System.Drawing.Point(836, 337);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(125, 40);
            this.InsertButton.TabIndex = 58;
            this.InsertButton.Text = "Add";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ImageInfoLabel
            // 
            this.ImageInfoLabel.AutoSize = true;
            this.ImageInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImageInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageInfoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ImageInfoLabel.Location = new System.Drawing.Point(64, 164);
            this.ImageInfoLabel.Name = "ImageInfoLabel";
            this.ImageInfoLabel.Size = new System.Drawing.Size(160, 42);
            this.ImageInfoLabel.TabIndex = 61;
            this.ImageInfoLabel.Text = "Click to paste \r\nimage from clipboard";
            this.ImageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImageInfoLabel.Click += new System.EventHandler(this.CompetitionPicture_Click);
            this.ImageInfoLabel.MouseLeave += new System.EventHandler(this.CompetitionPicture_MouseLeave);
            this.ImageInfoLabel.MouseHover += new System.EventHandler(this.CompetitionPicture_MouseHover);
            // 
            // CompetitionPicture
            // 
            this.CompetitionPicture.Location = new System.Drawing.Point(37, 88);
            this.CompetitionPicture.Name = "CompetitionPicture";
            this.CompetitionPicture.Size = new System.Drawing.Size(206, 198);
            this.CompetitionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CompetitionPicture.TabIndex = 62;
            this.CompetitionPicture.TabStop = false;
            this.CompetitionPicture.Click += new System.EventHandler(this.CompetitionPicture_Click);
            this.CompetitionPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.CompetitionPicture_Paint);
            this.CompetitionPicture.MouseLeave += new System.EventHandler(this.CompetitionPicture_MouseLeave);
            this.CompetitionPicture.MouseHover += new System.EventHandler(this.CompetitionPicture_MouseHover);
            // 
            // PointsButton
            // 
            this.PointsButton.AutoSize = true;
            this.PointsButton.Checked = true;
            this.PointsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PointsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PointsButton.Location = new System.Drawing.Point(9, 3);
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
            this.TimingsButton.Location = new System.Drawing.Point(9, 32);
            this.TimingsButton.Name = "TimingsButton";
            this.TimingsButton.Size = new System.Drawing.Size(74, 23);
            this.TimingsButton.TabIndex = 42;
            this.TimingsButton.Text = "Timings";
            this.TimingsButton.UseVisualStyleBackColor = true;
            this.TimingsButton.CheckedChanged += new System.EventHandler(this.TimingsButton_CheckedChanged);
            // 
            // ScoreRadioContainer
            // 
            this.ScoreRadioContainer.Controls.Add(this.PointsButton);
            this.ScoreRadioContainer.Controls.Add(this.TimingsButton);
            this.ScoreRadioContainer.Location = new System.Drawing.Point(711, 118);
            this.ScoreRadioContainer.Name = "ScoreRadioContainer";
            this.ScoreRadioContainer.Size = new System.Drawing.Size(101, 58);
            this.ScoreRadioContainer.TabIndex = 63;
            // 
            // SortRadioContainer
            // 
            this.SortRadioContainer.Controls.Add(this.AscendingButton);
            this.SortRadioContainer.Controls.Add(this.DescendingButton);
            this.SortRadioContainer.Location = new System.Drawing.Point(711, 209);
            this.SortRadioContainer.Name = "SortRadioContainer";
            this.SortRadioContainer.Size = new System.Drawing.Size(115, 58);
            this.SortRadioContainer.TabIndex = 64;
            // 
            // CompetitionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 389);
            this.Controls.Add(this.SortRadioContainer);
            this.Controls.Add(this.ScoreRadioContainer);
            this.Controls.Add(this.ImageInfoLabel);
            this.Controls.Add(this.CompetitionPicture);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.SortTypeLabel);
            this.Controls.Add(this.TimingsTypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CompetitionAddForm";
            this.Text = "New Competition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCompetitionForm_FormClosed);
            this.Controls.SetChildIndex(this.NameTextBox, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.DescriptionTextBox, 0);
            this.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.TypeLabel, 0);
            this.Controls.SetChildIndex(this.TimingsTypeBox, 0);
            this.Controls.SetChildIndex(this.SortTypeLabel, 0);
            this.Controls.SetChildIndex(this.InsertButton, 0);
            this.Controls.SetChildIndex(this.AbortButton, 0);
            this.Controls.SetChildIndex(this.MessagePanel, 0);
            this.Controls.SetChildIndex(this.CompetitionPicture, 0);
            this.Controls.SetChildIndex(this.ImageInfoLabel, 0);
            this.Controls.SetChildIndex(this.ScoreRadioContainer, 0);
            this.Controls.SetChildIndex(this.SortRadioContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionPicture)).EndInit();
            this.ScoreRadioContainer.ResumeLayout(false);
            this.ScoreRadioContainer.PerformLayout();
            this.SortRadioContainer.ResumeLayout(false);
            this.SortRadioContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TimingsTypeBox;
        private System.Windows.Forms.Label SortTypeLabel;
        private System.Windows.Forms.RadioButton DescendingButton;
        private System.Windows.Forms.RadioButton AscendingButton;
        private System.Windows.Forms.FlowLayoutPanel MessagePanel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label ImageInfoLabel;
        private System.Windows.Forms.PictureBox CompetitionPicture;
        private System.Windows.Forms.RadioButton PointsButton;
        private System.Windows.Forms.RadioButton TimingsButton;
        private System.Windows.Forms.Panel ScoreRadioContainer;
        private System.Windows.Forms.Panel SortRadioContainer;
    }
}