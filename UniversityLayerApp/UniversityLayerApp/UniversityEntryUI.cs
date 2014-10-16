using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLayerApp
{
    public partial class UniversityEntryUI : Form
    {
        public UniversityEntryUI()
        {
            InitializeComponent();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUi=new StudentEntryUI();
            aStudentEntryUi.Show();
        }

     
    }
}
