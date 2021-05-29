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
    public partial class adminEkran : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=DB_Diyet;Integrated Security=True");
        int id = 0;
        public adminEkran()
        {
            InitializeComponent();
            getDoctor();
        }
        private void getDoctor()
        {
            transListView.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM unVerifiedDoctorView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ID"].ToString();
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                transListView.Items.Add(add);

            }
            dr.Close();
            con.Close();
        }

        private void adminEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void transListView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(transListView.SelectedItems[0].SubItems[0].Text);
            con.Open();
            cmd = new SqlCommand("EXEC docConfirm '" + id + "'", con);
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    getDoctor();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
