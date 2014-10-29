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
            this.components = new System.ComponentModel.Container();
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.depertmentEntryButton = new System.Windows.Forms.Button();
            this.deptStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.universiyDatabaseDataSet = new UniversityLayerApp.UniversiyDatabaseDataSet();
            this.studentDepertmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDepertmentViewTableAdapter = new UniversityLayerApp.UniversiyDatabaseDataSetTableAdapters.StudentDepertmentViewTableAdapter();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deptStudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepertmentViewBindingSource)).BeginInit();
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
            this.depertmentEntryButton.Click += new System.EventHandler(this.depertmentEntryButton_Click);
            // 
            // deptStudentDataGridView
            // 
            this.deptStudentDataGridView.AutoGenerateColumns = false;
            this.deptStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.idDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.deptCodeDataGridViewTextBoxColumn});
            this.deptStudentDataGridView.DataSource = this.studentDepertmentViewBindingSource;
            this.deptStudentDataGridView.Location = new System.Drawing.Point(12, 105);
            this.deptStudentDataGridView.Name = "deptStudentDataGridView";
            this.deptStudentDataGridView.Size = new System.Drawing.Size(567, 319);
            this.deptStudentDataGridView.TabIndex = 1;
            // 
            // universiyDatabaseDataSet
            // 
            this.universiyDatabaseDataSet.DataSetName = "UniversiyDatabaseDataSet";
            this.universiyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDepertmentViewBindingSource
            // 
            this.studentDepertmentViewBindingSource.DataMember = "StudentDepertmentView";
            this.studentDepertmentViewBindingSource.DataSource = this.universiyDatabaseDataSet;
            // 
            // studentDepertmentViewTableAdapter
            // 
            this.studentDepertmentViewTableAdapter.ClearBeforeFill = true;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial Number";
            this.Serial.Name = "Serial";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "Depertment Name";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            // 
            // deptCodeDataGridViewTextBoxColumn
            // 
            this.deptCodeDataGridViewTextBoxColumn.DataPropertyName = "DeptCode";
            this.deptCodeDataGridViewTextBoxColumn.HeaderText = "Depertment Code";
            this.deptCodeDataGridViewTextBoxColumn.Name = "deptCodeDataGridViewTextBoxColumn";
            // 
            // UniversityEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 436);
            this.Controls.Add(this.deptStudentDataGridView);
            this.Controls.Add(this.depertmentEntryButton);
            this.Controls.Add(this.studentEntryButton);
            this.Name = "UniversityEntryUI";
            this.Text = "UniversityEntryUI";
            this.Load += new System.EventHandler(this.UniversityEntryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deptStudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepertmentViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentEntryButton;
        private System.Windows.Forms.Button depertmentEntryButton;
        private System.Windows.Forms.DataGridView deptStudentDataGridView;
        private UniversiyDatabaseDataSet universiyDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentDepertmentViewBindingSource;
        private UniversiyDatabaseDataSetTableAdapters.StudentDepertmentViewTableAdapter studentDepertmentViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCodeDataGridViewTextBoxColumn;
    }
}