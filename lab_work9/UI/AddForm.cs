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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int coordinateX=0;
            int coordinateY=0;
            int coordinateZ=0;
            bool isCorrect = true;
            try
            {     
                if (!int.TryParse(xBox.Text, out coordinateX))
                    isCorrect = false;
                if (!int.TryParse(xBox.Text, out coordinateX))
                    isCorrect = false;  
                if (!int.TryParse(xBox.Text, out coordinateX))
                    isCorrect = false;
                if (isCorrect == false)
                    throw new IncorrectValueException("One or more values inputed incorrectly.");
            }
            catch(IncorrectValueException exeption)
            {
                string errorMessage = "The vector hasn't been added. "+ exeption.Message;
                string errorCaption = "Addition result";
                MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
                this.Close();
            }
            if (isCorrect == true)
            {
                Vector vector = new Vector(coordinateX, coordinateY, coordinateZ);
                MainForm.Vectors.Add(vector);
                string message = "The vector has been added.";
                string caption = "Addition result";
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
