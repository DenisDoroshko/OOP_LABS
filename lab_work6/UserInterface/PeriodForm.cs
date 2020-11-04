using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAccounting;

namespace UserInterface
{
    /// <summary>
    /// The class representing a form that implements the interface for showing peroi information
    /// </summary>
    
    public partial class PeriodForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>
        
        private MainForm mainForm;

        /// <summary>
        /// Creates an instance of the PeriodForm class
        /// </summary>
        
        public PeriodForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the PeriodForm class
        /// </summary>
        
        public PeriodForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Shows average number of tickets by type by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showAveragesButton_Click(object sender, EventArgs e)
        {
            minimalDaylabel.Text = "";
            errorLabel.Text = "";
            List<DayInformation> periodDays = new List<DayInformation>();
            if (GetPeriodDays(periodDays))
            {
                double averageParterre = DayInformation.GetAverage(periodDays, TicketTypes.Parterre);
                double averageLoggia = DayInformation.GetAverage(periodDays, TicketTypes.Loggia);
                double averageBalcony = DayInformation.GetAverage(periodDays, TicketTypes.Balcony);
                parterreLabel.Text = "On average, tickets sold to the parterre:";
                averageParterreLabel.Text = Math.Round(averageParterre, 1).ToString();
                loggiaLabel.Text = "On average, tickets sold to the loggia:";
                averageLoggiaLabel.Text = Math.Round(averageLoggia, 1).ToString();
                balconyLabel.Text = "On average, tickets sold to the balcony:";
                averageBalconyLabel.Text = Math.Round(averageBalcony, 1).ToString();
            }
            else
            {
                errorLabel.Text = "Incorrect period";
            }
        }

        /// <summary>
        /// Shows the day with the minimal number of tickets sold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void showMinimalDaybutton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            parterreLabel.Text = "";
            averageParterreLabel.Text = "";
            loggiaLabel.Text = "";
            averageLoggiaLabel.Text = "";
            balconyLabel.Text = "";
            averageBalconyLabel.Text = "";
            List<DayInformation> periodDays = new List<DayInformation>();
            if (GetPeriodDays(periodDays))
            {

                DayInformation minimalDay = periodDays[0];
                foreach (var day in periodDays)
                {
                    if (minimalDay.Tickets.Count > day.Tickets.Count)
                        minimalDay = day;
                        
                }
                int number = 0;
                foreach (var day in periodDays)
                {
                    if (minimalDay.Tickets.Count == day.Tickets.Count)
                        number++;
                }

                switch (number)
                {
                    case 1:
                        minimalDaylabel.Text = "The day with minimal tickets number: "
                           +minimalDay.Date.ToShortDateString()+" tickets number:"+minimalDay.Tickets.Count;
                        break;
                    default:
                        minimalDaylabel.Text = "Days with a minimum tickets number more than one";
                        break;
                }
            }
            else
            {
                errorLabel.Text = "Incorrect period";
            }
        }

        /// <summary>
        /// Gets period days
        /// </summary>
        /// <param name="periodDays">Period days</param>
        /// <returns>The value is true if peroid is correct; otherwise value is false</returns>
        
        bool GetPeriodDays(List<DayInformation> periodDays)
        {
            bool isCorrectPeriod;
            DateTime fromDate = fromDatePicker.Value;
            DateTime toDate = toDatePicker.Value;
            if (fromDate.Date <= toDate)
            {
                DateTime currentDate = fromDate;
                while (currentDate.Date <= toDate.Date)
                {
                    DayInformation day = MainForm.Days.Find(x => x.Date == currentDate);
                    if (day != null)
                    {
                        periodDays.Add(day);
                    }
                    else
                    {
                        periodDays.Add(new DayInformation(currentDate, new List<DayInformation.Ticket>()));
                    }
                    currentDate = currentDate.AddDays(1);
                }
                isCorrectPeriod = true;
            }
            else
            {
                isCorrectPeriod = false;
            }
            return isCorrectPeriod;
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

        private void PeriodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
        
    }
}
