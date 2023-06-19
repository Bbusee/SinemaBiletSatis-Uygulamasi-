using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class Entity
    {
        public class Musteri
        {
            public string Musteri_ID { get; set; }

            public string Musteri_Adi { get; set; }

            public string Musteri_Soyadi { get; set; }

            public string Musteri_Telefon { get; set; }

            public string Musteri_Email { get; set; }

            public List<Bilet> Biletler = new List<Bilet>();
        }

        public class Bilet
        {
            public string Bilet_ID { get; set; }

            public string Bilet_MID { get; set; }

            public string Bilet_Filmadi { get; set; }

            public string Bilet_Seans { get; set; }

            public string Bilet_Fiyat { get; set; }

        }
    }
}
