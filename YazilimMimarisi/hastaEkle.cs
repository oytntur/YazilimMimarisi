using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class hastaEkle : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");

        public hastaEkle()
        {
            InitializeComponent();
            cmd = new SqlCommand("select * from tblHastalik", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["hastalikAD"].ToString());
            }
            con.Close();
            dr.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool hata=false;
            cmd = new SqlCommand("exec hastaOlustur '" + txtAd.Text + "','" + txtSoyad.Text + "'," +
                "'" + txtTel.Text + "','" + txtAdres.Text + "','" + bunifuDatepicker1.Value + "'," +
                "'" + txtTC.Text + "','" + (comboBox1.SelectedIndex + 1) + "'", con);
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
            if (hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Daha Sorna Tekrar Deneyiniz");
            }
            else
                MessageBox.Show("Hastanız Başarıyla Oluşturuldu");
        }
    }
}
