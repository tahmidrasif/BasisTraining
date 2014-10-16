using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLayerApp.BLL;
using UniversityLayerApp.DLL.DAO;

namespace UniversityLayerApp
{
    public partial class StudentEntryUI : Form
    {
        private StudentBLL aStudentBll;

        public StudentEntryUI()
        {
            InitializeComponent();
            ShowInGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = studentNameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            studentNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            addressTextBox.Text=string.Empty;

            Student aStudent= new Student();
            aStudent.StudentName = name;
            aStudent.Email = email;
            aStudent.Address = address;

            aStudentBll = new StudentBLL();
            string confirmationMessege=aStudentBll.Save(aStudent);
            MessageBox.Show(confirmationMessege);
            ShowInGridView();

        }

        private void ShowInGridView()
        {
            aStudentBll=new StudentBLL();
            List<Student> students= new List<Student>();
            students = aStudentBll.RetriveData();
            studentGridView.DataSource = students;
        }
    }
}
