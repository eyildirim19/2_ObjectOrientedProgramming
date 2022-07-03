namespace _4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Inheritance (Kalıtım) => bi sınıfın özelliklerinin başka bir sınıfa devredilme yaklaşımıdır..

            Egitmen egitmen = new Egitmen();
            egitmen.AdiSoyAdi = "Ekrem Yıldırım";
            egitmen.Yas = 34;
            egitmen.Cinsiyet = "E";
            egitmen.Maas = 500;


            Ogrenci ogr = new Ogrenci();
            ogr.AdiSoyAdi = "Büşra";
            ogr.Yas = 18;
            ogr.Cinsiyet = "K";
            ogr.OgrenciNo = "213133";





        }
    }
}