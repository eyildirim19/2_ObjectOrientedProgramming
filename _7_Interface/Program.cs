namespace _7_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface (Arayüz)
            // Interface konusu inheritance ve abstraction konulanırı içerir...


            //Class => kullanıcı tanımlı tipler oluşturmak için kullanılır
            // Interface => kullanıcı tanımlı tipler oluşturmak için kullanılır..

            // Interfaceler classlara yetenek kazandırmak için kullanılır. Bu yetenekler;
            // 1) C# dilinde class sadece tek bir classtan miras alabilir...bu durumda multiple inheritance (çoklu miras) alınmak istendiğinde interface kullanılır. çünkü bir class birden fazla interface'den miras alabilir...
            // 2) Interfaceler classların üyelerini gruplamak için kullanılabilir...

            int a;

            //IDemo d = new IDemo(); // interfacelerden instance alınamaz..çünkü interfaceler abstraction yaklaşımı için oluşturulur..

        }
    }

    public class A
    {

    }
    public class B
    {

    }
    //public class C : A, B // C# dilinde bir class tek bir classtan türeyebilir...
    //{
    //}
}