using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance3
{
    // Örnek gereği classlarımızı tek bir dosyada oluştuyoruz. Ancak normalde bir class bir cs dosyasısında olmalıdır..
    public class Insan
    {
        public string AdSoyAd { get; set; }
        public string Cinsiyet { get; set; }
        public string Email
        {
            get
            {
                return $"{AdSoyAd.ToLower()}@btakademi.com";
            }
        }
    }
    public class Ogrenci : Insan
    {
        public string OgrenciNo { get; set; }
    }

    public class Egitmen : Insan
    {
        public string EgitmenNo { get; set; }
    }


    public class Sinif
    {
        public Sinif(byte kisiSayisi)
        {
            Kapasite = kisiSayisi;
        }
        public byte Kapasite { get; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        private Insan[] insans = new Insan[0];

        public void Ekle(Insan insan)
        {
            Array.Resize(ref insans, insans.Length + 1);
            insans[insans.Length - 1] = insan;
        }
        public void Goster()
        {
            foreach (Insan item in insans)
            {
                if (item is Ogrenci)
                {
                    Ogrenci o = (Ogrenci)item;
                    Console.Write($"Öğrenci = {o.OgrenciNo} \t");
                }
                else if (item is Egitmen)
                {
                    Egitmen e = (Egitmen)item;
                    Console.Write($"Egitmen = {e.EgitmenNo} \t");
                }
                // \t => tab
                // \n => alt satıra geç
                // Environment.NewLine =>alt satıra geç...
                Console.Write($"{item.AdSoyAd} \t {item.Email} \n");
                //Console.WriteLine("**********");
            }
        }
    }
}
