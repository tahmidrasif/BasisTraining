using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAppExam.DAL.DAO;
using ShopAppExam.DAL.GATEWAY;

namespace ShopAppExam.BLL
{
    class ProductBll
    {
        //Shop aShop=new Shop();
        public string SaveIntoDataBase(Product aProduct)
        {
            if (ProductIsValid(aProduct))
            {
                ProductInsertIntoDataBase aDataBase = new ProductInsertIntoDataBase();
                if (aDataBase.ProductNotInTheDatabase(aProduct))
                {
                    int isAffected = aDataBase.Save(aProduct);
                    if (isAffected > 0)
                    {

                        return "Data Is Inserted";
                    }
                    return "Data Saving is error";
                }
                else if(aDataBase.name==1&&aDataBase.code==0)
                {
                    return "Name Already Exist";
                }
                else if (aDataBase.code == 1&&aDataBase.name==0)
                {
                    return "Code Already Exist";
                }
                else if (aDataBase.code == 1 && aDataBase.name == 1)
                {
                    return "Both Already Exist";
                }

            }
            return "Name or Code is invalid . . . . . . Name should be 5 to 10 Charechters and Code Should be 3 charecters";
        }

        private bool ProductIsValid(Product aProduct)
        {
            if (aProduct.ProductCode.Length == 3 &&(aProduct.ProductName.Length>=5&&aProduct.ProductName.Length<=10))
            {
                return true;
            }
            return false;
        }
    }
}
