using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Mammals.Felines
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight,  livingRegion, breed)
        {
        }
        public override void Eat(Food food)
        {
            string typefood = food.GetType().Name;
            if (typefood == "Meat")
            {
                this.Weight += food.Quantity * 1.00;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} does not eat {typefood }!");
            }

        }

        public override string ProducingSound()
        {
            return "ROAR!!!"; 
        }
    }
}
