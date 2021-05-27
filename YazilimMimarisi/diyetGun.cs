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
    public partial class diyetGun : Form
    {
        public Day Gun { get; set; }
        public diyetGun(string breakfast,string lunch,string meal)
        {
            InitializeComponent();
            txtBreakfast.Text = breakfast;
            txtLunch.Text = lunch;
            txtMeal.Text = meal;
            txtBreakfast.Enabled = false;
            txtLunch.Enabled = false;
            txtMeal.Enabled = false;
            bunifuImageButton1.Visible = false;

        }
        public diyetGun()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Gun = new Day();
            Gun.kahvalti = txtBreakfast.Text;
            Gun.Oglen = txtLunch.Text;
            Gun.Aksam = txtMeal.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
