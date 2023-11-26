using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    public interface IAnimal
    {
        string Name_of_Species { get; set; }
        string Parameter_2 { get; set; }
        string Parameter_3 { get; set; }
        string Number { get; set; }
    }
}
