using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDatabaseLayerArchitechture.DLL.DAO
{
    class Product
    {
        public int ID { get; set; }
        public string ProductCompany { get; set; }
        public int Quantity { get; set; }

        public Product(int id,string productCompany, int quantity):this()
        {
            ID = id;
            Quantity = quantity;
            ProductCompany = productCompany;
        }

        public Product()
        {
            
        }
    }
}
