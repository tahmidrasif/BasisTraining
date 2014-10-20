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
    class CourseGateway
    {
        private string connection = ConfigurationManager.ConnectionStrings["UniversityApp"].ConnectionString;
        private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        public int SaveIntoDataBase(Course aCourse)
        {
            string command = string.Format("INSERT INTO Course VALUES ('{0}','{1}',{2})",aCourse.Code,aCourse.Name,aCourse.Credit);
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command, aConnection);

            int isAffected = aCommand.ExecuteNonQuery();

            aConnection.Close();

            return isAffected;
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            string query = "SELECT * FROM Course";

            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(query, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.Code = aReader[0].ToString();
                    aCourse.Name = aReader[1].ToString();
                    //aCourse.Credit =(float) aReader[2];
                    courses.Add(aCourse);
                }
            }

            aConnection.Close();
            return courses;
        }
    }
}
