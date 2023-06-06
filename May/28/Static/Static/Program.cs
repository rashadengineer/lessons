using System;
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
             Bir method'unuz olsun və ad soyad parametrləri alsın. Method yoxlamalıdır ki,              ad və soyad'ın uzunluğu 20 xarakterdən uzundursa, adın ilk hərfi, nöqtə,               boşluq və soyad return etsin (O. Farafov). Yox əgər 20 simvoldan qısadırsa,              ad, boşluq, soyad formatında qaytarsın. Nəzərə alın ki, ad ilə soyad arasındakı              boşluq da 1 simvoldur (nöqtə də). Bir şeyi də nəzərə alın ki, bu method'u              proyektin 20-30 yerində istifadə edəcəyəm.
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
