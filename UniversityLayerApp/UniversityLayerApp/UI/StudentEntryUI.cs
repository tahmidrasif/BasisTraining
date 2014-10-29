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
        DepertmentBLL aDepertmentBll = new DepertmentBLL();
        public StudentEntryUI()
        {
            InitializeComponent();
            ShowInGridView();
            FillComboBox();
       }

         private void FillComboBox()
        {
             List<Depertment> depertments=new List<Depertment>();
             depertments = aDepertmentBll.Retrivedata();
             foreach (Depertment aDepertment in depertments)
             {
                 depertmentComboBox.Items.Add(aDepertment);
             }
             depertmentComboBox.DisplayMember = "DepertmentName";
             depertmentComboBox.ValueMember = "DepertmentID";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Depertment aDepertment=new Depertment();

            string name = studentNameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string depertmentId;
            studentNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            addressTextBox.Text=string.Empty;

            Student aStudent= new Student();
            aStudent.StudentName = name;
            aStudent.Email = email;
            aStudent.Address = address;
            aDepertment= (Depertment) depertmentComboBox.SelectedItem;
            aStudent.DepertmentId = aDepertment.DepertmentID;
               
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
