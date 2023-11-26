using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CS_HW_Patterns_18_5
{
    internal class FileSaver
    {

        public IFileSave SaverMod { get; set; }
        public string File_name;

        public FileSaver (IFileSave saverMod, string file_name)
        {
            this.SaverMod = saverMod;
            this.File_name = file_name;
        }

        public void Save (string Smthtosave_str)
        {
            this.SaverMod.SaveToFile(Smthtosave_str,File_name);
        }

        public void Save(ObservableCollection<IAnimal> Smthtosave_str)
        {
            this.SaverMod.SaveToFile(Smthtosave_str, File_name);
        }

        public void  ConvertCollectionToObsAndSave( ItemCollection collection)
        {
            ObservableCollection<IAnimal> animals = new ObservableCollection<IAnimal>();
            foreach (IAnimal animal in collection)
            {
                animals.Add(animal);
            }
            this.Save(animals);
            Debug.WriteLine($"Saved as {this.SaverMod.Name_of_Extention}");
        }
    }
}
