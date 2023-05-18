using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Student
    {
        
        public decimal CalcAverage(decimal num1, decimal num2, decimal num3)
        {
            decimal result = (num1 + num2 + num3) / 3;
            return result;
        }

        public void RateAverage(decimal num1, decimal num2, decimal num3)
        {
            decimal result = (num1 + num2 + num3) / 3;

            if (result <= 45)
            {
                Console.WriteLine("Imtahandan kesildi");
            }
            if (result > 45)
            {
                Console.WriteLine("Imtahanda ugurla kecdi");
            }
               
        }

        public void CalcAverage(string name,string lastname, decimal num1, decimal num2, decimal num3)
        {
            decimal result = (num1 + num2 + num3) / 3;
            Console.WriteLine("{0} {1} adli telebenin ortalama bali:{2}",name,lastname,result);
        }

    }
}
