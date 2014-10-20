using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class CourseUI : Form
    {
        public CourseUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Course aCourse=new Course();
            aCourse.Code = codeTextBox.Text;
            aCourse.Name = nameTextBox.Text;
            aCourse.Credit = (float) Convert.ToDouble(creditTextBox.Text);

            CourseBll aCourseBll = new CourseBll();
            string msg = aCourseBll.SaveIntoDataBase(aCourse);
            MessageBox.Show(msg);

        }

     
    }
}
