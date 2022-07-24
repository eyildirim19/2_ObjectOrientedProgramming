using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_2
{
    // Ortak operasyonları KullaniciOperasyon sıfınında tanımlayarak Subsınıflarda bu komutları yazmıyoruz..
    public class KullaniciOperasyon
    {
        public void OturumAc()
        {
            Console.WriteLine($"Oturum Açıldı...Tarih{DateTime.Now}");
        }

        public void OturumKapat()
        {
            Console.WriteLine($"Oturum Kapatıldı");
        }
    }

    public interface IAdminOperasyon
    {
        public void YillikSatisRaporlari()
        {
            Console.WriteLine("Yıllık Satış Raporları Gösteriliyor.....");
        }

        public void KendiSatislariniGoster(); // Adminlerin kendisine bağlı üyelerini göstersin...
    }

    public class AdminIslemleri : KullaniciIslemleri, IAdminOperasyon
    {
        public void KendiSatislariniGoster()
        {
            Console.WriteLine("Admin 100 adet ürün sattın...");
        }
    }

    public class SuperAdminIslemleri : KullaniciIslemleri, IAdminOperasyon
    {
        public void KendiSatislariniGoster()
        {
            Console.WriteLine("Süper admin 50 adet ürün sattın");
        }
    }

    public class KullaniciIslemleri : KullaniciOperasyon
    {

    }

}
