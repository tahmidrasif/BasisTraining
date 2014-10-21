using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;

namespace UniversityApp.DAL.GATEWAY
{
    class EnrollmentGateway
    {
        private string connection = ConfigurationManager.ConnectionStrings["UniversityApp"].ConnectionString;
            private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        Enrollment aEnrollment=new Enrollment();
        Course aCourse=new Course();
        public Enrollment GetAnEnrollment()
        {
            string command = string.Format("SELECT * FROM EnrollmentInformationView");
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command, aConnection);

            aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aCourse.Code = aReader[0].ToString();
                    aEnrollment.AStudent.RegistationNumber = aReader[1].ToString();
                    aEnrollment.AStudent.Email = aReader[2].ToString();
                    aEnrollment.AStudent.Address = aReader[3].ToString();
                    aCourse.Name = aReader[4].ToString();
                    aCourse.Credit = (float) aReader[4];
                    aEnrollment.Courses.Add(aCourse);
                }
                return aEnrollment;
            }
            return new Enrollment();

        }

        public int InsertIntoDatabase(string courseId, string regNo, DateTime aDateTime)
        {
            //string studentRegNo = aCourseEnrollment.AStudent.RegNo;

            string query = string.Format("INSERT INTO Enrollment VALUES ('{0}','{1}','{2}')", courseId, regNo, aDateTime);

            aConnection = new SqlConnection(connection);
            aConnection.Open();

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int isAffected = aCommand.ExecuteNonQuery();
            return isAffected;

          
        }
    }
}
