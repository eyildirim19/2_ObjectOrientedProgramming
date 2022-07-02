namespace _2_Encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Bayram";
            ogr.SoyAdi = "Karakaya";
            ogr.SetYas(20);
            
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Ekrem";
            ogr1.SoyAdi = "Yıldırım";
            ogr1.SetYas(15);


            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "İsmail";
            ogr2.SoyAdi = "Aslan";
            ogr2.SetYas(14);

            Console.WriteLine($"Adı = {ogr.Adi} & SoyAdı = {ogr.SoyAdi} & Yaş = {ogr.GetYas()}");
            Console.WriteLine($"Adı = {ogr1.Adi} & SoyAdı = {ogr1.SoyAdi} & Yaş ={ogr1.GetYas()}");
            Console.WriteLine($"Adı = {ogr2.Adi} & SoyAdı = {ogr2.SoyAdi} & Yaş ={ogr2.GetYas()}");

            Console.ReadKey();
        }
    }
}