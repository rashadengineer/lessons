﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Employee
    {
        /*
        Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun. Ancaq email property'sini set
             
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