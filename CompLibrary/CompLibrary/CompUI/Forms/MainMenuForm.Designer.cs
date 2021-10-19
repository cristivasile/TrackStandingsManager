
namespace CompUI
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.vehicleButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.competitionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleButton
            // 
            this.vehicleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.vehicleButton.FlatAppearance.BorderSize = 0;
            this.vehicleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vehicleButton.Location = new System.Drawing.Point(55, 54);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(230, 120);
            this.vehicleButton.TabIndex = 0;
            this.vehicleButton.Text = "Vehicle\r\nManager";
            this.vehicleButton.UseVisualStyleBackColor = false;
            this.vehicleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.helpButton.Location = new System.Drawing.Point(151, 248);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(337, 120);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "What should I do?";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // competitionButton
            // 
            this.competitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.competitionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.competitionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.competitionButton.Location = new System.Drawing.Point(354, 54);
            this.competitionButton.Name = "competitionButton";
            this.competitionButton.Size = new System.Drawing.Size(230, 120);
            this.competitionButton.TabIndex = 3;
            this.competitionButton.Text = "Competition\r\nManager\r\n";
            this.competitionButton.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 443);
            this.Controls.Add(this.competitionButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.vehicleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(706, 512);
            this.MinimumSize = new System.Drawing.Size(609, 428);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button competitionButton;
    }
}

