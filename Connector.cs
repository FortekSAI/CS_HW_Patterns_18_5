using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace CS_HW_Patterns_18_5
{   
/// <summary>
/// Class as Presenter
/// </summary>
    internal class Connector
    {
        public FileSaver Filesaver;
        private MultiSelector Dataviewer;
        private Button Saveasbutton;
        public ExportJson exportjson;
        public ExportTXT exporttxt;

        public Connector(MultiSelector dataviewer, Button saveasbutton) 
        {
            this.exportjson = new ExportJson();
            this.exporttxt = new ExportTXT();
            this.Filesaver = new FileSaver(exportjson, "Animals_List");
            this.Dataviewer = dataviewer;
            this.Saveasbutton = saveasbutton;
            using (AnimalContext ac = new AnimalContext())
            {
                dataviewer.ItemsSource = ac.LoadToObsCollection();
            }
        }

        public void AddNewData()
        {
            using (AnimalContext ac = new AnimalContext())
            {
                Dataviewer.ItemsSource = ac.Add_New_Random();
            }
        }

        public void RemoveData()
        {
            using (AnimalContext oc = new AnimalContext())
            {
                Dataviewer.ItemsSource = oc.Delete((Animal)Dataviewer.SelectedItem);
            }
        }
        
        public void EditData(object animal)
        {
            using (AnimalContext ac = new AnimalContext())
            {
                Dataviewer.ItemsSource = ac.Edit((Animal)animal);
            }
        }

        /// <summary>
        /// 0 = Json, 1 = TXT
        /// </summary>
        /// <param name="ext"></param>
        public void SaveCurrentDataAs(int ext) 
        {
            if(ext == 0)
            {
                this.Filesaver.SaverMod = exportjson;
            }
            if(ext == 1)
            {
                this.Filesaver.SaverMod = exporttxt;
            }
            Filesaver.ConvertCollectionToObsAndSave(Dataviewer.Items);
            Saveasbutton.Content = $"Save to {Filesaver.SaverMod.Name_of_Extention}";
        }
    }
}
