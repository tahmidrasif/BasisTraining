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
        private Vehicle aVehicle;
        private PowerGrid aGrid = new PowerGrid();

        public PowerGridUI()
        {
            InitializeComponent();
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle();
            
            aVehicle.name = vehicleNameTextBox.Text;
            aVehicle.regNo = regNoTextBox.Text;
        
            aVehicle.stateOfCharge = Convert.ToDouble(stateofChargeTextBox.Text);
            aVehicle.chargingTime = Convert.ToDouble(chargingTimeTextBox.Text);
            //bool available = aGrid.CheckIfNotInTheQueue(aVehicle);
            //if (available)
            //{
            //    MessageBox.Show("Please Enter your State Of Charge Of Battery and Charging time");
            //    enqueueButton.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("The Car is already in the queue");
            //}
            string msg = aGrid.Check(aVehicle);
            MessageBox.Show(msg);
            ShowInGridView(aVehicle);
        }

       

        private void ShowInGridView(Vehicle aVehicle)
        {
            ListViewItem anItem=new ListViewItem();
            anItem.Text = aVehicle.name;

            anItem.SubItems.Add(aVehicle.regNo);
            anItem.SubItems.Add(aVehicle.stateOfCharge.ToString());
            anItem.SubItems.Add(aVehicle.timeToRecharge.ToString());
           
            powerGirdListView.Items.Add(anItem);
        }

     
    }
}
