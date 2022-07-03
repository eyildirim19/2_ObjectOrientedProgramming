using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polimorphism
{
    public class Patron : Insan
    {
        public override void Dusunce()
        {
            Console.WriteLine("İşçiler çalışmıyor...");
        }
    }
}