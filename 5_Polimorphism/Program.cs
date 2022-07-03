namespace _5_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çok biçimlilik => base üyelerinin alt sıfınlarda davranışlarının değiştirilme yaklaşımıdır..


            // Miras alan sınıf, miras veren sınıf gibi davranır..baze durumlar miras alan sınıfın üyeleri base'den gelen üyeye göre farklılık gösterebilir. (farklı davranması gerekebilir). bu farklılıklar çokbiçimlilik olarak adlandırılır..

            Calisan c = new Calisan();
            c.KimlikNo = "1234";
            c.Dusunce();


            Patron p = new Patron();
            p.KimlikNo = "4321";
            p.Dusunce();

            Insan i = new Insan();
            i.Dusunce();


            // Insan nesnesi üzerinden c ve p'nin düşüncesini yazdırıyoruz...

            Goster(c);
            Goster(p);


            Console.ReadKey();
        }

        public static void Goster(Insan ins)
        {
            Console.WriteLine($"Kimlik No {ins.KimlikNo}");
            ins.Dusunce();
        }

        //public static void Goster(Calisan ins)
        //{
        //    Console.WriteLine($"Kimlik No {ins.KimlikNo}");
        //    ins.Dusunce();
        //}

        //public static void Goster(Patron ins)
        //{
        //    Console.WriteLine($"Kimlik No {ins.KimlikNo}");
        //    ins.Dusunce();
        //}

    }
}