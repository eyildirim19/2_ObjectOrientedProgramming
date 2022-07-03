namespace _4_Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.AdSoyAd = "Büşra";
            ogr.Cinsiyet = "K";
            ogr.OgrenciNo = "123";


            Ogrenci ogr2 = new Ogrenci();
            ogr2.AdSoyAd = "Onur";
            ogr2.Cinsiyet = "E";
            ogr2.OgrenciNo = "345";

            Egitmen egt = new Egitmen();
            egt.AdSoyAd = "Ekrem";
            egt.EgitmenNo = "9876";


            Sinif grup = new Sinif(3);
            grup.BaslangicTarihi = DateTime.Now;
            grup.BitisTarihi = DateTime.Now.AddDays(30); // AddMetotları ile tarihe ileri yönlü ekleme yapılır
            grup.Ekle(ogr);
            grup.Ekle(ogr2);
            grup.Ekle(egt);


            grup.Goster();

            Console.ReadKey();
        }
    }
}