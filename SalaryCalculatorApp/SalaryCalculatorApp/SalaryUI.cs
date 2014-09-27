using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryUI : Form
    {
        
        private double basicSalary;
        private double homeRent;
        private double medicalRent;
        private string name;
        private double totalSalary;
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SalaryInfo aSalaryInfo = new SalaryInfo();
            basicSalary = Convert.ToDouble(basicTxtBox.Text);
            homeRent = Convert.ToDouble(hRentTxtBox.Text);
            medicalRent = Convert.ToDouble(mRentTxtBox.Text);
            name = nameTxtBox.Text;
            aSalaryInfo.name = name;
            
            totalSalary=aSalaryInfo.GetTotal(basicSalary, homeRent, medicalRent);

            MessageBox.Show(aSalaryInfo.name+@" your total salary is: "+ totalSalary);
        }


    }
}
