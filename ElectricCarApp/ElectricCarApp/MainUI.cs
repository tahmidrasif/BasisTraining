using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricCarApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void vehicleUIButton_Click(object sender, EventArgs e)
        {
            VehicleUI aVehicleUi=new VehicleUI();
            aVehicleUi.ShowDialog();
        }

        private void powergridUIButton_Click(object sender, EventArgs e)
        {
            PowerGridUI aPowerGridUi=new PowerGridUI();
            aPowerGridUi.ShowDialog();
        }
    }
}
