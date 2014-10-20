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
    public partial class PowerGridUI : Form
    {
        private Vehicle aVehicle = new Vehicle();
        private PowerGrid aGrid = new PowerGrid();

        public PowerGridUI()
        {
            InitializeComponent();
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            
            
            //aVehicle.name = vehicleNameTextBox.Text;
            //aVehicle.regNo = regNoTextBox.Text;
            //aVehicle.type = vehicleTypeTextBox.Text;
            //bool available = aGrid.CheckIfNotInTheQueue(aVehicle);
            //if (available)
            //{
            //    MessageBox.Show("Please Enter your State Of Charge Of Battery and Charging time");
            //    enqueueButton.Enabled = true;
            //}
            //else
            //{
    
            //}

        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
           

          
        }

        private void ShowInGridView(Vehicle aVehicle)
        {
            ListViewItem anItem=new ListViewItem();
            anItem.Text = aVehicle.name;
            anItem.SubItems.Add(aVehicle.type);
            anItem.SubItems.Add(aVehicle.regNo);
           
            powerGirdListView.Items.Add(anItem);
        }

     
    }
}
