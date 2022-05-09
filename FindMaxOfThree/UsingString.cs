using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxOfThree
{
    class UsingString
    {
        public static string FindMaxString(string first, string second, string third)
        {
            int first_Length = first.Length;
            int second_Length = second.Length;
            int third_Length = third.Length;
            if (first_Length.CompareTo(second_Length) > 0 && first_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("First String Length is larger: " + first);
                return first;
            }
            if (second_Length.CompareTo(first_Length) > 0 && second_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("Second String Length is larger: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third String Length is larger: " + third);
                return third;
            }
        }

    }
}
