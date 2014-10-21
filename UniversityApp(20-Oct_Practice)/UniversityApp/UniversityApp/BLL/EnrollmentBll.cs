using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.GATEWAY;

namespace UniversityApp.BLL
{
    class EnrollmentBll
    {
        
        Enrollment aEnrollment=new Enrollment();
        EnrollmentGateway aEnrollmentGateway = new EnrollmentGateway();
        public Enrollment GetAnEnrollment()
        {
            
            aEnrollment = aEnrollmentGateway.GetAnEnrollment();
            return aEnrollment;
        }

        public string InsertIntoDatabase(string courseId, string regNo, DateTime aDateTime)
        {
            if (courseId!=null&&regNo!=null)
            {
                //if (CourseAlreadyTaken(courseId, aCourseEnrollment))
                //{
                    int isAffected = aEnrollmentGateway.InsertIntoDatabase(courseId, regNo,aDateTime);

                    if (isAffected > 0)
                    {
                        return "Successfully Entered";
                    }
                    //return isAffected;
                    return "Failed to Insert";
                //}
                return "This Course is Already Taken";
            }
            return "Fill Up All Fields";
        }
    }
}
