using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Mammals
{

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            string typefood = food.GetType().Name;
            if (typefood == "Fruit" || typefood == "Vegetable")
            {
                this.Weight += food.Quantity * 0.1;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Mouse does not eat {typefood }!");
            }

        }

        public override string ProducingSound()
        {
            return "Squeak"; ;
        }
    }
}
