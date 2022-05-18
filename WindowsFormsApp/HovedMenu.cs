using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
        }

        private void MainMenu_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LukNed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NormalPrisberegner_Click(object sender, EventArgs e)
        {
            var normalpris = new PrisberegnerMenu();
            normalpris.Show();
        }

        private void LægevagtPrisberegner_Click(object sender, EventArgs e)
        {
            var lægevagt = new LægevagtMenu();
            lægevagt.Show();
        }

        private void GETePortalKnap_Click(object sender, EventArgs e)
        {
            Process.Start("https://portal.get-e.com/portal/login");
        }

        private void LægevagtPortalKnap_Click(object sender, EventArgs e)
        {
            Process.Start("https://deltaplan.dk/logIn");
        }

        private void SharepointPortalKnap_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.flightstats.com/v2/");
        }

        private void GetEPrisberegner_Click(object sender, EventArgs e)
        {
            var geteMenuStart = new GeteMenu();
            geteMenuStart.Show();
        }

        private void HbPrisberegner_Click(object sender, EventArgs e)
        {
            var hbMenuStart = new hbPrisBeregner();
            hbMenuStart.Show();
        }
    }
}
