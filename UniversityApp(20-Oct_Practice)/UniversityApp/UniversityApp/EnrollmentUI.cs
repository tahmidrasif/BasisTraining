using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class EnrollmentUI : Form
    {
        private EnrollmentBll aEnrollmentBll=new EnrollmentBll();
        private Student aStudent=new Student();
        private Course aCourse=new Course();
        private Enrollment aEnrollment=new Enrollment();
        StudentBll aStudentBll=new StudentBll();
        CourseBll aCourseBll=new CourseBll();

        public EnrollmentUI()
        {
            InitializeComponent();
            List<Student> students=new List<Student>();
            List<Course> courses = new List<Course>();
            students=aStudentBll.GetAllStudent();
            courses = aCourseBll.GetAllCourses();
            FillComboBox(students,courses);
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            aEnrollmentBll = new EnrollmentBll();

          //  string msg = aEnrollmentBll.SaveIntoDataBase(aStudent);
          //  MessageBox.Show(msg);
        }

        private void FillComboBox(List<Student> students,List<Course> courses)
        {
            Enrollment aNewEnrollment=new Enrollment();
            aNewEnrollment = aEnrollment;
            courseComboBox.DataSource = courses;
            regNoComboBox.DataSource = students;

            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Code";

            regNoComboBox.DisplayMember = "RegistationNumber";
        }

    }
}
