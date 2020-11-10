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
using Vehicles;

namespace UI
{
    /// <summary>
    /// The class representing a window for adding a trip
    /// </summary>
    
    public partial class AddTripWindow : Window
    {
        /// <summary>
        /// Selected transport
        /// </summary>
        
        string SelectedTransport { get; set; }

        /// <summary>
        /// Index of selected transport
        /// </summary>
        
        int SelectedIndex { get; set; }

        /// <summary>
        /// Link to the MainWIndow
        /// </summary>
        
        MainWindow MainWindow { get; set; }

        /// <summary>
        /// Link to the parentWindow
        /// </summary>
        
        AddWindow ParentWindow { get; set; }

        /// <summary>
        /// Creates an instance of the AddTripWindow class
        /// </summary>
        /// <param name="selectedTransport">Selected transport</param>
        /// <param name="selectedIndex">Index of selected transport</param>
        /// <param name="mainWindow">Link to the MainWIndow</param>
        /// <param name="parentWindow">Link to the parentWindow</param>
        
        public AddTripWindow(string selectedTransport,int selectedIndex,MainWindow mainWindow,AddWindow parentWindow)
        {
            InitializeComponent();
            SelectedTransport = selectedTransport;
            SelectedIndex = selectedIndex;
            MainWindow = mainWindow;
            ParentWindow = parentWindow;
            switch (selectedIndex)
            {
                case 0:
                    firstPriceLabel.Content = "Enter Economy ticket price";
                    secondPriceLabel.Content = "Enter Business ticket price";
                    thirdPriceLabel.Content = "Enter First ticket price";
                    fourthPriceBox.Visibility = Visibility.Hidden;
                    fourthPriceLabel.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    firstPriceLabel.Content = "Enter Hard ticket price";
                    secondPriceLabel.Content = "Enter Soft ticket price";
                    thirdPriceBox.Visibility = Visibility.Hidden;
                    thirdPriceLabel.Visibility = Visibility.Hidden;
                    fourthPriceBox.Visibility = Visibility.Hidden;
                    fourthPriceLabel.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    firstPriceLabel.Content = "Enter Common ticket price";
                    secondPriceLabel.Content = "Enter Economy ticket price";
                    thirdPriceLabel.Content = "Enter Compartment ticket price";
                    fourthPriceLabel.Content = "Enter Luxury ticket price";
                    carriagesNumberBox.Visibility = Visibility.Visible;
                    carriagesNumberLabel.Visibility = Visibility.Visible;
                    break;
            }
        }

        /// <summary>
        /// Checks inputed symbols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void checkTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        /// <summary>
        /// Adds a tripb by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int ticketsNumber;
            int.TryParse(ticketsNumberBox.Text, out ticketsNumber);
            int tripNumber;
            int.TryParse(tripNumberBox.Text, out tripNumber);
            string departure = departureBox.Text;
            string destination = destinationBox.Text;
            int[] prices = GetPrices();
            ITransport trip = TripsCreator.CreateTrip(SelectedTransport, tripNumber, departure, destination, prices);
            if (trip != null)
            {
                if (SelectedIndex == 2)
                {
                    int carriagesNumber;
                    int.TryParse(carriagesNumberBox.Text, out carriagesNumber);
                    ((Train)trip).numbersOfFree = new int[carriagesNumber];
                    for(var i=0; i<carriagesNumber;i++)
                        ((Train)trip).numbersOfFree[i] = ticketsNumber;
                }
                trip.NumberOfFree = ticketsNumber;
                MainWindow.Trips.Add(trip);
                string message = "The trip was added.";
                string caption = "Addition result";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
                MainWindow.Show();
                ParentWindow.Close();
            }
            else
            {
                string message = "Addition error.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
            this.Close();
        }

        /// <summary>
        /// Gets inputed prices
        /// </summary>
        /// <returns>Prices</returns>
        
        private int[] GetPrices()
        {
            int[] prices = null;
            switch (SelectedIndex)
            {
                case 0:
                    prices = new int[3];
                    int.TryParse(firstPriceBox.Text, out prices[0]);
                    int.TryParse(secondPriceBox.Text, out prices[1]);
                    int.TryParse(thirdPriceBox.Text, out prices[2]);
                    break;
                case 1:
                    prices = new int[2];
                    int.TryParse(firstPriceBox.Text, out prices[0]);
                    int.TryParse(secondPriceBox.Text, out prices[1]);
                    break;
                case 2:
                    prices = new int[4];
                    int.TryParse(firstPriceBox.Text, out prices[0]);
                    int.TryParse(secondPriceBox.Text, out prices[1]);
                    int.TryParse(thirdPriceBox.Text, out prices[2]);
                    int.TryParse(fourthPriceBox.Text, out prices[3]);
                    break;
            }
            return prices;
        }

        /// <summary>
        /// Closes this window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void closeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
