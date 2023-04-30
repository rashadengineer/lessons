using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ad: ");
            string name = Console.ReadLine();

            Console.Write("Soyad: ");
            string surname = Console.ReadLine();

            Console.WriteLine("K ve ya Q");
            string gender = Console.ReadLine();
            Console.WriteLine("Cinsi : " + gender);

            Console.Write("Tarix: ");
            DateTime birthdayDate = Convert.ToDateTime(new DateTime());
            

            Console.Write("Yasadigi olke: ");
            string country = Console.ReadLine();

            Console.Write("Yasadigi seher: ");
            string city = Console.ReadLine();

            Console.Write("Boy: ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ceki: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Maas: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());






        }
    }
}
