using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class_3
{
    public class Ogrenci
    {
        public string Adi { get; set; }

        //soyadi'ni fieldda tutalım..
        public string SoyAdi;

        public float Vize { get; set; }

        // vize ve adi aynı mantıkta çalışır...set ve get'ini açıp kapatmaya gerek yoktur....
        public float final;
        public float Final
        {
            get
            {
                return final;
            }
            set
            {
                if (value <= 100)
                {
                    final = value;
                }
            }
        }
    }
}