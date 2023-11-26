using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    public class AniNumber
    {
        static public string CreateNumberWithLetter(string letter) 
        {
            Regex regex = new Regex(@"\D");
            string prenumbe_1 = regex.Replace(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff"), "");
            return prenumbe_1+letter;
        }
    }
}
