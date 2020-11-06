using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Flats;

namespace UserInterface
{
    /// <summary>
    /// The class representing a window for edit selected flat
    /// </summary>
    
    public partial class EditSelectedFlatWindow : Window
    {
        /// <summary>
        /// Number of the selected flat
        /// </summary>
        
        public int selectedFlat;

        /// <summary>
        /// Creates an instance of the EditSelectedWindow class
        /// </summary>

        public EditSelectedFlatWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the CreateRoomWindow class
        /// </summary>
        /// <param name="selectedFlat">Selected flat</param>

        public EditSelectedFlatWindow(int selectedFlat)
        {
            InitializeComponent();
            int roomNumber = 1;
            foreach (var room in MainWindow.Flats[selectedFlat].Rooms)
            {
                var item = new ComboBoxItem();
                item.Content = roomNumber;
                roomBox.Items.Add(item);
                roomNumber++;
            }
           
            this.selectedFlat = selectedFlat;
        }

        /// <summary>
        /// Edits selected room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Room room;
            if(GetRoom(out room))
            {
                int roomNumber = roomBox.SelectedIndex;
                MainWindow.Flats[selectedFlat].Rooms[roomNumber] = room;
                string message = "Room was edited.";
                string caption = "Edition result";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
            }
            else
            {
                string message = "Incorrect parameters.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
        }

        /// <summary>
        /// Gets entered data for room editing 
        /// </summary>
        /// <param name="room">Room</param>
        /// <returns>Value is true if entered data is correct, othewise - false</returns>

        private bool GetRoom(out Room room)
        {
            bool isCorrect = true;
            double square;
            double.TryParse(squareBox.Text, out square);
            if (square > 1000 || square <= 0)
                isCorrect = false;
            double height;
            double.TryParse(heightBox.Text, out height);
            if (height > 10 || height <= 0)
                isCorrect = false;
            int numberOfWindows;
            int.TryParse(windowsBox.Text, out numberOfWindows);
            if (numberOfWindows > 50 || numberOfWindows <= 0)
                isCorrect = false;
            var furnitureItem = (ComboBoxItem)furnitureBox.SelectedItem;
            bool isFurniture;
            if (furnitureItem.Content.ToString() == "Yes")
                isFurniture = true;
            else
                isFurniture = false;
            room = new Room(square, height, numberOfWindows, isFurniture);
            return isCorrect;
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
