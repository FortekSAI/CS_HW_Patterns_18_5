using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    /// <summary>
    /// 
    /// </summary>
    internal interface IFileSave
    {
        public string Name_of_Extention { get;}
        public abstract void SaveToFile(string smthtosave, string file_name);
        public abstract void SaveToFile(ObservableCollection<IAnimal> smthtosave, string file_name);
    }
}
