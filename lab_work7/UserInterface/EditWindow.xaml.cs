using Flats;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public MainWindow mainWindow;
        public int flatsNumber;
        public EditWindow()
        {
            InitializeComponent();
        }
        public EditWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            flatsNumber = MainWindow.Flats.Count;
            foreach (var flat in MainWindow.Flats)
            {
                var item = new ComboBoxItem();
                item.Content = flat.ToString();
                flatBox.Items.Add(item);
            }
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = flatBox.SelectedIndex;
            bool washerAvailability;
            var washerItem = (ComboBoxItem)washerBox.SelectedItem;
            if (washerBox.SelectedIndex == 0)
                washerAvailability = true;
            else
                washerAvailability = false;
            StoveTypes stoveType;
            var stoveTypeItem = (ComboBoxItem)stoveTypeBox.SelectedItem;
            if (stoveTypeItem.Content.ToString() == "Gas")
                stoveType = StoveTypes.Gas;
            else
                stoveType = StoveTypes.Electric;
            MainWindow.Flats[selectedIndex].WasherAvailability = washerAvailability;
            MainWindow.Flats[selectedIndex].StoveType = stoveType;
            var editWindow = new EditSelectedFlatWindow();
            editWindow.Show();
        }

        private void deleteFlatButton_Click(object sender, RoutedEventArgs e)
        {
            int index = flatBox.SelectedIndex;
            MainWindow.Flats.RemoveAt(index);
        }

        private void showMain_clossed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
