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
    public partial class MainForm : Form
    {
        public static List<DayInformation> Days;
        public MainForm()
        {
            InitializeComponent();
            Days = new List<DayInformation>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTicketForm ticketForm = new AddTicketForm(this);
            ticketForm.Show();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDayForm showForm = new ShowDayForm(this);
            showForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm showForm = new EditForm(this);
            showForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeriodForm periodForm = new PeriodForm(this);
            periodForm.Show();
        }
    }
}
