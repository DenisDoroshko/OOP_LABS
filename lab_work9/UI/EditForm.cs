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
    
    public partial class EditForm : Form
    {
        /// <summary>
        /// Selected vector
        /// </summary>
        
        public Vector vector;

        /// <summary>
        /// Creates an instance of the EditForm class
        /// </summary>
        /// <param name="vector">Selected vector</param>
        
        public EditForm(Vector vector)
        {
            InitializeComponent();
            this.vector = vector;
            xBox.Text = vector.CoordinateX.ToString();
            yBox.Text = vector.CoordinateY.ToString();
            zBox.Text = vector.CoordinateZ.ToString();
        }

        /// <summary>
        /// Edits a vector by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, EventArgs e)
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
                vector.CoordinateX = coordinateX;
                vector.CoordinateY = coordinateY;
                vector.CoordinateZ = coordinateZ;
                MainForm.Vectors.Add(vector);
                ShowGoodMessage();
            }
            catch (IncorrectValueException exception)
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
            string message = "The vector has been edited.";
            string caption = "Edition result";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        /// <summary>
        /// Shows a error message
        /// </summary>

        private void ShowErrorMessage(string message)
        {
            string errorMessage = "The vector hasn't been edited. " + message;
            string errorCaption = "Edition result";
            MessageBoxIcon errorIcon = MessageBoxIcon.Error;
            MessageBoxButtons errorButtons = MessageBoxButtons.OK;
            MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
        }

    }
}
