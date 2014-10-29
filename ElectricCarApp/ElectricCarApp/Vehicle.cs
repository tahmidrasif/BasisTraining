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
        public double BATTERY_CAPACITY = 4.4;
        public string name;
        public string regNo;
        public double stateOfCharge;
        public double chargingTime;
        public double timeToDischarge;
        public double timeToRecharge;
        public double moneyToPay;
        public double powerToRecharge;
        public double powerToDischarge;

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

        public double CalculateMoneyToIncome(double stateofCharge)
        {
            PowerGrid aPowerGrid=new PowerGrid();
            powerToDischarge = ((stateOfCharge - MIN_CHARGE)*BATTERY_CAPACITY)/100;
            double money = powerToDischarge*aPowerGrid.sellingCostPerUnit;
            return money;
        }

        public string Recharge(double stateofchargeParameter)
        {
            if (stateofchargeParameter != 100 || stateofchargeParameter > 100 || stateofchargeParameter < 0)
            {
                PowerGrid aPowerGrid = new PowerGrid();
                powerToRecharge = ((MAX_CHARGE - stateofchargeParameter) * BATTERY_CAPACITY) / 100;
                timeToRecharge = (MAX_CHARGE - stateofchargeParameter) * chargingTime;
                moneyToPay = powerToRecharge*aPowerGrid.sellingCostPerUnit;           
                return "You need "+powerToRecharge+"kwh power and " + timeToRecharge + " minutes to Recharge Your Vehicle and Your cost is " +
                        moneyToPay+ " taka";
            }
            return "Invalid";
        }
    }
}
