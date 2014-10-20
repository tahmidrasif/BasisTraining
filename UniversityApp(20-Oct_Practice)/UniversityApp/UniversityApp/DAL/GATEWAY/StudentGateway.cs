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
    class StudentGateway
    {
        private string connection = ConfigurationManager.ConnectionStrings["UniversityApp"].ConnectionString;
        private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        public int SaveIntoDataBase(Student aStudent)
        {
            string command = string.Format("INSERT INTO Student VALUES ('{0}','{1}','{2}')",aStudent.RegistationNumber,aStudent.Email,aStudent.Address);
            aConnection=new SqlConnection(connection);
            
            aConnection.Open();

            aCommand=new SqlCommand(command,aConnection);

            int isAffected = aCommand.ExecuteNonQuery();

            aConnection.Close();

            return isAffected;

        }

        public List<Student> GetAllStudent()
        {
            List<Student> students=new List<Student>();
            string query = "SELECT * FROM Student";

            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(query, aConnection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.RegistationNumber = aReader[0].ToString();
                    aStudent.Email = aReader[1].ToString();
                    aStudent.Address = aReader[2].ToString();
                    students.Add(aStudent);
                }

                aConnection.Close();
                
            }
            return students;
        }
    }
}
