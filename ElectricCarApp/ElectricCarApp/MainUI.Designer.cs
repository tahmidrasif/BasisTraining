namespace ElectricCarApp
{
    partial class MainUI
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
            this.vehicleUIButton = new System.Windows.Forms.Button();
            this.powergridUIButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleUIButton
            // 
            this.vehicleUIButton.Location = new System.Drawing.Point(29, 109);
            this.vehicleUIButton.Name = "vehicleUIButton";
            this.vehicleUIButton.Size = new System.Drawing.Size(146, 96);
            this.vehicleUIButton.TabIndex = 0;
            this.vehicleUIButton.Text = "Vehicle ";
            this.vehicleUIButton.UseVisualStyleBackColor = true;
            this.vehicleUIButton.Click += new System.EventHandler(this.vehicleUIButton_Click);
            // 
            // powergridUIButton
            // 
            this.powergridUIButton.Location = new System.Drawing.Point(249, 109);
            this.powergridUIButton.Name = "powergridUIButton";
            this.powergridUIButton.Size = new System.Drawing.Size(146, 96);
            this.powergridUIButton.TabIndex = 0;
            this.powergridUIButton.Text = "Powergrid";
            this.powergridUIButton.UseVisualStyleBackColor = true;
            this.powergridUIButton.Click += new System.EventHandler(this.powergridUIButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 407);
            this.Controls.Add(this.powergridUIButton);
            this.Controls.Add(this.vehicleUIButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vehicleUIButton;
        private System.Windows.Forms.Button powergridUIButton;
    }
}