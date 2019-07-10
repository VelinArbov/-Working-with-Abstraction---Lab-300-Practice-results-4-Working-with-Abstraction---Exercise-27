using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingsize) : base(name, weight,  wingsize)
        {
        }
        public override void Eat(Food food)
        {
          
                this.Weight += food.Quantity * 0.35;
                this.FoodEaten += food.Quantity;
          

        }

        public override string ProducingSound()
        {
            return "Cluck";
        }
    }
}
