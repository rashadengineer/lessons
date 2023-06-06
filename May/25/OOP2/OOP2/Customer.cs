﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Customer
    {
        /*
         Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
         */

        private string documentSerial;
        private string documentNumber;

        public string DocumentSerial {
            get
            {
                return this.documentSerial;
            }
            set
            {
                if (documentSerial.Length == 2)
                {
                    this.documentSerial = value;
                }
                else
                { 
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!");
                }
                
            }
        }
        public string DocumentNumber { get
            {
                int checkNum = int.Parse(documentNumber);
                int splitNum = checkNum % 100000;
                string chechSt = splitNum.ToString();
                //Console.WriteLine(checkSt + "*****");
                for (int i = 0; i < documentNumber.Length; i++)
                {
                    
                }

                return this.documentNumber;
            }
            set

            {
                if (documentNumber.Length == 8)
                {
                    this.documentNumber = value;
                }
                else
                {
                    int dcNum = 0;
                    bool dcCheck = int.TryParse(documentNumber,out dcNum);
                    if (dcCheck)
                    {
                        Console.WriteLine(documentNumber);
                    }
                    else
                    {
                        Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                    }
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");
                }

            }
        }
    }
}