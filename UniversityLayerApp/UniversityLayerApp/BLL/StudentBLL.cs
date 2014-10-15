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
         StudentGateway aStudentGateway = new StudentGateway();

        public string Save(Student aStudent)
        {
            if (aStudent.StudentName != string.Empty || aStudent.Email != string.Empty ||aStudent.Address != string.Empty)
            {
                if (HasthisEmailValid(aStudent))
                {
                    int isAffected = aStudentGateway.Save(aStudent);
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
                    return "This Email Id Is already Registerd";
                }
                
            }
            else
            {
                return "Please Fill up Fields";
            }
        }

        private bool HasthisEmailValid(Student aStudent)
        {
            return aStudentGateway.CheckEmail(aStudent);
        }
    }
}
