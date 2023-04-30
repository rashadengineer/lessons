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

            //int num1 = 20;
            //int num2 = 50;

            //int numEqual;
            //numEqual = num1;

            //num1 = num2;
            //num2 = numEqual;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //Console.ReadLine();



            #endregion

            #region Homework2

            //Console.Write("Birinci reqemi daxil edin: ");
            //int say1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ikinci reqemi daxil edin: ");
            //int say2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ucuncu reqemi daxil edin: ");
            //int say3 = Convert.ToInt32(Console.ReadLine());



            //int toplama = say1 + say2 + say3;
            //int cixma = say1 - say2 - say3;
            //int vurma = say1 * say2 * say3;
            //int bolme = say1 / say2 / say3;

            //Console.WriteLine("Toplama Netice: " +  say1 + " + " + say2 + " + " + say3 + " = " + toplama);
            //Console.WriteLine("Cixma Netice: " + say1 + " - " + say2 + " - " + say3 + " = " + cixma);
            //Console.WriteLine("Vurma Netice: " + say1 + " * " + say2 + " * " + say3 + " = " + vurma);
            //Console.WriteLine("Bolme Netice: " + say1 + " / " + say2 + " / " + say3 + " = " + bolme);

            //Console.ReadLine();


            #endregion

            #region Homework3

            //int reqem1 = Convert.ToInt32(Console.ReadLine());
            //int reqem2 = Convert.ToInt32(Console.ReadLine());
            //int reqem3 = Convert.ToInt32(Console.ReadLine());
            //int reqem4 = Convert.ToInt32(Console.ReadLine());
            //int reqem5 = Convert.ToInt32(Console.ReadLine());
            //int reqem6 = Convert.ToInt32(Console.ReadLine());
            //int reqem7 = Convert.ToInt32(Console.ReadLine());
            //int reqem8 = Convert.ToInt32(Console.ReadLine());
            //int reqem9 = Convert.ToInt32(Console.ReadLine());
            //int reqem10 = Convert.ToInt32(Console.ReadLine());

            //int toplama = reqem1 + reqem2 + reqem3 + reqem4 + reqem5 + reqem6 + reqem7 + reqem8 + reqem9 + reqem10;
            //toplama++;
            //int cixma = reqem1 - reqem2 - reqem3 - reqem4 - reqem5 - reqem6 - reqem7 - reqem8 - reqem9 - reqem10;
            //cixma--;
            //int vurma = reqem1 * reqem2 * reqem3 * reqem4 * reqem5 * reqem6 * reqem7 * reqem8 * reqem9 * reqem10;
            //vurma *= 20;
            //int bolme = reqem1 / reqem2 / reqem3 / reqem4 / reqem5 / reqem6 / reqem7 / reqem8 / reqem9 / reqem10;
            //bolme /= 20;


            //Console.WriteLine("Toplama netice: " + toplama);
            //Console.WriteLine("Cixma netice: " + cixma);
            //Console.WriteLine("Vurma netice: " + vurma);
            //Console.WriteLine("Bolme netice: " + bolme);


            //Console.ReadLine();

            #endregion

            #region Homework4

            var boolVal = Console.ReadLine();
            var stringVal = Console.ReadLine();
            var shortVal = Console.ReadLine();
            var longVal = Console.ReadLine();
            var intVal = Console.ReadLine();
            var charVal = Console.ReadLine();
            var dateVal = Console.ReadLine();


            bool boolConvert = Convert.ToBoolean(boolVal);
            string stringConvert = Convert.ToString(stringVal);
            short shortConvert = Convert.ToInt16(shortVal);
            long longConvert = Convert.ToInt64(longVal);
            int intConvert = Convert.ToInt32(intVal);
            char charConvert = Convert.ToChar(charVal);
            DateTime dateConvert = Convert.ToDateTime(dateVal);

            Console.WriteLine();

            Console.WriteLine("Boolean: " + boolConvert);
            Console.WriteLine("String: " + stringConvert);
            Console.WriteLine("Short: " + shortConvert);
            Console.WriteLine("Long: " + longConvert);
            Console.WriteLine("Interger: " + intConvert);
            Console.WriteLine("Char: " + charConvert);
            Console.WriteLine("Datetime: " + dateConvert);

            Console.ReadLine();
            

        
             

            #endregion

        }
    }
}
