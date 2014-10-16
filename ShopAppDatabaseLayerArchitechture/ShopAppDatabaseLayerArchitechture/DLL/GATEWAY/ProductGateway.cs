using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppDatabaseLayerArchitechture.DLL.DAO;

namespace ShopAppDatabaseLayerArchitechture.DLL.GATEWAY
{
    class ProductGateway
    {
        private string con = @"Data Source=RASIF-PC;Initial Catalog=ShopDatabase;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand aCommand;
        private SqlDataReader aReader;
        int oldquantity;
        public ProductGateway()
        {
            connection = new SqlConnection(con);
        }

        public bool IsAvaiable(Product aProduct)
        {
            
            int id = aProduct.ID;
            string query = string.Format("SELECT * FROM Product WHERE Id='{0}'", id);


            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                
                while (aReader.Read())
                {
                    oldquantity = Convert.ToInt16(aReader[2]);
                }
                connection.Close();
                return ProductUpdate(aProduct,oldquantity);
                
            }
            connection.Close();
            
            //*****Database Operation Ends********

            return ProductInsert(aProduct);
            
        }

        private bool ProductInsert(Product aProduct)
        {
            string query = string.Format("INSERT INTO Product VALUES ('{0}','{1}',{2})", aProduct.ID,aProduct.ProductCompany,aProduct.Quantity);
            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            int isAffected = aCommand.ExecuteNonQuery();

            connection.Close();
            //*****Database Operation Ends********
            return false;

        }

        private bool ProductUpdate(Product aProduct,int quantity)
        {
            int newQuantity = aProduct.Quantity + quantity;
            string query = "UPDATE Product SET Quantity=" + newQuantity + "WHERE Id=" + aProduct.ID;

            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            int isAffected = aCommand.ExecuteNonQuery();

            connection.Close();
            //*****Database Operation Ends********

            return true;

        }

        public List<Product> RetriveData()
        {
            string query = string.Format("SELECT * FROM Product");
            List<Product> products   = new List<Product>();

            //*****Database Operation Starts********
            connection.Open();

            aCommand = new SqlCommand(query, connection);

            aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.ID = (int)aReader[0];
                    aProduct.ProductCompany = aReader[1].ToString();
                    aProduct.Quantity = (int) aReader[2];
                    
                    products.Add(aProduct);
                }
            }

            connection.Close();
            //*****Database Operation Ends********
            return products;
        }
    }
}
