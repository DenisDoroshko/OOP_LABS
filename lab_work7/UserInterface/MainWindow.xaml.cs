using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// The class representing a window for menu of aplication
    /// </summary>
    
    public partial class MainWindow : Window
    {
        /// <summary>
        /// List of flats
        /// </summary>
        
        public static List<Flat> Flats { get; set; }

        /// <summary>
        /// /// Creates an instance of the MainWindow class
        /// </summary>
        
        public MainWindow()
        {
            InitializeComponent();
            Flats = new List<Flat>();
        }

        /// <summary>
        /// Calls a window for adding a flat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(this);
            addWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// Calls a window for editing a flat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
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
                string message = "There are no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        /// <summary>
        /// Calls a window for show data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (Flats.Count != 0)
            {
                var showWindow = new ShowWindow(this);
                this.Hide();
                showWindow.Show();
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

        /// <summary>
        /// Shows the average rent for 1 square meter for all three-room flats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
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

        /// <summary>
        /// Calls a window for showing quantity of flats by type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void QuantityButton_Click(object sender, RoutedEventArgs e)
        {
            if (Flats.Count != 0)
            {
                int flatTypesNumber = 5;
                int[] quantities = new int[flatTypesNumber];
                GetQuantities(quantities);
                string message = $"Quantity information by number of rooms:\nOne-room flats:{quantities[0]}" +
                    $"\nTwo-room flats:{quantities[1]}\nThree-room flats:{quantities[2]}" +
                    $"\nFour-room flats:{quantities[3]}\nFive-room flats:{quantities[4]}";
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

        /// <summary>
        /// Gets quantities of flats by type
        /// </summary>
        /// <param name="quantities"></param>
        
        private void GetQuantities(int[] quantities)
        {
            foreach (var flat in Flats)
            {
                switch (flat.NumberOfRooms)
                {
                    case 1:
                        quantities[0]++;
                        break;
                    case 2:
                        quantities[1]++;
                        break;
                    case 3:
                        quantities[2]++;
                        break;
                    case 4:
                        quantities[3]++;
                        break;
                    case 5:
                        quantities[4]++;
                        break;
                }
            }
        }

        /// <summary>
        /// Calls a window for showing flats with electric stove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void stoveFlatsButton_Click(object sender, RoutedEventArgs e)
        {
            if (Flats.Count != 0)
            {
                var stoveWindow = new ShowElectricStoveWindow(this);
                this.Hide();
                stoveWindow.Show();
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

        /// <summary>
        /// Closes the window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
