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

            /*Homework 3:
                Local function'lar yaradaraq bir kalkulyator yaradın.
                Ümumi bir calculate methodu olmalıdır və o method'un içində də Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
                Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal, iki int, iki string, string-decimal, decimal-int və
                int-string parametrləri ilə işləməlidir.
                Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
                Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq("15", 20.2M) yada int-string üçün(20, "15") belə.
                Bölmə zamanı divide zero exeption'dan qaçının.
                Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
                Yəni 100 - ün 5 faizi neçədir? hesablayacaq.İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10(a parametri),
                100 - ün(b parametrinin) neçə faizidir?
            */

            Calculate(10, "5");


            #endregion

            #region Homework2

            /*Homework 4:
                Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s.daxil ediləcək. Sonra sinif rəhbərinin adı
                soruşulacaq.Axırda isə, 10 tələbə adı soruşulacaq.Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                Method cəmi 3 parametr qəbul edə bilər. 3 - dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                  və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın.Tələbə adlarını da collection və ya list
                 şəklində göndərmək haqqınız yoxdur.İp ucu verim dərsdə keçmişdik.
             */

            Console.WriteLine("Sinif adi: ");
            string className = Console.ReadLine();

            Console.WriteLine("Sinif Rehber adi: ");
            string teacName = Console.ReadLine();

            Console.WriteLine("Telebe adi: ");
            string student1 = Console.ReadLine();
            string student2 = Console.ReadLine();
            string student3 = Console.ReadLine();
            string student4 = Console.ReadLine();
            string student5 = Console.ReadLine();
            string student6 = Console.ReadLine();
            string student7 = Console.ReadLine();
            string student8 = Console.ReadLine();
            string student9 = Console.ReadLine();
            string student10 = Console.ReadLine();

            Education(className,teacName,student1,student2,student3,student4,student5,student6,student7,student8,student9,student10);
            #endregion
        }

        #region Homework1

        static void Calculate(int num1, int num2)
        {
            int Toplama()
            {
                return num1 + num2;
            }

            int Cixma()
            {
                return num1 - num2;
            }

            int Vurma()
            {
                return num1 * num2;
            }

            int Bolme()
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return num1 / num2;
            }

            int FaizHesabla()
            {
                int result = 0;
                if (num1>num2)
                {
                    result = num1 * num2 / 100;
                }
                if (num1<num2)
                {
                    result = num2 * num1 / 100;
                }
                return result;

            }


            Console.WriteLine(Toplama());
            Console.WriteLine(Cixma());
            Console.WriteLine(Vurma());
            Console.WriteLine(Bolme());
            Console.WriteLine("Faiz hesablama metodu: ");
            Console.WriteLine(FaizHesabla());

        }

        static void Calculate(decimal num1, decimal num2)
        {
            decimal Toplama()
            {
                return num1 + num2;
            }

            decimal Cixma()
            {
                return num1 - num2;
            }

            decimal Vurma()
            {
                return num1 * num2;
            }

            decimal Bolme()
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return num1 / num2;
            }

            decimal FaizHesabla()
            {
                decimal result = 0;
                if (num1 > num2)
                {
                    result = num1 * num2 / 100;
                }
                if (num1 < num2)
                {
                    result = num2 * num1 / 100;
                }
                return result;

            }

            Console.WriteLine(Toplama());
            Console.WriteLine(Cixma());
            Console.WriteLine(Vurma());
            Console.WriteLine(Bolme());
            Console.WriteLine("Faiz hesablama metodu: ");
            Console.WriteLine(FaizHesabla());

        }

        static void Calculate(string num1, string num2)
        {
            int a = int.Parse(num1);
            int b = int.Parse(num2);

            int Toplama()
            {
                return a + b;
            }

            int Cixma()
            {
                return a - b;
            }

            int Vurma()
            {
                return a * b;
            }

            int Bolme()
            {
                if (b == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return a / b;
            }

            int FaizHesabla()
            {
                int result = 0;
                if (a > b)
                {
                    result = a * b / 100;
                }
                if (a < b)
                {
                    result = a * b / 100;
                }
                return result;

            }

            Console.WriteLine(Toplama());
            Console.WriteLine(Cixma());
            Console.WriteLine(Vurma());
            Console.WriteLine(Bolme());
            Console.WriteLine("Faiz hesablama metodu: ");
            Console.WriteLine(FaizHesabla());

        }

        static void Calculate(string num1, decimal num2)
        {
            decimal a = decimal.Parse(num1);

            decimal Toplama()
            {
                return a + num2;
            }

            decimal Cixma()
            {
                return a - num2;
            }

            decimal Vurma()
            {
                return a * num2;
            }

            decimal Bolme()
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return a / num2;
            }

            Console.WriteLine(Toplama());
            Console.WriteLine(Cixma());
            Console.WriteLine(Vurma());
            Console.WriteLine(Bolme());
        }

        static void Calculate(decimal num1, int num2)
        {
            decimal b = num2;

            decimal Toplama()
            {
                return num1 + b;
            }

            decimal Cixma()
            {
                return num1 - b;
            }

            decimal Vurma()
            {
                return num1 * b;
            }

            decimal Bolme()
            {
                if (b == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return num1 / b;
            }
        }

        static void Calculate(int num1, string num2)
        {
            int b = int.Parse(num2);
            int Toplama()
            {
                return num1 + b;
            }

            int Cixma()
            {
                return num1 - b;
            }

            int Vurma()
            {
                return num1 * b;
            }

            int Bolme()
            {
                if (b == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                }
                return num1 / b;
            }

            Console.WriteLine(Toplama());
            Console.WriteLine(Cixma());
            Console.WriteLine(Vurma());
            Console.WriteLine(Bolme());

        }

        




        #endregion

        #region Homework2

        static void Education(string className,string teacName, params string[] students)
        {
            Console.WriteLine("Sinif haqqında məlumat: ");
            Console.WriteLine(className);
            Console.WriteLine("------");
            Console.WriteLine(teacName);
            Console.WriteLine("------");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        #endregion
    }

}
