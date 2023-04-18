using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Birinci siz dediyiniz usul ile

            var city1 = "Baku";
            var city2 = "Gence";
            var city3 = "Calilabad";
            var city4 = "Lenkeran";
            var city5 = "Bilesuvar";
            var city6 = "Qebele";
            var city7 = "Quba";
            var city8 = "Zaqatala";
            var city9 = "Susa";
            var city10 = "Lacin";

            Console.WriteLine(city1);
            Console.WriteLine(city2);
            Console.WriteLine(city3);
            Console.WriteLine(city4);
            Console.WriteLine(city5);
            Console.WriteLine(city6);
            Console.WriteLine(city7);
            Console.WriteLine(city8);
            Console.WriteLine(city9);
            Console.WriteLine(city10);

            Console.WriteLine();
            
             // Ikinci usul ile helli 
            List<string> sheherler = new List<string>
            {
                "Baku", "Gence","Celilabad","Quba","Qebele", "Zaqatala","Lenkeran","Masalli","Astara","Bilesuvar"
            };
            foreach (var sheher in sheherler)
            {
                Console.WriteLine(sheher);
            }
            Console.ReadLine();
        }
    }
}
