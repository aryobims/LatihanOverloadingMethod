using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else return number2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return Math.Min(number1, number2);
        }

        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            else return number2;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return Math.Min(number1, number2);
        }
    }
}
