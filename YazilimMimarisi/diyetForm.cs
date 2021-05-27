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
using Newtonsoft.Json;//Json Okuma Yazdırma Paketi
using HtmlAgilityPack;//Html Olarak Yazdırmak için paket

namespace YazilimMimarisi
{
    public partial class diyetForm : Form
    {
        private Form activeForm = null;
        private int diyetID=0;
        private Diyet seciliDiyet=new Diyet();
        public diyetForm(int diyetID)
        {
            InitializeComponent();
            customizeDesing();
            this.diyetID = diyetID;
        }
        private void customizeDesing()
        {
            diyetSubPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (diyetSubPanel.Visible)
            {
                diyetSubPanel.Visible = false;
            }
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

        private void diyetForm_Load(object sender, EventArgs e)
        {
            

            //string strResultJson = JsonConvert.SerializeObject(List<Diyet>);
            //File.WriteAllText(@"test.json", strResultJson);

            List<Diyet> liste = LoadJson();
            foreach (Diyet item in liste)
            {
                if (item.ID == diyetID)
                {
                    seciliDiyet = item;
                }
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

        private void btnDiyet_Click(object sender, EventArgs e)
        {
            showSubMenu(diyetSubPanel);
            
        }
        #region Diyet
        private void btnMon_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Pazartesi.kahvalti, 
                seciliDiyet.Pazartesi.Oglen, seciliDiyet.Pazartesi.Aksam));
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Sali.kahvalti,
                seciliDiyet.Sali.Oglen, seciliDiyet.Sali.Aksam));
        }

        private void btnWed_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Carsamba.kahvalti,
                seciliDiyet.Carsamba.Oglen, seciliDiyet.Carsamba.Aksam));
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Persembe.kahvalti,
                seciliDiyet.Persembe.Oglen, seciliDiyet.Persembe.Aksam));
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Cuma.kahvalti,
                seciliDiyet.Cuma.Oglen, seciliDiyet.Cuma.Aksam));
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Cumartesi.kahvalti,
                seciliDiyet.Cumartesi.Oglen, seciliDiyet.Cumartesi.Aksam));
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            openChildForm(new diyetGun(seciliDiyet.Pazar.kahvalti,
                seciliDiyet.Pazar.Oglen, seciliDiyet.Pazar.Aksam));
        }
        #endregion

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
