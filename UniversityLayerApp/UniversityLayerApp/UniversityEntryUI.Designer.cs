namespace UniversityLayerApp
{
    partial class UniversityEntryUI
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
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.depertmentEntryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(12, 40);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(194, 45);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Enter New Student";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // depertmentEntryButton
            // 
            this.depertmentEntryButton.Location = new System.Drawing.Point(385, 40);
            this.depertmentEntryButton.Name = "depertmentEntryButton";
            this.depertmentEntryButton.Size = new System.Drawing.Size(194, 45);
            this.depertmentEntryButton.TabIndex = 0;
            this.depertmentEntryButton.Text = "Enter New Depertment";
            this.depertmentEntryButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // UniversityEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.depertmentEntryButton);
            this.Controls.Add(this.studentEntryButton);
            this.Name = "UniversityEntryUI";
            this.Text = "UniversityEntryUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentEntryButton;
        private System.Windows.Forms.Button depertmentEntryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}