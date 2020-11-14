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
    public partial class SelectForm : Form
    {
        public int ProductType { get; set; }
        public SelectForm(int type)
        {
            InitializeComponent();
            ProductType = type;
            InitializeBoxes();
            switch (type)
            {
                case 1:
                    numberBox.Visible = true;
                    break;
                case 2:
                    secondBox.Visible = true;
                    break;
                case 3:
                    secondBox.Visible = true;
                    break;
                case 4:
                    secondBox.Visible = true;
                    thirdBox.Visible = true;
                    break;
            }

        }
        public void InitializeBoxes()
        {
            foreach (var vector in MainForm.Vectors)
            {
                firstBox.Items.Add(vector.ToString());
            }
            firstBox.SelectedIndex = 0;
            foreach (var vector in MainForm.Vectors)
            {
                secondBox.Items.Add(vector.ToString());
            }
            secondBox.SelectedIndex = 0;
            foreach (var vector in MainForm.Vectors)
            {
                thirdBox.Items.Add(vector.ToString());
            }
            thirdBox.SelectedIndex = 0;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Vector firstVector = MainForm.Vectors[firstBox.SelectedIndex];
            Vector secondVector = MainForm.Vectors[secondBox.SelectedIndex];
            Vector thirdVector = MainForm.Vectors[thirdBox.SelectedIndex];
            string message = "";
            string caption = "Result";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            bool isCorrect = true; 
            switch (ProductType) 
            { 
                case 1:
                    int number=0;
                    try
                    {
                        if (int.TryParse(numberBox.Text, out number))
                        {
                            Vector numberResult = firstVector * number;
                            message = "Result: " + numberResult.ToString();
                        }
                        else
                        {
                            isCorrect = false;
                            throw new IncorrectValueException("Incorrect value");
                        }
                    }
                    catch (IncorrectValueException exeption)
                    {
                        string errorMessage = exeption.Message;
                        string errorCaption = "Error";
                        MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                        MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                        MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
                        this.Close();
                    }
                    
                    break;
                case 2:
                    int scalarResult = firstVector * secondVector;
                    message = "Result: " + scalarResult;
                    break;
                case 3:
                    Vector vectorResult = Vector.VectorMultiple(firstVector,secondVector);
                    message = "Result: " + vectorResult.ToString();
                    break;
                case 4:
                    int mixedResult = Vector.MixedMultiply(firstVector, secondVector,thirdVector);
                    message = "Result: " + mixedResult;
                    break;

            }
            if (isCorrect == true)
                MessageBox.Show(message, caption, buttons, icon);
        }
    }
}
