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
    public partial class HastalarScreen : Form
    {
        int id = 0;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");

        public HastalarScreen()
        {
            InitializeComponent();
            cmd = new SqlCommand("select * from hastaView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ID"].ToString();
                add.SubItems.Add(dr["Ad"].ToString()+" "+dr["Soyad"].ToString());
                add.SubItems.Add(dr["TC"].ToString());
                add.SubItems.Add(dr["Hastalik"].ToString());
                add.SubItems.Add(dr["Bday"].ToString());
                add.SubItems.Add(dr["Tel"].ToString());
                add.SubItems.Add(dr["Adres"].ToString());
                add.SubItems.Add(dr["Diyet"].ToString());
                listView1.Items.Add(add);

            }
            con.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Hasta hasta = new Hasta();
            hasta.ID = id;
            hasta.AdSoyad = listView1.SelectedItems[0].SubItems[1].Text;
            hasta.TC= listView1.SelectedItems[0].SubItems[2].Text;
            hasta.HastalikAd= listView1.SelectedItems[0].SubItems[3].Text;
            hasta.BirthDay= listView1.SelectedItems[0].SubItems[4].Text;
            hasta.Tel = listView1.SelectedItems[0].SubItems[5].Text;
            hasta.Adres = listView1.SelectedItems[0].SubItems[6].Text;
            hasta.DiyetAD = listView1.SelectedItems[0].SubItems[7].Text;
            diyetForm diyet = new diyetForm(hasta);
            diyet.Show();
        }
    }
}
