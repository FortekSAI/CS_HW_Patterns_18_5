using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    class Animal : IAnimal
    {
        [Key] public int Id { get; set; }
        public  string Name_of_Species { get; set; }
        public  string Parameter_2 { get; set; }
        public  string Parameter_3 { get; set; }
        public  string Number { get; set; }
    }
}
