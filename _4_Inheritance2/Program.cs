namespace _4_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.AdSoyad = "Büşra";
            ogr.Yas = 18;
            ogr.OgrenciNo = "123";

            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdSoyad = "Onur";
            ogr1.Yas = 34;
            ogr1.OgrenciNo = "456";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.AdSoyad = "Celalettin";
            ogr2.Yas = 34;
            ogr2.OgrenciNo = "789";

            Egitmen egitmen = new Egitmen();
            egitmen.AdSoyad = "Ekrem";
            egitmen.Yas = 34;

            Insan i = egitmen; // egitmen nesnesi Insan'dan türediği iiçn insan nesnesi egitmen nesnesinin REFERANSINI tutabilir
            Insan i1 = ogr; // ogr nesnesi Insan'dan türediği için insan nesnesi ogr nesnesinin REFERANSINI tutabilir...

            Console.WriteLine(i.AdSoyad);
            Console.WriteLine(i1.AdSoyad);

            BilgileriniYaz(ogr);
            BilgileriniYaz(ogr1);
            BilgileriniYaz(ogr2);
            BilgileriniYaz(egitmen);

            Console.ReadKey();
        }

        static void BilgileriniYaz(Insan insan)
        {
            int a = 1;
            byte b = (byte)a;

            Console.Write($"{insan.AdSoyad} - {insan.Yas}-");

            if (insan is Ogrenci) // is operatörü tip karşılaştırması yapar. instance tipi Ogrenci ise castin yap
            {
                Ogrenci o = (Ogrenci)insan;
                Console.Write(o.OgrenciNo);
            }
            else if (insan is Egitmen)
            {
                Egitmen e = (Egitmen)insan;
                Console.Write(e.Maas);
            }
            Console.WriteLine("*************");
        }
    }
}