using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foutafhandeling
{
    public partial class Foutvoorbeeld : Form
    {
        public Foutvoorbeeld()
        {
            InitializeComponent();
        }

        private void btnBreuk_Click(object sender, EventArgs e)
        {
            double getal = 0;
            double breuk = 0;

            try {
                ErrorProvider1.SetError(txbGetal, "");
                getal = double.Parse(txbGetal.Text);
                breuk = 1 / getal;
                MessageBox.Show("De breuk van " + getal.ToString() + " is: " + breuk.ToString(), "Bereken breuk");
            } catch (Exception exception) {
                ErrorProvider1.SetError(txbGetal, exception.Message);
                MessageBox.Show("Er is een fout opgetreden", "Error: " + exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbGetal_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
