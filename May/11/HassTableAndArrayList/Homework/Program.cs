using System;
using System.Collections;
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
            /*
            Homework 1:
               İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

               Menu:
               1 - Element elave et
               2 - Elementleri goster
               3 - Element axtar
               4 - Element editle
               5 - Element sil
               6 - Exit
               Emeliyyat novunu secin:

               Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
               1:
               Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
               Daxil edəndən sonra: "Element elave olundu!"

               2:
               Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
               1. Element = 15
               2. Element = Salam
               3. Element = Hi
               Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

               3:
               Bunu seçəndə aşağıdakı yazı çıxacaq.
               "Axtarmaq istediyiniz elementi daxil edin: "
               Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
               "Element tapildi : Index :0 - Deyer: Salam"
               tapılmayıbsa bu yazı çıxsın
               "Axtardiginiz element tapilmadi".

               4:
               "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
               ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
               "Axtardiginiz element tapilmadi"
               Varsa:
               "Salam elementini ne ile evezlemek isteyirsiniz?"
               Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

               5:
               İlk öncə bunu soruşsun:
               "Butun elementleri silmek isteyirsiniz? (H/Y)"
               əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
               əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
               ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
               çıxsın.
           */

            
            ArrayList arrList = new ArrayList();

            //Menu
            Console.WriteLine("1 - Element elave et");
            Console.WriteLine("2 - Elementleri goster");
            Console.WriteLine("3 - Element axtar");
            Console.WriteLine("4 - Element editle");
            Console.WriteLine("5 - Element sil");
            Console.WriteLine("6 - Exit");

            Console.Write("Emeliyyat novunu secin: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                    var addVal = Console.ReadLine();
                    var arr = arrList.Add(addVal);
                    Console.WriteLine("Element Elave olundu");
                    goto case 6;
                case 2:
                    while (true)
                    {
                        var addVal2 = Console.ReadLine();
                        var arr2 = arrList.Add(addVal2);
                        Console.WriteLine("Element = " + addVal2);
                        if (addVal2 == "Enter")
                        {
                            Console.WriteLine("Davam etmek ucun Enter'e basin");
                            break;
                        }
                    }
                    goto case 6;
                case 3:
                    goto case 6;
                case 4:
                    goto case 6;
                case 5:
                    goto case 6;
                case 6:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
