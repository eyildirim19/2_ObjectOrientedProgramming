using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    // text dosları için 
    public class TextFile : BaseFile, IFile
    {
        public void Read()
        {
            Console.WriteLine($"{Path} pathindeki veriler satır satır okundu...");
        }
    }
}