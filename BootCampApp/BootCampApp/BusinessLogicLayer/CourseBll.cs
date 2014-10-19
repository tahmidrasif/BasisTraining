using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.GateWay;

namespace BootCampApp.BusinessLogicLayer
{
    class CourseBll
    {
        public CourseGateWay aCourseGateWay;
        CourseEnrollmentGateway aCourseEnrollmentgGateway=new CourseEnrollmentGateway();

        public List<Course> GetAllCourse()
        {
            aCourseGateWay=new CourseGateWay();
            return aCourseGateWay.GetAllCourse();
        }
    }
}
