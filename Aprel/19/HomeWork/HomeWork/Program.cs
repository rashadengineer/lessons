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
            #region Byte
            //0-255 araliginda deyer alir
            byte myNum;
            myNum = 0;
            myNum = 50;
            myNum = 100;
            myNum = 200;
            myNum = 255;

            //-127-128 araliginda deyer alir 
            sbyte myNum2;
            myNum2 = -127;
            myNum2 = -50;
            myNum2 = 0;
            myNum2 = 50;
            myNum2 = 127;
            #endregion

            #region Interger
            // -32767 - 32767 araliginda deyer alir
            short myShort;
            myShort = -32767;
            myShort = -10000;
            myShort = 0;
            myShort = 10000;
            myShort = 32767;
            // 0 - 65535 araliginda bir deyer alir
            ushort  myUShort;
            myUShort = 0;
            myUShort = 10000;
            myUShort = 20000;
            myUShort = 45000;
            myUShort = 65535;

            // ----------------------------------------------------


            // -2,147,483,648 - 2,147,483,647 araliginda deyer alir
            int myInt;
            myInt = -2147483648;
            myInt = -1000000000;
            myInt = 0;
            myInt = 1000000000;
            myInt = 2147483647;

            // 0 - 4,294,967,295 deger alir

            uint myUint;
            myUint = 0;
            myUint = 500000000;
            myUint = 1000000000;
            myUint = 2500000000;
            myUint = 4294967295;

            //----------------------------------------------------






            #endregion

        }
    }
}
