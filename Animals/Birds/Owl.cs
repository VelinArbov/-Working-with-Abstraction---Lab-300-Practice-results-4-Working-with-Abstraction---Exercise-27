using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight,  double wingsize) : base(name, weight, wingsize)
        {
        }
        public override void Eat(Food food)
        {
            string typefood = food.GetType().Name;
            if (typefood == "Meat")
            {
                this.Weight += food.Quantity * 0.25;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} does not eat {typefood }!");
            }

        }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }
    }
}
