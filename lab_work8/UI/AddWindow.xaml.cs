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
    /// The class representing a window for adding a trip
    /// </summary>
    
    public partial class AddWindow : Window
    {
        /// <summary>
        /// Link to the MainWIndow
        /// </summary>
        
        MainWindow MainWindow { get; set; }

        /// <summary>
        /// Creates an instance of the AddWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>
        
        public AddWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        /// <summary>
        /// Creates window for trip inputing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddTripWindow(typeBox.Text,typeBox.SelectedIndex,MainWindow,this);
            window.Show();
        }

        /// <summary>
        /// Closes this window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void closeWindow_Clossed(object sender, EventArgs e)
        {
            MainWindow.Show();
            this.Close();
        }
    }
}
