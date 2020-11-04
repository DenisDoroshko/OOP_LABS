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
    /// The class representing a form that implements the interface for edit a data
    /// </summary>
    
    public partial class EditForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>
        
        private MainForm mainForm;

        /// <summary>
        /// Creates an instance of the EditForm class
        /// </summary>
        
        public EditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the EditForm class
        /// </summary>
        
        public EditForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Clears the data by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons,icon);
            if(result == DialogResult.Yes)
            {
                MainForm.Days.Clear();
                message = "All data has been deleted";
                caption = "Operation result";
                icon = MessageBoxIcon.Information;
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        /// <summary>
        /// Clears one selected day by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clearDayButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons,icon);
            if (result == DialogResult.Yes)
            {
                DateTime date = SelectedDate.Value;
                DayInformation day = MainForm.Days.Find(x => x.Date.Date == date.Date);
                MainForm.Days.Remove(day);
                message = "The day was deleted";
                caption = "Operation result";
                icon = MessageBoxIcon.Information;
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
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

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

    }
}
