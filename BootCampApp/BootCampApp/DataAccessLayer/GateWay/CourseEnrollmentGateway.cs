using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp.DataAccessLayer.GateWay
{
    internal class CourseEnrollmentGateway
    {
        public int studentCount = 0;
        private CourseEnrollment aCourseEnrollment;

        private string connection = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        private SqlConnection aConnection;

        public CourseEnrollment CheckRegNo(string regNo)
        {
            aCourseEnrollment = new CourseEnrollment();
            aConnection = new SqlConnection(connection);


            string registrationNumber = regNo;
            string query1 = "SELECT * FROM CourseEnrollmentView1 WHERE Student_RegNo='" + registrationNumber + "'";


            aConnection.Open();

            aCommand = new SqlCommand(query1, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read() && studentCount == 0)
                {
                    aCourseEnrollment.AStudent.RegNo = aReader[0].ToString();
                    aCourseEnrollment.AStudent.Name = aReader[1].ToString();
                    aCourseEnrollment.AStudent.Email = aReader[2].ToString();
                    studentCount++;
                }
                studentCount = 0;
            }
            aConnection.Close();



            return GetCourseInfo(aCourseEnrollment);
        }

        private CourseEnrollment GetCourseInfo(CourseEnrollment courseEnrollment)
        {
            string query = "SELECT * FROM CourseEnrollmentView2 WHERE Student_RegNo='" + aCourseEnrollment.AStudent.RegNo + "'";
            aConnection.Open();

            aCommand = new SqlCommand(query, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.CourseId = (int)aReader[1];
                    aCourse.CourseTitle = aReader[2].ToString();
                    aCourse.CourseName = aReader[3].ToString();
                    aCourseEnrollment.Courses.Add(aCourse);
                }
            }

            aConnection.Close();
            return aCourseEnrollment;
        }


        public int InsertIntoDatabase(int courseId,DateTime aDateTime,CourseEnrollment aCourseEnrollment)
        {
            string studentRegNo = aCourseEnrollment.AStudent.RegNo;

            string query = string.Format("INSERT INTO t_StudentEnroll VALUES ('{0}','{1}','{2}')", studentRegNo, courseId, aDateTime);

            aConnection = new SqlConnection(connection);
            aConnection.Open();

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int isAffected = aCommand.ExecuteNonQuery();
            return isAffected;
        }

        public List<Course> EnrollmentGridevieDataPicker(string regNo)
        {
            string query = "SELECT * FROM FillEnrollDataGridview WHERE Student_RegNo='" + regNo + "'";
            List<Course> aCourses = new List<Course>();
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(query, aConnection);

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

        public bool CourseAlreadyTaken(int courseId, CourseEnrollment courseEnrollment)
        {
            string query = "SELECT * FROM IsCourseAlreadyTakenView WHERE Student_RegNo='" + aCourseEnrollment.AStudent.RegNo + "'";
            aConnection = new SqlConnection(connection);
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
    }

}
