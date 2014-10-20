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
        public Enrollment GetAnEnrollment()
        {
            EnrollmentGateway aEnrollmentGateway=new EnrollmentGateway();
            aEnrollment = aEnrollmentGateway.GetAnEnrollment();
            return aEnrollment;
        }
    }
}
