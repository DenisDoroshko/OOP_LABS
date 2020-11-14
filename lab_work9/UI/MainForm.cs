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
    public partial class MainForm : Form
    {
        public static List<Vector> Vectors { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Vectors = new List<Vector>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Vectors.Count == 0)
                    throw new NoValuesExeption();
                else
                {
                    var productForm = new ProductForm(this);
                    productForm.Show();
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
        }
    }
}
