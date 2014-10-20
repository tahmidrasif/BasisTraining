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

        public double sellingCostPerUnit=100;

        
        
        //public string Check(Vehicle aVehicle)
        //{ 

        //    if (currentStateOfCharge < .35)
        //    {
        //        return "The Charge Of State is Not Enogh For Charging";
        //    }
        //    else if (currentStateOfCharge>=.35&&currentStateOfCharge<1)
        //    {
        //        return VehicleEnterToQueue(aVehicle);
        //    }
        //    return "Input is invalid";
        //}

        //public string VehicleEnterToQueue(Vehicle aVehicle)
        //{
        //    vehicles.Enqueue(aVehicle);
        //    return "The Car is Ready to Supply Charge ...Please Wait in the Queue";
        //}

        //public bool CheckIfNotInTheQueue(Vehicle aVehicle)
        //{

        //    if (!vehicles.Contains(aVehicle))
        //    {
        //        return true;
        //        //VehicleEnterToQueue(aVehicle);
        //    }
        //    return false;
        //}
    }
}
