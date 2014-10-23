using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppExam.DAL.DAO;
using ShopAppExam.DAL.GATEWAY;

namespace ShopAppExam.BLL
{
    class InventoryBll
    {
        private Shop aShop;
        private InventoryGateway aInventoryGateway;

        public Shop GetAllData()
        {
            aShop = new Shop();
            aInventoryGateway = new InventoryGateway();
            aShop=aInventoryGateway.GetAllData();
            return aShop;
        }
    }
}
