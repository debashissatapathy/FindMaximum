using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxOfThree
{
    class UsingFloat
    {
        public static double FindMaxFloat(double firstFloat, double secondFloat, double thirdFloat)
        {
            if (firstFloat.CompareTo(secondFloat) > 0 && firstFloat.CompareTo(thirdFloat) > 0)
            {
                Console.WriteLine("First Float Number is c: " + firstFloat);
                return firstFloat;
            }
            else if (secondFloat.CompareTo(firstFloat) > 0 && secondFloat.CompareTo(thirdFloat) > 0)
            {
                Console.WriteLine("Second Float Number is larger: " + secondFloat);
                return secondFloat;
            }
            else
            {
                Console.WriteLine("Third Float Number is larger: " + thirdFloat);
                return thirdFloat;
            }
        }
    }
}
