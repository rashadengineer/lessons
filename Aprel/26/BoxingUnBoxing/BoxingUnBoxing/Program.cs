using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task1

            bool booleanValue = true;
            int intergerValue = 1;


            string stringValue = Convert.ToString(booleanValue);

            //bool resultParse = bool.Parse(resultValue);

            bool resultValue = int.TryParse(stringValue, out intergerValue);

            int resultInt = Convert.ToInt32(resultValue);
            #endregion

            #region Task2

            int trueVal = 1;
            int falseVal = 0;

            bool fromIntTrueToTrue = Convert.ToBoolean(trueVal);
            bool fromIntFalseToFalse = Convert.ToBoolean(falseVal);

            #endregion

            #region Task3

            DateTime dateTimeNow = DateTime.Now;
            object o = dateTimeNow;
            DateTime dateTime = (DateTime)o;

            #endregion

            #region Task4

            string stringTrue = "True";
            string stringFalse = "False";

            bool boolTrue = bool.Parse(stringTrue);
            bool boolFalse = bool.Parse(stringFalse);

            #endregion





        }
    }
}
