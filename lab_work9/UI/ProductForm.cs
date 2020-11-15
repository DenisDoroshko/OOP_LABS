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

namespace UI
{
    /// <summary>
    /// The class representing a form for vector multiplication
    /// </summary>

    public partial class ProductForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>
        
        public MainForm MainForm { get; set; }

        /// <summary>
        /// Creates an instance of the ProductForm class
        /// </summary>
        /// <param name="mainForm"></param>
        
        public ProductForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        /// <summary>
        /// Creates a form for vector selecting by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                SelectForm selectForm = null;
                if (numberRadio.Checked)
                {
                    selectForm = new SelectForm(1, this);
                }
                if (scalarRadio.Checked)
                {
                    selectForm = new SelectForm(2, this);
                }
                if (vectorRadio.Checked)
                {
                    selectForm = new SelectForm(3, this);
                }
                if (mixedRadio.Checked)
                {
                    selectForm = new SelectForm(4, this);
                }
                if (selectForm == null)
                    throw new NoChoiceException();
                selectForm.Show();
                this.Hide();
            }
            catch (NoChoiceException exception)
            {
                ShowErrorMessage(exception.Message);
            }
        }

        /// <summary>
        /// Shows a error message
        /// </summary>

        private void ShowErrorMessage(string message)
        {
            string errorMessage = message+". Please select type of multiplication";
            string errorCaption = "Error";
            MessageBoxIcon errorIcon = MessageBoxIcon.Error;
            MessageBoxButtons errorButtons = MessageBoxButtons.OK;
            MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
        }

        /// <summary>
        /// Closes a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }

        /// <summary>
        /// Closes a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }
    }
}
