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
    class InventoryGateway
    {
        private string connection = ConfigurationManager.ConnectionStrings["ShopDatabase"].ConnectionString;
        private SqlConnection aConnection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        private Shop aShop = new Shop();
        

        public Shop GetAllData()
        {
            string command = string.Format("SELECT * FROM Products");
            aConnection = new SqlConnection(connection);

            aConnection.Open();

            aCommand = new SqlCommand(command, aConnection);

            aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                     Product aProduct = new Product();
                    aProduct.ProductCode = aReader[1].ToString();
                    aProduct.ProductName = aReader[2].ToString();
                    aProduct.Quantity = (int) aReader[3];
                    aShop.Products.Add(aProduct);
                    aShop.TotalProducts += aProduct.Quantity;

                }
                return aShop;
            }
            return new Shop();
        }
    }
}
