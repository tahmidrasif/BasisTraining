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

        public StudentGateway()
        {
            connection = new SqlConnection(con);
        }

        public int Save(Student aStudent)
        {

            string query = string.Format("INSERT INTO StudentInfo VALUES ('{0}','{1}','{2}')", aStudent.StudentName,aStudent.Email,aStudent.Address);

            //*****Database Operation Starts********
            connection.Open();

            SqlCommand aCommand = new SqlCommand(query, connection);

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

            SqlCommand aCommand = new SqlCommand(query, connection);

            SqlDataReader aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                return false;
            }
            connection.Close();

            return true;

            //*****Database Operation Ends********


        }
    }
}
