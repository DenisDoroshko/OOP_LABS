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
    /// Логика взаимодействия для EditTripWindow.xaml
    /// </summary>
    public partial class EditTripWindow : Window
    {
        int TransportType { get; set; }
        ITransport Trip { get; set; }
        public EditTripWindow(ITransport trip)
        {
            InitializeComponent();
            Dictionary<string, int> transportTypes = new Dictionary<string, int>
            {
                ["plane"] = 0,
                ["bus"] = 1,
                ["train"] = 2,
            };
            int key;
            transportTypes.TryGetValue(trip.TransportType, out key);
            TransportType = key;
            Trip = trip;
            tripNumberBox.Text = trip.TripNumber.ToString();
            departureBox.Text = trip.Departure;
            destinationBox.Text = trip.Destination;
            firstPriceBox.Text = trip.Prices[0].ToString();
            secondPriceBox.Text = trip.Prices[1].ToString();
            switch (key)
            {
                case 0:
                    thirdPriceBox.Text = trip.Prices[2].ToString();
                    ticketsNumberBox.Text = trip.NumberOfFree.ToString();
                    firstPriceLabel.Content = "Edit Economy ticket price";
                    secondPriceLabel.Content = "Edit Business ticket price";
                    thirdPriceLabel.Content = "Edit First ticket price";
                    fourthPriceBox.Visibility = Visibility.Hidden;
                    fourthPriceLabel.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    ticketsNumberBox.Text = trip.NumberOfFree.ToString();
                    firstPriceLabel.Content = "Edit Hard ticket price";
                    secondPriceLabel.Content = "Edit Soft ticket price";
                    thirdPriceBox.Visibility = Visibility.Hidden;
                    thirdPriceLabel.Visibility = Visibility.Hidden;
                    fourthPriceBox.Visibility = Visibility.Hidden;
                    fourthPriceLabel.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    thirdPriceBox.Text = trip.Prices[2].ToString();
                    fourthPriceBox.Text = trip.Prices[3].ToString();
                    Train train = (Train)trip;
                    ticketsNumberBox.Text = train.numbersOfFree[0].ToString();
                    firstPriceLabel.Content = "Edit Common ticket price";
                    secondPriceLabel.Content = "Edit Economy ticket price";
                    thirdPriceLabel.Content = "Edit Compartment ticket price";
                    fourthPriceLabel.Content = "Edit Luxury ticket price";
                    carriageBox.Visibility = Visibility.Visible;
                    carriageNumberLabel.Visibility = Visibility.Visible;
                    for (var i = 0; i < train.numbersOfFree.Length; i++)
                    {
                        var item = new ComboBoxItem();
                        item.Content = (i+1).ToString();
                        carriageBox.Items.Add(item);
                    }
                    break;
            }
        }
        private void checkTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int ticketsNumber;
            int.TryParse(ticketsNumberBox.Text, out ticketsNumber);
            int tripNumber;
            int.TryParse(tripNumberBox.Text, out tripNumber);
            string departure = departureBox.Text;
            string destination = destinationBox.Text;
            int[] prices = GetPrices();
            if (TransportType == 2)
            {
                int carriageNumber;
                int.TryParse(carriageBox.Text, out carriageNumber);
                Train train = (Train)Trip;
                train.numbersOfFree[carriageNumber] = ticketsNumber;
                Trip = train;
            }
            Trip.TripNumber = tripNumber;
            Trip.Departure = departure;
            Trip.Destination = destination;
            Trip.NumberOfFree = ticketsNumber;
            Trip.Prices = prices;
            string message = "The trip was edited.";
            string caption = "Edition result";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, caption, button, icon);
            this.Close();
        }
        private int[] GetPrices()
        {
            int[] prices = null;
            switch (TransportType)
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
        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
