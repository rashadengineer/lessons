using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 

            /* Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0 - dan                   kiçik, 100 - dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın.Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.

                 Bal 20 - dən kiçik olarsa "İmtahandan kəsildiniz" yazın.                   20 - dən böyük və ya bərabər, 40 - dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"                   40 - dan böyük və ya bərabər, 60 - dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"                   60 - dan böyük və ya bərabər, 80 - dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"                   80 - a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
            */

            //string strPoint = Console.ReadLine();
            //int point;
            //bool result = int.TryParse(strPoint, out point);

            //if (result)
            //{
            //    if (point < 0 || point > 100)
            //    {
            //        Console.WriteLine("Düzgün bal daxil edilməyib");
            //        Console.ReadLine();
            //    }
            //    else if (point < 20)
            //    {
            //        Console.WriteLine("Imtahandan kesildiniz");
            //        Console.ReadLine();
            //    }
            //    else if (point >= 20 && point < 40)
            //    {
            //        Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            //        Console.ReadLine();
            //    }
            //    else if (point >= 40 && point < 60)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        Console.WriteLine("Netice: kafi");
            //        Console.ReadLine();
            //    }
            //    else if (point >= 60 && point < 80)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        Console.WriteLine("Netice: yaxsi");
            //        Console.ReadLine();
            //    }
            //    else if (point >= 80)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        Console.WriteLine("Netice: ela");
            //        Console.ReadLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Xahis olunur bir reqem daxil edin");
            //    Console.ReadLine();
            //}


            #endregion

            #region Task2

            //Kiçik bir kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə edə biləcəyi əməliyyatları nömrələriylə göstərin.
            //    "Etmek istediyiniz emeliyyati secin:"
            //    "1. Toplama"
            //    "2. Çıxma"
            //    "3. Vurma"
            //    "4. Bölmə"
            //    İstifadəçi əməliyyatı seçəndən sonra a və b dəyərlərini rəqəm olaraq alın və əməliyyatı icra edib nəticəni göstərin.Sadəcə bir dənə bölmə
            //    əməliyyatında əgər b - nin dəyəri 0 olarsa ekrana "Dəyər 0-a bölünə bilməz!" yazdırın.

            //Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            //Console.WriteLine("1. Toplama");
            //Console.WriteLine("2. Çıxma");
            //Console.WriteLine("3. Vurma");
            //Console.WriteLine("4. Bölmə");

            //Console.Write("Secmek istediyiniz emeliyyat: ");
            //int select = Convert.ToInt32(Console.ReadLine());

            //int a, b;
            //Console.Write("a ededin daxil edin: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b ededin daxil edin: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //if (select == 1)
            //{
            //    Console.WriteLine(a + b);
            //}
            //if (select == 2)
            //{
            //    Console.WriteLine(a - b);
            //}
            //if (select == 3)
            //{
            //    Console.WriteLine(a * b);
            //}
            //if (select == 4)
            //{
            //    if (b == 0)
            //    {
            //        Console.WriteLine("Dəyər 0-a bölünə bilməz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(a / b);
            //    }
            //}


            #endregion

            #region Task3

            //1.İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
            // 2.İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.

            //int month = Convert.ToInt32(Console.ReadLine());


            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;

            //    default:
            //        Console.WriteLine("Baska ay");
            //        break;
            //}

            //string country = Console.ReadLine();

            //switch (country)
            //{
            //    case "Azerbaijan":
            //        Console.WriteLine("Baku");
            //        break;
            //    case "Turkiye":
            //        Console.WriteLine("Baku");
            //        break;
            //    case "Russia":
            //        Console.WriteLine("Moskow");
            //        break;
            //    default:
            //        Console.WriteLine("Hele bir olke movcud deyil");
            //        break;
            //}

            #endregion

         
        }
    }
}
