using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance=0;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetNumber(string number)
        {
            this.number = number;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNumber()
        {
            return number;
        }
        public double GetBalance()
        {
            return balance;
        }

        public void Deposite(double anAmount)
        {
            balance += anAmount;
            MessageBox.Show(anAmount + " amount is deposited");
        }

        public void Withdraw(double anAmount)
        {
            balance -= anAmount;
            MessageBox.Show(anAmount + " amount is Withdrawn");
        }

        

    }
}
