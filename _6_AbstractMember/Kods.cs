using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbstractMember
{

    public abstract class Insan
    {
        // abstract üye => sadece Abstract classlarda tanımlabilen üyelerdir (field hariç). Polimorphsim yaklaşımını uygulamak için üyenin üyenin abstract olarak işaretlenmesidir.
        // abstract üye gövdesi base tarafından değil subclass tarafından tanımlanan üyelerdir..

        // abstract üyeler subclasslarda overrride edilmek zorundadır...eğer override edilemse uygulanma hata verecektir..
        public abstract void Dusunce();
    }
    public class Patron : Insan
    {   
        public override void Dusunce()
        {
            //throw new NotImplementedException(); // eğer bu şekilde unutursak hata fırlatması için kullanılan template komuttur...
            Console.WriteLine("Personel Çalışmıyor");
        }
    }
    public class Personel : Insan
    {
        public override void Dusunce()
        {
            Console.WriteLine("Patron para vermiyor");
        }
    }
}