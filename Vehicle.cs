using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelquantity;


        public Vehicle(double fuel, double FuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuel;    
            this.FuelConsumption = FuelConsumption;
          


        }
        public int TankCapacity { get; private set; }


        public double FuelQuantity
        {
            get => this.fuelquantity;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelquantity = 0;
                }
                else
                {
                    this.fuelquantity = value;
                }
            }
        }
        public double FuelConsumption { get; set; }
        
       

        




        public string Drive(double distance)
        {
            double requiredFuel = this.FuelConsumption * distance;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }




        public virtual void Refuel(double fuel)
        {
            if (fuel <=0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            this.FuelQuantity += fuel;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }

       
    }







}
