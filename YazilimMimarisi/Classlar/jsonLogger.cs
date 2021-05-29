using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class jsonLogger 
    {
        public void LogAt(Rapor rapor)
        {
            if (rapor.Sira == 1)
            {
                string strResultJson = "{\"Hasta\":";
                strResultJson += JsonConvert.SerializeObject(rapor.Hasta);
                strResultJson += ", ";
                strResultJson += "\"Diyet\":";
                strResultJson += JsonConvert.SerializeObject(rapor.Diyet);
                strResultJson += "}";
                File.WriteAllText(@"rapor.json", strResultJson);
            }
            else if (rapor.Sira == 2)
            {
                string strResultJson = "{\"Diyet\":";
                strResultJson += JsonConvert.SerializeObject(rapor.Diyet);
                strResultJson += ", ";
                strResultJson += "\"Hasta\":";
                strResultJson += JsonConvert.SerializeObject(rapor.Hasta);
                strResultJson += "}";
                File.WriteAllText(@"rapor.json", strResultJson);
            }
        }
    }
}
