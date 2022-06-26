using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class_1
{
    // classlardan birden fazla verinin referansını tutan yapılardır. yani class tipler referans type'tır..

    //Class'lar soyut varlıklardır..
    //Nesneler somut varlıklardır..
    // Nesne class tipinde kullanılan değilkenlerdir...
    public class Ogrenci
    {
        public string Adi;
        public float Vize;
        public float Final;

        public float Ortalama()
        {
            
            return (Vize * 0.4f) + (Final * 0.6f);
        }
    }
}
