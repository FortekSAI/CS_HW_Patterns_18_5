using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Collections.ObjectModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace CS_HW_Patterns_18_5
{
    internal class ExportTXT : IFileSave
    {
        public string Name_of_Extention { get => "TXT"; }

        public void SaveToFile(string smthtosave, string file_name)
        {
            using (FileStream fs = new FileStream($"{file_name}.txt", FileMode.Create))
            {
                JsonSerializer.SerializeAsync(fs, smthtosave);
            }
        }

        public void SaveToFile(ObservableCollection<IAnimal> animalstosave, string file_name)
        {
            using (FileStream fs = new FileStream($"{file_name}.txt", FileMode.Create))
            {
                JsonSerializer.SerializeAsync(fs, animalstosave);
            }
        }

        public override string ToString() => $"{Name_of_Extention}";
    }
}
