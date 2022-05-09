using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxOfThree
{
    class UsingInit
    {
        public static int FindMaxInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                Console.WriteLine("First Number is larger: " + firstNumber);
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                Console.WriteLine("Second Number is larger: " + secondNumber);
                return secondNumber;
            }
            else
            {
                Console.WriteLine("Third Number is larger: " + thirdNumber);
                return thirdNumber;
            }
        }
    }
}
