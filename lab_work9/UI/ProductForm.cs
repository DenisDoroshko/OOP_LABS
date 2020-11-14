using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ProductForm : Form
    {
        public MainForm MainForm { get; set; }
        public ProductForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = null;
            if (numberRadio.Checked)
            {
                selectForm = new SelectForm(1);
            }
            if (scalarRadio.Checked)
            {
                selectForm = new SelectForm(2);
            }
            if (vectorRadio.Checked)
            {
                selectForm = new SelectForm(3);
            }
            if (mixedRadio.Checked)
            {
                selectForm = new SelectForm(4);
            }
            selectForm.Show();
        }
    }
}
