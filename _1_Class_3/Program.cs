namespace _1_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solid prensiblerinden Single Responsibility araştınız... 
            // Single Responsibility Prensibi.
            // Encapsulation konusunu işleyeceğiz..

            // Property Kavramı 
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Ziya";
            ogr.SoyAdi = "Erdoğdu";
            ogr.Vize = 100;

            ogr.Final = 150;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "İsmail";
            ogr2.SoyAdi = "Aslan";
            ogr2.Vize = 100;

            ogr2.Final = 100;

            Console.WriteLine(ogr2.final); // fielddan erişiyoruz...
            Console.WriteLine(ogr2.Final);// property üzerinden fielda erişiyoruz...
            Console.WriteLine(ogr.Final);

            Console.ReadKey();
        }
    }
}