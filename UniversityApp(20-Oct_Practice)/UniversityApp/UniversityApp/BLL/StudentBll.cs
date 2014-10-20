using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.GATEWAY;

namespace UniversityApp.BLL
{
    class StudentBll
    {
        private StudentGateway aStudentGateway;

        public string SaveIntoDataBase(Student aStudent)
        {
            if (aStudent.RegistationNumber != string.Empty && aStudent.Email != string.Empty &&
                aStudent.Address != string.Empty)
            {

                aStudentGateway = new StudentGateway();
                int isAffected = aStudentGateway.SaveIntoDataBase(aStudent);
                if (isAffected == 1)
                {
                    return "Successfully Inserted";
                }
                return "Invalid Insertion";
            }
            return "Please Fill Up All The Text Boxes";
        }

        public List<Student> GetAllStudent()
        {
             aStudentGateway = new StudentGateway();
             List<Student> students=new List<Student>();
             students=aStudentGateway.GetAllStudent();
             return students;
        }

        
    }
}
