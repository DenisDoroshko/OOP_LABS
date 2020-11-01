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
    /// Логика взаимодействия для ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public MainWindow mainWindow;
        public int flatsNumber;
        public ShowWindow()
        {
            InitializeComponent();
        }
        public ShowWindow(MainWindow mainWindow)
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

        private void showFlatButton_Click(object sender, RoutedEventArgs e)
        {
            if (flatsNumber != 0)
            {
                var flatItem = (ComboBoxItem)flatBox.SelectedItem;
                int selectedIndex = flatBox.SelectedIndex;
                string flat = flatItem.Content.ToString();
                showLabel.Content = flat;
                var roomNumber=1;
                foreach(var room in MainWindow.Flats[selectedIndex].Rooms)
                {
                    showLabel.Content += $"\nRoom №{roomNumber} {room}";
                    roomNumber++;
                }
            }
            else
            {
                string message = "No flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                this.Close();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void showMain_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
