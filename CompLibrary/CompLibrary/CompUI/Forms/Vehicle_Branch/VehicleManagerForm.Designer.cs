
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
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.seeVehiclesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addVehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addVehicleButton.FlatAppearance.BorderSize = 0;
            this.addVehicleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addVehicleButton.Location = new System.Drawing.Point(33, 38);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(230, 120);
            this.addVehicleButton.TabIndex = 1;
            this.addVehicleButton.Text = "Add\r\nVehicle\r\n";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            // 
            // seeVehiclesButton
            // 
            this.seeVehiclesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seeVehiclesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.seeVehiclesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seeVehiclesButton.FlatAppearance.BorderSize = 0;
            this.seeVehiclesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.seeVehiclesButton.Location = new System.Drawing.Point(334, 38);
            this.seeVehiclesButton.Name = "seeVehiclesButton";
            this.seeVehiclesButton.Size = new System.Drawing.Size(230, 120);
            this.seeVehiclesButton.TabIndex = 2;
            this.seeVehiclesButton.Text = "See all\r\nVehicles\r\n";
            this.seeVehiclesButton.UseVisualStyleBackColor = false;
            this.seeVehiclesButton.Click += new System.EventHandler(this.seeVehiclesButton_Click);
            // 
            // VehicleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 201);
            this.Controls.Add(this.seeVehiclesButton);
            this.Controls.Add(this.addVehicleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleManagerForm";
            this.Text = "Vehicle Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button seeVehiclesButton;
    }
}