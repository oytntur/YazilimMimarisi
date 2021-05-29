using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimMimarisi
{

    public partial class GirisEkran : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");

        public GirisEkran()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * from tblUser where userLogin='" + txtBoxUsername.text + "'AND userPassword='" + txtBoxPass.text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                if (Convert.ToInt32(dr["yetkiID"]) == 2 && Convert.ToBoolean(dr["isVerified"]) == true)
                {
                    MessageBox.Show(dr["userAd"].ToString() + " " + dr["userSoyad"].ToString()
                    + "\nHoşgeldiniz", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    doctorScreen doctorScreen = new doctorScreen();
                    doctorScreen.Show();
                    this.Hide();
                }
                else if (Convert.ToInt32(dr["yetkiID"]) == 1)
                {
                    adminEkran adminEkran = new adminEkran();
                    adminEkran.Show();
                    this.Hide();
                }
                else if (Convert.ToBoolean(dr["isVerified"]) == false)
                {
                    MessageBox.Show("Sayın " + dr["userAd"].ToString() + " " + dr["userSoyad"].ToString()
                    + "\nHoşgeldiniz"+ "\nGiriş Başarısız Lütfen Yöneticinin" +
                    " Onayını Bekleyiniz","Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Kullanici Adı Veya Şifre Yanlış", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            kayitForm kayit = new kayitForm();
            kayit.ShowDialog();
        }
    }
}
