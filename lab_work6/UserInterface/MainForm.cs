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
    /// The class representing a form that implements the interface of the application menu
    /// </summary>
    
    public partial class MainForm : Form
    {
        /// <summary>
        /// List of days
        /// </summary>
        
        public static List<DayInformation> Days;

        /// <summary>
        /// Creates an instance of the MainForm class
        /// </summary>
        
        public MainForm()
        {
            InitializeComponent();
            Days = new List<DayInformation>();
        }

        /// <summary>
        /// Calls the form for adding a ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTicketForm ticketForm = new AddTicketForm(this);
            ticketForm.Show();
        }

        /// <summary>
        /// Calls the form for showing days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ShowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDayForm showForm = new ShowDayForm(this);
            showForm.Show();
        }

        /// <summary>
        /// Calls the form for clearing the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm showForm = new EditForm(this);
            showForm.Show();
        }

        /// <summary>
        /// Calls the form for showing period information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void peroidButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeriodForm periodForm = new PeriodForm(this);
            periodForm.Show();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
