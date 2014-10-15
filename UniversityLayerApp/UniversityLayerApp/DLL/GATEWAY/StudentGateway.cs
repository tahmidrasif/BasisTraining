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
        public int Save(Student aStudent)
        {

            string query = string.Format("INSERT INTO StudentInfo VALUES ('{0}','{1}','{2}')", aStudent.StudentName,aStudent.Email,aStudent.Address);

            SqlConnection connection = new SqlConnection(con);
            connection.Open();

            SqlCommand aCommand = new SqlCommand(query, connection);

            int isAffected = aCommand.ExecuteNonQuery();
            connection.Close();
            return isAffected;
        }
    }
}
