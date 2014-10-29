using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLayerApp.DLL.DAO.VIEW;

namespace UniversityLayerApp.DLL.GATEWAY
{
    class StudentDepertmentGateway
    {
         private string con = @"Data Source=RASIF-PC;Initial Catalog=UniversiyDatabase;Integrated Security=True";
         private SqlConnection connection;
         private SqlCommand aCommand;
         private SqlDataReader aReader;
         public StudentDepertmentGateway()
            {
                connection = new SqlConnection(con);
            }
        public List<StudentDeperetmentInfo> GetData()
        {
            string query = "SELECT * FROM StudentDepertmentView";
            List<StudentDeperetmentInfo> studentDeperetmentInfos=new List<StudentDeperetmentInfo>();
            //Database Statrs
            connection.Open();

            aCommand=new SqlCommand(query,connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    StudentDeperetmentInfo aStudentDeperetmentInfo=new StudentDeperetmentInfo();
                    aStudentDeperetmentInfo.ID =(int) aReader[0];
                    aStudentDeperetmentInfo.StudentName =aReader[1].ToString();
                    aStudentDeperetmentInfo.Email = aReader[2].ToString();
                    aStudentDeperetmentInfo.Address = aReader[3].ToString();
                    aStudentDeperetmentInfo.DepertmentName = aReader[4].ToString();
                    aStudentDeperetmentInfo.DepertmentCode = aReader[5].ToString();
                    studentDeperetmentInfos.Add(aStudentDeperetmentInfo);
                }
                connection.Close();
                return studentDeperetmentInfos;
            }
            return new List<StudentDeperetmentInfo>();
        }
    }
}
