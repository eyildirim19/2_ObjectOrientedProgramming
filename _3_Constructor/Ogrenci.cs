using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor
{
    public class Ogrenci
    {
        // contructor kısaltılmışı ctor.
        // bir sınıftan intance alındığında o sınıfın constructor'ı tetiklenir...Constructorlar sınıfların yapıcı metotları olarak adlandırılır. yani yapıcı metotlar instance alınmasını sağlayan özel metotlardır.. BU metotlar önenmli oldukları için sınıf içerisinde default tanımlanmış sayılır. yani sınıfımızda şuanda bir yapıcı metot tanımlanlıdır..ctorlar  özel metotlardır. geriye dönüş tipi yoktur. ctor sınıf ismi ile aynı olan metoda denir. yani ctor yazılacaksa sınıfismi ile ctor ismi aynı olamlıdır ve dönüş tipi belirlenemez : Not => ctorlar public olmalıdır.ctorlar metot oldukları için parametre alabilirler

        // ctorlar genelde instance alındığında ilk değerleri set etmek için kullanılır..
        public Ogrenci(string isim)
        {
            Adi = isim;
        }
        public Ogrenci()
        {
        }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        //Destructor (yıkıcı metotlar) bellekten insntace silinirken çalışır. çok fazla kullanmayız ama bellekten nesnemiz silinirken silmek istediğimiz bağımlı varlıklı silmek için tercih edilebilir...
        ~Ogrenci()
        { 
        }
    }
}