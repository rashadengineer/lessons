using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1

            //Homework 1:
            //Əvvəlcədən iki dəyişəndə username və password saxlayın.Bunlar heç bir zaman dəyişməyəcək şəkildə olsun.Yəni proqramda belə dəyişdirmək mümkün olmasın
            //Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
            //Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.

            const string username = "admin";
            const string password = "12345678";

            Console.Write("Istifadeci adini daxil et: ");
            string userName = Console.ReadLine();
            Console.Write("Password daxil et: ");
            string userPassword = Console.ReadLine();

            //Step 1
            if (username == userName && password == userPassword)
            {
                Console.WriteLine("Sisteme daxil olundu");
            }
            else
            {
                //Step 2
                if (username != userName || password != userPassword)
                {
                    Console.Write("Istifadeci adini daxil et: ");
                    userName = Console.ReadLine();
                    Console.Write("Password daxil et: ");
                    userPassword = Console.ReadLine();

                    //Step 3
                    if (username != userName || password != userPassword)
                    {
                        Console.Write("Istifadeci adini daxil et: ");
                        userName = Console.ReadLine();
                        Console.Write("Password daxil et: ");
                        userPassword = Console.ReadLine();
                        Console.WriteLine("Hesab bloklandi!");

                    }
                    else
                    {
                        Console.WriteLine("Tekrar dan sisteme daxil olundu");
                    }

                }


            }


            #endregion

            #region Homework2

            //Homework 2:
            //Switch -case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
            //və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
            //istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.

            string menu = "menu";
            int a, b;
            Console.Write("a ededin daxil edin: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b ededin daxil edin: ");
            b = Convert.ToInt32(Console.ReadLine());
            int toplama = a + b;
            int cixma = a - b;
            int vurma = a * b;
            int bolme = a / b;

            switch (menu)
            {
                case "menu":
                    Console.Clear();
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Cixma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. Bolme ");
                    Console.Write("Etmek istediyiniz emeliyyat: ");
                    short select = Convert.ToInt16(Console.ReadLine());
                    if (select == 1)
                    { 
                        goto case "toplama";
                    }
                    else if (select == 2)
                    {
                        goto case "cixma";
                    }
                    else if (select == 3)
                    {
                        goto case "vurma";
                    }
                    else if (select == 4)
                    {
                        goto case "bolme";
                    }
                    break;
                case "toplama":
                    Console.WriteLine("Netice: " + toplama);
                    goto case "menu";
                case "cixma":
                    Console.WriteLine("Netice: " + cixma);
                    goto case "menu";
                case "vurma":
                    Console.WriteLine("Netice: " + vurma);
                    goto case "menu";
                case "bolme":
                    Console.WriteLine("Netice: " + bolme);
                    goto case "menu";
                default:
                    break;
            }
            #endregion
        }
    }
}
