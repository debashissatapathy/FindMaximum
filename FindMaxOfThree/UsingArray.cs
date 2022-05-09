using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxOfThree
{
    class UsingArray
    {
        public class MaxArray<T> where T: IComparable<T>
        {
            public T[] array;

            public  MaxArray(params T[] array)
            {
                this.array = array;
            }
            public static T MaxUsingGeneric<G>(T[] array)
            {
                Array.Sort(array);
                return array[array.Length - 1];
            }
        }
       
    }
}
