using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDatabaseLayerArchitechture.DLL.DAO
{
    class Supershop
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
        public Product Products { get; set; }


        public Supershop(string shopName, string address)
        {
            ShopName = shopName;
            Address = address;
        }
    }
}
