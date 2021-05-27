using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class doctorScreen : Form
    {
        private Form activeForm = null;
        Diyet Diyet = new Diyet();
        public doctorScreen()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            diyetaddSubPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (diyetaddSubPanel.Visible)
            {
                diyetaddSubPanel.Visible = false;
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showSubMenu(Panel subPanel)
        {
            if (!(subPanel.Visible))
            {
                hideSubMenu();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;
        }
        #region Diyet
        private void btnMon_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Pazartesi = form.Gun;
                }
            }
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Sali = form.Gun;
                }
            }
        }

        private void btnWed_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Carsamba = form.Gun;
                }
            }
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Persembe = form.Gun;
                }
            }
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Cuma = form.Gun;
                }
            }
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Cumartesi = form.Gun;
                }
            }
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            using (var form = new diyetGun())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diyet.Pazar = form.Gun;
                }
            }
        }

        #endregion

        private void btnChangeDiet_Click(object sender, EventArgs e)
        {
            showSubMenu(diyetaddSubPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new diyetAd())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.Ad;//values preserved after close
                    //Do something here with these values

                    //for example
                    this.Diyet.name = val;
                }
            }
            List<Diyet> LoadJson()
            {
                using (StreamReader r = new StreamReader(@"test.json"))
                {
                    string json = r.ReadToEnd();
                    List<Diyet> items = JsonConvert.DeserializeObject<List<Diyet>>(json);
                    return items;
                }
            }
            List<Diyet> liste = LoadJson();
            Diyet.ID = liste.Count + 1;
            eklemeFactory fabrika = new eklemeFactory();
            fabrika.Diet = this.Diyet;
            IONesneEkle ekle = fabrika.nesneEkle("Diyet");
            ekle.nesneEkle();
        }
    }
}
