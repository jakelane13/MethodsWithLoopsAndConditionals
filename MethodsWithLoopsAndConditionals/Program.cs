using System;
using System.Dynamic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintRange();
            //Threes();
            //IsEqual();
            //IsEven(1);
        }

        public static bool IsEven(int num)
        {
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("Even");
                return true;
            }
            else
            {
                Console.WriteLine("odd");
                return false;
            }
        }

        public static void IsEqual()
        {
            Console.WriteLine("give me 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
            }
        }

        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
