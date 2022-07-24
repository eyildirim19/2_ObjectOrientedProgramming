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

            // Interfaceler classlara yetenek kazandırmak için kullanılır;
            // C# dilinde class sadece tek bir classtan miras alabilir...bu durumda multiple inheritance (çoklu miras) alınmak istendiğinde interface kullanılır. çünkü bir class birden fazla interface'den miras alabilir...
            // 
        }
    }

    public interface A
    {

    }
    public interface B
    {

    }
    public class C : A, B
    {
    }
}