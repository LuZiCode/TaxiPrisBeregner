using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class hbPrisBeregner : Form
    {   
        public hbPrisBeregner()
        {
            InitializeComponent();
        }

        private void AreacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AreacomboBox.Text == "København")
            {
                SinglePriceTextBox.Text = "ukendt";
            }
            else if (AreacomboBox.Text == "Århus")
            {
                SinglePriceTextBox.Text = "15kr";
            }
            else if (AreacomboBox.Text == "Vejle")
            {
                SinglePriceTextBox.Text = "16,67kr";
            }
            else if (AreacomboBox.Text == "Øvrig")
            {
                SinglePriceTextBox.Text = "13,33kr";
            }
        }

        private void MINnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SinglePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UdregnButton_Click(object sender, EventArgs e)
        {
            decimal antalmin = MINnumericUpDown.Value;
            string område = AreacomboBox.Text;

            var 
        }
    }
}
