using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.GateWay;

namespace BootCampApp.BusinessLogicLayer
{
    class CourseEnrollmentBll
    {
        
        public int studentCount = 0;
        private CourseEnrollment aCourseEnrollment;
        CourseEnrollmentGateway aCourseEnrollmentGateway=new CourseEnrollmentGateway();

        private string connection = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        private SqlConnection aConnection;


        public CourseEnrollmentBll()
        {
            
        }
        public CourseEnrollment CheckRegNo(string regNo)
        {
            aCourseEnrollment = new CourseEnrollment();

            aCourseEnrollment = aCourseEnrollmentGateway.CheckRegNo(regNo);

            return aCourseEnrollment;
        }

        public List<Course> EnrollmentGridevieDataPicker(string regNo)
        {
            return aCourseEnrollmentGateway.EnrollmentGridevieDataPicker(regNo);
        }

        public string InsertIntoDatabase(int courseId, DateTime aDateTime, CourseEnrollment courseEnrollment)
        {
            if (CourseAlreadyTaken(courseId, aCourseEnrollment))
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

        private bool CourseAlreadyTaken(int courseId, CourseEnrollment courseEnrollment)
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
