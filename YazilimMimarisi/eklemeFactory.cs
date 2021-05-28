using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class eklemeFactory
    {
        public Diyet Diet { get; set; }
        public Hastalik Hastalik { get; set; }
        public IONesneEkle nesneEkle(string nesneAdi)
        {
            if (nesneAdi == "Diyet")
            {
                return Diet;
            }
            else if (nesneAdi == "Hastalik")
            {
                return Hastalik;
            }
            else
                return null;
        }

    }
}
