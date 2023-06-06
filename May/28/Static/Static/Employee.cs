using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Employee
    {
        /*
        Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun. Ancaq email property'sini set            edən zaman sadəcə @ işarəsinə qədər hissəsini set ediləcək. Yəni məsələn orkhan.farajov            @ işarəsi və domain set olunmayacaq. Ancaq mən o class'dan istifadə edib bir işçi yaradandan sonra email ünvanını set edib            alt sətirdə email'i get edəndə email'də @ işarəsi və domain də olacaq. Bunu edəndə encapsulation'a da uyğun edin. 
             
        */

        public static string email;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email {
            get
            {
                return email + "@gmail.com";
            }
            set
            {

            }
        }
        public int Gender { get; set; }

        public static void Welcome()
        {
            Console.WriteLine(email +" Xos Gelmisiniz! ");
        }

        public static void PassWord()
        {
            Console.WriteLine(email + "Sifrenizi yenileyin");
        }
    }
}
