using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class diyetDegistir : Form
    {
        Hasta hasta = new Hasta();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");

        public diyetDegistir(Hasta hasta)
        {
            InitializeComponent();
            this.hasta = hasta;
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
        private void diyetDegistir_Load(object sender, EventArgs e)
        {
            List<Diyet> liste = LoadJson();
            foreach (Diyet item in liste)
            {
                comboBox1.Items.Add(item.name);
            }
            label2.Text = "Aktif Diyet :" + hasta.DiyetAD;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool hata=false;
            if (comboBox1.SelectedIndex != -1)
            {
                cmd = new SqlCommand("exec diyetDegistir '" + comboBox1.SelectedItem.ToString() + "','" + hasta.ID + "'", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    hata = true;
                    throw;
                }
                con.Close();
            }
            else
                MessageBox.Show("Lütfen Yeni Diyeti Şeçiniz");hata = true;
            if (!hata)
            {
                MessageBox.Show("Değişiklikler Kaydedildi Programı Yeniden Başlatmanız Sonucunda Program Güncellenecektir");
            }
        }
    }
}
