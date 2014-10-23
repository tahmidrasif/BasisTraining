using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppExam.DAL.DAO
{
    class Shop
    {
        public int TotalProducts { get; set; }
        public List<Product> Products { get; set; }

        public Shop()
        {
            Products=new List<Product>();
        }

    }
}
