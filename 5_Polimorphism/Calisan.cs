using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polimorphism
{
    public class Calisan : Insan
    {
        // override => base'den gelen üyeyi ezmek için kullanılır. Base instance üzerinden çalıştığında override komutu ile ezilen metot tetiklenir...

        // base'den gelen virtual üyelere override ifadesi ile erişilebilir...

        public override void Dusunce()
        {
            //base.Dusunce();
            Console.WriteLine("Ben gidersem şirket batar");
        }
    }
}