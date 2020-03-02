using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leeftijdChecker
{
    public partial class leeftijdChecker : Form
    {
        public leeftijdChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Data
                DateTime today = DateTime.Now;
                DateTime date1 = bornDatePicker.Value;
                DateTime date2 = date1.AddYears(18);
                TimeSpan tSpan = today - date1;
                string result1 = date2.ToString("dd-MM-yyyy");
                double days = tSpan.TotalDays;
                double calc1 = (days / 365);
                int result2 = (int)calc1;

                // If statements
                if (checkBoxM.Checked == true && result2 >= 18)
                {
                    MessageBox.Show("Je mag al alcohol drinken.", "18+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxJ.Checked == true && result2 >= 18)
                {
                    MessageBox.Show("Je mag al alcohol drinken.", "18+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxM.Checked == true && result2 < 18)
                {
                    MessageBox.Show("Wat wil je dan wél drinken?", "Meisje 18-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxJ.Checked == true && result2 < 18)
                {
                    MessageBox.Show("Je hebt pech en kunt vandaag alleen nog maar water krijgen", 
                        "Jongen 18-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Je mag pas alcohol drinken vanaf: " + result1, "Jongen 18-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error MessageBox (Empty gender)
                    MessageBox.Show("Er is een fout opgetreden.", "Error: Empty gender.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception error)
            {
                //Error MessageBox
                MessageBox.Show("Er is een fout opgetreden.", "Error: " + error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Data
                DateTime today = DateTime.Now;
                DateTime date1 = bornDatePicker.Value;
                DateTime date2 = date1.AddYears(18);
                TimeSpan tSpan = today - date1;
                double days = tSpan.TotalDays;
                double calc1 = (days / 365);
                int result2 = (int)calc1;

                if (schoolfeestDatePicker.Value < date2 && checkBoxM.Checked || checkBoxJ.Checked)
                {
                    MessageBox.Show("Je bent met het schoolfeest nog geen 18.", "Schoolfeest 18-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (schoolfeestDatePicker.Value > date2 && checkBoxM.Checked || checkBoxJ.Checked)
                {
                    MessageBox.Show("Je bent met het schoolfeest 18.", "Schoolfeest 18+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error MessageBox (Empty gender)
                    MessageBox.Show("Er is een fout opgetreden.", "Error: Empty gender.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception error)
            {
                //Error MessageBox
                MessageBox.Show("Er is een fout opgetreden.", "Error: " + error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leeftijdChecker_Load(object sender, EventArgs e)
        {
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM.Checked == true)
            {
                checkBoxJ.Enabled = false;
            } else if (checkBoxM.Checked == false)
            {
                checkBoxJ.Enabled = true;
            }
        }

        private void checkBoxJ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJ.Checked == true)
            {
                checkBoxM.Enabled = false;
            }
            else if (checkBoxJ.Checked == false)
            {
                checkBoxM.Enabled = true;
            }
        }
    }
}
