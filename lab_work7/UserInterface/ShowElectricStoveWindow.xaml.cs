using Flats;
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
    /// <summary>
    /// The class representing a window for showing flats with electric stove
    /// </summary>
    
    public partial class ShowElectricStoveWindow : Window
    {
        /// <summary>
        /// Link to the MainWindow
        /// </summary>
        
        public MainWindow mainWindow;

        /// <summary>
        /// Creates an instance of the ShowElectricStoveWindow class
        /// </summary>
        
        public ShowElectricStoveWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the ShowElectricStoveWindow class
        /// </summary>
        /// <param name="mainWindow"></param>
        
        public ShowElectricStoveWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        /// <summary>
        /// Shows the flats with electric stove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ShowFlats(object sender, EventArgs e)
        {
            bool isElecticStove = false;
            foreach (var flat in MainWindow.Flats)
            {
                if (flat.StoveType == StoveTypes.Electric)
                {
                    showLabel.Content += $"{flat}\n";
                    var roomNumber = 1;
                    foreach (var room in flat.Rooms)
                    {
                        showLabel.Content += $"  Room №{roomNumber} {room}\n";
                    }
                    isElecticStove = true;
                }
            }
            if (isElecticStove == false)
            {
                string message = "There are no flats with electric stove.";
                string caption = "Not found";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                scrollViewer.Visibility = Visibility.Visible;
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
        
        private void ShowMain_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
