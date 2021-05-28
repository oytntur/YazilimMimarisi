using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Hastalik:IONesneEkle
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");
        public string Ad { get; set; }
        public void nesneEkle()
        {
            cmd = new SqlCommand("exec hastalikEkle '" + this.Ad + "'", con);
            con.Open();
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
        }
        public Hastalik(string ad)
        {
            this.Ad = ad;
        }
        
    }
}
