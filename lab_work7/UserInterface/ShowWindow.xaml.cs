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

namespace UserInterface
{
    public class FlatItem
    {
        public FlatItem(string type, int floor,double rent,double square)
        {
            Type = type;
            Floor = floor;
            Rent = rent;
            Square = square;
        }
        public string Type { get; set; }
        public int Floor { get; set; }
        public double Rent { get; set; }
        public double Square { get; set; }
    }

    /// <summary>
    /// The class representing a window for showing flats with electric stove
    /// </summary>

    public partial class ShowWindow : Window
    {
        /// <summary>
        /// Link to the MainWindow
        /// </summary>
        
        public MainWindow mainWindow;

        /// <summary>
        /// Number of flats
        /// </summary>
        
        public int flatsNumber;

        /// <summary>
        /// Creates an instance of the ShowWindow class
        /// </summary>
        
        public ShowWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the ShowWindow class
        /// </summary>
        /// <param name="mainWindow"></param>
        
        public ShowWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            flatsNumber = MainWindow.Flats.Count;
            foreach (var flat in MainWindow.Flats)
            {
                flatBox.Items.Add(new FlatItem(flat.FlatType,flat.Floor,flat.FlatRent,flat.Square));
            }
        }

        /// <summary>
        /// Shows the selected flat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showFlatButton_Click(object sender, RoutedEventArgs e)
        {
            if (flatsNumber != 0)
            {
                int selectedIndex = flatBox.SelectedIndex;
                showLabel.Content = MainWindow.Flats[selectedIndex].ToString();
                var roomNumber=1;
                foreach(var room in MainWindow.Flats[selectedIndex].Rooms)
                {
                    showLabel.Content += $"\nRoom №{roomNumber} {room}";
                    roomNumber++;
                }
            }
            else
            {
                string message = "There are no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                this.Close();
            }
        }

        /// <summary>
        /// Close window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Close window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showMain_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
