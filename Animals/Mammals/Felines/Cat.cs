using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight,  livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            string typefood = food.GetType().Name;
            if (typefood == "Meat" || typefood == "Vegetable")
            {
                this.Weight += food.Quantity * 0.3;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} does not eat {typefood }!");
            }

        }


        public override string ProducingSound()
        {
            return "Meow";
        }
    }
}
   

