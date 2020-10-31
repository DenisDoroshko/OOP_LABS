using Flats;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Room[] rooms;
        public int floor;
        public int numberOfRooms;
        public int unfilledRooms;
        public AddWindow()
        {
            InitializeComponent();
        }

        private void sendFlatButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> flatTypes = new Dictionary<string, int>()
            {
                ["One room flat"] = 1,
                ["Two room flat"] = 2,
                ["Three room flat"] = 3,
                ["Four room flat"] = 4,
                ["Five room flat"] = 5
            };
            var item = (ComboBoxItem)typeBox.SelectedItem;
            string flatType = item.Content.ToString();
            flatTypes.TryGetValue(flatType, out numberOfRooms);
            string stringFloor = floorBox.Text;
            int.TryParse(stringFloor, out floor);
            if(floor<1 || floor > 100)
            {
                string message = "Floor entered incorrectly";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message,caption,button,icon);
            }
            else
            {
                unfilledRooms = numberOfRooms;
                rooms = new Room[numberOfRooms];
                var roomWindow = new CreateRoomWindow(this,0);
                roomWindow.Show();
            }

        }

        private void floorBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
