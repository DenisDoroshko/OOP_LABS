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
    /// The class representing a window for editing a trip
    /// </summary>

    public partial class EditWindow : Window
    {
        /// <summary>
        /// Link to the MainWIndow
        /// </summary>

        public MainWindow MainWindow { get; set; }

        /// <summary>
        /// Creates an instance of the EditWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>

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
        /// <summary>
        /// Creates window for trip editing by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = tripsBox.SelectedIndex;
            var editWindow = new EditTripWindow(MainWindow.Trips[selectedIndex]);
            editWindow.Show();
        }

        /// <summary>
        /// Deletes selected trip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = tripsBox.SelectedIndex;
            MainWindow.Trips.RemoveAt(selectedIndex);
            string message = "The trip has been deleted.";
            string caption = "Result of deletion";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, caption, button, icon);
            FileUpdater.UpdateFile(MainWindow.Trips, "trips.txt");
            MainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Deletes all trips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void deleteAllButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Trips.Clear();
            string message = "All trips have been deleted.";
            string caption = "Result of deletion";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, caption, button, icon);
            FileUpdater.UpdateFile(MainWindow.Trips, "trips.txt");
            MainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Closes this window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void closeWindow_Closed(object sender, EventArgs e)
        {
            MainWindow.Show();
            this.Close();
        }
    }
}
