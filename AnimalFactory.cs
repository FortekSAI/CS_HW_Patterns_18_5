using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    internal class AnimalFactory
    {

        public static IAnimal CreateAnimal( string AnimalType,string Name_of_Type, string Prmtr_1, string Prmtr_2) 
        {
            switch( AnimalType ) 
            {
                case "Bird": return new Bird(Name_of_Type, Prmtr_1, Prmtr_2);
                case "Amphibian": return new Amphibian(Name_of_Type, Prmtr_1, Prmtr_2);
                case "Mammal": return new Mammal(Name_of_Type, Prmtr_1, Prmtr_2);
                default: return new NullAnimal();
            }
        }
    }
}
