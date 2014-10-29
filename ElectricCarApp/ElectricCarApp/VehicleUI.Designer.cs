namespace ElectricCarApp
{
    partial class VehicleUI
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
            this.dischargeButton = new System.Windows.Forms.Button();
            this.rechargeButton = new System.Windows.Forms.Button();
            this.stateOfChargeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expenseTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registryButton = new System.Windows.Forms.Button();
            this.chargingTimeTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dischargeButton
            // 
            this.dischargeButton.Enabled = false;
            this.dischargeButton.Location = new System.Drawing.Point(36, 120);
            this.dischargeButton.Name = "dischargeButton";
            this.dischargeButton.Size = new System.Drawing.Size(75, 23);
            this.dischargeButton.TabIndex = 0;
            this.dischargeButton.Text = "Discharge";
            this.dischargeButton.UseVisualStyleBackColor = true;
            this.dischargeButton.Click += new System.EventHandler(this.dischargeButton_Click);
            // 
            // rechargeButton
            // 
            this.rechargeButton.Enabled = false;
            this.rechargeButton.Location = new System.Drawing.Point(207, 120);
            this.rechargeButton.Name = "rechargeButton";
            this.rechargeButton.Size = new System.Drawing.Size(75, 23);
            this.rechargeButton.TabIndex = 1;
            this.rechargeButton.Text = "Recharge";
            this.rechargeButton.UseVisualStyleBackColor = true;
            this.rechargeButton.Click += new System.EventHandler(this.rechargeButton_Click);
            // 
            // stateOfChargeTextBox
            // 
            this.stateOfChargeTextBox.Location = new System.Drawing.Point(36, 53);
            this.stateOfChargeTextBox.Name = "stateOfChargeTextBox";
            this.stateOfChargeTextBox.Size = new System.Drawing.Size(246, 20);
            this.stateOfChargeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "State Of Charge (%)";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(36, 206);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(246, 20);
            this.incomeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount Of Money You Get";
            // 
            // expenseTextbox
            // 
            this.expenseTextbox.Location = new System.Drawing.Point(36, 292);
            this.expenseTextbox.Name = "expenseTextbox";
            this.expenseTextbox.Size = new System.Drawing.Size(246, 20);
            this.expenseTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount Of Money You Paid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registryButton);
            this.groupBox1.Controls.Add(this.chargingTimeTextBox);
            this.groupBox1.Controls.Add(this.regNoTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.vehicleNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(308, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // registryButton
            // 
            this.registryButton.Location = new System.Drawing.Point(179, 224);
            this.registryButton.Name = "registryButton";
            this.registryButton.Size = new System.Drawing.Size(75, 23);
            this.registryButton.TabIndex = 6;
            this.registryButton.Text = "Registration";
            this.registryButton.UseVisualStyleBackColor = true;
            this.registryButton.Click += new System.EventHandler(this.registryButton_Click);
            // 
            // chargingTimeTextBox
            // 
            this.chargingTimeTextBox.Location = new System.Drawing.Point(26, 160);
            this.chargingTimeTextBox.Name = "chargingTimeTextBox";
            this.chargingTimeTextBox.Size = new System.Drawing.Size(345, 20);
            this.chargingTimeTextBox.TabIndex = 1;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(26, 105);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(345, 20);
            this.regNoTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Default Charging Time Per Kilowatt Hour";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(26, 50);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(345, 20);
            this.vehicleNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registration Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle Name";
            // 
            // VehicleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expenseTextbox);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.stateOfChargeTextBox);
            this.Controls.Add(this.rechargeButton);
            this.Controls.Add(this.dischargeButton);
            this.Name = "VehicleUI";
            this.Text = "VehicleUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dischargeButton;
        private System.Windows.Forms.Button rechargeButton;
        private System.Windows.Forms.TextBox stateOfChargeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expenseTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registryButton;
        private System.Windows.Forms.TextBox chargingTimeTextBox;
        private System.Windows.Forms.Label label7;
    }
}