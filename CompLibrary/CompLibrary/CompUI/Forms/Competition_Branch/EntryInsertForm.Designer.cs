
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.currentCompetitionLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(30, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 30);
            this.titleLabel.TabIndex = 36;
            this.titleLabel.Text = "New entry in:";
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abortButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.abortButton.FlatAppearance.BorderSize = 0;
            this.abortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.abortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.abortButton.Location = new System.Drawing.Point(30, 284);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(125, 40);
            this.abortButton.TabIndex = 35;
            this.abortButton.Text = "Exit";
            this.abortButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateButton.Location = new System.Drawing.Point(598, 284);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 40);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Add";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vehicleLabel.Location = new System.Drawing.Point(46, 107);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(73, 25);
            this.vehicleLabel.TabIndex = 33;
            this.vehicleLabel.Text = "Vehicle";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.AutoSize = true;
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scoreTextBox.Location = new System.Drawing.Point(46, 201);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(111, 25);
            this.scoreTextBox.TabIndex = 31;
            this.scoreTextBox.Text = "Time/Points";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTextBox.Location = new System.Drawing.Point(172, 198);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(237, 32);
            this.timeTextBox.TabIndex = 30;
            this.timeTextBox.TextChanged += new System.EventHandler(this.brandTextBox_TextChanged);
            // 
            // currentCompetitionLabel
            // 
            this.currentCompetitionLabel.AutoSize = true;
            this.currentCompetitionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.currentCompetitionLabel.Location = new System.Drawing.Point(172, 35);
            this.currentCompetitionLabel.Name = "currentCompetitionLabel";
            this.currentCompetitionLabel.Size = new System.Drawing.Size(75, 30);
            this.currentCompetitionLabel.TabIndex = 37;
            this.currentCompetitionLabel.Text = "<null>";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(425, 110);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(25, 21);
            this.orLabel.TabIndex = 38;
            this.orLabel.Text = "or";
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleTextBox.Location = new System.Drawing.Point(466, 104);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.Size = new System.Drawing.Size(237, 32);
            this.vehicleTextBox.TabIndex = 39;
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(172, 104);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(237, 33);
            this.vehicleComboBox.TabIndex = 40;
            // 
            // EntryInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 355);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.currentCompetitionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EntryInsertForm";
            this.Text = "EntryInsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label scoreTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label currentCompetitionLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.ComboBox vehicleComboBox;
    }
}