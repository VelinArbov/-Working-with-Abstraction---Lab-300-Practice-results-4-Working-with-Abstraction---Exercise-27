using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {

        private const double additionalConsumption = 0.9;

        public Car(double fuel, double FuelConsumption, int tankCapacity) : base(fuel, FuelConsumption+additionalConsumption, tankCapacity)
        {
        }

       
    }
}
