using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumVoorbeeld
{
    public partial class datumvoorbeeld : Form
    {
        public datumvoorbeeld()
        {
            InitializeComponent();
        }

        private void btnVandaag_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            lblOutput.Text = vandaag.ToString();
        }

        private void btnJaar_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            int jaar = vandaag.Year;
            lblOutput.Text = jaar.ToString();
        }

        private void btnWeekdag_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            lblOutput.Text = vandaag.DayOfWeek.ToString();
        }

        private void btnNummer_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            int maand = vandaag.Month;
            lblOutput.Text = maand.ToString();
        }

        private void btnNaam_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            string maand = vandaag.ToString("MMMM");
            lblOutput.Text = maand;
        }

        private void btnAfkorting_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            string maand = vandaag.ToString("MMM");
            lblOutput.Text = maand;
        }

        private void btnLeeftijd_Click(object sender, EventArgs e)
        {
            DateTime geboortedatum = dateTimePickerGeboortedatum.Value;
            TimeSpan leeftijd = DateTime.Now - geboortedatum;
            lblOutput.Text = (leeftijd.TotalDays / 365.25).ToString();
        }
    }
}
