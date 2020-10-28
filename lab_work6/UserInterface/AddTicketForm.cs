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
    /// The class representing a form that implements the interface for adding a ticket
    /// </summary>
    
    public partial class AddTicketForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>
        
        private MainForm mainForm;

        /// <summary>
        /// Creates an instance of the AddTicketForm class
        /// </summary>
        
        public AddTicketForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the AddTicketForm class
        /// </summary>
        
        public AddTicketForm(MainForm mainForm)
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
            Ticket ticket = new Ticket(type, date);
            DayInformation.AddTicket(MainForm.Days, ticket);
        }

        /// <summary>
        /// Returns to the main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        /// <summary>
        /// Shows main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void AddTicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
