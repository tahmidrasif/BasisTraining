using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.GateWay;

namespace BootCampApp.BusinessLogicLayer
{
    class CourseEnrollmentBll
    {
        
        public int studentCount = 0;
        private CourseEnrollment aCourseEnrollment;
        CourseEnrollmentGateway aCourseEnrollmentGateway=new CourseEnrollmentGateway();

        


       
        public CourseEnrollment CheckRegNo(string regNo)
        {
            aCourseEnrollment = new CourseEnrollment();

            aCourseEnrollment = aCourseEnrollmentGateway.CheckRegNo(regNo);

            return aCourseEnrollment;
        }

        public List<Course> EnrollmentGridevieDataPicker(string regNo)
        {
            return aCourseEnrollmentGateway.EnrollmentGridevieDataPicker(regNo);
        }

        public string InsertIntoDatabase(int courseId, DateTime aDateTime, CourseEnrollment courseEnrollment)
        {

            if (courseEnrollment.AStudent.Name!=null&&courseEnrollment.AStudent.RegNo!=null&&courseEnrollment.AStudent.Email!=null)
            {
                if (CourseAlreadyTaken(courseId, aCourseEnrollment))
                {
                  int isAffected = aCourseEnrollmentGateway.InsertIntoDatabase(courseId, aDateTime, aCourseEnrollment);
                    
                    if (isAffected > 0)
                    {
                        return "Successfully Entered";
                    }
                    //return isAffected;
                    return "Failed to Insert";
                }
                return "This Course is Already Taken"; 
            }
            return "Fill Up All Fields";
        }

        private bool CourseAlreadyTaken(int courseId, CourseEnrollment courseEnrollment)
        {
            bool result = aCourseEnrollmentGateway.CourseAlreadyTaken(courseId, courseEnrollment);
            return result;
        }
    }
}
