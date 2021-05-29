using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YazilimMimarisi
{
    public class Diyet : IONesneEkle
    {
       
        public int ID { get; set; }
        public string name { get; set; }
        
        public Day Pazartesi { get; set; }
        public Day Sali { get; set; }
        public Day Carsamba { get; set; }
        public Day Persembe { get; set; }
        public Day Cuma { get; set; }
        public Day Cumartesi { get; set; }
        public Day Pazar { get; set; }

        public void nesneEkle()
        {
            this.diyetEkle();
        }
        private void diyetEkle()
        {
            List<Diyet> LoadJson()
            {
                using (StreamReader r = new StreamReader(@"test.json"))
                {
                    string json = r.ReadToEnd();
                    List<Diyet> items = JsonConvert.DeserializeObject<List<Diyet>>(json);
                    return items;
                }
            }
            List<Diyet> liste = LoadJson();
            liste.Add(this);
            string strResultJson = JsonConvert.SerializeObject(liste);
            File.WriteAllText(@"test.json", strResultJson);
            MessageBox.Show(this.name + " Diyeti Başarıyla Eklendi");
        }
    }
    
    public class Day
    {
        
        public string kahvalti { get; set; }
        public string Oglen { get; set; }
        public string Aksam { get; set; }
    }
}

