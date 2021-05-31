using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public class Hastalik:IONesneEkle
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");
        public string Ad { get; set; }
        public void nesneEkle()
        {

            bool hata = false;
            cmd = new SqlCommand("exec hastalikEkle '" + this.Ad + "'", con);
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
                MessageBox.Show("Bir Hata Meydana Geldi");
            }
            else
                MessageBox.Show("İşlem Başarıyla Gerçekleşti Programın Güncellenmesi İçin \n" +
                    "Programı Aç Kapa Yapabilrisiniz");
        }
        public Hastalik(string ad)
        {
            this.Ad = ad;
        }
        
    }
}
