using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Student(string studentName, string address, string email):this()
        {
            StudentName = studentName;
            Address = address;
            Email = email;
        }

        public Student()
        {
            
        }
    }
}
