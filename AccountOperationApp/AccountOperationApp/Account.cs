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

        public string Number
        {
            set
            {

                number = value;
            }

            get
            {

                return number;
            }

        }
        public string Name
        {
            set
            {

                name = value;
            }

            get
            {

                return name;
            }

        }

        public double Balance
        {
            
            get
            {

                return balance;
            }

        }


        /* public void SetName(string name)
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
        */
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
