using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppDatabaseLayerArchitechture.DLL.DAO;

namespace ShopAppDatabaseLayerArchitechture.BLL
{
    class SupershopBll
    {
        public string Check(Supershop aSupershop)
        {
            if (aSupershop.ShopName != string.Empty || aSupershop.Address != string.Empty)
            {
                return "Supershop named " + aSupershop.ShopName + " is saved";
            }
            return "Please Fill up the Box";
        }
    }
}
