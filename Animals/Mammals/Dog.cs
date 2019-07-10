using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            string typefood = food.GetType().Name;
            if (typefood == "Meat")
            {
                this.Weight += food.Quantity * 0.4;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} does not eat {typefood }!");
            }

        }

        public override string ProducingSound()
        {
            return "Woof!";
        }
    }
}
