namespace _6_AbstractMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel pers = new Personel();
            Patron pat = new Patron();


            DusunceGoster(pers);
            DusunceGoster(pat);

            Console.ReadKey();
            // Abstract üye vs Virual üye
            // Abstract üyeler gövdesi base'de tanımlanmaz...
            // Virtual üyeler gövdesi base'de tanımlanmalıdır...

            // Abstract üyeler subclass tarafından ezilerek implement (tamamlanmak) edilmek zorundadır..
            // virtual üyeler subclass tarafından ezilmek zorunda değildir
    
        }
        static void DusunceGoster(Insan ins)
        {
            ins.Dusunce();
        }
    }
}