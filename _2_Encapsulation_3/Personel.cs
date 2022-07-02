using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_3
{
    // Not : todo'lara view menüsü içerisinden task listlerden erişilir..
    // şirkete giren personelin emaili tarafımızdan oluşturulsun...
    public class Personel
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        // set bloğını silerek kapsülleme yapıyoruz...
        public string Email
        {
            get
            {
                // todo : email oluştururken özel karakterli düzelterek oluşturun... (Ödev)
                return $"{Name.ToLower()}.{SurName.ToLower()}@{CompanyName.ToLower()}.com";
            }
        }

        private string[] specialChars = { "ı", "ö", "ü", "ş", " " };
        private string[] normalChars = { "i", "o", "u", "s", "" };
    }
}
