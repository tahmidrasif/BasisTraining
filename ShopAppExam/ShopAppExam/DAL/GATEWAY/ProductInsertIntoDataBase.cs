using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppExam.DAL.DAO;

namespace ShopAppExam.DAL.GATEWAY
{
    class ProductInsertIntoDataBase
    {
        public int name;
        public int code;
        public int both;
        private string connection = ConfigurationManager.ConnectionStrings["ShopDatabase"].ConnectionString;
        private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        public int Save(Product aProduct)
        {
            string command = string.Format("INSERT INTO  Products VALUES ('{0}','{1}',{2})", aProduct.ProductCode,aProduct.ProductName,aProduct.Quantity);
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command, aConnection);

            int isAffected = aCommand.ExecuteNonQuery();

            aConnection.Close();

            return isAffected;
        }

        public bool ProductNotInTheDatabase(Product aProduct)
        {
            
            string command = "SELECT * FROM Products WHERE Product_Code='"+aProduct.ProductCode+"'";
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command, aConnection);

            aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                code++;
                
            }
            aConnection.Close();
            string command2 = "SELECT * FROM Products WHERE Product_Name='" + aProduct.ProductName + "'";
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command2, aConnection);

            aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                
                    name++;
               
               

            }
            aConnection.Close();
            if ((name == 1) || (code == 1) || (both == 1))
                return false;
            else
            {
                return true;
            }
        }
    }
}
