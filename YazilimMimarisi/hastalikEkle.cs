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
    public partial class hastalikEkle : Form
    {
        public hastalikEkle()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Hastalik hastalik = new Hastalik(bunifuMaterialTextbox1.Text);
            eklemeFactory fabrika = new eklemeFactory();
            fabrika.Hastalik = hastalik;
            IONesneEkle ekle = fabrika.nesneEkle("Hastalik");
            ekle.nesneEkle();
            this.Close();
        }
    }
}
