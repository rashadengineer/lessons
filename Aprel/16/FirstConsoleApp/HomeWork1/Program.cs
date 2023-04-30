using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adinizi yazin: ");
            var firstName = Console.ReadLine();
            Console.Write("Soyadinizi yazin: ");
            var lastName = Console.ReadLine();
            Console.Write("Adresinizi yazin: ");
            var adress = Console.ReadLine();

            
            
            Console.WriteLine(firstName + " " + lastName + " " + adress);
            Console.ReadLine();

        }
    }
}
