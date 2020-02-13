using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoer_Getallen
{
    public partial class InvoerGetallen : Form
    {
        public InvoerGetallen()
        {
            InitializeComponent();
        }

        private void txbGetall_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sbyte getal1 = sbyte.Parse(txbGetal1.Text);
                sbyte getal2 = sbyte.Parse(txbGetal2.Text);
                int result = getal1 + getal2;
                label2.Text = getal1.ToString() + " + " + getal2.ToString() + " = " + result.ToString();
                errorProvider1.SetError(txbGetal1, "");
                errorProvider1.SetError(txbGetal2, "");
            }
            catch (Exception exception)
            {
                errorProvider1.SetError(txbGetal1, exception.Message);
                errorProvider1.SetError(txbGetal2, exception.Message);
                MessageBox.Show("Je moet eerst een getal invoeren.", "Error: " + exception.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
