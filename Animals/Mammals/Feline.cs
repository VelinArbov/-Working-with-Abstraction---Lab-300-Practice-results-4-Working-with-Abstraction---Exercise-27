using System;
using System.Collections.Generic;
using System.Text;

namespace _03WildFarm.Animals.Mammals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight,  string livingRegion,string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
//•	Felines – "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"