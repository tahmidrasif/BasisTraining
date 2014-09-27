namespace PersonApp
{
    partial class PersonUI
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
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.fullTextBox = new System.Windows.Forms.TextBox();
            this.reverseBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(182, 49);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(193, 20);
            this.firstTextBox.TabIndex = 0;
            // 
            // middleTextBox
            // 
            this.middleTextBox.Location = new System.Drawing.Point(182, 112);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(193, 20);
            this.middleTextBox.TabIndex = 0;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Location = new System.Drawing.Point(182, 186);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(193, 20);
            this.lastTextBox.TabIndex = 0;
            // 
            // fullTextBox
            // 
            this.fullTextBox.Location = new System.Drawing.Point(182, 254);
            this.fullTextBox.Name = "fullTextBox";
            this.fullTextBox.Size = new System.Drawing.Size(359, 20);
            this.fullTextBox.TabIndex = 0;
            // 
            // reverseBox
            // 
            this.reverseBox.Location = new System.Drawing.Point(182, 308);
            this.reverseBox.Name = "reverseBox";
            this.reverseBox.Size = new System.Drawing.Size(359, 20);
            this.reverseBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(427, 112);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(124, 40);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reverse Name";
            // 
            // PersonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.reverseBox);
            this.Controls.Add(this.fullTextBox);
            this.Controls.Add(this.lastTextBox);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Name = "PersonUI";
            this.Text = "PersonUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox lastTextBox;
        private System.Windows.Forms.TextBox fullTextBox;
        private System.Windows.Forms.TextBox reverseBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}