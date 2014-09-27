namespace AccountOperationApp
{
    partial class AccountUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameTxtBox = new System.Windows.Forms.TextBox();
            this.acNumberTxtBox = new System.Windows.Forms.TextBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.depositeButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.amountTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(96, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transection";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(312, 107);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(114, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(116, 107);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(114, 23);
            this.depositeButton.TabIndex = 2;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount";
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(116, 44);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(310, 20);
            this.amountTxtBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.customerNameTxtBox);
            this.groupBox2.Controls.Add(this.acNumberTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(96, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Creation";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(201, 119);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(114, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number";
            // 
            // customerNameTxtBox
            // 
            this.customerNameTxtBox.Location = new System.Drawing.Point(116, 70);
            this.customerNameTxtBox.Name = "customerNameTxtBox";
            this.customerNameTxtBox.Size = new System.Drawing.Size(310, 20);
            this.customerNameTxtBox.TabIndex = 0;
            // 
            // acNumberTxtBox
            // 
            this.acNumberTxtBox.Location = new System.Drawing.Point(116, 19);
            this.acNumberTxtBox.Name = "acNumberTxtBox";
            this.acNumberTxtBox.Size = new System.Drawing.Size(310, 20);
            this.acNumberTxtBox.TabIndex = 0;
           // this.acNumberTxtBox.TextChanged += new System.EventHandler(this.acNumberTxtBox_TextChanged);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(297, 400);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(114, 23);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // AccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountUI";
            this.Text = "AccountUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameTxtBox;
        private System.Windows.Forms.TextBox acNumberTxtBox;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.TextBox amountTxtBox;
    }
}

