using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp
{
    class CourseEnrollment
    {

        public Student AStudent { get; set; }
        public List<Course> Courses { get; set; }

        public CourseEnrollment()
        {
            AStudent=new Student();
            Courses=new List<Course>();
        }

    
    }
}
