
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
            this.SuspendLayout();
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddVehicleButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVehicleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddVehicleButton.Location = new System.Drawing.Point(33, 38);
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
            this.SeeVehiclesButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.SeeVehiclesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SeeVehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeVehiclesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SeeVehiclesButton.Location = new System.Drawing.Point(334, 38);
            this.SeeVehiclesButton.Name = "SeeVehiclesButton";
            this.SeeVehiclesButton.Size = new System.Drawing.Size(230, 120);
            this.SeeVehiclesButton.TabIndex = 2;
            this.SeeVehiclesButton.Text = "See all\r\nVehicles\r\n";
            this.SeeVehiclesButton.UseVisualStyleBackColor = false;
            this.SeeVehiclesButton.Click += new System.EventHandler(this.SeeVehiclesButton_Click);
            // 
            // VehicleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 201);
            this.Controls.Add(this.SeeVehiclesButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehicleManagerForm";
            this.Text = "Vehicle Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleManagerForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button SeeVehiclesButton;
    }
}