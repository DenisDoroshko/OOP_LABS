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
    /// Логика взаимодействия для ShowElectricStoveWindow.xaml
    /// </summary>
    public partial class ShowElectricStoveWindow : Window
    {
        public MainWindow mainWindow;
        public ShowElectricStoveWindow()
        {
            InitializeComponent();
        }
        public ShowElectricStoveWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void ShowFlats(object sender, EventArgs e)
        {
            if (MainWindow.Flats.Count != 0)
            {
                foreach (var flat in MainWindow.Flats)
                {
                    if (flat.StoveType == StoveTypes.Electric)
                    {
                        showLabel.Content += $"{flat}\n";
                        foreach (var room in flat.Rooms)
                            showLabel.Content += $"  {room}\n";
                    }
                }
            }
            else
            {
                string message = "There no flats.";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, button, icon);
                mainWindow.Show();
                this.Close();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void ShowMain_Closed(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
