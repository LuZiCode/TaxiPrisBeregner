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
        private readonly TripDtoGetE _tripGetE;
        public GeteMenu()
        {
            InitializeComponent();


            _tripGetE = new TripDtoGetE()
            {
                ForventetKørtKm = AntalKMnumUpDown.Value,
                EkstraDistance = EkstraStopNumUpDown.Value,
                Storvogn = VogntypeComboBox.Text == "Minivan",
                ValgteTillæg = new List<TillægGetE>(),
            };

        }

        //meet & greet
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MeetGreetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(MeetGreetCheckBox.Checked, TillægGetE.MeetGreet);
        }

        private void StorebæltCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(StorebæltCheckBox.Checked, TillægGetE.Storebælt);
        }

        private void ØresundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTillæg(ØresundCheckBox.Checked, TillægGetE.Øresund);
        }

        private void SetTillæg(bool @checked, TillægGetE tillæg)
        {
            if (@checked)
            {
                _tripGetE.ValgteTillæg.Add(tillæg);
            }
            else
            {
                if (!_tripGetE.ValgteTillæg.Contains(tillæg)) return;

                _tripGetE.ValgteTillæg.Remove(tillæg);
            }
        }

        private void VogntypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VogntypeComboBox.Text == "Minivan")
            {
                _tripGetE.Storvogn = true;
                return;
            }
            if (VogntypeComboBox.Text == "Sedan")
            {
                _tripGetE.Storvogn = false;
                return;
            }
        }

        private void EkstraStopNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EkstraStopNumUpDown.Value < 0)
            {
                return;
            }
            else
            {
                _tripGetE.EkstraDistance = EkstraStopNumUpDown.Value;
            }
        }

        private void AntalKMnumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AntalKMnumUpDown.Value <= 0)
            {
                return;
            }
            else
            {
                _tripGetE.ForventetKørtKm = AntalKMnumUpDown.Value;
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
                var kmberegner = new GetEBeregner(_tripGetE);
                var k = kmberegner.StorEllerLilleVogn();

                var tillægberegner = new GetEBeregner(_tripGetE);
                var t = tillægberegner.TillægBerenger();

                var ekstrastopberegner = new GetEBeregner(_tripGetE);
                var ek = ekstrastopberegner.EkstraStopBeregner();

                var endeligResultat = k + t + ek;

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
