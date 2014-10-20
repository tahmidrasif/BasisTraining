using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCarApp
{
    class PowerGrid
    {
        

        public Queue<Vehicle> vehicles = new Queue<Vehicle>();

        public double sellingCostPerUnit=10;



        public string Check(Vehicle aVehicle)
        {

            if (aVehicle.stateOfCharge < 35)
            {
                return "The State of Charge is Not Enogh For Discharging";
            }
            else if (aVehicle.stateOfCharge >= 35 && aVehicle.stateOfCharge <= 100)
            {
                aVehicle.timeToRecharge = (aVehicle.MAX_CHARGE - aVehicle.stateOfCharge) * aVehicle.chargingTime;
                double moneyToPay = aVehicle.timeToRecharge * sellingCostPerUnit;
                VehicleEnterToQueue(aVehicle);
                return "You need " + aVehicle.timeToRecharge + " time to Recharge Your Vehicle and Your cost is " +
                        moneyToPay + " taka";
            }
            return "Input is invalid";
        }

        public void VehicleEnterToQueue(Vehicle aVehicle)
        {
            vehicles.Enqueue(aVehicle);
           // return "The Car is Ready to Supply Charge ...Please Wait in the Queue";
        }

        public bool CheckIfNotInTheQueue(Vehicle aVehicle)
        {

            if (!vehicles.Contains(aVehicle))
            {
                
                return true;
                
            }
            return false;
        }
    }
}
