namespace _2_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personel p = new Personel();
            p.Name = "Kübra";
            p.SurName = "Karakuş";
            p.CompanyName = "btakademi";
            // p.Email = "ksdlakdalş"; //set bloğu olmadığı için değer set edilemez..

            Console.WriteLine($"{p.Name} - {p.SurName} - {p.Email}");


            Personel p1 = new Personel();
            Console.WriteLine("Personel Adı Giriniz");
            p1.Name = Console.ReadLine();

            Console.WriteLine("Personel SoyAdı Giriniz");
            p1.SurName = Console.ReadLine();
            p1.CompanyName = "btakademi";


            Console.WriteLine($"Personelin Email Adresi = {p1.Email}");


            Console.ReadKey();

        }
    }
}