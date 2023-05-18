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

            //Homework1
            //        Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.Bunun üçün öncə bütün elementlərin toplamını
            //        tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
            //        bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
            //        Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.Bunu həm for döngüsüylə edin həm də foreach.

            //Console.Write("Nece reqem olacaq? ");
            //int num = int.Parse(Console.ReadLine());

            //int[] numbers = new int[num];
            //int sum = 0;
            //int result = 0;

            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    numbers[i] = num2;
            //    sum += num2;
            //    result = sum / num2;
            //}

            //Console.WriteLine("Toplama: " + sum);
            //Console.WriteLine("Ortalama: " + result);
            //Console.ReadLine();

            #endregion

            #region Homework2

            //Homework 2:
            //    int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın.Ancaq bunu edərkən sort və reverse
            //    method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.

            //int[] numArr = {20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12};
            //int equalNum = 0;


            //for (int i = 0; i <= numArr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < numArr.Length; j++)
            //    { 
            //        if (numArr[i] > numArr[j])
            //        {
            //            equalNum = numArr[i];
            //            numArr[i] = numArr[j];
            //            numArr[j] = equalNum;
            //        }
            //    }
            //    Console.WriteLine(numArr[i]);
            //}

            //foreach (var nums in numArr)
            //{
            //    Console.WriteLine(nums);
            //}

            //Console.ReadLine();


            #endregion

            #region Homework3

            //Homework 3:
            //    Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
            //    toplamını ekrana yazdırın.

            
            
            //Random rnd = new Random();
            //int randomNums;
            //int sum = 0;
            //int minNum;
            //int maxNum;

            //int[] numArr = new int[100];
        
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    randomNums = rnd.Next(1, 100000);
            //    numArr[i] = randomNums;
            //}

            //foreach (int num in numArr)
            //{
            //    Console.WriteLine(num);
            //    sum += num;
            //}

            //minNum = numArr.Min();
            //maxNum = numArr.Max();

            //Console.WriteLine("Minimum deyer: {0}", minNum);
            //Console.WriteLine("Maximum deyer: {0}",maxNum);
            //Console.WriteLine("Toplam: {0}", sum);   

            //Console.ReadLine();
           






            #endregion
        }
    }
}
