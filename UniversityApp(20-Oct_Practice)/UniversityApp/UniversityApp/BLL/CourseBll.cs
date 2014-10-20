using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.GATEWAY;

namespace UniversityApp.BLL
{
    class CourseBll
    {
        private CourseGateway aCourseGateway;

        public string SaveIntoDataBase(Course aCourse)
        {
           
            if (aCourse.Code!=string.Empty&&aCourse.Name!=string.Empty)
            {

                aCourseGateway = new CourseGateway();
                int isAffected = aCourseGateway.SaveIntoDataBase(aCourse);
                if (isAffected == 1)
                {
                    return "Successfully Inserted";
                }
                return "Invalid Insertion";
            }
            return "Please Fill Up All The Text Boxes";
    
        }
        public List<Course> GetAllCourses()
        {
            aCourseGateway=new CourseGateway();
            List<Course> courses=new List<Course>();
            courses = aCourseGateway.GetAllCourses();
            return courses;
        }
    }
}
