using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLayerApp.BLL;
using UniversityLayerApp.DLL.DAO;

namespace DepertmentApp
{
    public partial class DepertmentEntryUI : Form
    {
        private DepertmentBLL aDepertmentBll;
        private List<Depertment> dataSource;

        public DepertmentEntryUI()
        {
            InitializeComponent();
            ShowInGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Depertment aDepertment =new Depertment(nameTextBox.Text,codeTextBox.Text);
            aDepertmentBll = new DepertmentBLL();
            string messege=aDepertmentBll.CheckAndSave(aDepertment);
            MessageBox.Show(messege);
            ShowInGridView();
           
        }

        private void ShowInGridView()
        {
            dataSource = new List<Depertment>();
            aDepertmentBll=new DepertmentBLL();
            dataSource = aDepertmentBll.Retrivedata();
            departmentGridView.DataSource = dataSource;
        }
    }
}
