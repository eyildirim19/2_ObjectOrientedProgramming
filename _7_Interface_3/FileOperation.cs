using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    // FİleOperation sınıfı istenilen geliştirmelerde etkinlnemesi gereken bir sınıftır.
    public class FileOperation
    {

        //public void Read(ExcelFile file)
        //{
        //    file.Read();
        //}
        //public void ReadText(TextFile file)
        //{
        //    file.Read();
        //}
        //public void ReadWord(WordFile file)
        //{
        //    file.Read();
        //}
        // Dosyatipleri parametresi ile çalışan metotları kapattık. çünkü her bir dosyatipinde bu sınıfta geliştirme yapmamız gerekiyor. bu sınıfa öyle bir metot yazalım dosya tipi ne olursa olsun o dosyayı okuyabilsin....

        public void Read(IFile file)
        {
            file.Read();
        }
    }
}
