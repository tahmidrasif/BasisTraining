using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.DAO
{
    class Enrollment
    {
        public Student AStudent { get; set; }
        public List<Course> Courses { get; set; }

        public Enrollment()
        {
            AStudent = new Student();
            Courses=new List<Course>();
        }
    }
}
