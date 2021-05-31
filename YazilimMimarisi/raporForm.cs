using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class raporForm : Form
    {
        
        Rapor rapor= new Rapor();
        public raporForm(Hasta hasta,Diyet diyet)
        {
            InitializeComponent();
            rapor.Hasta = hasta;
            rapor.Diyet = diyet;

        }
        RaporAdapter loggerAdapter = new RaporAdapter();
        jsonLogger jsonLogger = new jsonLogger();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen İlk Görüntülenecek Bilgiyi Şeçiniz");
            }
            else
            {
                rapor.Sira = comboBox1.SelectedIndex + 1;
                loggerAdapter.LogAt(rapor);
                jsonLogger.LogAt(rapor);
            }
            MessageBox.Show("Rapor Başarıyla Oluşturuldu", "Rapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
