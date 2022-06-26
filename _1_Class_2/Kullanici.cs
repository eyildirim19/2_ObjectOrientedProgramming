using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class_2
{
    public class Kullanici
    {
        public string KullaniciAdi;
        public string Sifre;

        public void SifreDurumu()
        {
            if (Sifre.Length > 5)
            {
                Console.Write("Şifre Güçlü");
            }
            else
            {
                Console.Write("Şifre Zayıf!!!.");
            }
        }
    }
}
