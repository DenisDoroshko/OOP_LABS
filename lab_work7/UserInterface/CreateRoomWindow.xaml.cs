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
using Flats;

namespace UserInterface
{
    /// <summary>
    /// The class representing a window for filling a room
    /// </summary>
    
    public partial class CreateRoomWindow : Window
    {
        /// <summary>
        /// Link to the Mainwindow
        /// </summary>

        public MainWindow mainWindow;

        /// <summary>
        /// Link to the AddWindow
        /// </summary>

        public AddWindow addWindow;

        /// <summary>
        /// Current room being filled
        /// </summary>
        
        public int currentRoom;

        /// <summary>
        /// Creates an instance of the CreateRoomWindow class
        /// </summary>
        
        public CreateRoomWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the CreateRoomWindow class
        /// </summary>
        /// <param name="mainWindow">link to MainWindow</param>
        /// <param name="addWindow">link to AddWindow</param>
        /// <param name="currentRoom">Current room</param>

        public CreateRoomWindow(MainWindow mainWindow,AddWindow addWindow,int currentRoom)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.addWindow = addWindow;
            this.currentRoom = currentRoom;
            fillingLabel.Content = $"Fill room №{currentRoom+1}";
        }

        /// <summary>
        /// Adds room by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addRoomButton_Click(object sender, RoutedEventArgs e)
        {
            Room room;
            if (GetRoom(out room))
            {
                addWindow.rooms[currentRoom] = room;
                addWindow.unfilledRooms--;
                currentRoom++;
                if (addWindow.unfilledRooms != 0)
                {
                    var roomWindow = new CreateRoomWindow(mainWindow,addWindow, currentRoom);
                    roomWindow.Show();
                }
                else
                {
                    createFlat();
                    mainWindow.Show();
                    addWindow.Close();
                }
            }
            else
            {
                string message = "Incorrect parameters.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
            }
            this.Close();
        }

        /// <summary>
        /// Gets entered data to fill the room
        /// </summary>
        /// <param name="room">Room</param>
        /// <returns>Value is true if entered data is correct, othewise - false</returns>
        
        private bool GetRoom(out Room room)
        {
            bool isCorrect = true;
            double square;
            double.TryParse(squareBox.Text, out square);
            if (square > 1000 || square <=0)
                isCorrect = false;
            double height;
            double.TryParse(heightBox.Text, out height);
            if (height > 10 || height <=0)
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
        /// Creates the flat
        /// </summary>
        
        private void createFlat()
        {
            string message = "The flat was added.";
            string caption = "Addition result";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, caption, button, icon);  
            Flat flat = FlatCreator.CreateFlat(addWindow.numberOfRooms, addWindow.rooms,
                    addWindow.floor,addWindow.washerAvailability,addWindow.stoveType);
            if (flat != null)
                MainWindow.Flats.Add(flat);
        }

        /// <summary>
        /// Checks inputed symbols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void windowsBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        /// <summary>
        /// Checks inputed symbols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void heightBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool result = (Char.IsDigit(e.Text, 0)) || ((e.Text == ".") && (SeparatorCount(((TextBox)sender).Text)<1));
            e.Handled = !result;
        }

        /// <summary>
        /// Counts the number of separators
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The number of separators</returns>
        
        private int SeparatorCount(string s)
        {
            string s1 = ".";
            int count = (s.Length - s.Replace(s1, "").Length);
            return count;
        }
    }
}
