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
        Queue<Customer> aQueue = new Queue<Customer>();
        public QueueManagementUI()
        {
            InitializeComponent();
        }

       private void enqueButton_Click(object sender, EventArgs e)
        {
           if (eNameTxtBox.Text != string.Empty && eComplainTxtBox.Text != string.Empty)
           {
               serialNo++;
               Customer aCustomer = new Customer();

               aCustomer.serial = serialNo;
               aCustomer.name = eNameTxtBox.Text;
               aCustomer.complain = eComplainTxtBox.Text;

               eNameTxtBox.Text = string.Empty;
               eComplainTxtBox.Text = string.Empty;

               
               aQueue.Enqueue(aCustomer);
               MessageBox.Show("Your Complain is Added");
               ListViewItem item = new ListViewItem();
               item.Text = aCustomer.serial.ToString();
               item.SubItems.Add(aCustomer.name);
               item.SubItems.Add(aCustomer.complain);
               myListView.Items.Add(item);

           }
           else
           {
               MessageBox.Show("Empty Name Or Complain");
           }
           
        }

       private void dequeButton_Click(object sender, EventArgs e)
       {
           if (aQueue.Count == 0)
           {
               MessageBox.Show("No Complain is Available in the Queue");
           }
           else
           {
               Customer dequeueCustomer= new Customer();
               dequeueCustomer = aQueue.Dequeue();
               dSerialTxtBox.Text=dequeueCustomer.serial.ToString();
               dNameTxtBox.Text = dequeueCustomer.name;
               dComplainTxtBox.Text = dequeueCustomer.complain;
               
               
               myListView.Items.Clear();
               

               foreach (Customer aCustomer in aQueue)
               {
                   ListViewItem item2 = new ListViewItem();
                   item2.Text = aCustomer.serial.ToString();
                   item2.SubItems.Add(aCustomer.name);
                   item2.SubItems.Add(aCustomer.name);

                   myListView.Items.Add(item2);
               }
           }
       }

      
    }
}
