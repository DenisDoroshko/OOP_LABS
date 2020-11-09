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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public MainWindow MainWindow { get; set; }

        public EditWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
            foreach (var trip in MainWindow.Trips)
            {
                TripInfo tripInfo = new TripInfo(trip.TransportType, trip.TripNumber, trip.Departure, trip.Destination, trip.NumberOfFree, trip.Prices);
                tripsBox.Items.Add(tripInfo);
            }
        }

        private void closeWindow_Closed(object sender, EventArgs e)
        {
            MainWindow.Show();
            this.Close();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = tripsBox.SelectedIndex;
            var editWindow = new EditTripWindow(MainWindow.Trips[selectedIndex]);
            editWindow.Show();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = tripsBox.SelectedIndex;
            MainWindow.Trips.RemoveAt(selectedIndex);
            MainWindow.Show();
            this.Close();
        }

        private void deleteAllButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Trips.Clear();
            MainWindow.Show();
            this.Close();
        }
    }
}
