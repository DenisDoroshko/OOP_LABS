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

namespace UI
{
    /// <summary>
    /// The class representing a information about price
    /// </summary>
    
    public class PriceInfo
    {
        /// <summary>
        /// Creates an instance of the PriceInfo class
        /// </summary>
        /// <param name="tripNumber">Trip number</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="price">Price</param>
        public PriceInfo(int tripNumber,string departure, string destination,int price)
        {
            TripNumber = tripNumber;
            Departure = departure;
            Destination = destination;
            Price = price;
        }

        /// <summary>
        /// Trip number
        /// </summary>
        
        public int TripNumber { get; set; }

        /// <summary>
        /// Departure
        /// </summary>
        
        public string Departure { get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        
        public string Destination { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        
        public int Price { get; set; }
    }

    /// <summary>
    /// The class representing a window for prices showing
    /// </summary>

    public partial class TypePriceWindow : Window
    {
        /// <summary>
        /// Link to the MainWIndow
        /// </summary>

        MainWindow MainWindow { get; set; }

        /// <summary>
        /// Link to theParentWindow
        /// </summary>

        ShowPricesWindow ParentWindow { get; set; }

        /// <summary>
        /// Selected type of a ticket
        /// </summary>
        
        string SelectedType { get; set; }

        /// <summary>
        /// Creates an instance of the TypePriceWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>
        /// <param name="parentWindow">Link to the ParentWindow</param>
        /// <param name="selectedType">Selected type of a ticket</param>
        
        public TypePriceWindow(MainWindow mainWindow,ShowPricesWindow parentWindow,string selectedType)
        {
            InitializeComponent();
            MainWindow = mainWindow;
            ParentWindow = parentWindow;
            selectedType = selectedType.ToLower();
            SelectedType = selectedType;
            Dictionary<string, int> transportTypes = new Dictionary<string, int>
            {
                ["plane"] = 1,
                ["bus"] = 2,
                ["train"] = 3,
            };
            int key;
            transportTypes.TryGetValue(selectedType, out key);
            switch (key) 
            {
                case 1:
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Economy" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Business" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "First" });
                    break;
                case 2:
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Hard" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Soft" });
                    break;
                case 3:
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Common" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Economy" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Compartment" });
                    ticketBox.Items.Add(new ComboBoxItem() { Content = "Luxury" });
                    break;
            }

        }

        /// <summary>
        /// Shows selected prices by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            bool isFound = false;
            string ticketType = ticketBox.Text.ToLower();
            showTable.Items.Clear();
            foreach(var trip in MainWindow.Trips)
            {
                if (trip.TransportType == SelectedType)
                {
                    PriceInfo priceInfo = new PriceInfo(trip.TripNumber,trip.Departure,trip.Destination,trip[ticketType]);
                    showTable.Items.Add(priceInfo);
                    isFound = true;
                }
            }
            if (isFound == true)
            {
                showTable.Visibility = Visibility.Visible;
            }
            else
            {
                string message = "There are no prices.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                ParentWindow.Close();
                MainWindow.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Closes this window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void closeWindow_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
            ParentWindow.Close();
            this.Close();
        }
    }
}
