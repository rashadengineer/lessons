using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Conversion

            

            byte myNum = 100;
            short myNum2 = myNum;

            short myNum3 = 20000;
            int myNum4 = myNum3;

            int myNum5 = 300000000;
            long myNum6 = myNum5;

            uint myNum7 = 100000000;
            long myNum8 = myNum7;

            sbyte myNum9 = 127;
            short myNum10 = myNum9;
            #endregion

            #region Explicit Conversion

            short myExNum = 10000;
            byte myExNum1 = (byte)myExNum;

            checked
            {
                unchecked
                {
                    int myExNum3 = 40000;
                    short myExNum4 = (short)myExNum3;
                }

            }

            long myExNum5 = 1000000000;
            int myExNum6 = (int)myExNum5;

            sbyte myExNum7 = -100;
            byte myExNum8 = (byte)myExNum7;

            short myExNum9 = -15000;
            ushort myExNum10 = (ushort)myExNum9;

            #endregion

            #region Helper Conversion

            string stVal = "True";
            bool bolVal = Convert.ToBoolean(stVal);

            string stVal2 = "15";
            int intVal = Convert.ToInt32(stVal2);

            int intVal2 = 1;
            bool bolVal2 = Convert.ToBoolean(intVal2);

            string stVal3 = "R";
            char chVal = Convert.ToChar(stVal3);

            int intVal3 = 5000;
            string stVal4 = Convert.ToString(intVal3);
            

            #endregion
        }
    }
}
