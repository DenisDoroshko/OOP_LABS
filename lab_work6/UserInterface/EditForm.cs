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
    public partial class EditForm : Form
    {
        private MainForm mainForm;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if(result == DialogResult.Yes)
            {
                MainForm.Days.Clear();
            }
        }

        private void clearDayButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                DateTime date = SelectedDate.Value;
                DayInformation day = MainForm.Days.Find(x => x.Date == date);
                if (MainForm.Days.Remove(day))
                    clearLabel.Text = "yes";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

    }
}
