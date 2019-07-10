using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double additionalConsumption = 1.6;
        private const double wastedFuel = 0.05;
        public Truck(double fuel, double FuelConsumption, int tankCapacity) : base(fuel , FuelConsumption + additionalConsumption, tankCapacity)
        {
        }



        //protected override double AdditionalConsumption => additionalConsumption;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
            this.FuelQuantity -= fuel * wastedFuel;
          
        }

    }
}
