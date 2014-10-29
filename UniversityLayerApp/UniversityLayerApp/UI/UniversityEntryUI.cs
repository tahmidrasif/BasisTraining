using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepertmentApp;
using UniversityLayerApp.BLL;
using UniversityLayerApp.DLL.DAO;
using UniversityLayerApp.DLL.DAO.VIEW;

namespace UniversityLayerApp
{
    public partial class UniversityEntryUI : Form
    {
        
        public UniversityEntryUI()
        {
            InitializeComponent();
            ShowDataGridView();
        }

        private void ShowDataGridView()
        {
            int number = 1;
            List<StudentDeperetmentInfo> studentDeperetmentInfoList = new List<StudentDeperetmentInfo>();
            StudentDepertmentViewBll aStudentdepertmentviewbll = new StudentDepertmentViewBll();
            studentDeperetmentInfoList = aStudentdepertmentviewbll.GetData();
            //deptStudentDataGridView.DataSource = studentDeperetmentInfoList;
          

        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUi=new StudentEntryUI();
            aStudentEntryUi.Show();
        }

        private void depertmentEntryButton_Click(object sender, EventArgs e)
        {
            DepertmentEntryUI aDepertmentEntryUi=new DepertmentEntryUI();
            aDepertmentEntryUi.ShowDialog();
        }

        private void UniversityEntryUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universiyDatabaseDataSet.StudentDepertmentView' table. You can move, or remove it, as needed.
            this.studentDepertmentViewTableAdapter.Fill(this.universiyDatabaseDataSet.StudentDepertmentView);

        }

     
    }
}
