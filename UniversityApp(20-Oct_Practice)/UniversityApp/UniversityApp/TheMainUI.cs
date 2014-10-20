using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class TheMainUI : Form
    {
        public TheMainUI()
        {
            InitializeComponent();
        }

        private void courseEntryButton_Click(object sender, EventArgs e)
        {
            CourseUI aCourseUi=new CourseUI();
            aCourseUi.ShowDialog();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentUI aStudentUi=new StudentUI();
            aStudentUi.ShowDialog();

        }

        private void enrollmentButton_Click(object sender, EventArgs e)
        {
            EnrollmentUI aEnrollmentUi=new EnrollmentUI();
            aEnrollmentUi.ShowDialog();
        }
    }
}
