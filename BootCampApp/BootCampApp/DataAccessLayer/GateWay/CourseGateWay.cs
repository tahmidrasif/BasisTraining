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
    class CourseGateWay
    {
        private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;

        public CourseGateWay()
        {
            string connection = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
            aConnection = new SqlConnection(connection);

        }

        public List<Course> GetAllCourse()
        {
            List<Course> courses=new List<Course>();
            string query = "SELECT * FROM  t_Course";
          
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
                    courses.Add(aCourse);
                }
            }
            return courses;
        }
    }
}
