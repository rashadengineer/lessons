using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Customer
    {
        
        private static ArrayList usersInfo;

        
        private string username;
        private string password;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Username {
            get
            {
                return this.username;
            }

            set
            {
                if (ControlUsername())
                {
                    this.username = value;
                }
                else {
                    Console.WriteLine("Bu istifadeci artiq movcuddur");
                }
            }
        }
        public string Password {
            get
            {
                return this.password;
            }
            set
            {
                if (ControlPassword())
                {
                    this.password = value;
                }
                else {
                    Console.WriteLine("Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1 reqem olmalidir.");
                }
                
                
            }
        }


        static Customer()
        {
            usersInfo = new ArrayList();
        }



        public bool ControlUsername()
        {
            foreach (Customer item in usersInfo)
            {
                if (item.username.ToString() == username)
                {
                    return true;
                }

            }
            return false;
        }



        public int AddUsername(string customer = null)
        {
            int addUser = usersInfo.Add(customer);
            return addUser;
        }

        public void ControlEmail()
        {
            if (usersInfo.Contains(Email))
            {
                string checkMessage = "Elave etmek istediyiniz username artiq sistemde movcuddur!";
                Console.WriteLine(checkMessage);
            }
            else
            {
                int addUser = usersInfo.Add(Email);
                Console.WriteLine("Yeni musteri sisteme elave olundu!");
            }
        }

        /*
        Birdə password encapsulation üçün həm field həm də property olacaq. Property'nin getter'ində field return olacaq, setter'ində
             isə password'un valid olub olmaması yoxlanılacaq. Bunun üçün bir method yazın hansı ki, şifrəni validate etsin. Şifrə minimum
             8 simvol, ən az 1 böyük hərf və 1 rəqəm olmalıdır. Deyilsə, "Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1
             reqem olmalidir." mesajı çıxsın. Customer məlumatlarını elə Main method'unun içində kod tərəfdə yazmaq kifayətdir. Console 
             ekranından userdən soruşmağa ehtiyyac yoxdur. 
        */

        public bool ControlPassword()
        {
            bool lower = false, upper = false, digit = false;

            if (password.Length >= 8)
            {
                if (password.Contains(" "))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else {
                foreach (char ch in password)
                {
                    if (Char.IsLower(ch))
                    {
                        lower = true;
                    }
                    else if (Char.IsUpper(ch))
                    {
                        upper = true;

                    }
                    else if (Char.IsDigit(ch))
                    {
                        digit = true;
                    }
                    if (lower && upper && digit)
                    {
                        return true;
                    }
                }
                return false;

            }



            

         
        }

    }
}
