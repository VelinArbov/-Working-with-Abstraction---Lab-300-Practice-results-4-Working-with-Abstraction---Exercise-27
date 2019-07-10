using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingsize) : base(name, weight)
        {
            this.WingSize = wingsize;
        }

        public double WingSize { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }



       
        
    }
}
