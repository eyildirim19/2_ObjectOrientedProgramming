using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbstractClass
{
    // Abstract Class => sınıfın sadece miras vermesi için işaretlenmesidir..Miras verebilir ancak yeni bir referans oluşturulamaz..
    public abstract class Personel
    {
        public string Adi { get; set; }
    }

    public class Yazilimci : Personel
    {

    }

    public class Muhasebeci : Personel
    {

    }
    // sealed class ile işaretlenen sınıftan miras verilemez..
    public sealed class Departman
    {

    }

    // Departman sınıfı sealed olduğu için miras veremez...
    //public class IK : Departman
    //{
    //}
}
