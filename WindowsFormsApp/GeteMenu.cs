using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class GeteMenu : Form
    {
        private readonly TripDto _trip;
        public GeteMenu()
        {
            InitializeComponent();


            _trip = new TripDto()
            {
                ForventetKørtKm = AntalKMnumUpDown.Value,
                Storvogn = VogntypeComboBox.Text == "Minivan",
                ValgteTillæg = new List<Tillæg>(),
            };

        }

        //meet & greet
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MeetGreetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(MeetGreetCheckBox.Checked, Tillæg.MeetGreet);
        }

        private void StorebæltCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(StorebæltCheckBox.Checked, Tillæg.Storebælt);
        }

        private void ØresundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(StorebæltCheckBox.Checked, Tillæg.Storebælt);
        }

        private void SetTillæg(bool @checked, Tillæg tillæg)
        {
            if (@checked)
            {
                _trip.ValgteTillæg.Add(tillæg);
            }
            else
            {
                if (!_trip.ValgteTillæg.Contains(tillæg)) return;

                _trip.ValgteTillæg.Remove(tillæg);
            }
        }

        private void VogntypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VogntypeComboBox.Text == "Minivan")
            {
                _trip.Storvogn = true;
                return;
            }
            if (VogntypeComboBox.Text == "Sedan")
            {
                _trip.Storvogn = false;
                return;
            }
        }

        private void EkstraStopNumUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AntalKMnumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AntalKMnumUpDown.Value <= 0)
            {
                return;
            }
            else
            {
                _trip.ForventetKørtKm = AntalKMnumUpDown.Value;
            }
        }

        private void UdregnButton_Click(object sender, EventArgs e)
        {
            var result = ValidateFields();
            if (result != "")
            {
                MessageBox.Show(result, "Prisberegner Fejl");
            }
            else
            {
                var kmberegner = new GetEBeregner(_trip);
                var k = kmberegner.StorEllerLilleVogn();

                var tillægberegner = new GetEBeregner(_trip);
                var t = tillægberegner.TillægBerenger();

                var endeligResultat = k + t;

                ResultTextBox.Text = endeligResultat.ToString();
            }

        }

        private string ValidateFields()
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(VogntypeComboBox.Text)) sb.AppendLine("Vælg vogntype!");
            if (AntalKMnumUpDown.Value <= 0) sb.AppendLine("Indtast antal KM!");

            return sb.ToString();

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
