using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class adminEkran : Form
    {
        public adminEkran()
        {
            InitializeComponent();
        }

        private void adminEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
