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
    /// The class representing a form that implements the interface for showing the days
    /// </summary>
    
    public partial class ShowDayForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>

        private MainForm mainForm;

        /// <summary>
        /// Creates an instance of the ShowDayForm class
        /// </summary>

        public ShowDayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the ShowDayForm class
        /// </summary>

        public ShowDayForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Shows the selected day by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ShowButton_Click(object sender, EventArgs e)
        {
            DateTime date = SelectedDate.Value;
            DayInformation day =  MainForm.Days.Find(x => x.Date == date);
            numberLabel.Text = "Number of tikets sold:";
            if (day != null)
            {
                numberSold.Text = day.TicketsNumber.ToString();
                parterreLabel.Text = "Number of tikets to the parterre:";
                numberParterre.Text = day.ParterreNumber.ToString();
                loggiaLabel.Text = "Number of tikets to the loggia:";
                numberLoggia.Text = day.LoggiaNumber.ToString();
                balconyLabel.Text = "Number of tikets to the balcony:";
                numberBalcony.Text = day.BalconyNumber.ToString();
            }
            else
            {
                numberSold.Text = "0";
                parterreLabel.Text = "";
                numberParterre.Text = "";
                loggiaLabel.Text = "";
                numberLoggia.Text = "";
                balconyLabel.Text = "";
                numberBalcony.Text = "";
            }

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

        private void ShowDayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
