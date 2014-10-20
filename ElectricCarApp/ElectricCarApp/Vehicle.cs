using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarApp
{
    class Vehicle
    {
        public double MIN_CHARGE = 10;
        public double MAX_CHARGE = 100;
        public string name;
        public string type;
        public string regNo;
        public double stateOfCharge;
        public double chargingTime;
        public double timeToDischarge;
        public double timeToRecharge;
        public double moneyToPay;

       public string CalculateTimeToDischarge(double stateOfChargeparameter)
        {
            if (stateOfChargeparameter > 10)
            {
                stateOfCharge = stateOfChargeparameter;
                timeToDischarge = (stateOfCharge- MIN_CHARGE)*chargingTime;

                return "You Need " + timeToDischarge + " minutes to Discharge";
            }
            return "Your car is not avaiable for Discharge";
        }

        public double CalculateMoneyToIncome()
        {
            PowerGrid aPowerGrid=new PowerGrid();
            double money = timeToDischarge*aPowerGrid.sellingCostPerUnit;
            return money;
        }

        public string Recharge(double stateofcharge)
        {
            if (stateofcharge != 100 || stateOfCharge > 100 || stateOfCharge < 0)
            {
                PowerGrid aPowerGrid = new PowerGrid();
                timeToRecharge = (MAX_CHARGE - stateofcharge)*chargingTime;
                moneyToPay = timeToRecharge*aPowerGrid.sellingCostPerUnit;           
                return "You need " + timeToRecharge + " time to Recharge Your Vehicle and Your cost is " +
                        moneyToPay+ " taka";
            }
            return "Invalid";
        }
    }
}
