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
    /// The class representing a window for trips showing
    /// </summary>

    public partial class ShowTripsWindow : Window
    {
        /// <summary>
        /// Link to the MainWIndow
        /// </summary>

        public MainWindow MainWindow { get; set; }

        /// <summary>
        /// Creates an instance of the ShowTripsWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>

        public ShowTripsWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
            foreach(var trip in MainWindow.Trips)
            {
                TripInfo tripInfo = new TripInfo(trip.TransportType, trip.TripNumber, trip.Departure, trip.Destination, trip.NumberOfFree, trip.Prices);
                showTable.Items.Add(tripInfo);
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
            this.Close();
        }
    }
}
