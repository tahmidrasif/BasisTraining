using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopAppDatabaseLayerArchitechture.BLL;
using ShopAppDatabaseLayerArchitechture.DLL.DAO;

namespace ShopAppDatabaseLayerArchitechture
{
    public partial class ShopUI : Form
    {
        private Supershop aSupershop;
        private ProductBll aProductBll;

        public ShopUI()
        {
            InitializeComponent();
            ShowInGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aSupershop = new Supershop(shopNameTextBox.Text,shopAddressTextBox.Text);
            SupershopBll aSupershopBll=new SupershopBll();
            string messege=aSupershopBll.Check(aSupershop);
            MessageBox.Show(messege);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product aProduct=new Product(Convert.ToInt16(productIdTextBox.Text),productCompanyTextBox.Text,Convert.ToInt16(quantityTextBox.Text));

            aProductBll = new ProductBll();
            string msg=aProductBll.Check(aProduct);

            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowInGridView();
            
        }

        private void ShowInGridView()
        {
            aProductBll = new ProductBll();
            List<Product> products = new List<Product>();
            Product aProduct = new Product();
            products = aProductBll.RetriveData();
            productGridView.DataSource = products;
        }
      
    }
}
