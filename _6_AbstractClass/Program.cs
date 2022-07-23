namespace _6_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazilimci yz = new Yazilimci();
            yz.Adi = "Ekrem";

            Yazilimci yz1 = new Yazilimci();
            yz1.Adi = "İsmail";

            Muhasebeci mh = new Muhasebeci();
            mh.Adi = "Büşra";

            Personel p1 = mh; // p1 mh'nin referansını tutuyor...

            // Personel sınıfımız Abstract olduğu için bu sınıftan instance alınamaz...

            //Personel p = new Personel();
        

            OdemeYap(mh);

            Console.ReadKey();

        }
        static void OdemeYap(Personel p)
        {
        }
    }
}