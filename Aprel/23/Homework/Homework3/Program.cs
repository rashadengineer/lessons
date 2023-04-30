using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            int salary = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            int weight = Convert.ToInt32(Console.ReadLine());
            int friends = Convert.ToInt32(Console.ReadLine());

            checked
            {
                byte age2 = (byte)age;
                byte salary2 = (byte)salary;
                unchecked
                {
                    byte height2 = (byte)height;
                    byte weight2 = (byte)weight;
                    byte friends2 = (byte)friends;

                }
            }

            
        }
    }
}
