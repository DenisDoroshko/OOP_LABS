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
    public partial class ShowDayForm : Form
    {
        private MainForm mainForm;
        public ShowDayForm()
        {
            InitializeComponent();
        }
        public ShowDayForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

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
                numberParterre.Text = "";
                numberLoggia.Text = "";
                numberBalcony.Text = "";
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void ShowDayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
