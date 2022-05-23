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
    public partial class PrisberegnerMenu : Form
    {
        private readonly TripDto _trip;

        public PrisberegnerMenu()
        {
            InitializeComponent();
            
            //TidspunktcomboBox.DataSource = 

            _trip = new TripDto()
            {
                ForventetKørtKm = KMnumericUpDown.Value,
                Køretid = MINnumericUpDown.Value,
                Nattakst = TidspunktcomboBox.Text == "Nat",
                Storvogn = VognTypecomboBox.Text == "Storvogn",
                TurStartPris = 0,
                ValgteTillæg = new List<Tillæg>(),
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void openGoogleMaps_Click(object sender, EventArgs e)
        {
            StringBuilder queryadress = new StringBuilder();
            queryadress.Append("http://google.com/maps?q=");
            webBrowser1.Navigate(queryadress.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CykelcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBridge(CykelcheckBox.Checked, Tillæg.CykelOpbæringOgHjælp);
        }

        private void LufthavncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBridge(LufthavncheckBox.Checked, Tillæg.Lufthavn);
        }

        private void StorebæltcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBridge(StorebæltcheckBox.Checked, Tillæg.Storebælt);
        }

        private void ØresundcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBridge(ØresundcheckBox.Checked, Tillæg.Øresund);
        }


        private void SetBridge(bool @checked, Tillæg tillæg)
        {
            if (@checked)
            {
                _trip.ValgteTillæg.Add(tillæg);
            }
            else
            {
                if(!_trip.ValgteTillæg.Contains(tillæg)) return;

                _trip.ValgteTillæg.Remove(tillæg);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void KMnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(KMnumericUpDown.Value <= 0)
            {
                return;
            }
            else
            {
                _trip.ForventetKørtKm = KMnumericUpDown.Value;
            }
        }

        private void MINnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            if (MINnumericUpDown.Value <= 0)
            {
                return;
            }
            else
            {
                _trip.Køretid = MINnumericUpDown.Value;
            }
        }

        private void udregnButton_Click(object sender, EventArgs e)
        {
            var result = ValidateFields();
            if (result != "")
            {
                MessageBox.Show(result, "Prisberegner Fejl");
            }
            else
            {
                var beregninger = new SamledePrisForTuren(_trip);
                var t = beregninger.BestiltEllerGadeTur();

                var tillægberenger = new SamledePrisForTuren(_trip);
                var f = tillægberenger.TillægBeregner();

                var endeligResult = t + f;
                textBox1.Text = endeligResult.ToString();
            }

            ValidateFields();
        }

        private string ValidateFields()
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(VognTypecomboBox.Text)) sb.AppendLine("Vælg vogntype!");

            if (string.IsNullOrEmpty(TidspunktcomboBox.Text)) sb.AppendLine("Vælg tidspunkt!");
          
            if (string.IsNullOrEmpty(comboBoxTurType.Text)) sb.AppendLine("Vælg tur type!");

            if (KMnumericUpDown.Value <= 0) sb.AppendLine("Indtast KM!");

            if (MINnumericUpDown.Value <= 0) sb.AppendLine("Indtast Min!");

            return sb.ToString();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TidspunktcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TidspunktcomboBox.Text == "Nat")
            {
                _trip.Nattakst = true;
                return;
            }

            if (TidspunktcomboBox.Text == "Dag")
            {
                _trip.Nattakst = false;
                return;
            }

            //hvis vi kommer her skal der være en error besked.
            if (TidspunktcomboBox.Text != "Nat" || TidspunktcomboBox.Text != "Dag")
            {
                MessageBox.Show("Du skal indtaste et tidspunkt!");
                return;
            }
        }

        private void VognTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VognTypecomboBox.Text == "Storvogn")
            {
                _trip.Storvogn = true;
                return;
            }

            if (VognTypecomboBox.Text == "Personbil")
            {
                _trip.Storvogn = false;
                return;
            }
        }

        private void comboBoxTurType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTurType.Text == "Radiotur")
            {
                _trip.BestiltTur = true;
                return;
            }

            if (comboBoxTurType.Text == "Gadetur")
            {
                _trip.BestiltTur = false;
                return;
            }
        }
    }
}
