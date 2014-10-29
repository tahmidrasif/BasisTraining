using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLayerApp.DLL.DAO.VIEW;
using UniversityLayerApp.DLL.GATEWAY;

namespace UniversityLayerApp.BLL
{
    class StudentDepertmentViewBll
    {
        StudentDepertmentGateway aStudentDepertmentGateway=new StudentDepertmentGateway();
        public List<StudentDeperetmentInfo> GetData()
        {
            //List<StudentDeperetmentInfo> studentDeperetmentInfoList=new List<StudentDeperetmentInfo>();
           return aStudentDepertmentGateway.GetData();
        }
    }
}
