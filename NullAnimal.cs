using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
     class NullAnimal : Animal
    {
        public NullAnimal()
        {   
            this.Name_of_Species = "Not Determined";
            this.Parameter_2 = "Not Determined";
            this.Parameter_3 = "Not Determined";
            this.Number = AniNumber.CreateNumberWithLetter("N");
        }
    }
}
