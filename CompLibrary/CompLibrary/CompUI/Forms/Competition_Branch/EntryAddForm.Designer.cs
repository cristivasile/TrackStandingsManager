
namespace CompUI.Forms.Competition_Branch
{
    partial class EntryAddForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.VehicleLabel = new System.Windows.Forms.Label();
            this.ScoringLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.CurrentCompetitionLabel = new System.Windows.Forms.Label();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.TimeFormatLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.VehiclePicture = new System.Windows.Forms.PictureBox();
            this.VehicleAddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(30, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(131, 30);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "New entry in";
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AbortButton.FlatAppearance.BorderSize = 0;
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AbortButton.Location = new System.Drawing.Point(30, 284);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 35;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddButton.Location = new System.Drawing.Point(598, 284);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 40);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // VehicleLabel
            // 
            this.VehicleLabel.AutoSize = true;
            this.VehicleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.VehicleLabel.Location = new System.Drawing.Point(46, 90);
            this.VehicleLabel.Name = "VehicleLabel";
            this.VehicleLabel.Size = new System.Drawing.Size(73, 25);
            this.VehicleLabel.TabIndex = 33;
            this.VehicleLabel.Text = "Vehicle";
            // 
            // ScoringLabel
            // 
            this.ScoringLabel.AutoSize = true;
            this.ScoringLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoringLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScoringLabel.Location = new System.Drawing.Point(46, 201);
            this.ScoringLabel.Name = "ScoringLabel";
            this.ScoringLabel.Size = new System.Drawing.Size(111, 25);
            this.ScoringLabel.TabIndex = 31;
            this.ScoringLabel.Text = "Time/Points";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.ScoreTextBox.Location = new System.Drawing.Point(172, 198);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(237, 32);
            this.ScoreTextBox.TabIndex = 30;
            this.ScoreTextBox.TextChanged += new System.EventHandler(this.BrandTextBox_TextChanged);
            // 
            // CurrentCompetitionLabel
            // 
            this.CurrentCompetitionLabel.AutoSize = true;
            this.CurrentCompetitionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CurrentCompetitionLabel.Location = new System.Drawing.Point(163, 35);
            this.CurrentCompetitionLabel.Name = "CurrentCompetitionLabel";
            this.CurrentCompetitionLabel.Size = new System.Drawing.Size(75, 30);
            this.CurrentCompetitionLabel.TabIndex = 37;
            this.CurrentCompetitionLabel.Text = "<null>";
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleComboBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(172, 87);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(237, 33);
            this.VehicleComboBox.TabIndex = 40;
            this.VehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.VehicleComboBox_SelectedIndexChanged);
            this.VehicleComboBox.LostFocus += new System.EventHandler(this.VehicleComboBox_LostFocus);
            // 
            // TimeFormatLabel
            // 
            this.TimeFormatLabel.AutoSize = true;
            this.TimeFormatLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeFormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TimeFormatLabel.Location = new System.Drawing.Point(426, 201);
            this.TimeFormatLabel.Name = "TimeFormatLabel";
            this.TimeFormatLabel.Size = new System.Drawing.Size(138, 25);
            this.TimeFormatLabel.TabIndex = 58;
            this.TimeFormatLabel.Text = "<TimeFormat>";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AuthorLabel.Location = new System.Drawing.Point(46, 144);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(70, 25);
            this.AuthorLabel.TabIndex = 59;
            this.AuthorLabel.Text = "Author";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.AuthorTextBox.Location = new System.Drawing.Point(172, 144);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.PlaceholderText = "-optional-";
            this.AuthorTextBox.Size = new System.Drawing.Size(237, 32);
            this.AuthorTextBox.TabIndex = 61;
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MessagePanel.Location = new System.Drawing.Point(172, 284);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(409, 40);
            this.MessagePanel.TabIndex = 62;
            // 
            // VehiclePicture
            // 
            this.VehiclePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VehiclePicture.Location = new System.Drawing.Point(585, 44);
            this.VehiclePicture.Margin = new System.Windows.Forms.Padding(0);
            this.VehiclePicture.Name = "VehiclePicture";
            this.VehiclePicture.Size = new System.Drawing.Size(147, 115);
            this.VehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VehiclePicture.TabIndex = 63;
            this.VehiclePicture.TabStop = false;
            // 
            // VehicleAddButton
            // 
            this.VehicleAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.VehicleAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.VehicleAddButton.FlatAppearance.BorderSize = 0;
            this.VehicleAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.VehicleAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleAddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleAddButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.VehicleAddButton.Location = new System.Drawing.Point(505, 90);
            this.VehicleAddButton.Name = "VehicleAddButton";
            this.VehicleAddButton.Size = new System.Drawing.Size(59, 25);
            this.VehicleAddButton.TabIndex = 64;
            this.VehicleAddButton.Text = "New";
            this.VehicleAddButton.UseVisualStyleBackColor = false;
            this.VehicleAddButton.Click += new System.EventHandler(this.VehicleAddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Location = new System.Drawing.Point(430, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(59, 25);
            this.SearchButton.TabIndex = 65;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EntryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 344);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.VehicleAddButton);
            this.Controls.Add(this.VehiclePicture);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TimeFormatLabel);
            this.Controls.Add(this.VehicleComboBox);
            this.Controls.Add(this.CurrentCompetitionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.VehicleLabel);
            this.Controls.Add(this.ScoringLabel);
            this.Controls.Add(this.ScoreTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EntryAddForm";
            this.Text = "EntryInsertForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntryInsertForm_FormClosed);
            this.Controls.SetChildIndex(this.ScoreTextBox, 0);
            this.Controls.SetChildIndex(this.ScoringLabel, 0);
            this.Controls.SetChildIndex(this.VehicleLabel, 0);
            this.Controls.SetChildIndex(this.AddButton, 0);
            this.Controls.SetChildIndex(this.AbortButton, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.CurrentCompetitionLabel, 0);
            this.Controls.SetChildIndex(this.VehicleComboBox, 0);
            this.Controls.SetChildIndex(this.TimeFormatLabel, 0);
            this.Controls.SetChildIndex(this.AuthorLabel, 0);
            this.Controls.SetChildIndex(this.AuthorTextBox, 0);
            this.Controls.SetChildIndex(this.MessagePanel, 0);
            this.Controls.SetChildIndex(this.VehiclePicture, 0);
            this.Controls.SetChildIndex(this.VehicleAddButton, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label VehicleLabel;
        private System.Windows.Forms.Label ScoringLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Label CurrentCompetitionLabel;
        private System.Windows.Forms.ComboBox VehicleComboBox;
        private System.Windows.Forms.Label TimeFormatLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.FlowLayoutPanel MessagePanel;
        private System.Windows.Forms.PictureBox VehiclePicture;
        private System.Windows.Forms.Button VehicleAddButton;
        private System.Windows.Forms.Button SearchButton;
    }
}