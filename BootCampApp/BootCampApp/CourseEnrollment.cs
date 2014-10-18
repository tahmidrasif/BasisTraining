using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp
{
    class CourseEnrollment
    {

        public Student AStudent { get; set; }
        public List<Course> Courses { get; set; }
 
        private string connection = "Data Source=RASIF-PC;Initial Catalog=StudentInformation;Integrated Security=True";
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        private SqlConnection aConnection;


        public CourseEnrollment()
        {
            AStudent=new Student();
            Courses=new List<Course>();
        }

        public void Dataentry()
        {
            
        }

        public CourseEnrollment CheckRegNo(string regNo)
        {
            CourseEnrollment aCourseEnrollment=new CourseEnrollment();
            aConnection = new SqlConnection(connection);
            

            string registrationNumber = regNo;
            string query1 = "SELECT * FROM CourseEnrollmentView1 WHERE Student_RegNo='" + registrationNumber+"'";
            string query2 = "SELECT * FROM CourseEnrollmentView2";
            
            aConnection.Open();

            aCommand = new SqlCommand(query1, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aCourseEnrollment.AStudent.RegNo= aReader[0].ToString();
                    aCourseEnrollment.AStudent.Name = aReader[1].ToString();
                    aCourseEnrollment.AStudent.Email = aReader[2].ToString();
                    
                }
               
            }
            aConnection.Close();

            aConnection.Open();

            aCommand = new SqlCommand(query2, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.CourseId = (int) aReader[0];
                    aCourse.CourseTitle = aReader[1].ToString();
                    aCourse.CourseName = aReader[2].ToString();
                    aCourseEnrollment.Courses.Add(aCourse);
                }

            }

            aConnection.Close();

            return aCourseEnrollment;
        }

        public string InsertIntoDatabase(int courseId, DateTime aDateTime,CourseEnrollment aCourseEnrollment)
        {
            if (CourseAlreadyTaken(courseId,aCourseEnrollment))
            {
                string studentRegNo = aCourseEnrollment.AStudent.RegNo;

                string query = string.Format("INSERT INTO t_StudentEnroll VALUES ('{0}','{1}','{2}')", studentRegNo, courseId, aDateTime);

                aConnection = new SqlConnection(connection);
                aConnection.Open();

                SqlCommand aCommand = new SqlCommand(query, aConnection);

                int isAffected = aCommand.ExecuteNonQuery();
                aConnection.Close();
                if (isAffected > 0)
                {
                    return "Successfully Entered";
                }
                //return isAffected;
                return "Failed to Insert";
            }
            return "This Course is Already Taken";
        }

        private bool CourseAlreadyTaken(int courseId,CourseEnrollment aCourseEnrollment)
        {
            string query = "SELECT * FROM IsCourseAlreadyTakenView WHERE Student_RegNo='" +aCourseEnrollment.AStudent.RegNo + "'";
            aConnection=new SqlConnection(connection);
            aConnection.Open();

            aCommand = new SqlCommand(query, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    int tempCourseId = (int)aReader[0];
                    if (tempCourseId == courseId)
                    {
                        return false;
                    }
                }
                
            }

            aConnection.Close();
            return true;
        }

        public List<Course> EnrollmentGridevieDataPicker(string regNo)
        {
            string query2 = "SELECT * FROM FillEnrollDataGridview WHERE Student_RegNo='" + regNo + "'";
            List<Course> aCourses=new List<Course>(); 
            aConnection=new SqlConnection(connection);
            
            aConnection.Open();

            aCommand = new SqlCommand(query2, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.CourseId = (int)aReader[0];
                    aCourse.CourseTitle = aReader[1].ToString();
                    aCourse.CourseName = aReader[2].ToString();
                    aCourses.Add(aCourse);
                }
                return aCourses;
            }

            aConnection.Close();
            return new List<Course>();
        }
    }
}
