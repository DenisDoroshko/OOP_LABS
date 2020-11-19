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
using System.IO;
using System.Security.Cryptography;
using Vehicles;

namespace UI
{
    /// <summary>
    /// The class representing a window for menu of aplication
    /// </summary>

    public partial class MainWindow : Window
    {
        /// <summary>
        /// List of trips
        /// </summary>
        
        public static List<ITransport> Trips { get; set; }

        /// <summary>
        /// /// Creates an instance of the MainWindow class
        /// </summary>
        
        public MainWindow()
        {
            InitializeComponent();
            Trips = new List<ITransport>();
        }

        /// <summary>
        /// Gets trips from the file by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void getButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Trips = FileUpdater.GetTrips("trips.txt");
            int addedNumber = MainWindow.Trips.Count;
            if (addedNumber != 0)
            {
                string message = $"Trips have been added ({addedNumber})";
                string caption = "Addition result";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
            }
            else
            {
                string message = "Trips haven't been added.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
            FileUpdater.UpdateFile(MainWindow.Trips,"trips.txt");
        }

        /// <summary>
        /// Gets data
        /// </summary>
        /// <returns>Data</returns>
        
        private static List<string> GetData()
        {
            List<string> data = new List<string>();
            using (var sr = new StreamReader("trips.txt"))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }
            return data;
        }

        /// <summary>
        /// Gets prices of tickets
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Prices of tickets</returns>
        
        static int[] ParsePrices(List<string> values)
        {
            List<int> pricesList = new List<int>();
            int numberOfPrices = 0;
            foreach (string value in values)
            {
                int price;
                if (int.TryParse(value, out price))
                {
                    pricesList.Add(price);
                    numberOfPrices++;
                }
            }
            int[] points = new int[numberOfPrices];
            pricesList.CopyTo(points);
            return points;
        }

        /// <summary>
        /// Shows trips by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            if (Trips.Count != 0)
            {
                var showWindow = new ShowTripsWindow(this);
                showWindow.Show();
                this.Hide();
            }
            else
            {
                string message = "There are no trips.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        /// <summary>
        /// Creates a window for trip adding by clicking the button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(this);
            addWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// Creates a window for trip editing by clicking the button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (Trips.Count != 0)
            {
                var editWindow = new EditWindow(this);
                editWindow.Show();
                this.Hide();
            }
            else
            {
                string message = "There are no trips.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        /// <summary>
        /// Shows selected prices of tickets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showPriceButton_Click(object sender, RoutedEventArgs e)
        {
            if (Trips.Count != 0)
            {
                var showPrice = new ShowPricesWindow(this);
                showPrice.Show();
                this.Hide();
            }
            else
            {
                string message = "There are no trips.";
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
        
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
