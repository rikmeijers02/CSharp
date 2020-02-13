using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naam
{
    public partial class Naam : Form
    {
        public Naam()
        {
            InitializeComponent();
        }

        private void Naam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxNaam.Text))
            {
                MessageBox.Show("Je moet eerst je naam invullen.", "Error: Geen naam!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Hallo " + txtboxNaam.Text + ".");
            }
        }

        private void txtboxNaam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
