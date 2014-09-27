namespace SalaryCalculatorApp
{
    partial class SalaryUI
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.basicTxtBox = new System.Windows.Forms.TextBox();
            this.hRentTxtBox = new System.Windows.Forms.TextBox();
            this.mRentTxtBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(135, 29);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(359, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // basicTxtBox
            // 
            this.basicTxtBox.Location = new System.Drawing.Point(135, 87);
            this.basicTxtBox.Name = "basicTxtBox";
            this.basicTxtBox.Size = new System.Drawing.Size(225, 20);
            this.basicTxtBox.TabIndex = 0;
            // 
            // hRentTxtBox
            // 
            this.hRentTxtBox.Location = new System.Drawing.Point(135, 152);
            this.hRentTxtBox.Name = "hRentTxtBox";
            this.hRentTxtBox.Size = new System.Drawing.Size(225, 20);
            this.hRentTxtBox.TabIndex = 0;
            // 
            // mRentTxtBox
            // 
            this.mRentTxtBox.Location = new System.Drawing.Point(135, 220);
            this.mRentTxtBox.Name = "mRentTxtBox";
            this.mRentTxtBox.Size = new System.Drawing.Size(225, 20);
            this.mRentTxtBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(135, 283);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(225, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Medical Allowence";
            // 
            // SalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.mRentTxtBox);
            this.Controls.Add(this.hRentTxtBox);
            this.Controls.Add(this.basicTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "SalaryUI";
            this.Text = "SalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox basicTxtBox;
        private System.Windows.Forms.TextBox hRentTxtBox;
        private System.Windows.Forms.TextBox mRentTxtBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

