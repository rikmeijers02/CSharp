using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser
{
    public partial class Webbrowser : Form
    {
        public Webbrowser()
        {
            InitializeComponent();
        }

        private void btnWeb1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.youtube.com/");
        }

        private void btnWeb2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.nu.nl/");
        }

        private void btnWeb3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.buienradar.nl/");
        }
    }
}
