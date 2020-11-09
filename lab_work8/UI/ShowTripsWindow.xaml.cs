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
    /// Логика взаимодействия для ShowTripsWindow.xaml
    /// </summary>
    public partial class ShowTripsWindow : Window
    {
        public MainWindow MainWindow { get; set; }

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

        private void closeWindow_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
            this.Close();
        }
    }
}
