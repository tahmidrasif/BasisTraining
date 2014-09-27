namespace CalculatorApp
{
    partial class CalculationUi
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
            this.firstNumberTxtBox = new System.Windows.Forms.TextBox();
            this.secondNumberTxtBox = new System.Windows.Forms.TextBox();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumberTxtBox
            // 
            this.firstNumberTxtBox.Location = new System.Drawing.Point(158, 36);
            this.firstNumberTxtBox.Name = "firstNumberTxtBox";
            this.firstNumberTxtBox.Size = new System.Drawing.Size(335, 20);
            this.firstNumberTxtBox.TabIndex = 0;
            // 
            // secondNumberTxtBox
            // 
            this.secondNumberTxtBox.Location = new System.Drawing.Point(158, 121);
            this.secondNumberTxtBox.Name = "secondNumberTxtBox";
            this.secondNumberTxtBox.Size = new System.Drawing.Size(335, 20);
            this.secondNumberTxtBox.TabIndex = 0;
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(158, 221);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(335, 20);
            this.resultTxtBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(38, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(196, 317);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(75, 23);
            this.substractButton.TabIndex = 1;
            this.substractButton.Text = "Substract";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(361, 317);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 1;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(517, 317);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 1;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // CalculationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.secondNumberTxtBox);
            this.Controls.Add(this.firstNumberTxtBox);
            this.Name = "CalculationUi";
            this.Text = "CalculationUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTxtBox;
        private System.Windows.Forms.TextBox secondNumberTxtBox;
        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

