using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class Diyet
    {
        public string name { get; set; }
        
        public Day Pazartesi { get; set; }
        public Day Sali { get; set; }
        public Day Carsamba { get; set; }
        public Day Persembe { get; set; }
        public Day Cuma { get; set; }
        public Day Cumartesi { get; set; }
        public Day Pazar { get; set; }

    }
    class Day
    {
        
        public string kahvalti { get; set; }
        public string Oglen { get; set; }
        public string Aksam { get; set; }
    }
}

