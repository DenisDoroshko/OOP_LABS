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
    public partial class PeriodForm : Form
    {
        private MainForm mainForm;
        public PeriodForm()
        {
            InitializeComponent();
        }
        public PeriodForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

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
                
                DayInformation minimalDay = new DayInformation(new DateTime(),new List<Ticket>());
                bool isEmpty = true;
                foreach(var day in periodDays)
                {
                    if(minimalDay.Tickets.Count < day.Tickets.Count)
                    {
                        minimalDay = day;
                        isEmpty = false;
                    }
                        
                }
                int number = 0;
                foreach (var day in periodDays)
                {
                    if (minimalDay.Tickets.Count == day.Tickets.Count)
                        number++;
                }
                if (isEmpty == true)
                    number = 0;
                switch (number)
                {
                    case 0:
                        minimalDaylabel.Text = "All the days are empty";
                        break;
                    case 1:
                        minimalDaylabel.Text = "The day with minimal tickets number: "
                           +minimalDay.Date.ToShortDateString()+" tickets number:"+minimalDay.Tickets.Count;
                        break;
                    default:
                        minimalDaylabel.Text = "Days with a minimum tickets number more than two";
                        break;
                }
            }
            else
            {
                errorLabel.Text = "Incorrect period";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void PeriodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        bool GetPeriodDays(List<DayInformation> periodDays)
        {
            bool isCorrectPeriod;
            DateTime fromDate = fromDatePicker.Value;
            DateTime toDate = toDatePicker.Value;
            if (DateTime.Compare(fromDate, toDate) != 1)
            {
                DateTime currentDate = fromDate;
                while (DateTime.Compare(currentDate, toDate) != 1)
                {
                    DayInformation day = MainForm.Days.Find(x => x.Date == currentDate);
                    if (day != null)
                    {
                        periodDays.Add(day);
                    }
                    else
                    {
                        periodDays.Add(new DayInformation(currentDate, new List<Ticket>()));
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
        
    }
}
