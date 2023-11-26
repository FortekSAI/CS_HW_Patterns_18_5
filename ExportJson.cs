using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CS_HW_Patterns_18_5
{
    internal class ExportJson : IFileSave
    {

        public string Name_of_Extention { get => "Json";}

        public void SaveToFile(string smthtosave, string file_name)
        {
            using (FileStream fs = new FileStream($"{file_name}.json", FileMode.Create))
            {
                JsonSerializer.SerializeAsync(fs, smthtosave);
            }
        }

        public void SaveToFile(ObservableCollection<IAnimal> smthtosave, string file_name)
        {
            using (FileStream fs = new FileStream($"{file_name}.json", FileMode.Create))
            {
                JsonSerializer.SerializeAsync(fs, smthtosave);
            }
        }

        public override string ToString() => $"{Name_of_Extention}";
    }
}
