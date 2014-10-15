using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class StudentDatabaseUI : Form
    {
        private string con=@"Data Source=RASIF-PC;Initial Catalog=UniversiyDatabase;Integrated Security=True";
        private Student aStudent;
        private List<Student> students;


        public StudentDatabaseUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = studentNameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;

            aStudent = new Student(name,address,email);
            string query = string.Format("INSERT INTO StudentInfo VALUES ('{0}','{1}','{2}')", name, email, address);
            
            SqlConnection connection= new SqlConnection(con);
            connection.Open();
            
            SqlCommand aCommand= new SqlCommand(query,connection);
            
            int isAffected = aCommand.ExecuteNonQuery();
            connection.Close();
            if (isAffected > 0)
            {
                MessageBox.Show("1 row is updated");
            }
            else
            {
                MessageBox.Show("Problem");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM StudentInfo";
            students = new List<Student>();

            SqlConnection connection = new SqlConnection(con);
            connection.Open();

            SqlCommand aCommand = new SqlCommand(query, connection);

            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent=new Student();
                    aStudent.ID = (int) aReader[0];
                    aStudent.StudentName = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    aStudent.Address = aReader[3].ToString();
                    students.Add(aStudent);
                }
            }
            connection.Close();
            studentGridView.DataSource = students;
        }
    }
}
