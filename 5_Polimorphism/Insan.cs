using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polimorphism
{
    public class Insan
    {
        public string KimlikNo { get; set; }

        public virtual void Dusunce()
        {
            Console.WriteLine("İnsan düşünür");
        }



        // virtual => virtual üyeler alt sınıflar tarafından ezilebilen ve base üzerinden çalıştırıldığında alt sınıf üyeleri gibi çalışabilen üyelerdir...
    }
}