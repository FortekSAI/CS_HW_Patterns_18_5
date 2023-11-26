using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    public class RandomAnimal
    {
        static private string[] mammals = new string[10] {"Cow", "Bear", "Pig", "Wolf", "Cat", "Dog", "Sheep", "Elephant", "Camel", "Tiger" };
        static private string[] birds = new string[10] { "Sparrow", "Crow", "Pigeon", "Goose", "Turkey", "Penguin", "Crane", "Rawen", "Eagle", "Falcon" };
        static private string[] amphibians = new string[3] { "Frog", " Salamander", "Caeciliidae"};
         
        public static IAnimal NewRandomAnimal()
        {
            Random r = new Random();
            int rnd = r.Next(2);
            Random r_2 = new Random();
            switch (rnd)
            {
                case 0: return AnimalFactory.CreateAnimal("Mammal", mammals[r_2.Next(mammals.Length)], "Rnd_M_2", "Rnd_M_3");
                case 1: return AnimalFactory.CreateAnimal("Bird", birds[r_2.Next(birds.Length) - 1], "Rnd_B_2", "Rnd_B_3");
                case 3: return AnimalFactory.CreateAnimal("Bird", amphibians[r_2.Next(amphibians.Length) - 1], "Rnd_A_2", "Rnd_A_3");
                default: return null;
            }
        }
    }
}
