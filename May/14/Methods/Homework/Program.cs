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
            /*
            Homework 1:
                Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
                Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
                Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
                tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
                */
            Student student = new Student();

            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.Write("SoyAdinizi daxil edin: ");
            string lastname = Console.ReadLine();
            Console.Write("Qiymet 1 daxil edin: ");
            decimal point1 = decimal.Parse(Console.ReadLine());
            Console.Write("Qiymet 2 daxil edin: ");
            decimal point2 = decimal.Parse(Console.ReadLine());
            Console.Write("Qiymet 3 daxil edin: ");
            decimal point3 = decimal.Parse(Console.ReadLine());

            decimal ortalama = student.CalcAverage(point1, point2, point3);
            Console.WriteLine("Ortalama bal: " + ortalama);
            Console.WriteLine("--------------------");
            student.RateAverage(point1, point2, point3);
            Console.WriteLine("--------------------");
            student.CalcAverage(name, lastname, point1, point2, point3);

            Console.ReadLine();
        }

    }
}
