using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    // Excel dosyaları için
    public class ExcelFile : BaseFile, IFile
    {


        public void Read()
        {
            Console.WriteLine($"{Path} pathindeki excel dosyası hücre bazlı okundu...");
        }
    }
}