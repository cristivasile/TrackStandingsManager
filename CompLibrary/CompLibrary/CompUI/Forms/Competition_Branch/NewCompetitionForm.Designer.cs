
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.competitionPicture = new System.Windows.Forms.PictureBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.pointsButton = new System.Windows.Forms.RadioButton();
            this.timingsButton = new System.Windows.Forms.RadioButton();
            this.timingsTypeBox = new System.Windows.Forms.ComboBox();
            this.sortTypeLabel = new System.Windows.Forms.Label();
            this.descendingButton = new System.Windows.Forms.RadioButton();
            this.ascendingButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.competitionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(37, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(172, 30);
            this.titleLabel.TabIndex = 39;
            this.titleLabel.Text = "New competition";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abortButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.abortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.abortButton.Location = new System.Drawing.Point(37, 327);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(125, 40);
            this.abortButton.TabIndex = 38;
            this.abortButton.Text = "Exit";
            this.abortButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateButton.Location = new System.Drawing.Point(827, 327);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 40);
            this.updateButton.TabIndex = 37;
            this.updateButton.Text = "Add";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.descriptionLabel.Location = new System.Drawing.Point(291, 176);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(123, 30);
            this.descriptionLabel.TabIndex = 34;
            this.descriptionLabel.Text = "Description:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(431, 176);
            this.modelTextBox.Multiline = true;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(237, 110);
            this.modelTextBox.TabIndex = 33;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(291, 85);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 30);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.brandLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(431, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(237, 35);
            this.nameTextBox.TabIndex = 31;
            // 
            // competitionPicture
            // 
            this.competitionPicture.Location = new System.Drawing.Point(37, 88);
            this.competitionPicture.Name = "competitionPicture";
            this.competitionPicture.Size = new System.Drawing.Size(206, 198);
            this.competitionPicture.TabIndex = 30;
            this.competitionPicture.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.typeLabel.Location = new System.Drawing.Point(711, 85);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(115, 30);
            this.typeLabel.TabIndex = 40;
            this.typeLabel.Text = "Score type:";
            this.typeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pointsButton
            // 
            this.pointsButton.AutoSize = true;
            this.pointsButton.Checked = true;
            this.pointsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pointsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pointsButton.Location = new System.Drawing.Point(723, 118);
            this.pointsButton.Name = "pointsButton";
            this.pointsButton.Size = new System.Drawing.Size(64, 23);
            this.pointsButton.TabIndex = 41;
            this.pointsButton.TabStop = true;
            this.pointsButton.Text = "Points";
            this.pointsButton.UseVisualStyleBackColor = true;
            // 
            // timingsButton
            // 
            this.timingsButton.AutoSize = true;
            this.timingsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.timingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timingsButton.Location = new System.Drawing.Point(723, 147);
            this.timingsButton.Name = "timingsButton";
            this.timingsButton.Size = new System.Drawing.Size(74, 23);
            this.timingsButton.TabIndex = 42;
            this.timingsButton.Text = "Timings";
            this.timingsButton.UseVisualStyleBackColor = true;
            // 
            // timingsTypeBox
            // 
            this.timingsTypeBox.Enabled = false;
            this.timingsTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timingsTypeBox.FormattingEnabled = true;
            this.timingsTypeBox.Location = new System.Drawing.Point(827, 147);
            this.timingsTypeBox.Name = "timingsTypeBox";
            this.timingsTypeBox.Size = new System.Drawing.Size(134, 25);
            this.timingsTypeBox.TabIndex = 43;
            this.timingsTypeBox.Text = "Select time format";
            // 
            // sortTypeLabel
            // 
            this.sortTypeLabel.AutoSize = true;
            this.sortTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortTypeLabel.Location = new System.Drawing.Point(711, 176);
            this.sortTypeLabel.Name = "sortTypeLabel";
            this.sortTypeLabel.Size = new System.Drawing.Size(55, 30);
            this.sortTypeLabel.TabIndex = 44;
            this.sortTypeLabel.Text = "Sort:";
            // 
            // descendingButton
            // 
            this.descendingButton.AutoSize = true;
            this.descendingButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.descendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.descendingButton.Location = new System.Drawing.Point(723, 238);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(98, 23);
            this.descendingButton.TabIndex = 46;
            this.descendingButton.Text = "Descending";
            this.descendingButton.UseVisualStyleBackColor = true;
            // 
            // ascendingButton
            // 
            this.ascendingButton.AutoSize = true;
            this.ascendingButton.Checked = true;
            this.ascendingButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ascendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ascendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ascendingButton.Location = new System.Drawing.Point(723, 209);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(90, 23);
            this.ascendingButton.TabIndex = 45;
            this.ascendingButton.TabStop = true;
            this.ascendingButton.Text = "Ascending";
            this.ascendingButton.UseVisualStyleBackColor = true;
            // 
            // NewCompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 389);
            this.Controls.Add(this.descendingButton);
            this.Controls.Add(this.ascendingButton);
            this.Controls.Add(this.sortTypeLabel);
            this.Controls.Add(this.timingsTypeBox);
            this.Controls.Add(this.timingsButton);
            this.Controls.Add(this.pointsButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.competitionPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NewCompetitionForm";
            this.Text = "New Competition";
            ((System.ComponentModel.ISupportInitialize)(this.competitionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox competitionPicture;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.RadioButton pointsButton;
        private System.Windows.Forms.RadioButton timingsButton;
        private System.Windows.Forms.ComboBox timingsTypeBox;
        private System.Windows.Forms.Label sortTypeLabel;
        private System.Windows.Forms.RadioButton descendingButton;
        private System.Windows.Forms.RadioButton ascendingButton;
    }
}