namespace _7_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KullaniciIslemleri k = new KullaniciIslemleri();
            k.OturumAc();
            // işlemlerini yaptı.....
            k.OturumKapat();

            AdminIslemleri a = new AdminIslemleri();
            SuperAdminIslemleri s = new SuperAdminIslemleri();

            a.OturumAc();
            //a.KendiSatislariniGoster(); // interface'den gelen üye
            s.OturumAc();
            //s.KendiSatislariniGoster(); // interface'den gelen üye..

            // IAdminOperasyon tipinde değişken tanımlıyoruz..
            IAdminOperasyon adminlereOzelOperasyon;

            // adminin referansını tuyoruz...
            adminlereOzelOperasyon = a; // admin gibi davranır
            adminlereOzelOperasyon.KendiSatislariniGoster();
            adminlereOzelOperasyon.YillikSatisRaporlari();

            // süper adminin referansını tutuyyoruz..
            adminlereOzelOperasyon = s;
            adminlereOzelOperasyon.KendiSatislariniGoster();
            adminlereOzelOperasyon.YillikSatisRaporlari();


            a.OturumKapat(); //
            s.OturumKapat();


            Console.ReadKey();
        }
    }
}