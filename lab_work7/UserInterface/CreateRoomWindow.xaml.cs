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
    /// Логика взаимодействия для CreateRoomWindow.xaml
    /// </summary>
    public partial class CreateRoomWindow : Window
    {
        public MainWindow mainWindow;
        public AddWindow addWindow;
        public int currentRoom;
        public CreateRoomWindow()
        {
            InitializeComponent();
        }
        public CreateRoomWindow(MainWindow mainWindow,AddWindow addWindow,int currentRoom)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.addWindow = addWindow;
            this.currentRoom = currentRoom;
            fillingLabel.Content = $"Fill room №{currentRoom+1}";
        }

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
                this.Close();
            }
            else
            {
                string message = "Incorrect parameters.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                mainWindow.Show();
                this.Close();
            }
        }
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
        private void createFlat()
        {
                string message = "The flat was added.";
                string caption = "Addition result";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(message, caption, button, icon);
                FlatCreator.CreateFlat(MainWindow.Flats, addWindow.numberOfRooms, addWindow.rooms,
                    addWindow.floor,addWindow.washerAvailability,addWindow.stoveType);
        }

        private void windowsBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void heightBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool result = (Char.IsDigit(e.Text, 0)) || ((e.Text == ".") && (SeparatorCount(((TextBox)sender).Text)<1));
            e.Handled = !result;
        }
        private int SeparatorCount(string s)
        {
            string s1 = ".";
            int count = (s.Length - s.Replace(s1, "").Length);
            return count;
        }
    }
}
