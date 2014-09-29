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
           if (eNameTxtBox.Text != string.Empty && eComplainTxtBox.Text != string.Empty) //checking if Empty input is inserted
           {
               serialNo++; 
               Customer aCustomer = new Customer();

               //aCustomer.serial = serialNo;
               //aCustomer.name = eNameTxtBox.Text;
               //aCustomer.complain = eComplainTxtBox.Text;

               aCustomer.Name = eNameTxtBox.Text;
               aCustomer.Serial = serialNo;
               aCustomer.Complain = eComplainTxtBox.Text;

               eNameTxtBox.Text = string.Empty;
               eComplainTxtBox.Text = string.Empty;

               
               aQueue.Enqueue(aCustomer);
               MessageBox.Show("Your Complain is Added");

               ListViewItem item = new ListViewItem();

               item.Text = aCustomer.Serial.ToString();
               item.SubItems.Add(aCustomer.Name);
               item.SubItems.Add(aCustomer.Complain);
               myListView.Items.Add(item);

           }
           else
           {
               MessageBox.Show(@"Empty Name Or Complain");
           }
           
        }

       private void dequeButton_Click(object sender, EventArgs e)
       {
           if (aQueue.Count == 0)
           {
               MessageBox.Show(@"No Complain is Available in the Queue");
           }
           else
           {
               Customer dequeueCustomer= new Customer();
               dequeueCustomer = aQueue.Dequeue();
               dSerialTxtBox.Text=dequeueCustomer.Serial.ToString();
               dNameTxtBox.Text = dequeueCustomer.Name;
               dComplainTxtBox.Text = dequeueCustomer.Complain;
               
               
               myListView.Items.Clear();
               
               //Filling up listview items again

               foreach (Customer aCustomer in aQueue)
               {
                   ListViewItem item2 = new ListViewItem();
                   item2.Text = aCustomer.Serial.ToString();
                   item2.SubItems.Add(aCustomer.Name);
                   item2.SubItems.Add(aCustomer.Complain);

                   myListView.Items.Add(item2);
               }
           }
       }

      
    }
}
