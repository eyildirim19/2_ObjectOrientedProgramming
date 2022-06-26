using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class
{
    // Class => farklı tipteki verileri bir arada tutmak için oluşturulan yapılardır...
    // ayrıca classlar değişkenleri ve metotları bir arada tutan yapılardır.
    // program içerisinde kendimeze ait tipler oluşturduğumuz yapılardır...
    // değişken => veri tutmak için kullanılır
    // metot    => bir işlevi yerine getirmek için kullanılır. 

    internal class MyClass // sınıfların erişim belirteci internal veya public olabilir. bir sınıf proje içi genel veya proje dışı genel erilebilmelidir.. 
    {
        // classların üyeleri vardır. bunlara class members denir..
        // class members;
        // field => değişken dediğimiz yapılar
        // method => metotlar
        // properties => properties konusunda konuşacağız...field ve metot gibi kullanılabilen üyelerdir...

        // class içerisinde oluşturulan üyelere erişim seviyeleri vardır. bir üye nerede kullanılacaksa erişim seviyesi ile belirtilmelidir..
        // erişim seviyesi => sınıfların veya üyelerinin nerelerden erilebilecğeni belirtir..
        // private                => özel. sınıf üyelerinin default erişim belirtecidir.Sade sınıf üyeleri private olabilir..
        // protected              => özel . inheritance konusunda detaylı konuşuruz. miras alan sınıflardan erilebilir..
        // internal               => kısmi genel. proje içi genel erişim belirtecidir. üyeler veya sınıfların proje içerisinde genel kullanımıdır. sınıfların default erişim belirteci internaldır..
        // protected internal     => protected ve internal
        // public                 => genel. proje içerisinden ve dışından erilebilmesini sağlayan belirteçtir.

        // <erisimBelirteci> veriTipi uyeAdi

        private string FieldA;
        int FieldB;
        private void Metot()
        {
        }
        void Metot(string p)
        {
        }
    }
}
