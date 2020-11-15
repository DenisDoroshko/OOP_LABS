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
    /// The class representing the main form
    /// </summary>

    public partial class MainForm : Form
    {
        /// <summary>
        /// Vectors
        /// </summary>
        
        public static List<Vector> Vectors { get; set; }

        /// <summary>
        /// Creates an instance of the MainForm class
        /// </summary>
        
        public MainForm()
        {
            InitializeComponent();
            Vectors = new List<Vector>();
        }

        /// <summary>
        /// Creates a form for vector additing by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.Show();
        }


        /// <summary>
        /// Closes the application by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Creates a form for vector multiplication by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void multipleButton_Click(object sender, EventArgs e)
        {
            bool isAvailable = CheckAvailability();
            if (isAvailable == true)
            {
                var productForm = new ProductForm(this);
                productForm.Show();
                this.Hide();
            }

        }

        /// <summary>
        /// Creates a form for show and edit vectors by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void EditShowbutton_Click(object sender, EventArgs e)
        {
            bool isAvailable = CheckAvailability();
            if (isAvailable == true)
            {
                var editForm = new EditShowForm(this);
                editForm.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Checks availability of vectors
        /// </summary>
        /// <returns>Availability of vectors</returns>
        
        private bool CheckAvailability()
        {
            bool availability = false;
            try
            {
                if (Vectors.Count == 0)
                    throw new NoValuesExeption();
                else
                {
                    availability = true;
                }
            }
            catch (NoValuesExeption exeption)
            {
                string errorMessage = exeption.Message;
                string errorCaption = "Error";
                MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon);
            }
            return availability;
        }
    }
}
