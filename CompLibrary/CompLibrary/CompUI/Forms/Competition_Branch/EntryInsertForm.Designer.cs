
namespace CompUI.Forms.Competition_Branch
{
    partial class EntryInsertForm
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
            this.VehicleLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.CurrentCompetitionLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.VehicleTextBox = new System.Windows.Forms.TextBox();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleLabel.Location = new System.Drawing.Point(30, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(136, 30);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "New entry in:";
            // 
            // AbortButton
            // 
            this.AbortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AbortButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AbortButton.FlatAppearance.BorderSize = 0;
            this.AbortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AbortButton.Location = new System.Drawing.Point(30, 284);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(125, 40);
            this.AbortButton.TabIndex = 35;
            this.AbortButton.Text = "Exit";
            this.AbortButton.UseVisualStyleBackColor = false;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateButton.Location = new System.Drawing.Point(598, 284);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(125, 40);
            this.UpdateButton.TabIndex = 34;
            this.UpdateButton.Text = "Add";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // VehicleLabel
            // 
            this.VehicleLabel.AutoSize = true;
            this.VehicleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.VehicleLabel.Location = new System.Drawing.Point(46, 107);
            this.VehicleLabel.Name = "VehicleLabel";
            this.VehicleLabel.Size = new System.Drawing.Size(73, 25);
            this.VehicleLabel.TabIndex = 33;
            this.VehicleLabel.Text = "Vehicle";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.AutoSize = true;
            this.ScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScoreTextBox.Location = new System.Drawing.Point(46, 201);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(111, 25);
            this.ScoreTextBox.TabIndex = 31;
            this.ScoreTextBox.Text = "Time/Points";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeTextBox.Location = new System.Drawing.Point(172, 198);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(237, 32);
            this.TimeTextBox.TabIndex = 30;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.BrandTextBox_TextChanged);
            // 
            // CurrentCompetitionLabel
            // 
            this.CurrentCompetitionLabel.AutoSize = true;
            this.CurrentCompetitionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CurrentCompetitionLabel.Location = new System.Drawing.Point(172, 35);
            this.CurrentCompetitionLabel.Name = "CurrentCompetitionLabel";
            this.CurrentCompetitionLabel.Size = new System.Drawing.Size(75, 30);
            this.CurrentCompetitionLabel.TabIndex = 37;
            this.CurrentCompetitionLabel.Text = "<null>";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OrLabel.Location = new System.Drawing.Point(425, 110);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(25, 21);
            this.OrLabel.TabIndex = 38;
            this.OrLabel.Text = "or";
            // 
            // VehicleTextBox
            // 
            this.VehicleTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleTextBox.Location = new System.Drawing.Point(466, 104);
            this.VehicleTextBox.Name = "VehicleTextBox";
            this.VehicleTextBox.Size = new System.Drawing.Size(237, 32);
            this.VehicleTextBox.TabIndex = 39;
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(172, 104);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(237, 33);
            this.VehicleComboBox.TabIndex = 40;
            // 
            // EntryInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 355);
            this.Controls.Add(this.VehicleComboBox);
            this.Controls.Add(this.VehicleTextBox);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.CurrentCompetitionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.VehicleLabel);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.TimeTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EntryInsertForm";
            this.Text = "EntryInsertForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntryInsertForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label VehicleLabel;
        private System.Windows.Forms.Label ScoreTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label CurrentCompetitionLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.TextBox VehicleTextBox;
        private System.Windows.Forms.ComboBox VehicleComboBox;
    }
}