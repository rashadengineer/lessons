﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir method'unuz olsun və ad soyad parametrləri alsın. Method yoxlamalıdır ki,
             */

            Employee employee = new Employee();
            employee.Name = "Rashad";
            employee.Surname = "Hasanli";
            employee.Email = "rashad.hasanli";
            employee.Gender = 1;

            Employee.Welcome();
            Employee.PassWord();




        }
        #region Task1
        public static void FirstInfo(string name, string surname)
        {
            //string stringVal = "11111111111111111111";
            //int length = stringVal.Length;

            if (name.Length + surname.Length > 20)
            {

                Console.WriteLine(name[0] + "." + surname);
            }
            else
            {
                Console.WriteLine(name + " " + surname);
            }

        }
        #endregion

        #region Task2



        #endregion

    }
}