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
    public partial class LægevagtMenu : Form
    {
        public LægevagtMenu()
        {
            InitializeComponent();
        }

        public decimal prisprmin = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UdregnButton_Click(object sender, EventArgs e)
        {
            decimal antalMin = MINnumericUpDown.Value;
            decimal total = antalMin * prisprmin;

            TotalTextBox.Text = total.ToString();
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MINnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "08:00-16:00 (Lørdag-Søndag)")
            {
                prisprmin = 4.5m;
            }
            else if (comboBox1.Text == "16:00-23:00 (Søndag-Torsdag)")
            {
                prisprmin = 4.58m;
            }
            else if (comboBox1.Text == "16:00-23:00 (Fredag-Lørdag)")
            {
                prisprmin = 5m;
            }
            else if (comboBox1.Text == "17:00-23:00 (Søndag-Torsdag)")
            {
                prisprmin = 4.58m;
            }
            else if (comboBox1.Text == "17:00-23:00 (Fredag-Lørdag)")
            {
                prisprmin = 5m;
            }
            else if (comboBox1.Text == "23:00-08:00 (Søndag-Torsdag)")
            {
                prisprmin = 5m;
            }
            else if (comboBox1.Text == "23:00-08:00 (Fredag-Lørdag)")
            {
                prisprmin = 5.41m;
            }

            if (comboBox1.Text == "08:00-16:00 (Lørdag-Søndag)")
            {
                KontoNummerTextBox.Text = "10160";
            }
            else if (comboBox1.Text == "16:00-23:00 (Søndag-Torsdag)" || comboBox1.Text == "16:00-23:00 (Fredag-Lørdag)" || comboBox1.Text == "17:00-23:00 (Søndag-Torsdag)" || comboBox1.Text == "17:00-23:00 (Fredag-Lørdag)")
            {
                KontoNummerTextBox.Text = "10154";
            }
            else if (comboBox1.Text == "23:00-08:00 (Søndag-Torsdag)" || comboBox1.Text == "23:00-08:00 (Fredag-Lørdag)")
            {
                KontoNummerTextBox.Text = "10155";
            }
        }

        private void KontoNummerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
