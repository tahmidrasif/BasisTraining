namespace Expense_Application
{
    partial class ExpanseClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.perticularTxtBox = new System.Windows.Forms.TextBox();
            this.catergoryCombo1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vceButton = new System.Windows.Forms.Button();
            this.myListView = new System.Windows.Forms.ListView();
            this.vceTotalTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vsTotalTxtBox = new System.Windows.Forms.TextBox();
            this.maxTxtBox = new System.Windows.Forms.TextBox();
            this.vsShowButton = new System.Windows.Forms.Button();
            this.categoryCombo2 = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catergoryCombo1);
            this.groupBox1.Controls.Add(this.perticularTxtBox);
            this.groupBox1.Controls.Add(this.AmountTxtBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amaount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Perticular";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(271, 137);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.Location = new System.Drawing.Point(85, 20);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(303, 20);
            this.AmountTxtBox.TabIndex = 2;
            // 
            // perticularTxtBox
            // 
            this.perticularTxtBox.Location = new System.Drawing.Point(85, 95);
            this.perticularTxtBox.Multiline = true;
            this.perticularTxtBox.Name = "perticularTxtBox";
            this.perticularTxtBox.Size = new System.Drawing.Size(303, 36);
            this.perticularTxtBox.TabIndex = 2;
            // 
            // catergoryCombo1
            // 
            this.catergoryCombo1.FormattingEnabled = true;
            this.catergoryCombo1.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.catergoryCombo1.Location = new System.Drawing.Point(85, 59);
            this.catergoryCombo1.Name = "catergoryCombo1";
            this.catergoryCombo1.Size = new System.Drawing.Size(303, 21);
            this.catergoryCombo1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxTxtBox);
            this.groupBox2.Controls.Add(this.vsTotalTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.vsShowButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(16, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.categoryCombo2);
            this.groupBox3.Controls.Add(this.vceTotalTxtBox);
            this.groupBox3.Controls.Add(this.myListView);
            this.groupBox3.Controls.Add(this.vceButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(477, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 418);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Catagory Expense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Catagory";
            // 
            // vceButton
            // 
            this.vceButton.Location = new System.Drawing.Point(295, 89);
            this.vceButton.Name = "vceButton";
            this.vceButton.Size = new System.Drawing.Size(140, 25);
            this.vceButton.TabIndex = 2;
            this.vceButton.Text = "Show";
            this.vceButton.UseVisualStyleBackColor = true;
            this.vceButton.Click += new System.EventHandler(this.vceButton_Click);
            // 
            // myListView
            // 
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.myListView.Location = new System.Drawing.Point(98, 137);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(337, 204);
            this.myListView.TabIndex = 3;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            // 
            // vceTotalTxtBox
            // 
            this.vceTotalTxtBox.Location = new System.Drawing.Point(295, 383);
            this.vceTotalTxtBox.Name = "vceTotalTxtBox";
            this.vceTotalTxtBox.Size = new System.Drawing.Size(140, 20);
            this.vceTotalTxtBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Maximum Expense";
            // 
            // vsTotalTxtBox
            // 
            this.vsTotalTxtBox.Location = new System.Drawing.Point(195, 69);
            this.vsTotalTxtBox.Name = "vsTotalTxtBox";
            this.vsTotalTxtBox.Size = new System.Drawing.Size(140, 20);
            this.vsTotalTxtBox.TabIndex = 4;
            // 
            // maxTxtBox
            // 
            this.maxTxtBox.Location = new System.Drawing.Point(195, 116);
            this.maxTxtBox.Name = "maxTxtBox";
            this.maxTxtBox.Size = new System.Drawing.Size(140, 20);
            this.maxTxtBox.TabIndex = 4;
            // 
            // vsShowButton
            // 
            this.vsShowButton.Location = new System.Drawing.Point(274, 19);
            this.vsShowButton.Name = "vsShowButton";
            this.vsShowButton.Size = new System.Drawing.Size(117, 23);
            this.vsShowButton.TabIndex = 1;
            this.vsShowButton.Text = "Show";
            this.vsShowButton.UseVisualStyleBackColor = true;
            this.vsShowButton.Click += new System.EventHandler(this.vsShowButton_Click);
            // 
            // categoryCombo2
            // 
            this.categoryCombo2.FormattingEnabled = true;
            this.categoryCombo2.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryCombo2.Location = new System.Drawing.Point(142, 37);
            this.categoryCombo2.Name = "categoryCombo2";
            this.categoryCombo2.Size = new System.Drawing.Size(303, 21);
            this.categoryCombo2.TabIndex = 3;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Perticular";
            this.columnHeader3.Width = 170;
            // 
            // ExpanseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ExpanseClass";
            this.Text = "Daily Expense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox catergoryCombo1;
        private System.Windows.Forms.TextBox perticularTxtBox;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maxTxtBox;
        private System.Windows.Forms.TextBox vsTotalTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button vsShowButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox vceTotalTxtBox;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.Button vceButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryCombo2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

