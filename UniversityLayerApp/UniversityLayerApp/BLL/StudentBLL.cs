using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLayerApp.DLL.DAO;
using UniversityLayerApp.DLL.GATEWAY;

namespace UniversityLayerApp.BLL
{
    class StudentBLL
    {
        public string Save(Student aStudent)
        {
            if (aStudent.StudentName != string.Empty || aStudent.Email != string.Empty ||aStudent.Address != string.Empty)
            {
                StudentGateway aStudentGateway=new StudentGateway();
                int isAffected=aStudentGateway.Save(aStudent);
                if (isAffected > 0)
                {
                    return @"Insetion is successful";
                }
                else
                {
                    return "Data is not Inserted";
                }
                
            }
            else
            {
                return "Please Fill up Fields";
            }
        }
    }
}
