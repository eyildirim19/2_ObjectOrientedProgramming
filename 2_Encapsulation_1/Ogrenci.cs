using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_1
{

    // Encapsulation (Kapsülleme) => sınıfın üyesi(leri)ne kontrollü erişim yapma yaklaşımıdır. üye kapsüllenir ve yazma veya okuma başka bir üye tarafından yapılır. Encapsulation yapabilmek için getter(okuma) ve setter(yazma) metotlar kullanılır
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        // PROPERTY OLMASAYDI
        private int yas; 
        public void SetYas(int value)
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
        // yas private olduğu için class dışından gösterilemiyor (çünkü kriter dışında bir değer atanabilir). bu yüzden yas kontrollü bir şekilde dışarıya açılma(yazma ve okuma için)
        public int GetYas()
        {
            return yas;
        }
    }

    // Access modifers (erişim belirleyici) => class veya üyenin erişebilirlik seviyesidir. class memberlerın default erişim seviyeleri default privatedir.classların default erişim seviyeleri internaldır..
    // access modifiers;
    /*
    private => sınıf içerisinde erişilir..
    protected => sınıf ve miras alan sınıflar içerisinde erişilir. (kalıtım konusunda incelnir)
    internal =>proje içi
    public => genel (proje içi ve proje dışından)
     */
}
