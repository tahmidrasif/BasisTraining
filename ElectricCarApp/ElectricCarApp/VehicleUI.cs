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
    public partial class VehicleUI : Form
    {
        private Vehicle aVehicle = new Vehicle();
     

        public VehicleUI()
        {
            InitializeComponent();
        }

        private void dischargeButton_Click(object sender, EventArgs e)
        {
            double stateOfCharge = Convert.ToDouble(stateOfChargeTextBox.Text);
            string msg=aVehicle.CalculateTimeToDischarge(stateOfCharge);
            DialogResult dr = MessageBox.Show(msg,"", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                
                   double money = aVehicle.CalculateMoneyToIncome(stateOfCharge);
                   incomeTextBox.Text = money.ToString();
                    stateOfChargeTextBox.Text = aVehicle.MIN_CHARGE.ToString();
                    dischargeButton.Enabled = false;

                
            }
           
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            aVehicle.name = vehicleNameTextBox.Text;
            aVehicle.regNo = regNoTextBox.Text;
           
            aVehicle.chargingTime = Convert.ToDouble(chargingTimeTextBox.Text);
            dischargeButton.Enabled = true;
            rechargeButton.Enabled = true;
            registryButton.Enabled = false;
        }

        private void rechargeButton_Click(object sender, EventArgs e)
        {
            double stateOfCharge = Convert.ToDouble(stateOfChargeTextBox.Text);
            string msg = aVehicle.Recharge(stateOfCharge);
            if (msg != "Invalid")
            {
                DialogResult dr = MessageBox.Show(msg, "", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {

                    stateOfChargeTextBox.Text = aVehicle.MAX_CHARGE.ToString();
                    expenseTextbox.Text = aVehicle.moneyToPay.ToString();
                    rechargeButton.Enabled = false;
                    incomeTextBox.Text = "";
                    dischargeButton.Enabled = true;

                }
            }

        }

       
    }
}
