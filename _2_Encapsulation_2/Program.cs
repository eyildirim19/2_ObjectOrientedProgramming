namespace _2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Bayram";
            ogr.SoyAdi = "Karakaya";
            ogr.Yas = 20;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "Ekrem";
            ogr2.SoyAdi = "Yıldırım";
            ogr2.Yas = 18;

            Ogrenci ogr3 = new Ogrenci();
            ogr3.Adi = "İsmail";
            ogr3.SoyAdi = "Aslan";
            ogr3.Yas = 14; // propertynin set bloğu çalışır.

            Console.WriteLine($"{ogr.Adi} - {ogr.SoyAdi} - {ogr.Yas}");
            Console.WriteLine($"{ogr2.Adi} - {ogr2.SoyAdi} - {ogr2.Yas}");
            Console.WriteLine($"{ogr3.Adi} - {ogr3.SoyAdi} - {ogr3.Yas}");

            Console.ReadKey();
        }
    }
}