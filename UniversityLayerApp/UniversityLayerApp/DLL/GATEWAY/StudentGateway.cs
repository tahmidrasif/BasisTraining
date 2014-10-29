using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLayerApp.DLL.DAO;

namespace UniversityLayerApp.DLL.GATEWAY
{
    class StudentGateway
    {
       
        private string con = @"Data Source=RASIF-PC;Initial Catalog=UniversiyDatabase;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;

        public StudentGateway()
        {
            connection = new SqlConnection(con);
        }

        public int Save(Student aStudent)
        {

            string query = string.Format("INSERT INTO StudentInfo VALUES ('{0}','{1}','{2}',{3})", aStudent.StudentName,aStudent.Email,aStudent.Address,aStudent.DepertmentId);

            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            int isAffected = aCommand.ExecuteNonQuery();
            
            connection.Close();
            //*****Database Operation Ends********

            return isAffected;
        }

        public bool CheckEmail(Student aStudent)
        {
            string email = aStudent.Email;
            string query = string.Format("SELECT * FROM StudentInfo WHERE Email='{0}'",email);
           

            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                return false;
            }

            connection.Close();
            //*****Database Operation Ends********
            return true;

            


        }

        public List<Student> RetriveData()
        {
            string query = string.Format("SELECT * FROM StudentInfo");
            List<Student> students=new List<Student>();

            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.ID = (int)aReader[0];
                    aStudent.StudentName = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    aStudent.Address = aReader[3].ToString();
                    aStudent.DepertmentId = (int)aReader[4];
                    students.Add(aStudent); 
                }
            }
            
            connection.Close();
            //*****Database Operation Ends********
            return students;
        }
    }
}
