using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassTableAndArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList()
            {
                "Hasanli",
                "Nabiyeva"
            };

            arr.Add(5);
            arr.Add("Rashad");
            arr.Add("Rugiyya");
            arr.AddRange(arr2);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

            #endregion
        }
    }
}
