using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAppExam.BLL;
using ShopAppExam.DAL.DAO;

namespace ShopAppExam
{
    public partial class ShopUI : Form
    {
        private Product aProduct = new Product();
        private ProductBll aProductBll = new ProductBll();
        Shop aShop = new Shop();

        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aProduct.ProductCode = codeTextBox.Text;
            aProduct.ProductName = nameTextBox.Text;
            aProduct.Quantity = Convert.ToInt16(quantityTextBox.Text);
            string msg=aProductBll.SaveIntoDataBase(aProduct);
            MessageBox.Show(msg);
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            InventoryBll aInventoryBll=new InventoryBll();
            
            aShop=aInventoryBll.GetAllData();
            productsDataGridView.DataSource = aShop.Products;
            totalQuantityTextBox.Text = aShop.TotalProducts.ToString();
        }
    }
}
