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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Flats;

namespace UserInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Flat> Flats { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Flats = new List<Flat>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(this);
            addWindow.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (Flats.Count != 0)
            {
                var editWindow = new EditWindow(this);
                editWindow.Show();
                this.Hide();
            }
            else
            {
                string message = "There no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (Flats.Count != 0)
            {
                var showWindow = new ShowWindow(this);
            showWindow.Show();
            }
            else
            {
                string message = "There no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        private void AverageButton_Click(object sender, RoutedEventArgs e)
        {
            List<Flat> threeRoomflats = new List<Flat>();
            foreach(var flat in Flats)
            {
                if (flat.NumberOfRooms == 3)
                    threeRoomflats.Add(flat);
            }
            if (threeRoomflats.Count != 0)
            {


                double average = Math.Round(ThreeRoomFlat.GetAverageRent(threeRoomflats),1);
                string message = $"The average rent for 1 square meter for all three-room flats is:{average}";
                string caption = "Average result";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
            }
            else
            {
                string message = "There are no three-room flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        private void QuantityButton_Click(object sender, RoutedEventArgs e)
        {
            int oneRoomQuantity = 0;
            int twoRoomQuantity = 0;
            int threeRoomQuantity = 0;
            int fourRoomQuantity = 0;
            int fiveRoomQuantity = 0;
            foreach(var flat in Flats)
            {
                switch (flat.NumberOfRooms) 
                {
                    case 1:
                        oneRoomQuantity++;
                        break;
                    case 2:
                        twoRoomQuantity++;
                        break;
                    case 3:
                        threeRoomQuantity++;
                        break;
                    case 4:
                        fourRoomQuantity++;
                        break;
                    case 5:
                        fiveRoomQuantity++;
                        break;
                }
            }
            if (Flats.Count != 0)
            {
                string message = $"Quantity information by number of rooms:\nOne-room flats:{oneRoomQuantity}" +
                    $"\nTwo-room flats:{twoRoomQuantity}\nThree-room flats:{threeRoomQuantity}" +
                    $"\nFour-room flats:{fourRoomQuantity}\nFive-room flats:{fiveRoomQuantity}";
                string caption = "Quantity information";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
            }
            else
            {
                string message = "There are no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }

        }

        private void stoveFlatsButton_Click(object sender, RoutedEventArgs e)
        {
            var stoveWindow = new ShowElectricStoveWindow(this);
            stoveWindow.Show();
            this.Hide();
        }
    }
}
