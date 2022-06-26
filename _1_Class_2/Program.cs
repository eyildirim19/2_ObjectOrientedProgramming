namespace _1_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici k = new Kullanici();
            k.KullaniciAdi = "eyildirim";
            k.Sifre = "123456";

            Kullanici k1 = new Kullanici();
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            k1.KullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz");
            k1.Sifre = Console.ReadLine();

            Kullanici[] users = new Kullanici[2]; // 2 elemanlı Kullanici tipinde users dizisi...
            users[0] = k;
            users[1] = k1;

            Console.WriteLine("************");
            foreach(Kullanici item in users)
            {
                Console.WriteLine(item.KullaniciAdi );
                item.SifreDurumu(); // şifre durumunu ekrana yazdır...
            }
        }
    }
}