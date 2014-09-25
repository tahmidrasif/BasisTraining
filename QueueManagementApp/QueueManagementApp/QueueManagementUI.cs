using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QueueManagementApp
{
    public partial class QueueManagementUI : Form
    {
        private int serialNo = 0;
        public QueueManagementUI()
        {
            InitializeComponent();
        }

       private void enqueButton_Click(object sender, EventArgs e)
        {
            serialNo++;
            Customer aCustomer = new Customer();

            aCustomer.serial = serialNo;
            aCustomer.name = eNameTxtBox.Text;
            aCustomer.complain = eComplainTxtBox.Text;

            eNameTxtBox.Text = string.Empty;
            eComplainTxtBox.Text = string.Empty;

            Queue<Customer> aQueue= new Queue<Customer>();
            aQueue.Enqueue(aCustomer);
            ListViewItem item=new ListViewItem();
            item.Text = aCustomer.serial.ToString();
            item.SubItems.Add(aCustomer.name);
            item.SubItems.Add(aCustomer.complain);
            myListView.Items.Add(item);
        }

      
    }
}
