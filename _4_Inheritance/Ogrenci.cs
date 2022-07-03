using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance
{
    // : miras almak için kullanılır..Ogrenci sınıfı Insan sınıfından türetiliyor. Miras veren Insan sınıfı base sınıf, turetilen Ogrenci sınıfı derived sınıf olarak adlandırılır..
    public class Ogrenci : Insan
    {
        public string OgrenciNo { get; set; }
    }
}