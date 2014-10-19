using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using BootCampApp.BusinessLogicLayer;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp.UserInterface
{
    public partial class CourseEnrollmentUI : Form
    {
        CourseEnrollment aCourseEnrollment = new CourseEnrollment();
        private CourseEnrollmentBll aCourseEnrollmentBll;

        public CourseEnrollmentUI()
        {
            InitializeComponent();
        }

        

        private void findButton_Click(object sender, EventArgs e)
        {
            string regNo = regnoTextBox.Text;
            aCourseEnrollment = new CourseEnrollment();
            aCourseEnrollmentBll = new CourseEnrollmentBll();

            aCourseEnrollment= aCourseEnrollmentBll.CheckRegNo(regNo);
            nameTextBox.Text = aCourseEnrollment.AStudent.Name;
            emailTextBox.Text = aCourseEnrollment.AStudent.Email;
            courseComboBox.DataSource = aCourseEnrollment.Courses;
            courseComboBox.DisplayMember = "CourseTitle";
            courseComboBox.ValueMember = "CourseId";
            enrolledCoursesDataGridView.DataSource = aCourseEnrollmentBll.EnrollmentGridevieDataPicker(aCourseEnrollment.AStudent.RegNo);

        }

       

        private void enrollButton_Click(object sender, EventArgs e)
        {
           string courseId = courseComboBox.SelectedValue.ToString();
           DateTime aDateTime=new DateTime();
           aDateTime = enrollmentDateTimePicker.Value.Date;
            
           string msg=aCourseEnrollmentBll.InsertIntoDatabase(Convert.ToInt16(courseId), aDateTime,aCourseEnrollment);
           MessageBox.Show(msg);
           enrolledCoursesDataGridView.DataSource = aCourseEnrollmentBll.EnrollmentGridevieDataPicker(aCourseEnrollment.AStudent.RegNo);
        }
    }
}
