using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exceptions;
using Vectors;

namespace UI
{
    /// <summary>
    /// The class representing a form for edding a vector
    /// </summary>

    public partial class EditShowForm : Form
    {
        /// <summary>
        /// Link to the MainForm
        /// </summary>
       
        MainForm MainForm { get; set; }

        /// <summary>
        /// Creates an instance of the ShowEditForm class
        /// </summary>
        /// <param name="mainForm">Link to the MainForm</param>
        
        public EditShowForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            foreach (var vector in MainForm.Vectors)
            {
                vectorsBox.Items.Add(vector.ToString());
            }
        }

        /// <summary>
        /// Creates form for vector editing by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, EventArgs e)
        {
            try 
            {
                int index = vectorsBox.SelectedIndex;
                if (index < 0 || index >= MainForm.Vectors.Count)
                    throw new OutOfRangeException();
                Vector vector = MainForm.Vectors[vectorsBox.SelectedIndex];
                var editForm = new EditForm(vector);
                editForm.Show();
            }
            catch (OutOfRangeException exception)
            {
                ShowErrorMessage(exception.Message);
            }
            
        }

        /// <summary>
        /// Deletes all vectors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Confirmation";
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                MainForm.Vectors.Clear();
                vectorsBox.Items.Clear();
                foreach (var vector in MainForm.Vectors)
                {
                    vectorsBox.Items.Add(vector.ToString());
                }
                ShowGoodMessage("All data has been deleted.");
            }
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void EditShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Confirmation";
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int index = vectorsBox.SelectedIndex;
                    if (index < 0 || index >= MainForm.Vectors.Count)
                        throw new OutOfRangeException();
                    MainForm.Vectors.RemoveAt(index);
                    vectorsBox.Items.Clear();
                    foreach (var vector in MainForm.Vectors)
                    {
                        vectorsBox.Items.Add(vector.ToString());
                    }
                    ShowGoodMessage("Vector has been deleted.");
                }
                catch (OutOfRangeException exception)
                {
                    ShowErrorMessage(exception.Message);
                }
            }

        }

        /// <summary>
        /// Shows a good message
        /// </summary>

        private void ShowGoodMessage(string message)
        {
            string caption = "Operation result";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        /// <summary>
        /// Shows a error message
        /// </summary>

        private void ShowErrorMessage(string message)
        {
            string caption = "Error";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }
    }
}
