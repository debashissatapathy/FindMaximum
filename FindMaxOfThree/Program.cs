using System;

namespace FindMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maximum of three using generics");
            
            while(true)
            {
                Console.WriteLine("Choose one program to execute: \n1.UsingInit\n2.UsingFloat\n3.UsingString\n4.GenericMethod\n5.GenericClass\n6.UsingArray");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Please enter the value of firstNumber, secondNumber, thirdNumber ");
                        int firstNumber= Convert.ToInt16(Console.ReadLine());
                        int secondNumber= Convert.ToInt16(Console.ReadLine());
                        int thirdNumber= Convert.ToInt16(Console.ReadLine());
                        int result= UsingInit.FindMaxInteger(firstNumber, secondNumber, thirdNumber);
                        Console.WriteLine("The Maximum of three integers is :" + result);
                        Console.Write("\n");
                        break;
                    case 2:
                        Console.WriteLine("Please enter the value of firstNumber, secondNumber, thirdNumber ");
                        double firstFloat = Convert.ToDouble(Console.ReadLine());
                        double secondFloat = Convert.ToDouble(Console.ReadLine());
                        double thirdFloat = Convert.ToDouble(Console.ReadLine());
                        double result1 = UsingFloat.FindMaxFloat(firstFloat, secondFloat, thirdFloat);
                        Console.WriteLine("The Maximum of three integers is :" + result1);
                        Console.Write("\n");
                        break;
                    case 3:
                        Console.WriteLine("Please enter the value of firstString, secondString, thirdString ");
                        string firstString = Console.ReadLine();
                        string secondString = Console.ReadLine();
                        string thirdString = Console.ReadLine();
                        string result2 = UsingString.FindMaxString(firstString, secondString, thirdString);
                        Console.WriteLine("The Maximum of three integers is :" + result2);
                        Console.Write("\n");
                        break;
                    case 4:
                        GenericMethod genericClass = new GenericMethod();
                        int value1 = GenericMethod.MaxusingGenerics<int>(2, 3, 4);
                        Console.WriteLine("The Maximum of three integers is :" + value1);
                        double value2 = GenericMethod.MaxusingGenerics<double>(2.2, 3.3, 4.4);
                        Console.WriteLine("The Maximum of three values is :" + value2);
                        string value3 = GenericMethod.MaxusingGenerics<string>("Apple", "peach", "banana");
                        Console.WriteLine("The Maximum of three strings is :" + value3);
                        Console.WriteLine("\n");
                        break;
                       
                    case 5:
                        Console.WriteLine("Please enter the value of firstNumber, secondNumber, thirdNumber ");
                        int Mvalue1 = GenericClass<int>.MaxusingGenerics<int>(2, 3, 4);
                        Console.WriteLine("The Maximum of three integers is :" + Mvalue1);
                        double Mvalue2 = GenericClass<double>.MaxusingGenerics<double>(2.2, 3.3, 4.4);
                        Console.WriteLine("The Maximum of three values is :" + Mvalue2);
                        string Mvalue3 = GenericClass<string>.MaxusingGenerics<string>("Apple", "peach", "banana");
                        Console.WriteLine("The Maximum of three strings is :" + Mvalue3);
                        Console.WriteLine("\n");
                        break;

                    case 6:
                        int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
                        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5,5.4 };
                        string[] stringArray = { "Apple", "Animal", "Banana","orange" };
                        
                        int Avalue1 = UsingArray.MaxArray<int>.MaxUsingGeneric<int>(intArray);
                        Console.WriteLine("The Maximum of IntArray is :" + Avalue1);
                        double Avalue2 = UsingArray.MaxArray<double>.MaxUsingGeneric<double>(doubleArray);
                        Console.WriteLine("The Maximum of DoubleArray is :" + Avalue2);
                        string Avalue3 = UsingArray.MaxArray<String>.MaxUsingGeneric<string>(stringArray);
                        Console.WriteLine("The Maximum of StringArray is :" + Avalue3);
                        Console.WriteLine("\n");
                        break;
                }
            }
        }
    }
}
