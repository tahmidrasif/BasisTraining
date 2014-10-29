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
        private StudentGateway aStudentGateway;

        public StudentBLL()
        {
            aStudentGateway = new StudentGateway();
        }

        public string Save(Student aStudent)
        {
            if (aStudent.StudentName != string.Empty || aStudent.Email != string.Empty ||aStudent.Address != string.Empty)
            {
                return ThisEmailIdIsAlreadyRegisterd(aStudent);
            }
            else
            {
                return "Please Fill up Fields";
            }
        }

        private string ThisEmailIdIsAlreadyRegisterd(Student aStudent)
        {
            if (HasthisEmailValid(aStudent))
            {
                return DataInsert(aStudent);
            }
            else
            {
                return "This Email Id Is already Registerd";
            }
        }

        private string DataInsert(Student aStudent)
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

        private bool HasthisEmailValid(Student aStudent)
        {
            return aStudentGateway.CheckEmail(aStudent);
        }

        public List<Student> RetriveData()
        {
            List<Student> students= new List<Student>();
            students= aStudentGateway.RetriveData();
            return students;
        }

      
    }
}
