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
    public partial class diyetAd : Form
    {
        public string Ad { get; set; }
        public diyetAd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Ad = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
