using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManagementApp
{
    public class Customer
    {
        private int serial;
        private string name;
        private string complain;

        public int Serial
        {
            get
            {
                return serial;
            }
            set
            {
                serial = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Complain
        {
            get
            {
                return complain;
            }
            set
            {
                complain = value;
            }
        }

    }
}
