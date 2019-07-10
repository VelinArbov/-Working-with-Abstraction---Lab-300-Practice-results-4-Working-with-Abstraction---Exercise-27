using _03WildFarm.Animals.Birds;
using _03WildFarm.Animals.Mammals;
using _03WildFarm.Animals.Mammals.Felines;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm
{
    public static class animalFactory
    {

        public static Animal Create (params string[] animalArgs)
        {

            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);
            if ( type == nameof(Hen))
            {
                return new Hen(name, weight, double.Parse(animalArgs[3]));
            }
            else if (type == nameof(Owl))
            {
                return new Owl(name, weight, double.Parse(animalArgs[3]));
            }
         
            else if (type == nameof(Mouse))
            {
                return new Mouse(name, weight, animalArgs[3]);
            }
            else if (type == nameof(Dog))
            {
                return new Dog(name, weight, animalArgs[3]);
            }
            else if (type == nameof(Cat))
            {
                return new Cat(name, weight, animalArgs[3], animalArgs[4]);
            }
            else if (type == nameof(Tiger))
            {
                return new Tiger(name, weight, animalArgs[3], animalArgs[4]);
            }

            return null;

        }
    }
}
