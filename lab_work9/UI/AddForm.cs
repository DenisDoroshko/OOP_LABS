using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vectors;
using Exceptions;

namespace UI
{
    /// <summary>
    /// The class representing a form for adding a vector
    /// </summary>
    
    public partial class AddForm : Form
    {
        /// <summary>
        /// Creates an instance of the AddForm class
        /// </summary>
        
        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a vector by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int coordinateX;
                int coordinateY;
                int coordinateZ;
                if (!int.TryParse(xBox.Text, out coordinateX))
                    throw new IncorrectValueException("One or more values inputed incorrectly.");
                if (!int.TryParse(yBox.Text, out coordinateY))
                    throw new IncorrectValueException("One or more values inputed incorrectly.");
                if (!int.TryParse(zBox.Text, out coordinateZ))
                    throw new IncorrectValueException("One or more values inputed incorrectly.");
                Vector vector = new Vector(coordinateX, coordinateY, coordinateZ);
                MainForm.Vectors.Add(vector);
                ShowGoodMessage();
            }
            catch(IncorrectValueException exception)
            {
                ShowErrorMessage(exception.Message);
            }
            this.Close();

        }

        /// <summary>
        /// Shows a good message
        /// </summary>
        
        private void ShowGoodMessage()
        {
            string message = "The vector has been added.";
            string caption = "Addition result";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        /// <summary>
        /// Shows a error message
        /// </summary>

        private void ShowErrorMessage(string message)
        {
            string errorMessage = "The vector hasn't been added. " + message;
            string errorCaption = "Addition result";
            MessageBoxIcon errorIcon = MessageBoxIcon.Error;
            MessageBoxButtons errorButtons = MessageBoxButtons.OK;
            MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
        }

    }
}
