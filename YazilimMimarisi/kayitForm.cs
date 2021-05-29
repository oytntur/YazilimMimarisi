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
    public partial class kayitForm : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");

        public kayitForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hata = false;
            cmd = new SqlCommand("exec doktorOlustur '" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "'", con);
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
                MessageBox.Show("Kaydınız Başarıyla Alındı \nLütfen Yoneticinin Üyeliğinizi Onaylamasını Bekleyiniz");
        }

       
    }
}
