using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OopTekrar
{
    //Not : bir cs dosyasında tek bir class olmalıdır. bu örnekte tekrar yaptığımız iiçn bir cs dosyasına birden fazla class ekledik...
    public class MailGonderEncapsulation
    {

        private string From = "info@btakdemi.com";
        // property => sınıf üyelerini işaret eden sınıf üyeleridir..property yardımıyla alanlara veri yazılabilir (set) ve veri okunabilir(get)
        private string to;
        public string To
        {
            get
            {
                return to;
            }
            set
            {
                if (value.Contains("@"))
                {
                    to = value;
                }
                else
                {
                    throw new Exception("Invalid Email Adress");
                }
            }
        }
        public byte GonderimSaati { get; set; } // eğer propertyde açık birşeykilde field belirtilmezse property gizli bir field kullanılır. 
        private byte BaslangicSaati = 08;
        private byte BitisSaati = 19;
        public string Message;
        public void Gonder()
        {
            if (GonderimSaati > BaslangicSaati && GonderimSaati < BitisSaati)
            {
                // mail gönderme işlemleri yapıyoruz...
                // To'ya Message From'dan gönderildi....
                Console.WriteLine($"{Message}");
            }
        }
    }

    public class MailGonder
    {

        private string From = "info@btakdemi.com";
        // property => sınıf üyelerini işaret eden sınıf üyeleridir..property yardımıyla alanlara veri yazılabilir (set) ve veri okunabilir(get)
        public string To;
        public byte GonderimSaati;
        private byte BaslangicSaati = 08;
        private byte BitisSaati = 19;
        public string Message;
        public void Gonder()
        {
            if (GonderimSaati > BaslangicSaati && GonderimSaati < BitisSaati)
            {
                // mail gönderme işlemleri yapıyoruz...
                // To'ya Message From'dan gönderildi....
                Console.WriteLine($"{Message}");
            }
        }
    }

    // Anasayfa,UrunEKle,Sepet,Siparis
    public class Urun
    {
        public string Adi;
        public decimal Fiyat;
        public short Stock;
    }

    public class Nakliyeci
    {
        public string FirmaAdi;
        public string Adresi;
        public string TelNo;
    }

    // Inheritance => OOP yaklaşımıdır. Sınıfların üyelerini başka bir sınıfa devretmesidir. Amaç yine kod tekrarının önüne geçmektir. Miras sınıf base class olarak adlandırılır. Miras alan sınıf Derived Class veya SubClass veya ChildClass olarak adlandırılır...

    // Base sınfılar miras verdikleri için miras alan sınıfın atasıdır. Bu yüzden base sınıf miras alan sınıfın referansını tutabilir....


    public class OdemeSistemleri
    {
        public string KartNo { get; set; }
        public string AdiSoyAdi { get; set; }
        public string GuvenlkNo { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public decimal Tutar { get; set; }
        public virtual void OdemeYap()
        {
            // Banka ile irtibata geç...Kartbilgilerinin verilerini bankanın adresine gönder. Yani banka entegrasyonun yapıldığı yer burasıdır....
            Console.WriteLine("Banka ile bağlantı kuruldu");
            Console.WriteLine("Ödeme yapıldı");
        }
    }
    // KrediKartı sınıfı OdemeSistemleri sınıfından türeyerek onun üyelerini devralır..
    public class KrediKarti : OdemeSistemleri
    {
        public byte TaksitSayisi { get; set; }
        // Not : üyenin override edilebilmesi için base'de virtual olarak tanımlanması gerekir.
        public override void OdemeYap()
        {
            if (TaksitSayisi > 0)
            {
                Console.WriteLine($"Banka ile bağlantı kuruldu");
                Console.WriteLine($"{TaksitSayisi} taksit ile ödendi");
            }
            else
            {
                base.OdemeYap(); // base üzerinden tetikle...
            }
            
        }
    }
    // DebitKart sınıfı OdemeSistemleri sınıfından türeyerek onun üyelerini devralır..
    public class DebitKart : OdemeSistemleri
    {
    }
    public class YemekKarti : OdemeSistemleri
    {

    }
}
