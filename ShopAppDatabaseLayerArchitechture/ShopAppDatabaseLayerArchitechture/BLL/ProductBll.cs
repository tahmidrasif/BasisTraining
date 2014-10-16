using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppDatabaseLayerArchitechture.DLL.DAO;
using ShopAppDatabaseLayerArchitechture.DLL.GATEWAY;

namespace ShopAppDatabaseLayerArchitechture.BLL
{
    class ProductBll
    {
        ProductGateway aProductGateway = new ProductGateway();
        public string Check(Product aProduct)
        {
            
            if (aProductGateway.IsAvaiable(aProduct))
            {
                return "Product is updated";
            }
            return "New Product Added";
        }

        public List<Product> RetriveData()
        {
            List<Product> products = new List<Product>();
            products = aProductGateway.RetriveData();
            return products;
        }
    }
}
