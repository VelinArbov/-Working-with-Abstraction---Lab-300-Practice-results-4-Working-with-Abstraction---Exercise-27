using _03WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm
{
    public static class foodFactory
    {
        public static Food Create(params string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);
            if (type == nameof(Vegetable))
            {
                return new Vegetable(quantity);
            }
            else if (type == nameof(Seeds))
            {
                return new Seeds(quantity);
            }
            else if (type == nameof(Meat))
            {
                return new Meat(quantity);

            }
            else if (type == nameof(Fruit))
            {
                return new Fruit(quantity);

            }
            return null;
        }
    }
}
