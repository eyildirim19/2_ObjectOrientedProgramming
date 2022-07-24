using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    public class XmlFile : BaseFile, IFile
    {
        public void Read()
        {
            Console.WriteLine($"{Path} pathindeki xml verisi key-value şeklinde okundu...");
        }
    }
}
