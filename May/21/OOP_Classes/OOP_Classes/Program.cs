using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1

            /*
             Homework 1:
             İnternetdə Access Modifiers mövzusunu araşdırın və elə edin ki, CheckCustomerFromDb methodunu nə public nədə private istifadə etmədən,
             Program class'ında istifadə edə bilim. Inherit almaq şansınız yoxdur, yanlız aşağıdakı kimi yazanda işləməlidir və dəyişikliyi Customer
             class'ı tərəfdə etməlisiniz.

             Nümunə:
             Customer customer = new Customer();
             customer.CheckCustomerFromDb();
             */

            Customer cs = new Customer();
            cs.CheckCustomerFromDb();


            #endregion

            #region Homework2

            /*
             Homework 2:
             Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.
             Satılacaq məhsul dedikdə məsələn Vehicle class'ı ola bilər.

             Məhsul (item) Class'ında olacaq property'lər:
                Marka
                Model
                İstehsal ili
                Km
                Yanacaq növü
                Sürətlər qutusu
                Alış qiyməti
                Satış qiyməti
                Max endirim məbləği
                Qiymət (private olması mütləqdir!)

               Constructor overload'ları aşağıdakı kimi olmalıdır:
                1. marka, model
                2. marka, model, istehsal ili
                3. marka, model, istehsal ili, km
                4. bütün property'lər

               Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
               satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
               olmalıdır. Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
               Məsələn:
               Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
               satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
            */

            Vehicle vehicle = new Vehicle("Hyundai","Santa Fe",2014,101000);
            vehicle.Marka = "Kia";
            vehicle.Model = "Sorento";
            vehicle.Il = 2015;
            vehicle.Yurus = 1500000;
            vehicle.YanacaqNovu = "Dizel";
            vehicle.SatisQiy = 40000;
            vehicle.AlisQiy = 35000;
            vehicle.Discount = 20;
            vehicle.Suretqutu = "Avtomat";

            Vehicle vehicle2 = new Vehicle("Kia", "Sorento", 2015, 150000);
            vehicle2.Marka = "Kia";
            vehicle2.Model = "Sorento";
            vehicle2.Il = 2015;
            vehicle2.Yurus = 1500000;
            vehicle2.YanacaqNovu = "Dizel";
            vehicle2.SatisQiy = 40000;
            vehicle2.AlisQiy = 35000;
            vehicle2.Discount = 20;
            vehicle2.Suretqutu = "Avtomat";


            vehicle.AllProp();
            vehicle.SpecialOffer(30000,35000,10);
            


            #endregion
        }
    }
}
