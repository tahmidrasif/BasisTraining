using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepertmentApp.DLL.DAO
{
    class Depertment
    {
        public int DepertmentID { get; set; }
        public string DepertmentName { get; set; }
        public string DepertmentCode { get; set; }

        public Depertment(string depertmentName, string depertmentCode):this()
        {
            
            DepertmentName = depertmentName;
            DepertmentCode = depertmentCode;
        }

        public Depertment()
        {
            
        }
    }
}
