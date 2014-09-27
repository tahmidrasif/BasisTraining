using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }


         Account anAccount;
        private void createButton_Click(object sender, EventArgs e)
        {
            if (customerNameTxtBox.Text == string.Empty || acNumberTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                anAccount=new Account();
                createButton.Enabled = false;
                anAccount.Name = customerNameTxtBox.Text;
                anAccount.Number = acNumberTxtBox.Text;
            }
            
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            if (anAccount.Name != null && anAccount.Number != null)
            {
                if (amountTxtBox.Text!=string.Empty)
                {
                    
                    double aVariable = Convert.ToDouble(amountTxtBox.Text);
                    anAccount.Deposite(aVariable);
                    amountTxtBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Enter an amount you want to deposite...");
                }
            }
            else
            {
                MessageBox.Show("First you must create an account");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount.Name != null && anAccount.Number != null)
            {
                if (amountTxtBox.Text!=string.Empty)
                {
                    double aVariable = Convert.ToDouble(amountTxtBox.Text);
                    anAccount.Withdraw(aVariable);
                    amountTxtBox.Text =string.Empty;
                }
                else
                {
                    MessageBox.Show("Enter an amount you want to withdraw...");
                }
            }
            else
            {
                MessageBox.Show("First you must create an account");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (createButton.Enabled == false)
            {
                string name = anAccount.Name;
                string accNo = anAccount.Number;
                double balance = anAccount.Balance;
                MessageBox.Show(name + " your account number: " + accNo + " ant it's balance is: " + balance.ToString());
            }

            else
            {
                MessageBox.Show("Recheck account information");
            }
            
        }

      //  private void acNumberTxtBox_TextChanged(object sender, EventArgs e)
     //   {
     //       createButton.Enabled = true;
     //   }
    }
}
