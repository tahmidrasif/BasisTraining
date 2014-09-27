using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    class RunPoint
    {
        public static void Main()
        {
           /* Person aPerson = new Person();
            aPerson.firstName = "Rasif";
            aPerson.middleName = "Tahmid";
            aPerson.lastName = "Islam";

            string fullName = aPerson.GetFullName();
            string reverseFullName = aPerson.GetReverseFullName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseFullName);
            Console.ReadKey();*/
            PersonUI apPersonUi= new PersonUI();
            Application.Run(apPersonUi);
        }
    }
}
