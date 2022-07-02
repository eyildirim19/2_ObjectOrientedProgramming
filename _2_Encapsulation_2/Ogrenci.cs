using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_2
{
    // propertyler genişletilebilen üyelerdir. property eğer belirtmezsek bizim için fieldı temsil eder. yani set ve get metotları gizli bir fielde değer yazmak ve okumak için kullanılır. propertyler içerisindeki get ve set ifadeleri aslında getter(okumak) ve setter(yazmak) metotları ifade eder.bu get ve set komutları {} ile kullanılıldığında belirtilen gizli field kaybolur. propertyler kapsülleme yapmak için hazır varlıklardır.. bu mantıkta geliştirilmiştir..

    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        private int yas; // field
        public int Yas
        {
            set // bir parametre alan void metot gibi çalışır..bu parametre value ismi ile gelir
            {
                if (value > 18)
                {
                    yas = value;
                }
                else
                {
                    yas = 18;
                }
            }
            get
            {
                return yas;
            }
        }
    }
}
