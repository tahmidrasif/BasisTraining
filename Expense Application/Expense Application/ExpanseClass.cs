using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  CSVLib;
using  System.IO;

namespace Expense_Application
{
    public partial class ExpanseClass : Form
    {
        public ExpanseClass()
        {
            InitializeComponent();
        }
        string filepath = "addressbook5.csv";
        private double amount;
        private string category;
        private string perticular;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (AmountTxtBox.Text == "" || perticularTxtBox.Text == "")

            {
                MessageBox.Show("Empty Fileld");
                
            }

            else
            {
                amount = Convert.ToDouble(AmountTxtBox.Text);
                category = catergoryCombo1.SelectedItem.ToString();
                //MessageBox.Show(category);
                perticular = perticularTxtBox.Text;

                AmountTxtBox.Text = "";
                catergoryCombo1.Text = "";
                perticularTxtBox.Text = "";


                FileStream aStreamWriter = new FileStream(filepath, FileMode.Append);
                
                CsvFileWriter aWriter = new CsvFileWriter(aStreamWriter);
             
                List<string> aList = new List<string>();

                aList.Add(amount.ToString());
                aList.Add(category);
                aList.Add(perticular);

                aWriter.WriteRow(aList);
                MessageBox.Show("Successfully Saved");
                aStreamWriter.Close();
            }
            
        }

        private void vsShowButton_Click(object sender, EventArgs e)
        {

            FileStream aStream = new FileStream(filepath, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> newExpanseList = new List<string>();

            List<double> expenses= new List<double>();
            double totalExpense=0;
            double maxExpense;

            while (aReader.ReadRow(newExpanseList))
            {

               // double expense = Convert.ToDouble(newExpanseList[0]);

               // expenses.Add(expense);
                
                expenses.Add(Convert.ToDouble(newExpanseList[0]));



            }

            foreach (double expense in expenses )
            {
                totalExpense += expense;
            }
            vsTotalTxtBox.Text = totalExpense.ToString();
            aStream.Close();

            maxExpense = expenses.Max();
            maxTxtBox.Text = maxExpense.ToString();
            aStream.Close();
            
        }

        private void vceButton_Click(object sender, EventArgs e)
        {
            if (categoryCombo2.Text != "")
            {
                string selectedCategory;
                string category;
                double vceTotal = 0;
                FileStream aStream = new FileStream(filepath, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> newExpenseList = new List<string>();

                selectedCategory = categoryCombo2.SelectedItem.ToString();

                myListView.Items.Clear();
                while (aReader.ReadRow(newExpenseList))
                {


                    category = newExpenseList[1];


                    if (selectedCategory == category)
                    {

                        ListViewItem item = new ListViewItem();
                        item.Text = newExpenseList[0];
                        item.SubItems.Add(newExpenseList[1]);
                        item.SubItems.Add(newExpenseList[2]);
                        vceTotal += Convert.ToDouble(newExpenseList[0]);
                        myListView.Items.Add(item);


                    }
                    vceTotalTxtBox.Text = vceTotal.ToString();


                }

                aStream.Close();
            }
            
        }
    }
}
