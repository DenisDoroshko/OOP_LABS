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
    /// <summary>
    /// The class representing a form that implements the interface for ticket adding
    /// </summary>
    
    public partial class AddForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>

        private MainForm mainForm;

        /// <summary>
        /// Creates an instance of the AddForm class
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creates an instance of the AddForm class
        /// </summary>

        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Adds the entered ticket by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            DayInformation.Ticket ticket = new DayInformation.Ticket(type, date);
            DayInformation.AddTicket(MainForm.Days, ticket);
            string message = "The ticket was added";
            string caption = "Addition result";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message,caption,buttons,icon);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
