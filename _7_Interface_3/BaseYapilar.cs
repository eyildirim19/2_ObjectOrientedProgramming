using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    public interface IFile
    {
        void Read();
    }

    public abstract class BaseFile
    {
        public string Path { get; set; }
        public string Name { get; set; } 
    }
}
