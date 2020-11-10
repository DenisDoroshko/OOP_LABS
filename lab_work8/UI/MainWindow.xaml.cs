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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<ITransport> Trips { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Trips = new List<ITransport>();
        }

        private void getButton_Click(object sender, RoutedEventArgs e)
        {
            int addedNumber = 0;
            List<string> data = GetData();
            foreach(var stringTrip in data)
            {
                string[] tripValues = stringTrip.Split();
                string type = tripValues[0];
                int tripNumber;
                int.TryParse(tripValues[1], out tripNumber);
                string departure = tripValues[2];
                string destination = tripValues[3];
                List<string> stringPrices = new List<string>();
                for(var i =4; i < tripValues.Length; i++)
                {
                    stringPrices.Add(tripValues[i]);
                }
                int[] prices = ParsePrices(stringPrices);
                ITransport trip = TripsCreator.CreateTrip(type,tripNumber,departure,destination,prices);
                if (trip != null)
                {
                    Trips.Add(trip);
                    addedNumber++;
                }
            }
            string message = $"Trips have been added ({addedNumber})";
            string caption = "Addition result";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, caption, button, icon);
        }
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

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            var showWindow = new ShowTripsWindow(this);
            showWindow.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(this);
            addWindow.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new EditWindow(this);
            editWindow.Show();
            this.Hide();
        }

        private void showPriceButton_Click(object sender, RoutedEventArgs e)
        {
            var showPrice = new ShowPricesWindow(this);
            showPrice.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
