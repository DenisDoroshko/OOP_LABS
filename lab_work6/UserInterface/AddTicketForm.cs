using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAccounting;

namespace UserInterface
{
    public partial class AddTicketForm : Form
    {
        private MainForm mainForm;
        public AddTicketForm()
        {
            InitializeComponent();
        }
        public AddTicketForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, TicketTypes> ticketTypes = new Dictionary<string, TicketTypes>
            {
                ["Parterre"] = TicketTypes.Parterre,
                ["Loggia"] = TicketTypes.Loggia,
                ["Balcony"] = TicketTypes.Balcony
            };
            TicketTypes type;
            ticketTypes.TryGetValue(BoxTicketType.Text, out type);
            DateTime date = SelectedDate.Value;
            Ticket ticket = new Ticket(type, date);
            DayInformation.AddTicket(MainForm.Days, ticket);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void AddTicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
