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
    /// The class representing a window for prices showing
    /// </summary>

    public partial class ShowPricesWindow : Window
    {
        /// <summary>
        /// Link to the MainWIndow
        /// </summary>

        public MainWindow MainWindow { get; set; }

        /// <summary>
        /// Creates an instance of the ShowPricesWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>

        public ShowPricesWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        /// <summary>
        /// Shows selected prices of tickets by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedType = typeBox.Text;
            var priceWindow = new TypePriceWindow(MainWindow,this,selectedType);
            priceWindow.Show();
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
