using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface
{
    // Kural 1. interface isimlerinin önüne I yazılır. bu o dosyanın bir interface dosyası olduğunu gösterir. bu yazılı olmayan ama bütün developerlar tarafından kabul gören bir kuraldır...


    // interface üyelerinin gövdeleri olamaz.Ancak c# 8.0 ile birlikte bu kural değiştirilmiştir. yani interface içerisinde gövdeli üye tanımlanabilir buna default member denilir. 
    // interfacelerde gövdesiz üyeler tanımlanabilir. eğer gövde açmazsanız bu üyeler alt sınıflar tarafından implement edilmek zorundadır...



    public interface IDemo
    {
        //// interface'nin gövdeli metodu. default member alt sınıflar tarafından implement edilmek zorunda değildir...
        public void Deneme()
        {
            Console.WriteLine("deneme");
        }
        public string Yeni()
        {
            return "bu metot inerfaceten türeyen sınıfların ortak metodudur. implement edilmesine gerek yoktur";
        }

        public void Message();
        // interface üyeleri eğer gövdesiz ise private tanımlanamaz...çünkü private olursa üye interface özel olacak bu durumda diğer sınıflar tarafından implemen edilemeyeceği için o üye gereksiz
        //private void Test();tanımlanmış olacak..
        void Test(); // interfacelerde üyelerin erişim seviyesi belirtilmek zorunda değildir. Eski belirtemezdiniz şimdi açıkça yazılabilir ancak erişim seviye belirtilmezse public olarak açılacaktı.

        // interfacelerde field tanımlanamaz..
        //public int Age;
        //string Name; // Field
    }


    public class Demo : IDemo
    {
        // interface üyelerinin implementasyonunu doğru bir şekilde yazarak yapılabilir veya IDemo interfacesinin üzerine tıklanıp 
        // 
        public void Message()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        public string Yeni()
        {
            throw new NotImplementedException();
        }
    }

    public class Test : IDemo
    {
        public void Message()
        {
            throw new NotImplementedException();
        }

        void IDemo.Test()
        {
            throw new NotImplementedException();
        }
    }
}
