using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepertmentApp.DLL.DAO;

namespace DepertmentApp.DLL.GATEWAY
{
    class DepertmentGateway
    {

        private string con = @"Data Source=RASIF-PC;Initial Catalog=UniversiyDatabase;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;

        public DepertmentGateway()
        {
            connection = new SqlConnection(con);
        }

        public bool Check(Depertment aDepertment)
        {
            string name = aDepertment.DepertmentName;
            string query = string.Format("SELECT * FROM DepertmentInfo WHERE DeptName='{0}'", name);


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

        public int SaveInDatabase(Depertment aDepertment)
        {
            string query = string.Format("INSERT INTO DepertmentInfo VALUES ('{0}','{1}')",aDepertment.DepertmentName,aDepertment.DepertmentCode );  
            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            int isAffected = aCommand.ExecuteNonQuery();

            connection.Close();
            //*****Database Operation Ends********

            return isAffected;
        }

        public List<Depertment> RetrivedataFromDatabase()
        {
            string query = @"SELECT * FROM DepertmentInfo";
            List<Depertment> depertments= new List<Depertment>();

            //*****Database Operation Starts********
            connection.Open();

            aCommand=new SqlCommand(query,connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Depertment aDepertment= new Depertment();
                    aDepertment.DepertmentID = (int) aReader[0];
                    aDepertment.DepertmentName = aReader[1].ToString();
                    aDepertment.DepertmentCode = aReader[2].ToString();
                    depertments.Add(aDepertment);
                }
            }
            connection.Close();
            //*****Database Operation Ends********

            return depertments;
        }
    }
}
