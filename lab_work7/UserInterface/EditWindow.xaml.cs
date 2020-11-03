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
    /// The class representing a window for edit selected flat
    /// </summary>
    
    public partial class EditWindow : Window
    {
        /// <summary>
        /// Link to the main window
        /// </summary>
        
        public MainWindow mainWindow;

        /// <summary>
        /// Number of flats
        /// </summary>
        
        public int flatsNumber;

        /// <summary>
        /// Creates an instance of the EditWindow class
        /// </summary>
        
        public EditWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the EditWindow class
        /// </summary>
        /// <param name="mainWindow">Link to the MainWindow</param>
        
        public EditWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            flatsNumber = MainWindow.Flats.Count;
            foreach (var flat in MainWindow.Flats)
            {
                var item = new ComboBoxItem();
                item.Content = flat.ToString();
                flatBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Edits the selected flat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = flatBox.SelectedIndex;
            bool washerAvailability;
            if (washerBox.SelectedIndex == 0)
            {
                washerAvailability = true;
            }
            else
            {
                washerAvailability = false;
            }
            StoveTypes stoveType;
            var stoveTypeItem = (ComboBoxItem)stoveTypeBox.SelectedItem;
            if (stoveTypeItem.Content.ToString() == "Gas")
            {
                stoveType = StoveTypes.Gas;
            }
            else
            {
                stoveType = StoveTypes.Electric;
            }
            MainWindow.Flats[selectedIndex].WasherAvailability = washerAvailability;
            MainWindow.Flats[selectedIndex].StoveType = stoveType;
            var editWindow = new EditSelectedFlatWindow();
            editWindow.Show();
        }

        /// <summary>
        /// Deletes the selected flat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void deleteFlatButton_Click(object sender, RoutedEventArgs e)
        {
            int index = flatBox.SelectedIndex;
            MainWindow.Flats.RemoveAt(index);
        }

        /// <summary>
        /// Closes the window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void showMain_clossed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Closes the window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
