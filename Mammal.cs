﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
     class Mammal : Animal
    {   

        public Mammal(string nameofspecies, string prmtr_2, string prmtr_3)
        {
            this.Name_of_Species = nameofspecies;
            this.Parameter_2 = prmtr_2;
            this.Parameter_3 = prmtr_3;
            this.Number = AniNumber.CreateNumberWithLetter("M");
        }
        
    }
}
