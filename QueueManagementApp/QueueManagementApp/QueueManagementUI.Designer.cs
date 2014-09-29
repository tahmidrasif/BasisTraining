namespace QueueManagementApp
{
    partial class QueueManagementUI
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
            this.eNameTxtBox = new System.Windows.Forms.TextBox();
            this.dSerialTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enqueButton = new System.Windows.Forms.Button();
            this.eComplainTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dequeButton = new System.Windows.Forms.Button();
            this.dComplainTxtBox = new System.Windows.Forms.TextBox();
            this.dNameTxtBox = new System.Windows.Forms.TextBox();
            this.myListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eNameTxtBox
            // 
            this.eNameTxtBox.Location = new System.Drawing.Point(109, 29);
            this.eNameTxtBox.Name = "eNameTxtBox";
            this.eNameTxtBox.Size = new System.Drawing.Size(250, 20);
            this.eNameTxtBox.TabIndex = 0;
            // 
            // dSerialTxtBox
            // 
            this.dSerialTxtBox.Location = new System.Drawing.Point(87, 19);
            this.dSerialTxtBox.Name = "dSerialTxtBox";
            this.dSerialTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dSerialTxtBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.enqueButton);
            this.groupBox1.Controls.Add(this.eComplainTxtBox);
            this.groupBox1.Controls.Add(this.eNameTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enque Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // enqueButton
            // 
            this.enqueButton.Location = new System.Drawing.Point(109, 145);
            this.enqueButton.Name = "enqueButton";
            this.enqueButton.Size = new System.Drawing.Size(120, 23);
            this.enqueButton.TabIndex = 2;
            this.enqueButton.Text = "Enque";
            this.enqueButton.UseVisualStyleBackColor = true;
            this.enqueButton.Click += new System.EventHandler(this.enqueButton_Click);
            // 
            // eComplainTxtBox
            // 
            this.eComplainTxtBox.Location = new System.Drawing.Point(109, 72);
            this.eComplainTxtBox.Multiline = true;
            this.eComplainTxtBox.Name = "eComplainTxtBox";
            this.eComplainTxtBox.Size = new System.Drawing.Size(250, 45);
            this.eComplainTxtBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dequeButton);
            this.groupBox2.Controls.Add(this.dComplainTxtBox);
            this.groupBox2.Controls.Add(this.dNameTxtBox);
            this.groupBox2.Controls.Add(this.dSerialTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(493, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deque Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial No.";
            // 
            // dequeButton
            // 
            this.dequeButton.Location = new System.Drawing.Point(286, 19);
            this.dequeButton.Name = "dequeButton";
            this.dequeButton.Size = new System.Drawing.Size(120, 23);
            this.dequeButton.TabIndex = 6;
            this.dequeButton.Text = "Deque";
            this.dequeButton.UseVisualStyleBackColor = true;
            this.dequeButton.Click += new System.EventHandler(this.dequeButton_Click);
            // 
            // dComplainTxtBox
            // 
            this.dComplainTxtBox.Location = new System.Drawing.Point(87, 103);
            this.dComplainTxtBox.Multiline = true;
            this.dComplainTxtBox.Name = "dComplainTxtBox";
            this.dComplainTxtBox.Size = new System.Drawing.Size(250, 45);
            this.dComplainTxtBox.TabIndex = 5;
            // 
            // dNameTxtBox
            // 
            this.dNameTxtBox.Location = new System.Drawing.Point(87, 65);
            this.dNameTxtBox.Name = "dNameTxtBox";
            this.dNameTxtBox.Size = new System.Drawing.Size(250, 20);
            this.dNameTxtBox.TabIndex = 4;
            // 
            // myListView
            // 
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.myListView.Location = new System.Drawing.Point(12, 241);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(908, 194);
            this.myListView.TabIndex = 3;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 197;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Customer";
            this.columnHeader3.Width = 174;
            // 
            // QueueManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueueManagementUI";
            this.Text = "QueueManagementUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox eNameTxtBox;
        private System.Windows.Forms.TextBox dSerialTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enqueButton;
        private System.Windows.Forms.TextBox eComplainTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dequeButton;
        private System.Windows.Forms.TextBox dComplainTxtBox;
        private System.Windows.Forms.TextBox dNameTxtBox;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
    }
}

