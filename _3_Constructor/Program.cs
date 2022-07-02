namespace _3_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // value Type => değer tipler. sadece değer tutabilen tipler bu zamana kadar gördüğümüz string hariç bütün tipler value type.
            // reference Type => referans tipler. değerden ziyade refarans tutan tiplerdir. atama yapıldığında referans tutarlar. ve classalar refarns type'lardır..Örneğin Ogrenci instance alındığında Adi ve SoyAdının referansını tutar..

            // instance => nesnlerin kullanımı için bellekte oluşturulmasıdır. bellekte nesne örneğidir...

            // new ifadesinden sonra sinifName() aslında ctotrun tetiklenmesidir..

            // instance new ifadesi ile alınır
            Ogrenci ogr = new Ogrenci("aaa"); 
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "bbb";
      
            int a = 3;
            int b = a; // a'nin değeri b'ye atanır

            Ogrenci ogr2 = ogr; // ogr'nin refaransı ogr2'ye atanır.
            ogr2.Adi = "ccc";

            Console.WriteLine(ogr.Adi);//?
        }
    }
}