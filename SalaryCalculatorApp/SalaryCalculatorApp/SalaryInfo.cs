using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryInfo
    {
        public string name;
      

        

        public double GetTotal(double basicAmount, double houseRent, double medicalRent)
        {
            
            double houseRentCalculation;
            double medicalCalculation;
            double totalSalary;

            houseRentCalculation =  (basicAmount*(houseRent/100));
            medicalCalculation = (basicAmount * (medicalRent / 100));
            totalSalary = basicAmount + houseRentCalculation + medicalCalculation;
            return totalSalary;
        }
    }
}
