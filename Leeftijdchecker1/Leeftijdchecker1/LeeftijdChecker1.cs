using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leeftijdchecker1
{
    public partial class LeeftijdChecker1 : Form
    {
        public LeeftijdChecker1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte age = byte.Parse(txbAge.Text);
                int translate = 18 - age;
                DateTime geboortedatum = DateTime.Now;
                int jaar = geboortedatum.Year + translate;

                if (age >= 18)
                {
                    errorProvider1.SetError(txbAge, "");
                    MessageBox.Show("Drink bier inplaatsvan water, dan heb je morgen een flinke kater.", "18+");
                }
                else if (checkBoxMeisje.Checked == true && age < 18)
                {
                    errorProvider1.SetError(txbAge, "");
                    MessageBox.Show("Wat wil je dan wel drinken?", "18- Meisjes");
                    MessageBox.Show("Je mag pas alcohol drinken vanaf " + jaar.ToString(), "18+?");
                }
                else if (checkBoxJongen.Checked == true && age < 18)
                {
                    errorProvider1.SetError(txbAge, "");
                    MessageBox.Show("Je hebt pech je krijgt vandaag alleen nog maar water.", "18- Jongens");
                    MessageBox.Show("Je mag pas alcohol drinken vanaf " + jaar.ToString(), "18+?");
                }
                else
                {
                    errorProvider1.SetError(txbAge, "Input string was not in a correct format.");
                    MessageBox.Show("Er is een probleem opgetreden.", "Error: Niet alle velden ingevuld" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                errorProvider1.SetError(txbAge, exception.Message);
                MessageBox.Show("Er is een probleem opgetreden.", "Error: " + exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte age = byte.Parse(txbAge.Text);

                if (age >= 17)
                {
                    MessageBox.Show("Je bent met het schoolfeest 18.", "18+ Schoolfeest");
                } else
                {
                    MessageBox.Show("Je bent met het schoolfeest nog geen 18+.", "18- Schoolfeest");
                }
            }
            catch (Exception exception)
            {
                errorProvider1.SetError(txbAge, exception.Message);
                MessageBox.Show("Er is een probleem opgetreden.", "Error: " + exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxMeisje_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
