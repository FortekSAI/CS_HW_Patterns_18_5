using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS_HW_Patterns_18_5
{
    public partial class MainWindow : Window
    {
        Connector connector;
        int saveas_int;

        public MainWindow()
        {
            InitializeComponent();
            connector = new Connector(AnimalsDataGrid, SavetofileButton);
            saveas_int = 0;
            ComboBoxItem_Json.IsSelected = true;
            SavetofileButton.Content = $"Save to {connector.Filesaver.SaverMod.Name_of_Extention}";
            ComboBoxItem_Json.Content = connector.exportjson.Name_of_Extention;
            ComboBoxItem_TXT.Content = connector.exporttxt.Name_of_Extention;
            DeleteButton.IsEnabled = false ;
        }

        private void NewAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            connector.AddNewData();
        }

        private void SavetofileButton_Click(object sender, RoutedEventArgs e)
        {
            connector.SaveCurrentDataAs(saveas_int);
        }

        private void Extentions_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Extentions_combobox.Text == "TXT")
            {
                saveas_int = 0;
                SavetofileButton.Content = $"Save to {connector.exportjson.Name_of_Extention}";
                Debug.WriteLine($"Selection changed {connector.exportjson.Name_of_Extention}");

            }
            if (Extentions_combobox.Text == "Json")
            {
                saveas_int = 1;
                SavetofileButton.Content = $"Save to {connector.exporttxt.Name_of_Extention}";
                Debug.WriteLine($"Selection changed {connector.exporttxt.Name_of_Extention}");

            }
        }

        private void AnimalsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
        }

        private void AnimalsDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var edited_cell_animal = e.Row.DataContext;
            connector.EditData(edited_cell_animal);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           connector.RemoveData();
        }
    }
}
