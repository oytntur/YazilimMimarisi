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
using Newtonsoft.Json;

namespace YazilimMimarisi
{
    public partial class diyetForm : Form
    {
        public diyetForm()
        {
            InitializeComponent();
        }

        private void diyetForm_Load(object sender, EventArgs e)
        {
            Diyet diyet = new Diyet();
            Day day = new Day();
            diyet.name = "glutensiz";
            day.kahvalti = "Glutensiz ekmek, çiğ sebze (buharda yapılabilir), beyaz peynir, 2 tane kuru erik";
            day.Oglen = "Izgara balık, rokalı salata, mısır ekmeği";
            day.Aksam = "Tavuk sote, pirinçli yayla çorbası, mevsim salatası";
            diyet.Pazartesi = day;
            Diyet diyet2 = new Diyet();
            Day day2 = new Day();
            diyet2.name = "Şeker";
            diyet2.Pazartesi = day;
            List<Diyet> diyets = new List<Diyet>();
            diyets.Add(diyet2);
            diyets.Add(diyet);

            string strResultJson = JsonConvert.SerializeObject(diyets);
            File.WriteAllText(@"test.json", strResultJson);
            List<Diyet> liste = LoadJson();
            foreach (Diyet item in liste)
            {
                MessageBox.Show(item.Pazartesi.kahvalti);
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
    }
}
