using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methids_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            
            int[] nums = new int[] {1,3,5,7};
            //int[] nums = new int[] { 1, 3, 5, 7,9};
            //int[] nums = new int[] { 1, 3, 5, 7,9,11};
            //int[] nums = new int[] { 1, 3, 5, 7,9,11,13};
            Addition(nums);
            #endregion

            #region OOP
            /*
                -Musteri : 
                    -id
                    -Vetendasligi
                    -Marka
                    -Model
                    -Reng
                    -Qiymet
                    -Kredit sertleri
                -Satis temsilcisi:
                    -Id
                    -Melumat
                    -Kredit setleri
                -Satilacaq mehsul:
                    -Id
                    -MasinNovu
                    -Model
                    -Marka
                    -Reng
                    -Motor hecmi
                    -Qiymet
             */
            #endregion
        }

        public static void Addition(params int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
                Console.WriteLine("Reqemler: {0}" + num + "Cemi: {1}",sum );
            }
            
        }
    }
}
