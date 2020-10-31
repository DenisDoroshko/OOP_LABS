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
        public AddWindow addWindow;
        public int currentRoom;
        public CreateRoomWindow()
        {
            InitializeComponent();
        }
        public CreateRoomWindow(AddWindow addWindow,int currentRoom)
        {
            InitializeComponent();
            this.addWindow = addWindow;
            this.currentRoom = currentRoom;
        }

        private void addRoomButton_Click(object sender, RoutedEventArgs e)
        {
            //
            //More of the code
            //
            addWindow.rooms[currentRoom] = new Room(70,3,4,true,true, StoveTypes.Electric);
            addWindow.unfilledRooms--;
            currentRoom++;
            if (addWindow.unfilledRooms != 0)
            {
                var roomWindow = new CreateRoomWindow(addWindow, currentRoom);
                roomWindow.Show();
            }
            this.Close();
        }
    }
}
