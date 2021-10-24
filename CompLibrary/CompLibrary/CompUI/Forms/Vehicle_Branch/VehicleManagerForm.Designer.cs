
namespace CompUI
{
    partial class VehicleManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleManagerForm));
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.SeeVehiclesButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddVehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.AddVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVehicleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddVehicleButton.Location = new System.Drawing.Point(36, 51);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(230, 120);
            this.AddVehicleButton.TabIndex = 1;
            this.AddVehicleButton.Text = "Add\r\nVehicle\r\n";
            this.AddVehicleButton.UseVisualStyleBackColor = false;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // SeeVehiclesButton
            // 
            this.SeeVehiclesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeVehiclesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SeeVehiclesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SeeVehiclesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SeeVehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeVehiclesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SeeVehiclesButton.Location = new System.Drawing.Point(325, 51);
            this.SeeVehiclesButton.Name = "SeeVehiclesButton";
            this.SeeVehiclesButton.Size = new System.Drawing.Size(230, 120);
            this.SeeVehiclesButton.TabIndex = 2;
            this.SeeVehiclesButton.Text = "See all\r\nVehicles\r\n";
            this.SeeVehiclesButton.UseVisualStyleBackColor = false;
            this.SeeVehiclesButton.Click += new System.EventHandler(this.SeeVehiclesButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(543, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinimizeButton.Size = new System.Drawing.Size(22, 18);
            this.MinimizeButton.TabIndex = 36;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(567, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseButton.Size = new System.Drawing.Size(22, 18);
            this.CloseButton.TabIndex = 35;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.TopBarPanel.Controls.Add(this.MinimizeButton);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.Location = new System.Drawing.Point(0, -1);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(591, 25);
            this.TopBarPanel.TabIndex = 35;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VehicleManagerForm_MouseDown);
            // 
            // VehicleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 199);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.SeeVehiclesButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleManagerForm";
            this.Text = "Vehicle Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleManagerForm_FormClosed);
            this.TopBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button SeeVehiclesButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopBarPanel;
    }
}