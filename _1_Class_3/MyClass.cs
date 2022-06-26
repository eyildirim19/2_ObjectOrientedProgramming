using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class_3
{
    internal class MyClass
    {
        // Field => sınıfıın alanları.sınıf içerisinde veri tutmak için kullanılan yapılardır.. yani değişken olarak bildiğimiz şeyler aslında class seviyesinde tanımlaysa bu bir fielddır. class seviye class scope içerisidir

        // Metot => sınıf içerisinde işlem yapmak için kullandığımız yapılardır..

        // örnek metot
        public string Adi; // field


        // eğer bir alt scope içerisinde (metot veya propery) tanımlanna yapılar değişkendir. o metot ile oluşur metot işi bittiğine silinir..
        public void Goster()
        {
            string str = ""; // değişken

            Console.WriteLine(Adi);
        }

        // property => property sınıfın bir diğer üyesidir.. property field ve metot gibi kullanılan yapılardır..Genelde Fied yerine kullanılır..Uzun logicler metotlara yazılması tercih edilir..propert içerisindeki set ifadesi property'e değer atanacağını get ise properyden değer okunanacağını belirtir..
        public string Vize
        {
            set; get;
        } // vize için gizli bir field tutulur..

        // propertyler aslında fieldlara kontrollü erişim için kullanılır... örneğin veri kısıtlaması. yani 25'in alındaki notları kabul edilmediği senorya.

        private float final;// field
        public float Final
        {
            set
            {
                final = value; // value dışarıdan gelen parametreyi ifade eder..
            }
            get
            {
                return final; // tutulan değeri geri dön...
            }
        }


        // get ve set gizli metotlardır.bu metotlar bir fielda veri yazmak veya veri okumak için kullanılır. set yazmak, get okumak. set blığında yazılan veri value ile alınır...ve bir fielda atanır. bu veri okunmak istendipinde get'te return ile fieldan alınır ve dönülür..
    }
}
