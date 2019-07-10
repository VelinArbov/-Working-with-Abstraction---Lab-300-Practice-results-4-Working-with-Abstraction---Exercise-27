using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double addconsumption = 1.4;
       
        public Bus(double fuel, double FuelConsumption, int tankCapacity) : base(fuel, FuelConsumption+addconsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            
            this.FuelConsumption -= addconsumption;
            return base.Drive(distance);
        }
        
    }
}
