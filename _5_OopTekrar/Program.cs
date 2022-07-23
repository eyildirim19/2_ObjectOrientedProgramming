namespace _5_OopTekrar
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //// Value Type (değer tipler)        => sadece veri tutulan tiplerdir.
            //// Reference Type (referans tipler) => sadece referans tutan tiplerdir..
            //string adi1 = "Masa";
            //decimal fiyat = 1500;
            //short stok = 99;

            //string adi2 = "Sandalye";
            //decimal fiyat2 = 1500;
            //short stok2 = 99;


            //string adi3 = "Televizyon";
            //decimal fiyat3 = 6000;
            //short stok3 = 1299;

            //// örneğin diziler referans typetır.
            //// Dizi birden fazla aynı tipteki değişkenlerin bir arada tutulamasını sağyalan yapılardır..
            //string[] urunler = new string[3];
            //urunler[0] = adi1;
            //urunler[1] = adi2;
            //urunler[2] = adi3;





            ////new => nesnelere instance(referans) oluşturmak için kullanılır
            //// Sınıfların bellekte kullanılabilir hallerine nesne denir. yani sinıf tipli değişkenlerimiz birer nesnedir..
            //Urun u = new Urun(); // yeni referans açtık
            //u.Adi = "Masa";
            //u.Fiyat = 1500;
            //u.Stock = 99;

            //Urun u1 = new Urun(); // yeni referans açtık
            //u1.Adi = "Sandalye";
            //u1.Fiyat = 150;
            //u1.Stock = 100;

            //Urun u2 = new Urun(); // yeni referans açtık

            //Urun u3 = u; // yeni referans açmadık. u'nın referansını u3'e atadık...

            //u3.Adi = "adadad";

            //// Encapsulation=> SINIF ÜYELERİNİ ERİŞİMİN KONTROLLÜ OLMASIDIR...

            string kmailAdiresi = "eyildirim@e.com";

            //MailGonder mg = new MailGonder();
            //mg.GonderimSaati = 22;
            ////mg.From = "aaa@a.com";// Kapsüllediğimiz için artık bu alanlara class dışında erişemeyiz
            ////mg.BitisSaati = 24;  // Kapsüllediğimiz için artık bu alanlara class dışında erişemeyiz
            ////Console.WriteLine(mg.From); // Kapsüllediğimiz için artık bu alanlara class dışında erişemeyiz
            //if (kmailAdiresi.Contains("@"))
            //{
            //    mg.To = kmailAdiresi;
            //}
            //else
            //{
            //    // hata fırlat...
            //    throw new Exception("Mail adresi geçersiz");
            //}


            //string kmailadresi1 = "ekrem.yildirim@windowslive.com";
            //MailGonder mg1 = new MailGonder();
            //mg1.GonderimSaati = 13;

            //if (kmailadresi1.Contains("@"))
            //{
            //    if (kmailadresi1.Contains("."))
            //    {
            //        mg1.To = kmailadresi1;
            //    }

            //}
            //else
            //{
            //    // hata fırlat...
            //    throw new Exception("Mail adresi geçersiz");
            //}
            //mg1.Message = "Siparişiniz Yola Çıktı";
            //mg1.Gonder();

            //MailGonder mg2 = new MailGonder();
            //mg2.GonderimSaati = Convert.ToByte(Console.ReadLine());
            //if (Console.ReadLine().Contains("@"))
            //{
            //    mg2.To = Console.ReadLine();
            //}
            //else
            //{
            //    //hata fırlat
            //    throw new Exception("Mail adresi geçersiz");
            //}


            //mg2.Message = "Siparişiniz Onaylandı";
            //mg2.Gonder();

            // yukarıdaki örnekte encapsulation kkullanmadığımız için mail kontrolünü sürekli tekrar ettik. MailGonderEncapsulation örneğinde ise encapsulation kullanıdğımız iiçn bu kontrolü tekrar etmek yerine tek bir noktadan yaptık....

            MailGonderEncapsulation mge = new MailGonderEncapsulation();
            mge.To = kmailAdiresi;
            mge.Message = "Siparişiniz Onaylandı";
            mge.Gonder();


            MailGonderEncapsulation mge1 = new MailGonderEncapsulation();
            mge1.To = kmailAdiresi;
            mge1.Message = "Siparişiniz Yola Çıktı";
            mge1.Gonder();


            KrediKarti k1 = new KrediKarti();
            // kart bilgilerini doldurdukk.....
            k1.Tutar = 5000;
            k1.TaksitSayisi = 5;

            DebitKart db = new DebitKart();
            db.Tutar = 1000;

            KrediKarti k2 = new KrediKarti();
            k2.Tutar = 500;
            k2.TaksitSayisi = 0;

            BankaEntegrasyon(k1);
            BankaEntegrasyon(k2);
            BankaEntegrasyon(db);


            Console.ReadKey();
        }

        static void BankaEntegrasyon(OdemeSistemleri odeme)
        {
            // bu metot eğer belirtildiyse subsınıftaki gibi çalışmalıdır. bunun için metodun subsınıfta override ile işartelnmesi gerekir. 
            odeme.OdemeYap(); // ödeme burada yapılıyor....
        }


        // OdemeYap metodu base sınıfta tanımlı olduğu için subsınıflarda üzerindne çağrıldığında basesınıftaki gibi çalışır. OdemeYap metodu eğer subsınıfınların referansı ile çağrılırsa BankaEntegrasyon metodunda olduğu gibi yine basesınıfta olduğu gibi çalışır..Eğer OdemeYap metodu Subsınıflara tanımlanırsa;
        // subsınıf instancei üzerinden çağrıldığında subsınıftaki gibi
        // basesınıf üzerinden çağrılüında base sınıftaki gibi çalışır. 
        // problem tamda burada orataya çıkar. Metod nereden çağırrılısa çağrılsın subsınıftaki gibi çalışmalıdır. Buna poliymorphism(Çok biçimlilik) yaklaşımı denmektetir.

        // Poliymorphism => base sınıflardan gelen üyelerin duruma göre subsınıf üyesi gibi davranmasıdır..

    }
}